using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text==Convert.ToString("user"))

            {
                if(textBox2.Text==Convert.ToString(1))
                {
                    Form3 obj=new Form3();
                    this.Hide();
                    obj.Show();
                }
                else{
                MessageBox.Show("Incorrect Password");
                }
                
            }
            else
                {
                MessageBox.Show("Incorrect Username");
                }
        }

        
    }
}
