using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7A
{
    public partial class Form2 : Form
    {
        internal static string NAME;
        public Form2()
        {
            InitializeComponent();
        }

        private void input_button_Click(object sender, EventArgs e)
        {
            NAME = Convert.ToString(input_box.Text);
            input_box.Clear();
            this.Close();
        }
    }
}
