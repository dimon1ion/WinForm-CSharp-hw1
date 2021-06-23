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
    public partial class Task6 : Form
    {
        public Task6()
        {
            InitializeComponent();
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void Task6_Resize(object sender, EventArgs e)
        {
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            string[] arrStr = textBox1.Text.Split('.');
            int day, month, year;
            if (arrStr.Length == 3)
            {
                if (Int32.TryParse(arrStr[0], out day) && Int32.TryParse(arrStr[1], out month) && Int32.TryParse(arrStr[2], out year))
                {
                    if (1 <= month && month <= 12)
                    {
                        if (!(0 < day && day <= DateTime.DaysInMonth(year, month)))
                        {
                            MessageBox.Show($"This month is {DateTime.DaysInMonth(year, month)} days", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wow, a total of 12 months a year", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DateTime date = new DateTime(year, month, day);
                    textBox2.Text = date.DayOfWeek.ToString();
                }
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Task7 t7 = new Task7();
            this.Visible = false;
            t7.ShowDialog();
            this.Close();
        }
    }
}
