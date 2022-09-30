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
        List<AgentType> agentTypes = DBContext.Context.AgentType.ToList();
        int nPage = 0;
        int nPageMax = 0;

        public MainForm()
        {
            InitializeComponent();

            agents = DBContext.Context.Agent.ToList();

            ApplyFilters();

            agentTypes.Insert(0, new AgentType { Title = "Все типы" });
            filterComboBox.DataSource = agentTypes;

            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод генерации карточек агентов
        /// </summary>
        /// <param name="agents">Список агентов в таблице базы данных</param>
        /// <param name="nPage">Текущая страница</param>
        /// <param name="pageSize">Количество элементов на странице</param>
        private void GenerateAgentCardList(List<Agent> agents, int nPage, int pageSize)
        {
            nPageMax = ((int)agents.Count / 10 < 1) ? 1 : (int)agents.Count / 10;
            agents = agents.Skip(nPage * pageSize).Take(pageSize).ToList();
            pagesLbl.Text = $"{nPage + 1} из {nPageMax}";

            agentCardsLayout.Controls.Clear();
            foreach (var agent in agents)
            {
                AgentCard agentCard = new AgentCard();

                agentCard.GenerateAgentData(agent);
                agentCardsLayout.Controls.Add(agentCard);

                agentCard.Click += AgentCard_Click;
                agentCard.DoubleClick += AgentCard_DoubleClick;
            }
        }
        #region События нажатий на карточки агентов
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
        }
        #endregion

        #region События нажатий кнопок на форме
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
        private void changePriorityBtn_Click(object sender, EventArgs e)
        {
            if (selectedAgents.Count == 0)
            {
                MessageBox.Show("Необходимо выбрать хотя бы одного агента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChangePriorityForm change = new ChangePriorityForm(selectedAgents);
            DialogResult dr = change.ShowDialog();
            if (dr == DialogResult.OK)
            {
                selectedAgents.Clear();
                ApplyFilters();
            }
        }

        private void nextPageLbl_Click(object sender, EventArgs e)
        {
            if (nPage + 1 < nPageMax)
            {
                nPage++;
                GenerateAgentCardList(agents, nPage, 10);
            }
        }

        private void prevPageLbl_Click(object sender, EventArgs e)
        {
            if (nPage > 0)
            {
                nPage--;
                GenerateAgentCardList(agents, nPage, 10);
            }
        }
        #endregion

        #region Поиск, сортировка и фильтрация
        public void ApplyFilters()
        {
            var updatedList = DBContext.Context.Agent.ToList();
            #region Поиск
            if (!string.IsNullOrWhiteSpace(searchTxtBox.Text)
                && searchTxtBox.Text != "Введите для поиска")
            {
                updatedList = updatedList
                    .Where(x => x.Title.ToLower().Contains(searchTxtBox.Text.ToLower())
                    || x.Email.ToLower().Contains(searchTxtBox.Text.ToLower())
                    || x.Phone.ToLower().Contains(searchTxtBox.Text.ToLower()))
                    .ToList();
            }
            #endregion
            #region Фильтрация
            if (filterComboBox.SelectedIndex > 0)
            {
                updatedList = updatedList.Where(x => x.AgentType.ID == filterComboBox.SelectedIndex).ToList();
            }
            #endregion
            #region Сортировка
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
            #endregion
            nPage = 0;
            selectedAgents.Clear();
            GenerateAgentCardList(updatedList, nPage, 10);
        }
        /// <summary>
        /// Событие для вызова метода сортировки, поиска и фильтрации
        /// </summary>
        private void TriggerFilters(object sender, EventArgs e) => ApplyFilters();
        #endregion
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
