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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void Task3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Form.ModifierKeys == Keys.Control)
                {
                    this.Close();
                    return;
                }
                if (e.X < 10 || e.Y < 10 || e.Y > this.Height - 50 || e.X > this.Width - 30)
                {
                    MessageBox.Show("The current point is outside the rectangle");
                }
                else if (e.X == 10 || e.Y == 10 || e.Y == this.Height - 50 || e.X == this.Width - 30)
                {
                    MessageBox.Show("The current point is on the border of the rectangle");
                }
                else
                {
                    MessageBox.Show("The current point is inside the rectangle");
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show($"X = {e.X}; Y = {e.Y}");
            }
        }

        private void Task3_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Task 3: X = {Form.MousePosition.X}; Y = {Form.MousePosition.Y}";
        }

        private void Task3_Resize(object sender, EventArgs e)
        {
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Task4 t4 = new Task4();
            this.Visible = false;
            t4.ShowDialog();
            this.Close();
        }
    }
}
