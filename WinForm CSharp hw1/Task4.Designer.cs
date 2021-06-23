
namespace WinForm_CSharp_hw1
{
    partial class Task4
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
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(665, 385);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 27);
            this.Next.TabIndex = 7;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 424);
            this.Controls.Add(this.Next);
            this.Name = "Task4";
            this.Text = "Task4";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Task4_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Task4_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Task4_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Task4_MouseUp);
            this.Resize += new System.EventHandler(this.Task4_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Next;
    }
}