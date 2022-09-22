using GlazkiSaveApp.Models;
using GlazkiSaveApp.Utilities;
using GlazkiSaveApp.Views;
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
        public static List<AgentCard> selectedAgents = new List<AgentCard>();

        public MainForm()
        {
            InitializeComponent();

            agents = DBContext.Context.Agent.ToList();

            GenerateAgentCardList(agents);

            List<AgentType> agentTypes = DBContext.Context.AgentType.ToList();
            agentTypes.Insert(0, new AgentType { Title = "Все типы" });

            filterComboBox.DataSource = agentTypes;

            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
        }

        private void GenerateAgentCardList(List<Agent> agents)
        {
            foreach (var agent in agents)
            {
                AgentCard agentCard = new AgentCard();

                agentCard.GenerateAgentData(agent);
                agentCardsLayout.Controls.Add(agentCard);

                agentCard.Click += AgentCard_Click;
                agentCard.DoubleClick += AgentCard_DoubleClick;
            }
        }

        private void AgentCard_DoubleClick(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;

            AddEditAgentForm edit = new AddEditAgentForm(DBContext.Context.Agent.First(x => x.ID.ToString() == card.idAgentLbl.Text));

            DialogResult dialogResult = edit.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ApplyFilters();
                selectedAgents.Clear();
            }
        }

        private void AgentCard_Click(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;

            if (card.BackColor == Color.White)
            {
                card.BackColor = Color.FromArgb(255, 233, 249);
                selectedAgents.Add(card);
            }
            else
            {
                card.BackColor = Color.White;
                selectedAgents.Remove(card);
            }

            if (selectedAgents.Count > 1)
                addAgentBtn.Visible = false;
            else
                addAgentBtn.Visible = true;
        }

        public void ApplyFilters()
        {
            AgentCard card = new AgentCard();

            var updatedList = DBContext.Context.Agent.ToList();

            if (filterComboBox.SelectedIndex > 0)
            {
                updatedList = updatedList.Where(x => x.AgentType.ID == filterComboBox.SelectedIndex).ToList();
            }

            if (sortComboBox.SelectedIndex > 0)
            {
                switch (sortComboBox.SelectedIndex)
                {
                    case 1:
                        if (!ascDescCheck.Checked)
                            updatedList = updatedList.OrderBy(x => x.Title).ToList();
                        else
                            updatedList = updatedList.OrderByDescending(x => x.Title).ToList();
                        break;
                    case 2:
                        if (!ascDescCheck.Checked)
                            updatedList = updatedList.OrderBy(x => x.Discount).ToList();
                        else
                            updatedList = updatedList.OrderByDescending(x => x.Discount).ToList();
                        break;
                    case 3:
                        if (!ascDescCheck.Checked)
                            updatedList = updatedList.OrderBy(x => x.Priority).ToList();
                        else
                            updatedList = updatedList.OrderByDescending(x => x.Priority).ToList();
                        break;
                }
            }

            if (string.IsNullOrWhiteSpace(searchTxtBox.Text))
            {
                updatedList = updatedList
                    .Where(x => x.Title.ToLower().Contains(searchTxtBox.Text.ToLower())
                    || x.Email.ToLower().Contains(searchTxtBox.Text.ToLower())
                    || x.Phone.ToLower().Contains(searchTxtBox.Text.ToLower()))
                    .ToList();
            }

            if (agentCardsLayout.Controls.Count > 0)
            {
                agentCardsLayout.Controls.Clear();
            }

            GenerateAgentCardList(updatedList);
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTxtBox.Text != "Введите для поиска"
                && !string.IsNullOrWhiteSpace(searchTxtBox.Text))
            {
                agentCardsLayout.Controls.Clear();
                ApplyFilters();
            }
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

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ascDescCheck_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void addAgentBtn_Click(object sender, EventArgs e)
        {
            AddEditAgentForm add = new AddEditAgentForm(null);
            DialogResult dialogResult = add.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ApplyFilters();
                selectedAgents.Clear();
            }
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
