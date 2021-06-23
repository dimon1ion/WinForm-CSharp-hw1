
namespace WinForm_CSharp_hw1
{
    partial class Task5
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
            this.button1 = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Стасик";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(723, 413);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 27);
            this.Next.TabIndex = 7;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 452);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Task5";
            this.Text = "Task5";
            this.Resize += new System.EventHandler(this.Task5_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Next;
    }
}