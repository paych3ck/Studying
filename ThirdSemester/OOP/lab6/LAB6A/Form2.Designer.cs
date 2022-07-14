
namespace LAB6A
{
    partial class Form2
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
            this.input_button = new System.Windows.Forms.Button();
            this.xtb_1 = new System.Windows.Forms.TextBox();
            this.ytb_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_button
            // 
            this.input_button.Location = new System.Drawing.Point(119, 116);
            this.input_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(112, 91);
            this.input_button.TabIndex = 0;
            this.input_button.Text = "Ввод размеров";
            this.input_button.UseVisualStyleBackColor = true;
            this.input_button.Click += new System.EventHandler(this.input_button_Click);
            // 
            // xtb_1
            // 
            this.xtb_1.Location = new System.Drawing.Point(304, 116);
            this.xtb_1.Name = "xtb_1";
            this.xtb_1.Size = new System.Drawing.Size(100, 26);
            this.xtb_1.TabIndex = 1;
            // 
            // ytb_1
            // 
            this.ytb_1.Location = new System.Drawing.Point(304, 181);
            this.ytb_1.Name = "ytb_1";
            this.ytb_1.Size = new System.Drawing.Size(100, 26);
            this.ytb_1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 311);
            this.Controls.Add(this.ytb_1);
            this.Controls.Add(this.xtb_1);
            this.Controls.Add(this.input_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.TextBox xtb_1;
        private System.Windows.Forms.TextBox ytb_1;
    }
}