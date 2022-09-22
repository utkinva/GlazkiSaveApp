namespace GlazkiSaveApp.Views.PartialView
{
    partial class AgentCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.priorityValueLbl = new System.Windows.Forms.Label();
            this.priorityLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.salesQtyLbl = new System.Windows.Forms.Label();
            this.percentLbl = new System.Windows.Forms.Label();
            this.titleTypeLbl = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.idAgentLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // priorityValueLbl
            // 
            this.priorityValueLbl.AutoSize = true;
            this.priorityValueLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityValueLbl.Location = new System.Drawing.Point(503, 158);
            this.priorityValueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priorityValueLbl.Name = "priorityValueLbl";
            this.priorityValueLbl.Size = new System.Drawing.Size(45, 33);
            this.priorityValueLbl.TabIndex = 3;
            this.priorityValueLbl.Text = "10";
            // 
            // priorityLbl
            // 
            this.priorityLbl.AutoSize = true;
            this.priorityLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLbl.Location = new System.Drawing.Point(262, 158);
            this.priorityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priorityLbl.Name = "priorityLbl";
            this.priorityLbl.Size = new System.Drawing.Size(240, 33);
            this.priorityLbl.TabIndex = 4;
            this.priorityLbl.Text = "Приоритетность:";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(262, 116);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(210, 33);
            this.phoneLbl.TabIndex = 5;
            this.phoneLbl.Text = "+7 111 11 11 11";
            // 
            // salesQtyLbl
            // 
            this.salesQtyLbl.AutoSize = true;
            this.salesQtyLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesQtyLbl.Location = new System.Drawing.Point(262, 75);
            this.salesQtyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salesQtyLbl.Name = "salesQtyLbl";
            this.salesQtyLbl.Size = new System.Drawing.Size(254, 33);
            this.salesQtyLbl.TabIndex = 6;
            this.salesQtyLbl.Text = "## продаж за год";
            // 
            // percentLbl
            // 
            this.percentLbl.AutoSize = true;
            this.percentLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentLbl.Location = new System.Drawing.Point(1097, 32);
            this.percentLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.percentLbl.Name = "percentLbl";
            this.percentLbl.Size = new System.Drawing.Size(81, 38);
            this.percentLbl.TabIndex = 7;
            this.percentLbl.Text = "10%";
            // 
            // titleTypeLbl
            // 
            this.titleTypeLbl.AutoSize = true;
            this.titleTypeLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTypeLbl.Location = new System.Drawing.Point(261, 32);
            this.titleTypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleTypeLbl.Name = "titleTypeLbl";
            this.titleTypeLbl.Size = new System.Drawing.Size(395, 32);
            this.titleTypeLbl.TabIndex = 8;
            this.titleTypeLbl.Text = "Тип | Наименование агента";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::GlazkiSaveApp.Properties.Resources.picture;
            this.logoPictureBox.Location = new System.Drawing.Point(25, 32);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(212, 170);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // idAgentLbl
            // 
            this.idAgentLbl.AutoSize = true;
            this.idAgentLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idAgentLbl.Location = new System.Drawing.Point(916, 111);
            this.idAgentLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idAgentLbl.Name = "idAgentLbl";
            this.idAgentLbl.Size = new System.Drawing.Size(0, 38);
            this.idAgentLbl.TabIndex = 7;
            this.idAgentLbl.Visible = false;
            // 
            // AgentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.priorityValueLbl);
            this.Controls.Add(this.priorityLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.salesQtyLbl);
            this.Controls.Add(this.idAgentLbl);
            this.Controls.Add(this.percentLbl);
            this.Controls.Add(this.titleTypeLbl);
            this.Name = "AgentCard";
            this.Size = new System.Drawing.Size(1190, 221);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox logoPictureBox;
        public System.Windows.Forms.Label priorityValueLbl;
        public System.Windows.Forms.Label priorityLbl;
        public System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label salesQtyLbl;
        public System.Windows.Forms.Label titleTypeLbl;
        public System.Windows.Forms.Label percentLbl;
        public System.Windows.Forms.Label idAgentLbl;
    }
}
