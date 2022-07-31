using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4A
{
    public partial class Form1 : Form
    {
        static int objectIndex;
        static int N = 14;
        Prism[,] prisms = new Prism[N];

        void InitArray()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; i++)
                    prisms[i] = new Prism(0, 0);
            }
        }
        public Form1()
        {
            InitializeComponent();
            InitArray();
        }

        public static void Error(bool statement)
        {
            if (statement)
            {
                MessageBox.Show("Введите корректное значение!", "Ошибка!");
            }
            else
            {
                MessageBox.Show("Объект не выбран!", "Внимание!");
            }
        }

        class Prism
        {
            private int hight;
            private int side;

            public Prism()
            {
                this.hight = 0;
                this.side = 5;
            }

            public Prism(int hight, int side)
            {
                this.hight = hight;
                this.side = side;

                if(side < 5)
                {
                    this.side = 5;
                }

                if(side > 19)
                {
                    this.side = 19;
                }

                if(side < 0)
                {
                    Error(true);
                }

                if (hight < 0)
                {
                    Error(true);
                }
            }

            private int Area()
            {
                return 9 * hight * side;
            }

            private double Volume()
            {
                return Math.Sqrt(3) / 4 * Math.Pow(side, 2) * hight;
            }

            public int Side
            {
                get { return side; }
                set
                {
                    if(side < 5)
                    {
                        side = 5;
                    }

                    if(side > 19)
                    {
                        side = 19;
                    }
                }
            }

            public int Hight
            {
                get { return hight; }
                set { hight = value; }
            }

            public int ObjectIndex
            {
                get { return objectIndex; }
                set { objectIndex = value; }
            }

            public String Info()
            {
                return "Призма №" + objectIndex + " - сторона: " + side + ", высота: " + hight + ", площадь: " + Area() + ", объем: " + Volume();
            }
        }

        private void input_button_Click(object sender, EventArgs e)
        {
            try
            {
                int _hight = Convert.ToInt32(hight_TB.Text);
                int _side = Convert.ToInt32(side_TB.Text);
                objectIndex = Convert.ToInt32(object_TB.Text);

                if (objectIndex > 0 && objectIndex < N && _hight > 0 && _side > 0)
                {
                    prisms[objectIndex - 1] = new Prism(_hight, _side);
                    output_label.Text = "Значения объекта №" + objectIndex + " введены.";
                }

                else
                {
                    Error(true);
                }
            }
            catch
            {
                Error(true);
            }
        }

        private void output_button_Click(object sender, EventArgs e)
        {
            PrismsBox.Items.Clear();

            objectIndex = 0;

            for (int i = 0; i < N; i++)
            {
                objectIndex += 1;
                String prism_info = prisms[i].Info();
                PrismsBox.Items.Add(prism_info);
            }

            objectIndex = 0;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            PrismsBox.Items.Clear();
        }
    }
}