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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string summary = "Меня зовут Дмитрий. Мне 19 годиков. Я хороший человек(наверное). Я киберспортсмен, качок, ученый. У меня 100 миллионов подписчиков.";
            string[] sentences = summary.Split('.');
            int simbols = 0;
            for (int i = 0, j = 1; i < sentences.Length - 1; i++, j++)
            {
                simbols += sentences[i].Length;
                MessageBox.Show(sentences[i], (i == sentences.Length - 2 ? (simbols / j).ToString() : ""), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Task1_Resize(object sender, EventArgs e)
        {
            Next.Left = this.Width - Next.Width - 40;
            Next.Top = this.Height - Next.Height - 50;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Task2 t2 = new Task2();
            this.Visible = false;
            t2.ShowDialog();
            this.Close();
        }
    }
}
