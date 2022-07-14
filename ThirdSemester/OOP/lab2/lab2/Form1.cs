using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2A
{
    public partial class Form1 : Form
    {
        static int isChecked;
        Prism prism1 = new Prism();
        Prism prism2 = new Prism();
        Prism prism3 = new Prism();
        Prism prism4 = new Prism();
        Prism prism = new Prism();

        public Form1()
        {
            InitializeComponent();
        }

        public static void Error(bool isValues)
        {
            if (isValues)
            {
                MessageBox.Show("Введите корректное значение!", "Ошибка!");
            }
            else
            {
                MessageBox.Show("Объект не выбран!", "Внимание!");
            }
        }

        void RadioButtonCheck()
        {
            switch (isChecked)
            {
                case 1:
                    prism1 = prism;
                    prism1.IsChecked = isChecked;
                    output_label.Text = "Значения первого объекта\nвведены.";
                    break;

                case 2:
                    prism2 = prism;
                    prism2.IsChecked = isChecked;
                    output_label.Text = "Значения второго объекта\nвведены.";
                    break;

                case 3:
                    prism3 = prism;
                    prism3.IsChecked = isChecked;
                    output_label.Text = "Значения третьего объекта\nвведены.";
                    break;

                case 4:
                    prism4 = prism;
                    prism4.IsChecked = isChecked;
                    output_label.Text = "Значения четвертого объекта\nвведены.";
                    break;

                default:
                    Error(false);
                    break;
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

                if (side < 5)
                {
                    this.side = 5;
                }

                if (side > 19)
                {
                    this.side = 19;
                }

                if (side < 0)
                {
                    Form1.Error(true);
                }

                if (hight < 0)
                {
                    Form1.Error(true);
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
                    if (side < 4)
                    {
                        side = 4;
                    }

                    if (side > 20)
                    {
                        side = 20;
                    }
                }
            }

            public int Hight
            {
                get { return hight; }
                set { hight = value; }
            }

            public int IsChecked
            {
                get { return isChecked; }
                set { isChecked = value; }
            }

            public String Info()
            {
                return "Сторона: " + side + "\nВысота: " + hight + "\nПлощадь: " + Area() + "\nОбъем: " + Volume();
            }
        }

        private void obj1RB_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = 1;
        }

        private void obj2RB_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = 2;
        }

        private void obj3RB_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = 3;
        }

        private void obj4RB_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = 4;
        }

        private void input_button_Click(object sender, EventArgs e)
        {
            try
            {
                int _hight = Convert.ToInt32(hightTextBox.Text);
                int _side = Convert.ToInt32(sideTextBox.Text);

                prism = new Prism(_hight, _side);

                if (_hight > 0 && _side > 0)
                {
                    RadioButtonCheck();
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

        private void result_label_Click(object sender, EventArgs e)
        {
            switch (isChecked)
            {
                case 1:
                    output_label.Text = prism1.Info();
                    break;

                case 2:
                    output_label.Text = prism2.Info();
                    break;

                case 3:
                    output_label.Text = prism3.Info();
                    break;

                case 4:
                    output_label.Text = prism4.Info();
                    break;

                default:
                    Error(false);
                    break;
            }
        }
    }
}
