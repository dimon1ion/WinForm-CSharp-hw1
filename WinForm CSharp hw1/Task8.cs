using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CSharp_hw1
{
    public partial class Task8 : Form
    {
        public Task8()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "АИ-98")
            {
                textBox1.Text = "4.44";
            }
            else if(comboBox1.Text == "Diesel")
            {
                textBox1.Text = "2.22";
            }
            else if (comboBox1.Text == "АИ-95")
            {
                textBox1.Text = "6.66";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = !textBox2.Enabled;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = !textBox3.Enabled;
        }
    }
}
