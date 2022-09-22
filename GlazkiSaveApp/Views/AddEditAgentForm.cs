using GlazkiSaveApp.Models;
using GlazkiSaveApp.Properties;
using GlazkiSaveApp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazkiSaveApp.Views
{
    public partial class AddEditAgentForm : Form
    {
        Agent agent { get; set; } = null;
        public AddEditAgentForm(Agent current)
        {
            InitializeComponent();

            agentTypeBindingSource.DataSource = DBContext.Context.AgentType.ToList();

            if (current != null)
            {
                agent = current;
                this.Text = "Редактировать агента";
            }
            else
            {
                agent = new Agent();
                this.Text = "Добавить нового агента";
            }
        }

        private void AddEditAgentForm_Load(object sender, EventArgs e)
        {
            if (agent != null)
            {
                agentBindingSource.Add(agent);
            }
            else
            {
                agentBindingSource.AddNew();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
                error.AppendLine("Наименование");
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
                error.AppendLine("Адрес");
            if (string.IsNullOrWhiteSpace(iNNTextBox.Text))
                error.AppendLine("ИНН");
            if (string.IsNullOrWhiteSpace(kPPTextBox.Text))
                error.AppendLine("КПП");
            if (string.IsNullOrWhiteSpace(priorityTextBox.Text))
                error.AppendLine("Приоритет");
            if (phoneMaskedTextBox.Text.Length != 15)
                error.AppendLine("Номер телефона");
            if (string.IsNullOrWhiteSpace(emailTextBox.Text)
                || !emailTextBox.Text.Contains("@"))
                error.AppendLine("Email");
            if (agentTypeIDComboBox.SelectedItem == null)
                error.AppendLine("Тип агента");



            if (error.Length != 0)
            {
                MessageBox.Show($"Не удалось сохранить изменения: \n{error}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (agent.ID == 0)
            {
                DBContext.Context.Agent.Add(agent);
            }

            try
            {
                DBContext.Context.SaveChanges();
                MessageBox.Show("Данные успешно сохранены", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
