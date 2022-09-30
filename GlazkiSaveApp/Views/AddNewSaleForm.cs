using GlazkiSaveApp.Models;
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
    public partial class AddNewSaleForm : Form
    {
        Agent agent { get; set; } = null;
        public AddNewSaleForm(Agent current)
        {
            InitializeComponent();

            agent = current;

            productBindingSource.DataSource = DBContext.Context.Product.ToList();
            productSaleBindingSource.AddNew();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (productCountNumericUpDown.Value <= 0)
                errors.AppendLine("Количество должно быть не равным нулю");
            if (saleDateDateTimePicker.Value > DateTime.Now)
                errors.AppendLine($"Дата продажи может быть не позднее {DateTime.Now.ToShortDateString()}");
            if (productIDComboBox.SelectedItem == null)
                errors.AppendLine($"Выберите продукт");

            if (errors.Length > 0)
            {
                MessageBox.Show($"{errors}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ProductSale sale = new ProductSale()
            {
                AgentID = agent.ID,
                ProductID = ((ProductSale)productSaleBindingSource.Current).ProductID,
                SaleDate = DateTime.Parse(saleDateDateTimePicker.Value.ToShortDateString()),
                ProductCount = ((ProductSale)productSaleBindingSource.Current).ProductCount,
            };
                
            try
            {
                DBContext.Context.ProductSale.Add(sale);
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
