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
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.changeLogoBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.agentTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            logoLabel.Location = new System.Drawing.Point(575, 19);
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
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "INN", true));
            this.iNNTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iNNTextBox.Location = new System.Drawing.Point(276, 79);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(220, 33);
            this.iNNTextBox.TabIndex = 10;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kPPTextBox.Location = new System.Drawing.Point(276, 141);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(220, 33);
            this.kPPTextBox.TabIndex = 12;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.agentBindingSource, "Logo", true));
            this.logoPictureBox.Image = global::GlazkiSaveApp.Properties.Resources.picture;
            this.logoPictureBox.Location = new System.Drawing.Point(579, 49);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(250, 250);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 14;
            this.logoPictureBox.TabStop = false;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Priority", true));
            this.priorityTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityTextBox.Location = new System.Drawing.Point(276, 267);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(220, 33);
            this.priorityTextBox.TabIndex = 18;
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
            this.changeLogoBtn.Location = new System.Drawing.Point(579, 305);
            this.changeLogoBtn.Name = "changeLogoBtn";
            this.changeLogoBtn.Size = new System.Drawing.Size(250, 42);
            this.changeLogoBtn.TabIndex = 21;
            this.changeLogoBtn.Text = "Выбрать";
            this.changeLogoBtn.UseVisualStyleBackColor = false;
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
            this.cancelBtn.Location = new System.Drawing.Point(579, 496);
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
            // AddEditAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 558);
            this.ControlBox = false;
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.cancelBtn);
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
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(this.kPPTextBox);
            this.Controls.Add(logoLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityTextBox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button changeLogoBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.ComboBox agentTypeIDComboBox;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
    }
}