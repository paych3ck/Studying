namespace LAB9A
{
    partial class Form1
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
            this.TxtBox = new System.Windows.Forms.CheckBox();
            this.CntrBox = new System.Windows.Forms.CheckBox();
            this.VoBox = new System.Windows.Forms.CheckBox();
            this.VnBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBox
            // 
            this.TxtBox.AutoSize = true;
            this.TxtBox.Location = new System.Drawing.Point(178, 112);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(78, 24);
            this.TxtBox.TabIndex = 0;
            this.TxtBox.Text = "Текст";
            this.TxtBox.UseVisualStyleBackColor = true;
            this.TxtBox.CheckedChanged += new System.EventHandler(this.TxtBox_CheckedChanged);
            // 
            // CntrBox
            // 
            this.CntrBox.AutoSize = true;
            this.CntrBox.Location = new System.Drawing.Point(178, 184);
            this.CntrBox.Name = "CntrBox";
            this.CntrBox.Size = new System.Drawing.Size(83, 24);
            this.CntrBox.TabIndex = 1;
            this.CntrBox.Text = "Центр";
            this.CntrBox.UseVisualStyleBackColor = true;
            this.CntrBox.CheckedChanged += new System.EventHandler(this.CntrBox_CheckedChanged);
            // 
            // VoBox
            // 
            this.VoBox.AutoSize = true;
            this.VoBox.Location = new System.Drawing.Point(178, 261);
            this.VoBox.Name = "VoBox";
            this.VoBox.Size = new System.Drawing.Size(172, 24);
            this.VoBox.TabIndex = 2;
            this.VoBox.Text = "Внешняя обводка";
            this.VoBox.UseVisualStyleBackColor = true;
            this.VoBox.CheckedChanged += new System.EventHandler(this.VoBox_CheckedChanged);
            // 
            // VnBox
            // 
            this.VnBox.AutoSize = true;
            this.VnBox.Location = new System.Drawing.Point(178, 336);
            this.VnBox.Name = "VnBox";
            this.VnBox.Size = new System.Drawing.Size(193, 24);
            this.VnBox.TabIndex = 3;
            this.VnBox.Text = "Внутренняя обводка";
            this.VnBox.UseVisualStyleBackColor = true;
            this.VnBox.CheckedChanged += new System.EventHandler(this.VnBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(523, -190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 977);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(523, -190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1040, 997);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Рисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 794);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VnBox);
            this.Controls.Add(this.VoBox);
            this.Controls.Add(this.CntrBox);
            this.Controls.Add(this.TxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TxtBox;
        private System.Windows.Forms.CheckBox CntrBox;
        private System.Windows.Forms.CheckBox VoBox;
        private System.Windows.Forms.CheckBox VnBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

