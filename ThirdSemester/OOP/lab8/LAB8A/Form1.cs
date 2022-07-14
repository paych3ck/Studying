using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8A
{
    public partial class Form1 : Form
    {
        bool left = true;
        Vector vect_l;
        Vector vect_r;
        private int size = 0;
        private int size2 = 0;

        private void LBox()
        {
            if (listBox1.SelectedIndex != -1)
            {
                string str = "Объект " + size + ": " + VcList.VectList[VcList.p].ListBoxInfo().ToString();
                listBox1.Items.Insert(listBox1.SelectedIndex + 1, str);
                size++;
            }
            else
            {
                string str = "Объект " + size + ": " + VcList.VectList[VcList.p].ListBoxInfo().ToString();
                listBox1.Items.Insert(size, str);
                size++;
            }
        }

        private void LBox2(Vector vec)
        {

            string str = "Объект " + size2 + ": " + vec.ListBoxInfo().ToString();
            listBox2.Items.Add(str);
            size2++;
        }

        public static void Error(bool isValues)
        {
            if (isValues)
                MessageBox.Show("Введите другое значение");

            else
                MessageBox.Show("Выберите объект");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            VcList.Clear();
            size = 0;
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            label5.Text = "Произведение: " + Convert.ToString(vect_l * vect_r);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBox1.Text);
            label5.Text = Convert.ToString(vect_l * k);
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            label5.Text = (vect_l - 1).getInfo();
            LBox2(vect_l - 1);
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            if (vect_l == vect_r) label5.Text = "Вектора равны";
            else label5.Text = "Вектора не равны";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Vector vct = new Vector(Convert.ToInt32(xTextBox.Text), Convert.ToInt32(yTextBox.Text), Convert.ToInt32(zTextBox.Text));
                VcList.Add(vct);
                LBox();
            }
            catch
            {
                Error(true);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (left)
            {
                label1.Text = "Объект " + listBox1.SelectedIndex + ":\n" + VcList.VectList[listBox1.SelectedIndex].getInfo();
                vect_l = VcList.VectList[listBox1.SelectedIndex];
                left = false;
            }
            else
            {
                label2.Text = "Объект " + listBox1.SelectedIndex + ":\n" + VcList.VectList[listBox1.SelectedIndex].getInfo();
                vect_r = VcList.VectList[listBox1.SelectedIndex];
                left = true;
            }
        }
    }

    public class VcList
    {
        public static List<Vector> VectList = new List<Vector>();
        public static int p = -1;

        public static void Add(Vector v)
        {
            VectList.Insert(++p, v);
        }

        public static void Clear()
        {
            VectList.Clear();
            p = -1;
        }

        public static int Count
        {
            get { return VectList.Count; }
        }
    }

    public class Vector
    {
        int x { get; set; }
        int y { get; set; }
        int z { get; set; }

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public string ListBoxInfo()
        {
            return "\nx: " + x + " \ny: " + y + " \nz: " + z;
        }

        public string getInfo()
        {
            return "\nx: " + x + " \ny: " + y + " \nz: " + z;
        }

        public static int operator *(Vector vect1, Vector vect2)
        {
            int mltpl = vect1.x * vect2.x + vect1.y * vect2.y + vect1.z * vect2.z;
            return mltpl;
        }

        public static int operator *(Vector vect1, int k)
        {
            int _x = vect1.x * k;
            int _y = vect1.y * k;
            int _z = vect1.z * k;
            int summ = _x + _y + _z;
            return summ;
        }

        public static Vector operator -(Vector vect1, int one)
        {
            return new Vector(vect1.x - one, vect1.y - one, vect1.z - one);
        }

        public static bool operator ==(Vector vect1, Vector vect2)
        {
            return vect1.x == vect2.x && vect1.y == vect2.y && vect1.z == vect2.z;
        }
        public static bool operator !=(Vector vect1, Vector vect2)
        {
            return vect1.x != vect2.x && vect1.y != vect2.y && vect1.z != vect2.z;
        }

    }
}
