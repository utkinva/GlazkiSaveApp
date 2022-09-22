using GlazkiSaveApp.Models;
using GlazkiSaveApp.Utilities;
using GlazkiSaveApp.Views.PartialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazkiSaveApp
{
    public partial class MainForm : Form
    {
        public static List<Agent> agents = new List<Agent>();

        public MainForm()
        {
            InitializeComponent();
            agents = DBContext.Context.Agent.ToList();
            GenerateAgentCardList(agents);
        }

        private void GenerateAgentCardList(List<Agent> agents)
        {
            foreach (var agent in agents)
            {
                AgentCard agentCard = new AgentCard();

                agentCard.GenerateAgentData(agent);
                agentCardsLayout.Controls.Add(agentCard);


            }
        }

        public void ApplyFilters()
        {
            var updatedList = DBContext.Context.Agent.ToList();

            if (string.IsNullOrWhiteSpace(searchTxtBox.Text))
            {
                updatedList = updatedList.Where(x => x.Title.ToLower().Contains(searchTxtBox.Text.ToLower())
                                                  || x.Email.ToLower().Contains(searchTxtBox.Text.ToLower())
                                                  || x.Phone.ToLower().Contains(searchTxtBox.Text.ToLower()))
                                                  .ToList();
            }

            agentCardsLayout.Controls.Clear();
            GenerateAgentCardList(updatedList);
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void searchTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTxtBox.Text))
            {
                searchTxtBox.Text = "Введите для поиска";
            }
        }

        private void searchTxtBox_Enter(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "Введите для поиска")
            {
                searchTxtBox.Text = string.Empty;
            }
        }
    }
}
