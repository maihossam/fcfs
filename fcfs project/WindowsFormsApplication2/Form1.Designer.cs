namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.fcfsbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fcfsbtn
            // 
            this.fcfsbtn.Location = new System.Drawing.Point(73, 27);
            this.fcfsbtn.Name = "fcfsbtn";
            this.fcfsbtn.Size = new System.Drawing.Size(126, 36);
            this.fcfsbtn.TabIndex = 0;
            this.fcfsbtn.Text = "FCFS";
            this.fcfsbtn.UseVisualStyleBackColor = true;
            this.fcfsbtn.Click += new System.EventHandler(this.fcfsbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fcfsbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fcfsbtn;
    }
}

