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
    public partial class Form2 : Form
    {
        internal static int X;
        internal static int Y;

        public Form2()
        {
            InitializeComponent();
        }

        internal void Error(bool statement)
        {
            if (statement)
                MessageBox.Show("Введите корректное значение!", "Ошибка!");

            else
                MessageBox.Show("Выберите объект!", "Ошибка!");
        }

        private void input_button_Click(object sender, EventArgs e)
        {
            try
            {
                X = Convert.ToInt32(xtb_1.Text);
                Y = Convert.ToInt32(ytb_1.Text);
                this.Close();
            }
            catch
            {
                Error(true);
            }
        }
    }
}
