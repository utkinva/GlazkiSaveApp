namespace GlazkiSaveApp.Views
{
    partial class AddEditAgentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label agentTypeIDLabel;
            System.Windows.Forms.Label directorNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label logoLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditAgentForm));
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.changeLogoBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.agentTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priorityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.iNNMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.kPPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addSaleBtn = new System.Windows.Forms.Button();
            this.deleteSaleBtn = new System.Windows.Forms.Button();
            addressLabel = new System.Windows.Forms.Label();
            agentTypeIDLabel = new System.Windows.Forms.Label();
            directorNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            logoLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(12, 82);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(85, 24);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Адрес:";
            // 
            // agentTypeIDLabel
            // 
            agentTypeIDLabel.AutoSize = true;
            agentTypeIDLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            agentTypeIDLabel.Location = new System.Drawing.Point(12, 145);
            agentTypeIDLabel.Name = "agentTypeIDLabel";
            agentTypeIDLabel.Size = new System.Drawing.Size(126, 24);
            agentTypeIDLabel.TabIndex = 3;
            agentTypeIDLabel.Text = "Тип агента:";
            // 
            // directorNameLabel
            // 
            directorNameLabel.AutoSize = true;
            directorNameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            directorNameLabel.Location = new System.Drawing.Point(12, 207);
            directorNameLabel.Name = "directorNameLabel";
            directorNameLabel.Size = new System.Drawing.Size(188, 24);
            directorNameLabel.TabIndex = 5;
            directorNameLabel.Text = "ФИО директора:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(12, 270);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(69, 24);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iNNLabel.Location = new System.Drawing.Point(272, 52);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(59, 24);
            iNNLabel.TabIndex = 9;
            iNNLabel.Text = "ИНН:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kPPLabel.Location = new System.Drawing.Point(272, 115);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(50, 24);
            kPPLabel.TabIndex = 11;
            kPPLabel.Text = "КПП";
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            logoLabel.Location = new System.Drawing.Point(513, 14);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(100, 24);
            logoLabel.TabIndex = 13;
            logoLabel.Text = "Логотип:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priorityLabel.Location = new System.Drawing.Point(272, 240);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(127, 24);
            priorityLabel.TabIndex = 17;
            priorityLabel.Text = "Приоритет:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(12, 19);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(179, 24);
            titleLabel.TabIndex = 19;
            titleLabel.Text = "Наименование:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(272, 180);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(202, 24);
            phoneLabel.TabIndex = 21;
            phoneLabel.Text = "Номер телефона";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(16, 109);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(220, 33);
            this.addressTextBox.TabIndex = 2;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(GlazkiSaveApp.Models.Agent);
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "DirectorName", true));
            this.directorNameTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorNameTextBox.Location = new System.Drawing.Point(16, 234);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(220, 33);
            this.directorNameTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(16, 297);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(220, 33);
            this.emailTextBox.TabIndex = 8;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.agentBindingSource, "Logo", true));
            this.logoPictureBox.Image = global::GlazkiSaveApp.Properties.Resources.picture;
            this.logoPictureBox.Location = new System.Drawing.Point(517, 44);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(250, 250);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 14;
            this.logoPictureBox.TabStop = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(16, 46);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(220, 33);
            this.titleTextBox.TabIndex = 20;
            // 
            // changeLogoBtn
            // 
            this.changeLogoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.changeLogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeLogoBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeLogoBtn.ForeColor = System.Drawing.Color.White;
            this.changeLogoBtn.Location = new System.Drawing.Point(517, 300);
            this.changeLogoBtn.Name = "changeLogoBtn";
            this.changeLogoBtn.Size = new System.Drawing.Size(250, 42);
            this.changeLogoBtn.TabIndex = 21;
            this.changeLogoBtn.Text = "Выбрать";
            this.changeLogoBtn.UseVisualStyleBackColor = false;
            this.changeLogoBtn.Click += new System.EventHandler(this.changeLogoBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(12, 496);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(250, 42);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(996, 496);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(250, 42);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(276, 207);
            this.phoneMaskedTextBox.Mask = "+7 000 000 00 00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(220, 33);
            this.phoneMaskedTextBox.TabIndex = 22;
            // 
            // agentTypeIDComboBox
            // 
            this.agentTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agentBindingSource, "AgentTypeID", true));
            this.agentTypeIDComboBox.DataSource = this.agentTypeBindingSource;
            this.agentTypeIDComboBox.DisplayMember = "Title";
            this.agentTypeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agentTypeIDComboBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentTypeIDComboBox.FormattingEnabled = true;
            this.agentTypeIDComboBox.Location = new System.Drawing.Point(16, 172);
            this.agentTypeIDComboBox.Name = "agentTypeIDComboBox";
            this.agentTypeIDComboBox.Size = new System.Drawing.Size(220, 32);
            this.agentTypeIDComboBox.TabIndex = 4;
            this.agentTypeIDComboBox.ValueMember = "ID";
            // 
            // agentTypeBindingSource
            // 
            this.agentTypeBindingSource.DataSource = typeof(GlazkiSaveApp.Models.AgentType);
            // 
            // priorityNumericUpDown
            // 
            this.priorityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agentBindingSource, "Priority", true));
            this.priorityNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.priorityNumericUpDown.Location = new System.Drawing.Point(276, 267);
            this.priorityNumericUpDown.Name = "priorityNumericUpDown";
            this.priorityNumericUpDown.Size = new System.Drawing.Size(217, 33);
            this.priorityNumericUpDown.TabIndex = 24;
            // 
            // iNNMaskedTextBox
            // 
            this.iNNMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "INN", true));
            this.iNNMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.iNNMaskedTextBox.Location = new System.Drawing.Point(276, 79);
            this.iNNMaskedTextBox.Mask = "0000000000";
            this.iNNMaskedTextBox.Name = "iNNMaskedTextBox";
            this.iNNMaskedTextBox.Size = new System.Drawing.Size(220, 33);
            this.iNNMaskedTextBox.TabIndex = 25;
            // 
            // kPPMaskedTextBox
            // 
            this.kPPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.kPPMaskedTextBox.Location = new System.Drawing.Point(276, 142);
            this.kPPMaskedTextBox.Mask = "000000000";
            this.kPPMaskedTextBox.Name = "kPPMaskedTextBox";
            this.kPPMaskedTextBox.Size = new System.Drawing.Size(220, 33);
            this.kPPMaskedTextBox.TabIndex = 26;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(268, 496);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(250, 42);
            this.deleteBtn.TabIndex = 21;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productCountDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.productSaleBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(773, 19);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(473, 323);
            this.dataGridView.TabIndex = 27;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.DataSource = this.productBindingSource;
            this.productIDDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.productIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(GlazkiSaveApp.Models.Product);
            // 
            // productCountDataGridViewTextBoxColumn
            // 
            this.productCountDataGridViewTextBoxColumn.DataPropertyName = "ProductCount";
            this.productCountDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.productCountDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.productCountDataGridViewTextBoxColumn.Name = "productCountDataGridViewTextBoxColumn";
            this.productCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.saleDateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productSaleBindingSource
            // 
            this.productSaleBindingSource.DataSource = typeof(GlazkiSaveApp.Models.ProductSale);
            // 
            // addSaleBtn
            // 
            this.addSaleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.addSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSaleBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSaleBtn.ForeColor = System.Drawing.Color.White;
            this.addSaleBtn.Location = new System.Drawing.Point(773, 348);
            this.addSaleBtn.Name = "addSaleBtn";
            this.addSaleBtn.Size = new System.Drawing.Size(212, 42);
            this.addSaleBtn.TabIndex = 21;
            this.addSaleBtn.Text = "+";
            this.addSaleBtn.UseVisualStyleBackColor = false;
            // 
            // deleteSaleBtn
            // 
            this.deleteSaleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.deleteSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSaleBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteSaleBtn.ForeColor = System.Drawing.Color.White;
            this.deleteSaleBtn.Location = new System.Drawing.Point(1034, 348);
            this.deleteSaleBtn.Name = "deleteSaleBtn";
            this.deleteSaleBtn.Size = new System.Drawing.Size(212, 42);
            this.deleteSaleBtn.TabIndex = 21;
            this.deleteSaleBtn.Text = "-";
            this.deleteSaleBtn.UseVisualStyleBackColor = false;
            this.deleteSaleBtn.Click += new System.EventHandler(this.deleteSaleBtn_Click);
            // 
            // AddEditAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 541);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.kPPMaskedTextBox);
            this.Controls.Add(this.iNNMaskedTextBox);
            this.Controls.Add(this.priorityNumericUpDown);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.deleteSaleBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addSaleBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.changeLogoBtn);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(agentTypeIDLabel);
            this.Controls.Add(this.agentTypeIDComboBox);
            this.Controls.Add(directorNameLabel);
            this.Controls.Add(this.directorNameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(logoLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditAgentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление/Изменение агента";
            this.Load += new System.EventHandler(this.AddEditAgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button changeLogoBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.ComboBox agentTypeIDComboBox;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
        private System.Windows.Forms.NumericUpDown priorityNumericUpDown;
        private System.Windows.Forms.MaskedTextBox iNNMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox kPPMaskedTextBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productSaleBindingSource;
        private System.Windows.Forms.Button addSaleBtn;
        private System.Windows.Forms.Button deleteSaleBtn;
    }
}