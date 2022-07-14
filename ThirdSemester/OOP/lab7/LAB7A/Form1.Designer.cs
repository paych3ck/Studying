namespace LAB7A
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
            this.add_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(596, 50);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(116, 48);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(596, 137);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(116, 48);
            this.next_button.TabIndex = 1;
            this.next_button.Text = "Следующий";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(755, 50);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(123, 48);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.Location = new System.Drawing.Point(755, 137);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(123, 48);
            this.previous_button.TabIndex = 3;
            this.previous_button.Text = "Предыдущий";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(682, 226);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 48);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 224);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.add_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Panel panel1;
    }
}

