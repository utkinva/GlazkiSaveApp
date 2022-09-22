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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.priorityValueLbl = new System.Windows.Forms.Label();
            this.priorityLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.salesQtyLbl = new System.Windows.Forms.Label();
            this.percentLbl = new System.Windows.Forms.Label();
            this.typeNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GlazkiSaveApp.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(2, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // priorityValueLbl
            // 
            this.priorityValueLbl.AutoSize = true;
            this.priorityValueLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityValueLbl.Location = new System.Drawing.Point(460, 158);
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
            this.priorityLbl.Location = new System.Drawing.Point(219, 158);
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
            this.phoneLbl.Location = new System.Drawing.Point(219, 116);
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
            this.salesQtyLbl.Location = new System.Drawing.Point(219, 75);
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
            this.percentLbl.Location = new System.Drawing.Point(882, 32);
            this.percentLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.percentLbl.Name = "percentLbl";
            this.percentLbl.Size = new System.Drawing.Size(81, 38);
            this.percentLbl.TabIndex = 7;
            this.percentLbl.Text = "10%";
            // 
            // typeNameLbl
            // 
            this.typeNameLbl.AutoSize = true;
            this.typeNameLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeNameLbl.Location = new System.Drawing.Point(218, 32);
            this.typeNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeNameLbl.Name = "typeNameLbl";
            this.typeNameLbl.Size = new System.Drawing.Size(395, 32);
            this.typeNameLbl.TabIndex = 8;
            this.typeNameLbl.Text = "Тип | Наименование агента";
            // 
            // AgentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.priorityValueLbl);
            this.Controls.Add(this.priorityLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.salesQtyLbl);
            this.Controls.Add(this.percentLbl);
            this.Controls.Add(this.typeNameLbl);
            this.Name = "AgentCard";
            this.Size = new System.Drawing.Size(992, 223);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label priorityValueLbl;
        public System.Windows.Forms.Label priorityLbl;
        public System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label salesQtyLbl;
        private System.Windows.Forms.Label percentLbl;
        public System.Windows.Forms.Label typeNameLbl;
    }
}
