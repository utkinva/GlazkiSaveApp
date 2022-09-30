using GlazkiSaveApp.Models;
using GlazkiSaveApp.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GlazkiSaveApp.Views
{
    public partial class AddEditAgentForm : Form
    {
        Agent agent { get; set; } = null;
        List<ProductSale> salesList = new List<ProductSale>();
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
                addSaleBtn.Enabled = false;
                deleteSaleBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }

            productBindingSource.DataSource = DBContext.Context.Product.ToList();
            productSaleBindingSource.DataSource = GetSalesList();
        }

        private List<ProductSale> GetSalesList()
        {
            salesList = DBContext.Context.ProductSale.ToList();
            salesList = salesList.Where(x => x.AgentID == agent.ID).ToList();
            return salesList;
        }

        private void AddEditAgentForm_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(agent.Phone))
            {
                agent.Phone = String.Concat(agent.Phone.Where(c => !Char.IsWhiteSpace(c))).Remove(0, 2);
            }

            if (agent != null)
            {
                if (agent.Logo != null)
                {
                    logoPictureBox.ImageLocation = agent.Logo;
                }
                else
                {
                    logoPictureBox.ImageLocation = @"..\..\Resources\picture.png";
                }
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
            if (iNNMaskedTextBox.Text.Length != 10)
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
                agent.Logo = agent.Logo == @"..\..\Resources\picture.png" ? null : agent.Logo;
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                MessageBox.Show("Невозможно удалить агента, потому что у него есть история продаж", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Agent itemToDelete = (Agent)agentBindingSource.Current;

            DialogResult dr = MessageBox.Show("Удалить текущего агента?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    DBContext.Context.Agent.Remove(itemToDelete);
                    DBContext.Context.SaveChanges();
                    MessageBox.Show("Данные успешно удалены", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void deleteSaleBtn_Click(object sender, EventArgs e)
        {
            ProductSale itemToDelete = productSaleBindingSource.Current as ProductSale;

            DialogResult dr = MessageBox.Show("Удалить данные о продаже?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    DBContext.Context.ProductSale.Remove(itemToDelete);
                    DBContext.Context.SaveChanges();
                    MessageBox.Show("Данные успешно удалены", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productSaleBindingSource.DataSource = GetSalesList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void addSaleBtn_Click(object sender, EventArgs e)
        {
            AddNewSaleForm sale = new AddNewSaleForm(agent);
            DialogResult dr = sale.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productSaleBindingSource.DataSource = GetSalesList();
            }
        }
    }
}
