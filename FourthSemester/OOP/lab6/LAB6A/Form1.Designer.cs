
namespace LAB6A
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.rectangle_button = new System.Windows.Forms.Button();
            this.rhomb_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.x_tb = new System.Windows.Forms.TextBox();
            this.y_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // rectangle_button
            // 
            this.rectangle_button.Location = new System.Drawing.Point(186, 128);
            this.rectangle_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rectangle_button.Name = "rectangle_button";
            this.rectangle_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rectangle_button.Size = new System.Drawing.Size(166, 35);
            this.rectangle_button.TabIndex = 0;
            this.rectangle_button.Text = "Прямоугольник";
            this.rectangle_button.UseVisualStyleBackColor = true;
            this.rectangle_button.Click += new System.EventHandler(this.rectangle_button_Click);
            // 
            // rhomb_button
            // 
            this.rhomb_button.Location = new System.Drawing.Point(186, 212);
            this.rhomb_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rhomb_button.Name = "rhomb_button";
            this.rhomb_button.Size = new System.Drawing.Size(166, 35);
            this.rhomb_button.TabIndex = 1;
            this.rhomb_button.Text = "Ромб";
            this.rhomb_button.UseVisualStyleBackColor = true;
            this.rhomb_button.Click += new System.EventHandler(this.rhomb_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xpos";
            // 
            // x_tb
            // 
            this.x_tb.Location = new System.Drawing.Point(224, 291);
            this.x_tb.Name = "x_tb";
            this.x_tb.Size = new System.Drawing.Size(128, 26);
            this.x_tb.TabIndex = 3;
            // 
            // y_tb
            // 
            this.y_tb.Location = new System.Drawing.Point(224, 344);
            this.y_tb.Name = "y_tb";
            this.y_tb.Size = new System.Drawing.Size(128, 26);
            this.y_tb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ypos";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(186, 419);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(166, 35);
            this.start_button.TabIndex = 6;
            this.start_button.Text = "Начать";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(549, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 326);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.y_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rhomb_button);
            this.Controls.Add(this.rectangle_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button rhomb_button;
        private System.Windows.Forms.Button rectangle_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TextBox y_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x_tb;
        private System.Windows.Forms.Label label1;
    }
}

