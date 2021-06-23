
namespace WinForm_CSharp_hw1
{
    partial class Task6
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter data 01.01.0001";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(196, 127);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 27);
            this.Next.TabIndex = 6;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(157, 73);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(75, 23);
            this.ResultButton.TabIndex = 7;
            this.ResultButton.Text = "Result";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(157, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 9;
            // 
            // Task6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 166);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(299, 205);
            this.Name = "Task6";
            this.Text = "Task6";
            this.Resize += new System.EventHandler(this.Task6_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.TextBox textBox2;
    }
}