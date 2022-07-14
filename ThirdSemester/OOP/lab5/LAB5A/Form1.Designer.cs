
namespace LAB5A
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
            System.Windows.Forms.Button regular_hexagon;
            this.point_button = new System.Windows.Forms.Button();
            this.regular_triangle = new System.Windows.Forms.Button();
            this.square_button = new System.Windows.Forms.Button();
            this.info_label = new System.Windows.Forms.Label();
            this.squareo_button = new System.Windows.Forms.Button();
            this.squarev_button = new System.Windows.Forms.Button();
            this.diagonal_button = new System.Windows.Forms.Button();
            this.perimeter_button = new System.Windows.Forms.Button();
            regular_hexagon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regular_hexagon
            // 
            regular_hexagon.Location = new System.Drawing.Point(233, 173);
            regular_hexagon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            regular_hexagon.Name = "regular_hexagon";
            regular_hexagon.Size = new System.Drawing.Size(261, 38);
            regular_hexagon.TabIndex = 1;
            regular_hexagon.Text = "Правильный шестиугольник";
            regular_hexagon.UseVisualStyleBackColor = true;
            regular_hexagon.Click += new System.EventHandler(this.regular_hexagon_Click);
            // 
            // point_button
            // 
            this.point_button.Location = new System.Drawing.Point(61, 173);
            this.point_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.point_button.Name = "point_button";
            this.point_button.Size = new System.Drawing.Size(116, 38);
            this.point_button.TabIndex = 0;
            this.point_button.Text = "Точка";
            this.point_button.UseVisualStyleBackColor = true;
            this.point_button.Click += new System.EventHandler(this.point_button_Click);
            // 
            // regular_triangle
            // 
            this.regular_triangle.Location = new System.Drawing.Point(233, 247);
            this.regular_triangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.regular_triangle.Name = "regular_triangle";
            this.regular_triangle.Size = new System.Drawing.Size(261, 38);
            this.regular_triangle.TabIndex = 2;
            this.regular_triangle.Text = "Правильный треугольник";
            this.regular_triangle.UseVisualStyleBackColor = true;
            this.regular_triangle.Click += new System.EventHandler(this.regular_triangle_Click);
            // 
            // square_button
            // 
            this.square_button.Location = new System.Drawing.Point(61, 247);
            this.square_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.square_button.Name = "square_button";
            this.square_button.Size = new System.Drawing.Size(116, 37);
            this.square_button.TabIndex = 3;
            this.square_button.Text = "Квадрат";
            this.square_button.UseVisualStyleBackColor = true;
            this.square_button.Click += new System.EventHandler(this.square_button_Click);
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(61, 353);
            this.info_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(19, 25);
            this.info_label.TabIndex = 4;
            this.info_label.Text = "-";
            // 
            // squareo_button
            // 
            this.squareo_button.Location = new System.Drawing.Point(654, 173);
            this.squareo_button.Name = "squareo_button";
            this.squareo_button.Size = new System.Drawing.Size(145, 38);
            this.squareo_button.TabIndex = 5;
            this.squareo_button.Text = "Площадь_О";
            this.squareo_button.UseVisualStyleBackColor = true;
            this.squareo_button.Click += new System.EventHandler(this.squareo_button_Click);
            // 
            // squarev_button
            // 
            this.squarev_button.Location = new System.Drawing.Point(892, 173);
            this.squarev_button.Name = "squarev_button";
            this.squarev_button.Size = new System.Drawing.Size(145, 38);
            this.squarev_button.TabIndex = 6;
            this.squarev_button.Text = "Площадь_В";
            this.squarev_button.UseVisualStyleBackColor = true;
            this.squarev_button.Click += new System.EventHandler(this.squarev_button_Click);
            // 
            // diagonal_button
            // 
            this.diagonal_button.Location = new System.Drawing.Point(654, 247);
            this.diagonal_button.Name = "diagonal_button";
            this.diagonal_button.Size = new System.Drawing.Size(145, 38);
            this.diagonal_button.TabIndex = 7;
            this.diagonal_button.Text = "Диагональ";
            this.diagonal_button.UseVisualStyleBackColor = true;
            this.diagonal_button.Click += new System.EventHandler(this.diagonal_button_Click);
            // 
            // perimeter_button
            // 
            this.perimeter_button.Location = new System.Drawing.Point(892, 247);
            this.perimeter_button.Name = "perimeter_button";
            this.perimeter_button.Size = new System.Drawing.Size(145, 38);
            this.perimeter_button.TabIndex = 8;
            this.perimeter_button.Text = "Периметр";
            this.perimeter_button.UseVisualStyleBackColor = true;
            this.perimeter_button.Click += new System.EventHandler(this.perimeter_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 557);
            this.Controls.Add(this.perimeter_button);
            this.Controls.Add(this.diagonal_button);
            this.Controls.Add(this.squarev_button);
            this.Controls.Add(this.squareo_button);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.square_button);
            this.Controls.Add(this.regular_triangle);
            this.Controls.Add(regular_hexagon);
            this.Controls.Add(this.point_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button point_button;
        private System.Windows.Forms.Button regular_hexagon;
        private System.Windows.Forms.Button regular_triangle;
        private System.Windows.Forms.Button square_button;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Button squareo_button;
        private System.Windows.Forms.Button squarev_button;
        private System.Windows.Forms.Button diagonal_button;
        private System.Windows.Forms.Button perimeter_button;
    }
}

