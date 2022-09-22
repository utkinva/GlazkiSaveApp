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

            idAgentLbl.Text = agent.ID.ToString();
            logoPictureBox.ImageLocation = agent.Logo;
            titleTypeLbl.Text = $"{agent.AgentType.Title} | {agent.Title}";
            phoneLbl.Text = agent.Phone;
            priorityValueLbl.Text = agent.Priority.ToString();
            percentLbl.Text = $"{agent.Discount}%";

            //  продажи за последний год
            foreach (ProductSale sale in agent.ProductSale)
            {
                if (sale.SaleDate.Year == 2019)
                {
                    salesQtyLastYear += sale.ProductCount;
                }
            }

            salesQtyLbl.Text = $"{salesQtyLastYear} продаж за год";

            if (int.Parse(percentLbl.Text.Remove(percentLbl.Text.Length - 1)) >= 25)
            {
                titleTypeLbl.ForeColor = Color.LightGreen;
                percentLbl.ForeColor = Color.LightGreen;
            }
        }
    }
}
