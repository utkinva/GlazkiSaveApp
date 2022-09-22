using GlazkiSaveApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazkiSaveApp.Views.PartialView
{
    public partial class AgentCard : UserControl
    {
        public AgentCard()
        {
            InitializeComponent();
        }

        public void GenerateAgentData(Agent agent)
        {
            int salesQtyLastYear = 0;
            int salesQtyAllPeriod = 0;
            decimal salesSum = 0;

            logoPictureBox.ImageLocation = agent.Logo;
            titleTypeLbl.Text = $"{agent.AgentType.Title} | {agent.Title}";
            phoneLbl.Text = agent.Phone;
            priorityValueLbl.Text = agent.Priority.ToString();

            // общая сумма продаж
            foreach (ProductSale sale in agent.ProductSale)
            {
                salesQtyAllPeriod += sale.ProductCount;
                salesSum += salesQtyAllPeriod * sale.Product.MinCostForAgent;
            }

            //  продажи за последний год
            foreach (ProductSale sale in agent.ProductSale)
            {
                if (sale.SaleDate.Year == 2019)
                {
                    salesQtyLastYear += sale.ProductCount;

                }
            }

            salesQtyLbl.Text = $"{salesQtyLastYear} продаж за год";

            if (salesSum < 10000)
            {
                percentLbl.Text = "0%";
            }
            else if (salesSum >= 10000 && salesSum <= 50000)
            {
                percentLbl.Text = "5%";
            }
            else if (salesSum > 50000 && salesSum <= 150000)
            {
                percentLbl.Text = "10%";
            }
            else if (salesSum > 150000 && salesSum <= 500000)
            {
                percentLbl.Text = "20%";
            }
            else
            {
                percentLbl.Text = "25%";
            }
 
            if (int.Parse(percentLbl.Text.Remove(percentLbl.Text.Length - 1)) >= 25)
            {
                BackColor = Color.LightGreen;
            }
        }
    }
}
