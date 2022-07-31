
namespace Lab2A
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
            this.hight = new System.Windows.Forms.Label();
            this.side = new System.Windows.Forms.Label();
            this.hightTextBox = new System.Windows.Forms.TextBox();
            this.sideTextBox = new System.Windows.Forms.TextBox();
            this.obj1RB = new System.Windows.Forms.RadioButton();
            this.obj2RB = new System.Windows.Forms.RadioButton();
            this.obj3RB = new System.Windows.Forms.RadioButton();
            this.obj4RB = new System.Windows.Forms.RadioButton();
            this.input_button = new System.Windows.Forms.Button();
            this.output_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hight
            // 
            this.hight.AutoSize = true;
            this.hight.Location = new System.Drawing.Point(286, 65);
            this.hight.Name = "hight";
            this.hight.Size = new System.Drawing.Size(45, 13);
            this.hight.TabIndex = 0;
            this.hight.Text = "Высота";
            // 
            // side
            // 
            this.side.AutoSize = true;
            this.side.Location = new System.Drawing.Point(490, 65);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(49, 13);
            this.side.TabIndex = 1;
            this.side.Text = "Сторона";
            // 
            // hightTextBox
            // 
            this.hightTextBox.Location = new System.Drawing.Point(259, 86);
            this.hightTextBox.Name = "hightTextBox";
            this.hightTextBox.Size = new System.Drawing.Size(100, 20);
            this.hightTextBox.TabIndex = 2;
            // 
            // sideTextBox
            // 
            this.sideTextBox.Location = new System.Drawing.Point(471, 86);
            this.sideTextBox.Name = "sideTextBox";
            this.sideTextBox.Size = new System.Drawing.Size(88, 20);
            this.sideTextBox.TabIndex = 3;
            // 
            // obj1RB
            // 
            this.obj1RB.AutoSize = true;
            this.obj1RB.Location = new System.Drawing.Point(47, 65);
            this.obj1RB.Name = "obj1RB";
            this.obj1RB.Size = new System.Drawing.Size(104, 17);
            this.obj1RB.TabIndex = 10;
            this.obj1RB.TabStop = true;
            this.obj1RB.Text = "Первый объект";
            this.obj1RB.UseVisualStyleBackColor = true;
            this.obj1RB.CheckedChanged += new System.EventHandler(this.obj1RB_CheckedChanged);
            // 
            // obj2RB
            // 
            this.obj2RB.AutoSize = true;
            this.obj2RB.Location = new System.Drawing.Point(47, 122);
            this.obj2RB.Name = "obj2RB";
            this.obj2RB.Size = new System.Drawing.Size(100, 17);
            this.obj2RB.TabIndex = 11;
            this.obj2RB.TabStop = true;
            this.obj2RB.Text = "Второй объект";
            this.obj2RB.UseVisualStyleBackColor = true;
            this.obj2RB.CheckedChanged += new System.EventHandler(this.obj2RB_CheckedChanged);
            // 
            // obj3RB
            // 
            this.obj3RB.AutoSize = true;
            this.obj3RB.Location = new System.Drawing.Point(47, 176);
            this.obj3RB.Name = "obj3RB";
            this.obj3RB.Size = new System.Drawing.Size(100, 17);
            this.obj3RB.TabIndex = 12;
            this.obj3RB.TabStop = true;
            this.obj3RB.Text = "Третий объект";
            this.obj3RB.UseVisualStyleBackColor = true;
            this.obj3RB.CheckedChanged += new System.EventHandler(this.obj3RB_CheckedChanged);
            // 
            // obj4RB
            // 
            this.obj4RB.AutoSize = true;
            this.obj4RB.Location = new System.Drawing.Point(47, 230);
            this.obj4RB.Name = "obj4RB";
            this.obj4RB.Size = new System.Drawing.Size(120, 17);
            this.obj4RB.TabIndex = 13;
            this.obj4RB.TabStop = true;
            this.obj4RB.Text = "Четвертый объект";
            this.obj4RB.UseVisualStyleBackColor = true;
            this.obj4RB.CheckedChanged += new System.EventHandler(this.obj4RB_CheckedChanged);
            // 
            // input_button
            // 
            this.input_button.Location = new System.Drawing.Point(259, 125);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(100, 23);
            this.input_button.TabIndex = 14;
            this.input_button.Text = "Ввод значений";
            this.input_button.UseVisualStyleBackColor = true;
            this.input_button.Click += new System.EventHandler(this.input_button_Click);
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Location = new System.Drawing.Point(256, 176);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(10, 13);
            this.output_label.TabIndex = 15;
            this.output_label.Text = "-";
            // 
            // result_label
            // 
            this.result_label.Location = new System.Drawing.Point(471, 125);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(88, 23);
            this.result_label.TabIndex = 16;
            this.result_label.Text = "Результат";
            this.result_label.UseVisualStyleBackColor = true;
            this.result_label.Click += new System.EventHandler(this.result_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 398);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.input_button);
            this.Controls.Add(this.obj4RB);
            this.Controls.Add(this.obj3RB);
            this.Controls.Add(this.obj2RB);
            this.Controls.Add(this.obj1RB);
            this.Controls.Add(this.sideTextBox);
            this.Controls.Add(this.hightTextBox);
            this.Controls.Add(this.side);
            this.Controls.Add(this.hight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hight;
        private System.Windows.Forms.Label side;
        private System.Windows.Forms.TextBox hightTextBox;
        private System.Windows.Forms.TextBox sideTextBox;
        private System.Windows.Forms.RadioButton obj1RB;
        private System.Windows.Forms.RadioButton obj2RB;
        private System.Windows.Forms.RadioButton obj3RB;
        private System.Windows.Forms.RadioButton obj4RB;
        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.Button result_label;
    }
}

