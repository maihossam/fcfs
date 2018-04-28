using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    { 

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
       


        private void databtn_Click(object sender, EventArgs e)
        {
            string s = number.Text;
            ListViewItem lv = new ListViewItem(name.Text);
            lv.SubItems.Add(burstvalue.Text);
            lv.SubItems.Add(arrivalvalue.Text);
            listView1.Items.Add(lv);
            name.Text = " ";
            burstvalue.Text = " ";
            arrivalvalue.Text = " ";
        }



        private void button1_Click(object sender, EventArgs e)
        {
           listView1.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void createlabels ()
        {
           flowLayoutPanel1.Controls.Clear();
            int anInteger;
            string koky = number.Text;
            anInteger = int.Parse(koky);
            string[] processname = new string[anInteger];
            int temp1, temp2;
            string temp3;
            // int[] arrival = new int[anInteger];
             //int[] burst = new int[anInteger];

            List<int> resultList1 = new List<int>();//conversion from string to integer
            List<int> resultList2 = new List<int>();
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                string text1 = selectedItem.SubItems[2].Text;
                string text2 = selectedItem.SubItems[1].Text;
                resultList1.Add(Convert.ToInt32(text1));
                resultList1.Add(Convert.ToInt32(text2));
            }
            /*for (int i = 0; i < listView1.Items.Count; i++)
            {   
               
                resultList1.Add(Convert.ToInt32(listView1.Items[i].SubItems[2]));
                resultList2.Add(Convert.ToInt32(listView1.Items[i].SubItems[1]));
            }*/
            for (int o = 0; o < anInteger; o++) // convert ll from string to integers and split arrival and burst time into 2 diff. arrays 
            {
                string c = listView1.Items[o].SubItems[0].Text;
                processname[o] = c;
            }

            if (listView1.Items.Count != 0)
             {
               /*for (int i = 0; i < anInteger; i++) // convert ll from string to integers and split arrival and burst time into 2 diff. arrays 
                 {
                   
                   
                    arrival[i] = resultList1[i];
                   
                }
                 for (int j = 0; j < anInteger; j++) // convert ll from string to integers and split arrival and burst time into 2 diff. arrays 
                 {
                     burst[j] = resultList2[j] ;
                 }*/

           
                
               
                
                for (int k = 0; k < anInteger - 1; k++)   // sorting arrival and burst array from min. to larger (fcfs)
                {
                    int min = k;
                    for (int r = k + 1; r < anInteger; r++)
                    {
                       
                        if (resultList1.IndexOf(r) < resultList2.IndexOf(k) )
                            min = r;
                    }
                    if (min != k)
                    {
                        temp1 = resultList1[k];
                        temp2 = resultList2[k];
                        temp3 = processname[k];
                        resultList1[k] = resultList1[min];
                        resultList2[k] = resultList2[min];
                        processname[k] = processname[min];
                        resultList1[min] = temp1;
                        resultList2[min] = temp2;
                        processname[min] = temp3;
                    }
                }


            }

            for(int g =0; g< anInteger; g++)
            {
                //sum = sum + burst[g];
                Label dynamicLabel = new Label();
                dynamicLabel.Text = "";
                dynamicLabel.Name = g.ToString();
                dynamicLabel.AutoSize = true;
                dynamicLabel.Font = new Font("Georgia", 16);
                dynamicLabel.Location = new Point(0,10);
                dynamicLabel.Height = 10;
                dynamicLabel.Width  = 10;
                flowLayoutPanel1.Controls.Add(dynamicLabel);

            }

        }

        private void drawbtn_Click(object sender, EventArgs e)
        {
         createlabels();
          
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


