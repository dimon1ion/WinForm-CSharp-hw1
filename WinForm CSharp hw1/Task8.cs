using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm_CSharp_hw1
{
    public partial class Task8 : Form
    {
        float[] arrCostCafeFood;
        Timer timer = new Timer();
        double TodayWork;
        public Task8()
        {
            InitializeComponent();
            arrCostCafeFood = new float[4];
            for (int i = 0; i < arrCostCafeFood.Length; i++)
            {
                arrCostCafeFood[i] = 0f;
            }
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            TodayWork = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "АИ-98")
            {
                CostOilTextBox.Text = "4,44";
            }
            else if (comboBox1.Text == "Diesel")
            {
                CostOilTextBox.Text = "2,22";
            }
            else if (comboBox1.Text == "АИ-95")
            {
                CostOilTextBox.Text = "6,66";
            }
            if (radioButton1.Checked)
            {
                radioButton1_CheckedChanged(sender, e);
            }
            else
            {
                radioButton2_CheckedChanged(sender, e);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                textBox2.Enabled = !textBox2.Enabled;
            }
            if (radioButton1.Checked)
            {
                groupBox3.Text = "К оплате";
                rubSumOilLabel.Text = "руб.";
                if (CostOilTextBox.Text != String.Empty)
                {
                    float liters;
                    if (Single.TryParse(textBox2.Text, out liters))
                    {
                        SumOil.Text = (liters * Single.Parse(CostOilTextBox.Text)).ToString();
                    }
                }
            }
            else
            {
                SumOil.Text = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                textBox3.Enabled = !textBox3.Enabled;
            }
            if (radioButton2.Checked)
            {
                groupBox3.Text = "К выдаче";
                rubSumOilLabel.Text = "л.";
                if (CostOilTextBox.Text != String.Empty)
                {
                    float cost;
                    if (Single.TryParse(textBox3.Text, out cost))
                    {
                        SumOil.Text = (cost / Single.Parse(CostOilTextBox.Text)).ToString();
                    }

                }
            }
            else
            {
                SumOil.Text = "0";
            }
        }

        private void Change_SumFoodTextBox()
        {
            SumFoodTextBox.Text = arrCostCafeFood.Sum().ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CountHot_DogTextBox.Enabled = !CountHot_DogTextBox.Enabled;
            }
            if (CountHot_DogTextBox.Enabled)
            {
                float count;
                if (Single.TryParse(CountHot_DogTextBox.Text, out count))
                {
                    arrCostCafeFood[0] = count * Single.Parse(CostHot_DogTextBox.Text);
                }
            }
            else
            {
                arrCostCafeFood[0] = 0f;
            }
            Change_SumFoodTextBox();
        }

        private void HamburgerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CountHamburgerTextBox.Enabled = !CountHamburgerTextBox.Enabled;
            }
            if (CountHamburgerTextBox.Enabled)
            {
                float count;
                if (Single.TryParse(CountHamburgerTextBox.Text, out count))
                {
                    arrCostCafeFood[1] = count * Single.Parse(CostHamburgerTextBox.Text);
                }
            }
            else
            {
                arrCostCafeFood[1] = 0f;
            }
            Change_SumFoodTextBox();
        }

        private void PotatoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CountPotatoTextBox.Enabled = !CountPotatoTextBox.Enabled;
            }
            if (CountPotatoTextBox.Enabled)
            {
                float count;
                if (Single.TryParse(CountPotatoTextBox.Text, out count))
                {
                    arrCostCafeFood[2] = count * Single.Parse(CostPotatoTextBox.Text);
                }
            }
            else
            {
                arrCostCafeFood[2] = 0f;
            }
            Change_SumFoodTextBox();
        }

        private void CocaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CountCocaTextBox.Enabled = !CountCocaTextBox.Enabled;
            }
            if (CountCocaTextBox.Enabled)
            {
                float count;
                if (Single.TryParse(CountCocaTextBox.Text, out count))
                {
                    arrCostCafeFood[3] = count * Single.Parse(CostCocaTextBox.Text);
                }
            }
            else
            {
                arrCostCafeFood[3] = 0f;
            }
            Change_SumFoodTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                SumAllTextBox.Text = (Single.Parse(textBox3.Text) + Single.Parse(SumFoodTextBox.Text)).ToString();
            }
            else
            {
                SumAllTextBox.Text = (Single.Parse(SumOil.Text) + Single.Parse(SumFoodTextBox.Text)).ToString();
            }
            TodayWork += Double.Parse(SumAllTextBox.Text);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();
            DialogResult dialogResult = MessageBox.Show("Появился следующий покупатель?", "Запрос на очистку", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                comboBox1.SelectedItem = null;
                CostOilTextBox.Text = String.Empty;

                radioButton1.Checked = true;
                textBox2.Text = String.Empty;
                textBox2.Enabled = true;

                radioButton2.Checked = false;
                textBox3.Text = String.Empty;
                textBox3.Enabled = false;

                groupBox3.Text = "К оплате";
                SumOil.Text = "0";
                rubSumOilLabel.Text = "руб.";

                Hot_DogCheckBox.Checked = false;
                HamburgerCheckBox.Checked = false;
                PotatoCheckBox.Checked = false;
                CocaCheckBox.Checked = false;

                CountHot_DogTextBox.Text = String.Empty;
                CountHamburgerTextBox.Text = String.Empty;
                CountPotatoTextBox.Text = String.Empty;
                CountCocaTextBox.Text = String.Empty;

                CountHot_DogTextBox.Enabled = false;
                CountHamburgerTextBox.Enabled = false;
                CountPotatoTextBox.Enabled = false;
                CountCocaTextBox.Enabled = false;

                SumFoodTextBox.Text = "0";

                SumAllTextBox.Text = "0";
            }
            else
            {
                (sender as Timer).Start();
            }
        }

        private void Task8_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Общая сумма выручки: {TodayWork} рублей");
        }
    }
}
