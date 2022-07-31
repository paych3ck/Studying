using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6A
{
    public partial class Form1 : Form
    {
        private Form2 f2 = new Form2();
        private Figure fr;
        private Pen pen;
        private Bitmap bmp;
        private Graphics g;
        private int xl;
        private int yl;

        public Form1()
        {
            InitializeComponent();
            GraphIn();
        }

        public abstract class Figure
        {
            public abstract Bitmap Draw(Pen pen, Bitmap bmp, Graphics g, int xl, int yl);
        }

        public class Rect : Figure
        {
            private int x;
            private int y;

            public Rect(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public Rect()
            {
                x = 0;
                y = 0;
            }

            public int X
            {
                get => x;
                set => x = value;
            }

            public int Y
            {
                get => y;
                set => y = value;
            }

            public override Bitmap Draw(Pen pen, Bitmap bmp, Graphics g, int xl, int yl)
            {
                g.DrawLine(pen, xl, yl, x + xl, yl);
                g.DrawLine(pen, xl, y + yl, xl, yl);
                g.DrawLine(pen, x + xl, yl, x + xl, y + yl);
                g.DrawLine(pen, xl, y + yl, x + xl, y + yl);
                return bmp;
            }
        }

        public class Rhomb : Figure
        {
            private int x;
            private int y;

            public Rhomb(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public Rhomb()
            {
                x = 0;
                y = 0;
            }

            public int X
            {
                get => x;
                set => x = value;
            }

            public int Y
            {
                get => y;
                set => y = value;
            }

            public override Bitmap Draw(Pen pen, Bitmap bmp, Graphics g, int xl, int yl)
            {
                g.DrawLine(pen, xl, yl - y, x + xl, yl);
                g.DrawLine(pen, xl, yl - y, xl - x, yl);
                g.DrawLine(pen, x + xl, yl, xl, y + yl);
                g.DrawLine(pen, xl, y + yl, xl - x, yl);
                return bmp;
            }
        }

        public void GraphIn()
        {
            pen = new Pen(Color.Crimson, 2.0F);
            bmp = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bmp);
        }

        private void rectangle_button_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            g.Clear(Color.LightYellow);
            f2.ShowDialog();
            int x = Form2.X;
            int y = Form2.Y;
            Rect rct = new Rect(x, y);
            fr = rct;
        }

        private void rhomb_button_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            g.Clear(Color.LightYellow);
            f2.ShowDialog();
            int x = Form2.X;
            int y = Form2.Y;
            Rhomb rhmb = new Rhomb(x, y);
            fr = rhmb;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            try
            {
                //xl = Convert.ToInt32(x_tb.Text);
                //yl = Convert.ToInt32(y_tb.Text);
                //panel1.BackgroundImage = fr.Draw(pen, bmp, g, xl, yl);
            }

            catch
            {
                f2.Error(true);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            xl = e.X;
            yl = e.Y;
            panel1.BackgroundImage = fr.Draw(pen, bmp, g, xl, yl);
        }
    }
}
