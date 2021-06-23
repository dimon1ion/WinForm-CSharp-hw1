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
    public partial class Task5 : Form
    {
        Random rnd = new Random();
        public Task5()
        {
            InitializeComponent();
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
            button1.Top = rnd.Next(1, this.Height - button1.Height - 50);
            button1.Left = rnd.Next(1, this.Width - button1.Width - 40);
        }


        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

            if (button1.Width - 5 <= e.X)
            {
                button1.Left -= 30;
            }
            else if (button1.Height - 5 <= e.Y)
            {
                button1.Top -= 30;
            }
            else if (e.X <= 5)
            {
                button1.Left += 30;
            }
            else if (e.Y <= 5)
            {
                button1.Top += 30;
            }
            else
            {
                button1.Top = rnd.Next(1, this.Height - button1.Height - 50);
                button1.Left = rnd.Next(1, this.Width - button1.Width - 40);
            }

            if (button1.Left < 0 || button1.Top < 0 || button1.Left + button1.Width >= this.Width - 10 || button1.Top + button1.Height >= this.Height - 30)
            {
                button1.Top = rnd.Next(1, this.Height - button1.Height - 50);
                button1.Left = rnd.Next(1, this.Width - button1.Width - 40);
            }
        }

        private void Task5_Resize(object sender, EventArgs e)
        {
            if (button1.Left < 0 || button1.Top < 0 || button1.Left + button1.Width >= this.Width - 10 || button1.Top + button1.Height >= this.Height - 30)
            {
                button1.Top = rnd.Next(1, this.Height - button1.Height - 50);
                button1.Left = rnd.Next(1, this.Width - button1.Width - 40);
            }
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Task6 t6 = new Task6();
            this.Visible = false;
            t6.ShowDialog();
            this.Close();
        }
    }
}
