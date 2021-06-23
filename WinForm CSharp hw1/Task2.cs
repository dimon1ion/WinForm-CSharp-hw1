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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max, min, num, requests;
            bool guess;
            while (true)
            {
                DialogResult dialogResult = MessageBox.Show("Guess a number from 1 to 2000", "Game Guess the number!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No) { break; }
                max = 2000;
                min = 1;
                num = (max + min) / 2;
                guess = false;
                requests = 0;
                for (; min < max; requests++)
                {
                    dialogResult = MessageBox.Show($"Is your number {num}?", "Game Guess the number 1 to 2000!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) { guess = true; break; }
                    dialogResult = MessageBox.Show($"Is your number greater than {num}?", "Game Guess the number 1 to 2000!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        min = num;
                    }
                    else
                    {
                        max = num;
                    }
                    num = (max + min) / 2;
                }
                if (guess)
                {
                    dialogResult = MessageBox.Show($"Your number is {num}!\nRequests: {requests}\nDo you want to play again?", "Game Guess the number!", MessageBoxButtons.YesNo);
                }
                else
                {
                    dialogResult = MessageBox.Show("Is it joke?)\nDo you want to play again?", "Game Guess the number!", MessageBoxButtons.YesNo);
                }
                if (dialogResult == DialogResult.No) { break; }
            }
            MessageBox.Show("Thanks for playing!");
        }

        private void Task2_Resize(object sender, EventArgs e)
        {
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Task3 t3 = new Task3();
            this.Visible = false;
            t3.ShowDialog();
            this.Close();
        }
    }
}
