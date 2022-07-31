using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//4v 3v

namespace LAB7A
{
    public partial class Form1 : Form
    {
        private CircularList cl1 = new CircularList();
        private Form2 f2 = new Form2();
        private static Font font = new Font("Arial", 10);
        public Form1()
        {
            InitializeComponent();
        }

        public class Object
        {
            public string name;

            public Object(string name)
            {
                this.name = name;
            }

            public string getName()
            {
                return name.ToString();
            }
        }

        public class CircularList
        {
            private List<Object> List = new List<Object>();
            private Graphics graphics;
            private int position = -1;

            public void Add(Object v)
            {
                List.Insert(++position, v);
                Draw();
            }

            public void Delete()
            {
                if (Count < 1)
                {
                    return;
                }

                List.RemoveAt(position);

                if (position > 0)
                {
                    position--;
                }

                if (Count < 1)
                {
                    position = -1;
                }

                Draw();
            }

            public void Clear()
            {
                List.Clear();
                position = -1;
            }

            public int Count
            {
                get { return List.Count; }
            }

            public void Next()
            {
                if (position + 1 < Count)
                {
                    ++position;
                    Draw();
                }
                else
                {
                    position = 0;
                    Draw();
                }    
            }

            public void Previous()
            {
                if (position > 0)
                {
                    --position;
                    Draw();
                }
                else
                {
                    position = Count - 1;
                    Draw();
                }
            }

            public void setGraphics(Graphics grphcs)
            {
                graphics = grphcs;
            }

            public void Draw()
            {
                Size size = TextRenderer.MeasureText(Form2.NAME, font);
                graphics.Clear(Color.White);

                if (Count < 1)
                {
                    return;
                }

                graphics.FillRectangle(new SolidBrush(Color.LightGray), (position + 1) * size.Width, 50, size.Width, 20);
                Pen pen = new Pen(Color.Blue);

                for (int i = 0; i < Count; i++)
                {
                    graphics.DrawString(List[i].getName(), font, new SolidBrush(Color.Black), (i + 1) * size.Width + 3, 52);
                    graphics.DrawRectangle(pen, (i + 1) * size.Width, 50, size.Width, 20);
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(bmp);
            f2.ShowDialog();
            Object obj = new Object(Form2.NAME);
            cl1.setGraphics(g);
            cl1.Add(obj);
            panel1.BackgroundImage = bmp;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(bmp);
            cl1.setGraphics(g);
            cl1.Delete();
            panel1.BackgroundImage = bmp;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(bmp);
            cl1.setGraphics(g);
            cl1.Next();
            panel1.BackgroundImage = bmp;
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(bmp);
            cl1.setGraphics(g);
            cl1.Previous();
            panel1.BackgroundImage = bmp;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(bmp);
            cl1.setGraphics(g);
            cl1.Clear();
            panel1.BackgroundImage = bmp;
        }
    }
}
