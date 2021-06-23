
namespace WinForm_CSharp_hw1
{
    partial class Task7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.YearRadioButton = new System.Windows.Forms.RadioButton();
            this.MonthRadioButton = new System.Windows.Forms.RadioButton();
            this.DayRadioButton = new System.Windows.Forms.RadioButton();
            this.SecondRadioButton = new System.Windows.Forms.RadioButton();
            this.MinuteRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Math";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YearRadioButton
            // 
            this.YearRadioButton.AutoSize = true;
            this.YearRadioButton.Checked = true;
            this.YearRadioButton.Location = new System.Drawing.Point(16, 12);
            this.YearRadioButton.Name = "YearRadioButton";
            this.YearRadioButton.Size = new System.Drawing.Size(47, 17);
            this.YearRadioButton.TabIndex = 2;
            this.YearRadioButton.TabStop = true;
            this.YearRadioButton.Text = "Year";
            this.YearRadioButton.UseVisualStyleBackColor = true;
            // 
            // MonthRadioButton
            // 
            this.MonthRadioButton.AutoSize = true;
            this.MonthRadioButton.Location = new System.Drawing.Point(16, 35);
            this.MonthRadioButton.Name = "MonthRadioButton";
            this.MonthRadioButton.Size = new System.Drawing.Size(55, 17);
            this.MonthRadioButton.TabIndex = 3;
            this.MonthRadioButton.Text = "Month";
            this.MonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // DayRadioButton
            // 
            this.DayRadioButton.AutoSize = true;
            this.DayRadioButton.Location = new System.Drawing.Point(16, 58);
            this.DayRadioButton.Name = "DayRadioButton";
            this.DayRadioButton.Size = new System.Drawing.Size(49, 17);
            this.DayRadioButton.TabIndex = 4;
            this.DayRadioButton.Text = "Days";
            this.DayRadioButton.UseVisualStyleBackColor = true;
            // 
            // SecondRadioButton
            // 
            this.SecondRadioButton.AutoSize = true;
            this.SecondRadioButton.Location = new System.Drawing.Point(16, 103);
            this.SecondRadioButton.Name = "SecondRadioButton";
            this.SecondRadioButton.Size = new System.Drawing.Size(67, 17);
            this.SecondRadioButton.TabIndex = 5;
            this.SecondRadioButton.Text = "Seconds";
            this.SecondRadioButton.UseVisualStyleBackColor = true;
            // 
            // MinuteRadioButton
            // 
            this.MinuteRadioButton.AutoSize = true;
            this.MinuteRadioButton.Location = new System.Drawing.Point(16, 81);
            this.MinuteRadioButton.Name = "MinuteRadioButton";
            this.MinuteRadioButton.Size = new System.Drawing.Size(62, 17);
            this.MinuteRadioButton.TabIndex = 6;
            this.MinuteRadioButton.Text = "Minutes";
            this.MinuteRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(120, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 13);
            this.textBox2.TabIndex = 7;
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(278, 168);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 27);
            this.Next.TabIndex = 8;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter data 01.01.0001";
            // 
            // Task7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 204);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MinuteRadioButton);
            this.Controls.Add(this.SecondRadioButton);
            this.Controls.Add(this.DayRadioButton);
            this.Controls.Add(this.MonthRadioButton);
            this.Controls.Add(this.YearRadioButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Task7";
            this.Text = "Task7";
            this.Resize += new System.EventHandler(this.Task7_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton YearRadioButton;
        private System.Windows.Forms.RadioButton MonthRadioButton;
        private System.Windows.Forms.RadioButton DayRadioButton;
        private System.Windows.Forms.RadioButton SecondRadioButton;
        private System.Windows.Forms.RadioButton MinuteRadioButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
    }
}