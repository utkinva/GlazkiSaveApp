using GlazkiSaveApp.Models;
using GlazkiSaveApp.Properties;
using GlazkiSaveApp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            priorityNumericUpDown.Maximum = Int32.MaxValue;

            agentTypeBindingSource.DataSource = DBContext.Context.AgentType.ToList();

            if (current != null)
            {
                agent = current;
                this.Text = "Редактировать агента";
            }
            else
            {
                agent = new Agent()
                {
                    Logo = @"..\..\Resources\picture.png"
                };
                this.Text = "Добавить нового агента";
            }
        }

        private void AddEditAgentForm_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(agent.Phone))
            {
                agent.Phone = String.Concat(agent.Phone.Where(c => !Char.IsWhiteSpace(c))).Remove(0, 2);
            }
            if (agent != null)
            {
                agentBindingSource.Add(agent);
                if (agent.Logo != null)
                {
                    logoPictureBox.ImageLocation = agent.Logo;
                }
                else
                {
                    logoPictureBox.ImageLocation = @"..\..\Resources\picture.png";
                }
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
            if (iNNMaskedTextBox.Text.Length != 12)
                error.AppendLine("ИНН");
            if (kPPMaskedTextBox.Text.Length != 9)
                error.AppendLine("КПП");
            if (phoneMaskedTextBox.Text.Length != 16)
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

        private void changeLogoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.CurrentDirectory + @"\agents\";
            DialogResult dr = dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string file = dialog.FileName;
                int num = file.IndexOf(@"agents");
                file = file.Substring(num);

                logoPictureBox.Image = Image.FromFile(file);
                ((Agent)agentBindingSource.Current).Logo = file;
            }

        }
    }
}
