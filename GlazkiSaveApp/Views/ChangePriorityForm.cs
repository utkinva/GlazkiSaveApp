using GlazkiSaveApp.Models;
using GlazkiSaveApp.Utilities;
using GlazkiSaveApp.Views.PartialView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GlazkiSaveApp.Views
{
    public partial class ChangePriorityForm : Form
    {
        List<Agent> agents = new List<Agent>();
        public ChangePriorityForm(List<AgentCard> agentCards)
        {
            InitializeComponent();

            priorityNumeric.Maximum = Int32.MaxValue;
            priorityNumeric.Value = GetMaximumPriorityValue(agentCards);
        }

        private int GetMaximumPriorityValue(List<AgentCard> cards)
        {
            int maximumPriority = 0;
            foreach (var card in cards)
            {

                agents.Add((Agent)DBContext.Context.Agent.First(x => x.ID.ToString() == card.idAgentLbl.Text));
            }
            foreach (var agent in agents)
            {
                maximumPriority = agent.Priority > maximumPriority ? agent.Priority : maximumPriority;
            }
            return maximumPriority;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (var agent in agents)
            {
                agent.Priority = (int)priorityNumeric.Value;
            }

            try
            {
                DBContext.Context.SaveChanges();
                MessageBox.Show("Данные успешно сохранены.", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
