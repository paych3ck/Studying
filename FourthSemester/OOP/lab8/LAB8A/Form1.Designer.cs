namespace LAB8A
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
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.compareBtn = new System.Windows.Forms.Button();
            this.zTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(74, 94);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 26);
            this.xTextBox.TabIndex = 0;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(226, 94);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 26);
            this.yTextBox.TabIndex = 1;
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Location = new System.Drawing.Point(716, 42);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(88, 78);
            this.multiplyBtn.TabIndex = 2;
            this.multiplyBtn.Text = "*";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(861, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "* (на k)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(997, 42);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(88, 78);
            this.minusBtn.TabIndex = 4;
            this.minusBtn.Text = "- -";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(1124, 42);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(88, 78);
            this.compareBtn.TabIndex = 5;
            this.compareBtn.Text = "==, !=";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // zTextBox
            // 
            this.zTextBox.Location = new System.Drawing.Point(387, 94);
            this.zTextBox.Name = "zTextBox";
            this.zTextBox.Size = new System.Drawing.Size(100, 26);
            this.zTextBox.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(226, 208);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(458, 104);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(226, 384);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(458, 104);
            this.listBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "z";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "k";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(950, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 639);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.zTextBox);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.TextBox zTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

