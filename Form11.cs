using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        
          
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Price of this bed is Rs. 13000");
            }
            else if (checkBox2.Checked == true)
            {
                MessageBox.Show("Price of this bed is Rs. 18000");
            }
            else if (checkBox3.Checked == true)
            {
                MessageBox.Show("Price of this bed is Rs. 20000");
            }
            else if (checkBox4.Checked == true)
            {
                MessageBox.Show("Price of this bed is Rs. 35000");
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
