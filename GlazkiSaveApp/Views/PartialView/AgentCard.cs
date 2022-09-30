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
            idAgentLbl.Text = agent.ID.ToString();
            logoPictureBox.ImageLocation = agent.Logo;
            titleTypeLbl.Text = $"{agent.AgentType.Title} | {agent.Title}";
            phoneLbl.Text = agent.Phone;
            priorityValueLbl.Text = agent.Priority.ToString();
            percentLbl.Text = $"{agent.Discount}%";
            salesQtyLbl.Text = $"{agent.SalesQtyPerLastYear} продаж за год";

            if (agent.Discount >= 25)
            {
                titleTypeLbl.ForeColor = Color.LightGreen;
                percentLbl.ForeColor = Color.LightGreen;
            }
        }
    }
}
