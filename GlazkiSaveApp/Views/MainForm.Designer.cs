namespace GlazkiSaveApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ascDescCheck = new System.Windows.Forms.CheckBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.addAgentBtn = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.agentCardsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.FooterPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.ascDescCheck);
            this.HeaderPanel.Controls.Add(this.filterComboBox);
            this.HeaderPanel.Controls.Add(this.sortComboBox);
            this.HeaderPanel.Controls.Add(this.searchTxtBox);
            this.HeaderPanel.Controls.Add(this.logoPictureBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1216, 150);
            this.HeaderPanel.TabIndex = 0;
            // 
            // ascDescCheck
            // 
            this.ascDescCheck.AutoSize = true;
            this.ascDescCheck.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ascDescCheck.Location = new System.Drawing.Point(825, 112);
            this.ascDescCheck.Name = "ascDescCheck";
            this.ascDescCheck.Size = new System.Drawing.Size(170, 28);
            this.ascDescCheck.TabIndex = 2;
            this.ascDescCheck.Text = "По убыванию";
            this.ascDescCheck.UseVisualStyleBackColor = true;
            this.ascDescCheck.CheckedChanged += new System.EventHandler(this.ascDescCheck_CheckedChanged);
            // 
            // filterComboBox
            // 
            this.filterComboBox.DataSource = this.agentTypeBindingSource;
            this.filterComboBox.DisplayMember = "Title";
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(1001, 111);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(202, 32);
            this.filterComboBox.TabIndex = 1;
            this.filterComboBox.ValueMember = "ID";
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // agentTypeBindingSource
            // 
            this.agentTypeBindingSource.DataSource = typeof(GlazkiSaveApp.Models.AgentType);
            // 
            // sortComboBox
            // 
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Без сортировки",
            "Наименование",
            "Размер скидки",
            "Приоритет"});
            this.sortComboBox.Location = new System.Drawing.Point(581, 110);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(238, 32);
            this.sortComboBox.TabIndex = 0;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxtBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxtBox.Location = new System.Drawing.Point(149, 110);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(426, 33);
            this.searchTxtBox.TabIndex = 1;
            this.searchTxtBox.Text = "Введите для поиска";
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            this.searchTxtBox.Enter += new System.EventHandler(this.searchTxtBox_Enter);
            this.searchTxtBox.Leave += new System.EventHandler(this.searchTxtBox_Leave);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::GlazkiSaveApp.Properties.Resources.Глазки_save;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(140, 140);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.FooterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FooterPanel.Controls.Add(this.addAgentBtn);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 734);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1216, 54);
            this.FooterPanel.TabIndex = 1;
            // 
            // addAgentBtn
            // 
            this.addAgentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.addAgentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAgentBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAgentBtn.ForeColor = System.Drawing.Color.White;
            this.addAgentBtn.Location = new System.Drawing.Point(11, 5);
            this.addAgentBtn.Name = "addAgentBtn";
            this.addAgentBtn.Size = new System.Drawing.Size(200, 42);
            this.addAgentBtn.TabIndex = 0;
            this.addAgentBtn.Text = "Добавить";
            this.addAgentBtn.UseVisualStyleBackColor = false;
            this.addAgentBtn.Click += new System.EventHandler(this.addAgentBtn_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.agentCardsLayout);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 150);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1216, 584);
            this.ContentPanel.TabIndex = 2;
            // 
            // agentCardsLayout
            // 
            this.agentCardsLayout.AutoScroll = true;
            this.agentCardsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentCardsLayout.Location = new System.Drawing.Point(0, 0);
            this.agentCardsLayout.Name = "agentCardsLayout";
            this.agentCardsLayout.Size = new System.Drawing.Size(1216, 584);
            this.agentCardsLayout.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 788);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1232, 827);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.FooterPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.FlowLayoutPanel agentCardsLayout;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
        private System.Windows.Forms.CheckBox ascDescCheck;
        private System.Windows.Forms.Button addAgentBtn;
    }
}

