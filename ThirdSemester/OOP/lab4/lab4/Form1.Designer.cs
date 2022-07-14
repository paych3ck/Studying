
namespace LAB4A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.object_TB = new System.Windows.Forms.TextBox();
            this.hight_TB = new System.Windows.Forms.TextBox();
            this.side_TB = new System.Windows.Forms.TextBox();
            this.PrismsBox = new System.Windows.Forms.ListBox();
            this.input_button = new System.Windows.Forms.Button();
            this.output_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.output_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объект";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сторона";
            // 
            // object_TB
            // 
            this.object_TB.Location = new System.Drawing.Point(12, 52);
            this.object_TB.Name = "object_TB";
            this.object_TB.Size = new System.Drawing.Size(67, 23);
            this.object_TB.TabIndex = 3;
            // 
            // hight_TB
            // 
            this.hight_TB.Location = new System.Drawing.Point(116, 52);
            this.hight_TB.Name = "hight_TB";
            this.hight_TB.Size = new System.Drawing.Size(67, 23);
            this.hight_TB.TabIndex = 4;
            // 
            // side_TB
            // 
            this.side_TB.Location = new System.Drawing.Point(227, 52);
            this.side_TB.Name = "side_TB";
            this.side_TB.Size = new System.Drawing.Size(67, 23);
            this.side_TB.TabIndex = 5;
            // 
            // PrismsBox
            // 
            this.PrismsBox.FormattingEnabled = true;
            this.PrismsBox.ItemHeight = 15;
            this.PrismsBox.Location = new System.Drawing.Point(12, 132);
            this.PrismsBox.Name = "PrismsBox";
            this.PrismsBox.Size = new System.Drawing.Size(487, 139);
            this.PrismsBox.TabIndex = 6;
            // 
            // input_button
            // 
            this.input_button.Location = new System.Drawing.Point(537, 132);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(75, 23);
            this.input_button.TabIndex = 7;
            this.input_button.Text = "Ввод";
            this.input_button.UseVisualStyleBackColor = true;
            this.input_button.Click += new System.EventHandler(this.input_button_Click);
            // 
            // output_button
            // 
            this.output_button.Location = new System.Drawing.Point(537, 190);
            this.output_button.Name = "output_button";
            this.output_button.Size = new System.Drawing.Size(75, 23);
            this.output_button.TabIndex = 8;
            this.output_button.Text = "Вывод";
            this.output_button.UseVisualStyleBackColor = true;
            this.output_button.Click += new System.EventHandler(this.output_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(537, 248);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 9;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Location = new System.Drawing.Point(12, 104);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(0, 15);
            this.output_label.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 338);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.output_button);
            this.Controls.Add(this.input_button);
            this.Controls.Add(this.PrismsBox);
            this.Controls.Add(this.side_TB);
            this.Controls.Add(this.hight_TB);
            this.Controls.Add(this.object_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox object_TB;
        private System.Windows.Forms.TextBox hight_TB;
        private System.Windows.Forms.TextBox side_TB;
        private System.Windows.Forms.ListBox PrismsBox;
        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label output_label;
    }
}

