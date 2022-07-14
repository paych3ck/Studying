using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5A
{
    public partial class Form1 : Form
    {
        private Point point = new Point();
        private RegularHexagon regularhexagon = new RegularHexagon();
        private RegularTriangle regulartriangle = new RegularTriangle();
        private Square square = new Square();

        private Point t = new Point();

        public Form1()
        {
            InitializeComponent();
        }

        private void point_button_Click(object sender, EventArgs e)
        {
            t = point;
            info_label.Text = t.Info();
        }

        private void square_button_Click(object sender, EventArgs e)
        {
            t = square;
            info_label.Text = t.Info();
        }

        private void regular_hexagon_Click(object sender, EventArgs e)
        {
            t = regularhexagon;
            info_label.Text = t.Info();
        }

        private void regular_triangle_Click(object sender, EventArgs e)
        {
            t = regulartriangle;
            info_label.Text = t.Info();
        }

        class Point
        {
            public double Area()
            {
                return 0;
            }

            public virtual double virtual_Area()
            {
                return 0;
            }

            public virtual string Info()
            {
                string[] s = this.ToString().Split("+");
                return s[1];
            }
        }

        class RegularHexagon : Point
        {
            private int side;

            public RegularHexagon()
            {
                side = 10;
            }

            public RegularHexagon(int side)
            {
                this.side = side;
            }

            public double Area()
            {
                return 6 * (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            }

            public override double virtual_Area()
            {
                return 6 * (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            }

            public double Perimeter()
            {
                return 6 * side;
            }

            public int Side
            {
                get { return side; }
                set { side = value; }
            }

            public override string Info()
            {
                string[] s = this.ToString().Split("+");
                return s[1] + ":\nДлина: " + Side + "\nПлощадь: " + Area() + "\nПериметр: " + Perimeter();
            }
        }

        class RegularTriangle : Point
        {
            private int side;

            public RegularTriangle()
            {
                side = 10;
            }

            public RegularTriangle(int side)
            {
                this.side = side;
            }

            public double Area()
            {
                return Math.Pow(side, 2) * Math.Sqrt(3) / 4;
            }

            public override double virtual_Area()
            {
                return Math.Pow(side, 2) * Math.Sqrt(3) / 4;
            }

            public double Perimeter()
            {
                return 3 * side;
            }

            public int Side
            {
                get { return side; }
                set { side = value; }
            }

            public override string Info()
            {
                string[] s = this.ToString().Split("+");
                return s[1] + ":\nДлина: " + Side + "\nПлощадь: " + Area() + "\nПериметр: " + Perimeter();
            }
        }

        class Square : Point
        {
            private int side;

            public Square()
            {
                side = 10;
            }

            public Square(int side)
            {
                this.side = side;
            }

            public double Area()
            {
                return side * side;
            }

            public override double virtual_Area()
            {
                return side * side;
            }

            public double Perimeter()
            {
                return 4 * side;
            }

            public double Diagonal()
            {
                return Math.Sqrt(2) * side;
            }

            public int Side
            {
                get { return side; }
                set { side = value; }
            }

            public override string Info()
            {
                string[] s = this.ToString().Split("+");
                return s[1] + ":\nСторона: " + Side + "\nДиагональ: " + Diagonal() + "\nПериметр: " + Perimeter() + "\nПлощадь: " + Area();
            }
        }

        private void diagonal_button_Click(object sender, EventArgs e)
        {
            if (t is Square)
            {
                info_label.Text += "\nДиагональ: " + square.Diagonal();
            }
            else
            {
                info_label.Text += "\nМетод для активного объекта не определен.";
            }
        }

        private void perimeter_button_Click(object sender, EventArgs e)
        {

            if (t is Square)
            {
                info_label.Text += "\nПериметр: " + square.Perimeter();
            }
            else if (t is RegularHexagon)
            {
                info_label.Text += "\nПериметр: " + regularhexagon.Perimeter();
            }
            else if (t is RegularTriangle)
            {
                info_label.Text += "\nПериметр: " + regulartriangle.Perimeter();
            }
            else
            {
                info_label.Text += "Метод для активного объекта не определен.";
            }
        }

        private void squarev_button_Click(object sender, EventArgs e)
        {
            info_label.Text += "\nПлощадь: " + t.virtual_Area();
        }

        private void squareo_button_Click(object sender, EventArgs e)
        {
            if (t is Square)
            {
                info_label.Text += "\nПлощадь: " + ((Square)t).Area();
            }
            else if (t is RegularHexagon)
            {
                info_label.Text += "\nПлощадь: " + ((RegularHexagon)t).Area();
            }
            else if (t is RegularTriangle)
            {
                info_label.Text += "\nПлощадь: " + ((RegularTriangle)t).Area();
            }
            else
            {
                info_label.Text += "\nПлощадь: " + t.Area();
            }
        }
    }
}
