using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB9A
{
    public partial class Form1 : Form
    {
        private BmwLogo bmwLogo = new BmwLogo();
        public static Bitmap bmp;
        public static Bitmap bmp1;
        public static Graphics g;
        public static Graphics gg;
        private Draw draw;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            gg = Graphics.FromImage(bmp1);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(0, 0);
        }
        public class BmwLogo
        {
            private Graphics g = Form1.g;
            private static Graphics gg = Form1.gg;
            private static BmwLogo bmwLogo = new BmwLogo();
            public void VoDraw()
            {
                bmwLogo = this;
                this.g = Form1.g;
                g.DrawEllipse(new Pen(Color.White, 8), 250, 270, 360, 360);
            }

            public static void VnDraw()
            {
                gg = Form1.gg;
                gg.DrawEllipse(new Pen(Color.Black, 80), 290, 310, 280, 280);
            }
        }

        public void DrawText()
        {
            Font font = new Font("Arial", 35, FontStyle.Bold);
            g.RotateTransform(-15.0F);
            g.DrawString("B", font, new SolidBrush(Color.White), 260, 390);
            g.RotateTransform(15.0F);
            g.DrawString("M", font, new SolidBrush(Color.White), 400, 300);
            g.RotateTransform(15.0F);
            g.DrawString("W", font, new SolidBrush(Color.White), 515, 170);
            g.RotateTransform(-15.0F);
        }

        public static void DrawCenter()
        {
            g.DrawArc(new Pen(Color.White, 110), 370, 400, 115, 100, 90, 90);
            g.DrawArc(new Pen(Color.White, 110), 370, 400, 115, 100, 270, 90);

            g.DrawArc(new Pen(Color.Blue, 110), 370, 400, 115, 100, 180, 90);
            g.DrawArc(new Pen(Color.Blue, 110), 370, 400, 115, 100, 0, 90);
        }

        delegate void Draw();

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Transparent);
            gg.Clear(Color.Transparent);
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            if (draw != null) draw();
            pictureBox2.Image = bmp;
            pictureBox1.Image = bmp1;
        }

        private void VnBox_CheckedChanged(object sender, EventArgs e)
        {
            if (VnBox.Checked) 
                draw += BmwLogo.VnDraw;

            else 
                draw -= BmwLogo.VnDraw;
        }

        private void VoBox_CheckedChanged(object sender, EventArgs e)
        {
            if (VoBox.Checked) 
                draw += bmwLogo.VoDraw;

            else
                draw -= bmwLogo.VoDraw;
        }

        private void CntrBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CntrBox.Checked)
                draw += DrawCenter;

            else 
                draw -= DrawCenter;
        }

        private void TxtBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtBox.Checked)
                draw += DrawText;

            else
                draw -= DrawText;
        }
    }
}
