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
    public partial class Form12 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\USER\documents\visual studio 2010\Projects\WindowsFormsApplication5\WindowsFormsApplication5\Database1.mdf;Integrated Security=True;User Instance=True");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd = new SqlCommand("select * from patient", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from patient where id='" + comboBox1.Text + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[7].ToString();
            }
            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update patient set balance_due='" + textBox2.Text + "' where id='" + comboBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated");
        }
    }
}
