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
    public partial class Task4 : Form
    {
        List<Button> buttons = new List<Button>();
        int[] arrX = new int[2];
        int[] arrY = new int[2];
        public Task4()
        {
            InitializeComponent();
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void Task4_MouseDown(object sender, MouseEventArgs e)
        {
            arrX[0] = e.X;
            arrY[0] = e.Y;
        }

        private void Task4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrX[1] = e.X;
                arrY[1] = e.Y;
                Array.Sort(arrX);
                Array.Sort(arrY);
                if (arrX[1] - arrX[0] > 10 && arrY[1] - arrY[0] > 10)
                {
                    buttons.Add(new Button());
                    buttons.ElementAt(buttons.Count - 1).Name = "mybutton";
                    buttons.ElementAt(buttons.Count - 1).Text = "";
                    buttons.ElementAt(buttons.Count - 1).Location = new System.Drawing.Point(arrX[0], arrY[0]);
                    buttons.ElementAt(buttons.Count - 1).Size = new System.Drawing.Size(arrX[1] - arrX[0], arrY[1] - arrY[0]);
                    this.Controls.Add(buttons.ElementAt(buttons.Count - 1));
                }
                else if (arrX[1] - arrX[0] != 0 && arrY[1] - arrY[0] != 0)
                {
                    MessageBox.Show("Too small size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Task4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = buttons.Count - 1; i >= 0; i--)
                {
                    if (buttons.ElementAt(i).Location.X <= e.X && e.X <= buttons.ElementAt(i).Size.Width + buttons.ElementAt(i).Location.X && e.Y < buttons.ElementAt(i).Location.Y)
                    {
                        MessageBox.Show($"X = {buttons.ElementAt(i).Location.X}; Y = {buttons.ElementAt(i).Location.Y}" +
                            $"\nS = {buttons.ElementAt(i).Size.Height * buttons.ElementAt(i).Size.Width}");
                        break;
                    }
                }
            }
        }

        private void Task4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Button button in buttons)
                {
                    if (button.Location.X <= e.X && e.X <= button.Size.Width + button.Location.X && e.Y < button.Location.Y)
                    {
                        this.Controls.Remove(button);
                        buttons.Remove(button);
                        break;
                    }
                }
            }
        }

        private void Task4_Resize(object sender, EventArgs e)
        {
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Task5 t5 = new Task5();
            this.Visible = false;
            t5.ShowDialog();
            this.Close();
        }
    }
}
