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
    public partial class Task7 : Form
    {
        public Task7()
        {
            InitializeComponent();
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void button1_Click(object sender, EventArgs e)
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
                    Timer t = new Timer();
                    DateTime date = new DateTime(year, month, day);
                    TimeSpan time = date.Subtract(DateTime.Now);

                    if (YearRadioButton.Checked)
                    {
                        textBox2.Text = Math.Abs((Convert.ToDouble(time.Days) / 365)).ToString() + " years";
                    }
                    else if (MonthRadioButton.Checked)
                    {
                        textBox2.Text = Math.Abs((Convert.ToDouble(time.Days) / 365 * 12)).ToString() + " months";
                    }
                    else if (DayRadioButton.Checked)
                    {
                        textBox2.Text = Math.Abs(time.Days).ToString() + " days";
                    }
                    else if (MinuteRadioButton.Checked)
                    {
                        textBox2.Text = Math.Abs((time.Days * 24 * 60 + (time.Hours * 60) + time.Minutes)).ToString() + " minutes";
                    }
                    else
                    {
                        textBox2.Text = Math.Abs((time.Days * 24 * 60 * 60 + (time.Hours * 60 * 60) + (time.Minutes * 60) + time.Seconds)).ToString() + " seconds";
                    }
                }
            }
        }


        private void Task7_Resize(object sender, EventArgs e)
        {
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            Task8 t8 = new Task8();
            this.Visible = false;
            t8.ShowDialog();
            this.Close();
        }
    }
}
