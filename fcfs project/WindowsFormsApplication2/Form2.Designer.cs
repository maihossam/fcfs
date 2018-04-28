namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.arrivalvalue = new System.Windows.Forms.TextBox();
            this.burstvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databtn = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.TextBox();
            this.removebtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.drawbtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // arrivalvalue
            // 
            this.arrivalvalue.Location = new System.Drawing.Point(91, 64);
            this.arrivalvalue.Name = "arrivalvalue";
            this.arrivalvalue.Size = new System.Drawing.Size(85, 20);
            this.arrivalvalue.TabIndex = 1;
            // 
            // burstvalue
            // 
            this.burstvalue.Location = new System.Drawing.Point(91, 38);
            this.burstvalue.Name = "burstvalue";
            this.burstvalue.Size = new System.Drawing.Size(85, 20);
            this.burstvalue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "processes no.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Burst time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arrival time";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(15, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(231, 133);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "process name";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Burst time";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Arrival time";
            this.columnHeader3.Width = 80;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(91, 90);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(85, 20);
            this.name.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "process name";
            // 
            // databtn
            // 
            this.databtn.Location = new System.Drawing.Point(253, 12);
            this.databtn.Name = "databtn";
            this.databtn.Size = new System.Drawing.Size(95, 44);
            this.databtn.TabIndex = 10;
            this.databtn.Text = "Enter Data";
            this.databtn.UseVisualStyleBackColor = true;
            this.databtn.Click += new System.EventHandler(this.databtn_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(91, 12);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(85, 20);
            this.number.TabIndex = 11;
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(250, 64);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(95, 39);
            this.removebtn.TabIndex = 12;
            this.removebtn.Text = "Remove Data";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // drawbtn
            // 
            this.drawbtn.Location = new System.Drawing.Point(72, 279);
            this.drawbtn.Name = "drawbtn";
            this.drawbtn.Size = new System.Drawing.Size(95, 39);
            this.drawbtn.TabIndex = 14;
            this.drawbtn.Text = "Draw";
            this.drawbtn.UseVisualStyleBackColor = true;
            this.drawbtn.Click += new System.EventHandler(this.drawbtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 324);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 114);
            this.flowLayoutPanel1.TabIndex = 15;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.drawbtn);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.number);
            this.Controls.Add(this.databtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.burstvalue);
            this.Controls.Add(this.arrivalvalue);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox arrivalvalue;
        private System.Windows.Forms.TextBox burstvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button databtn;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button drawbtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}