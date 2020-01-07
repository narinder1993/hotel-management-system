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
    public partial class Form10 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                con=new SqlConnection (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\USER\documents\visual studio 2010\Projects\WindowsFormsApplication5\WindowsFormsApplication5\Database1.mdf;Integrated Security=True;User Instance=True");
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd = new SqlCommand("select * from doctors ",con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                comboBox3.Items.Add(dr[1].ToString ());

            }
            dr.Close();
            
            cmd = new SqlCommand("select * from patient",con);
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
                textBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                comboBox2.Text  = dr[3].ToString();
                textBox3.Text = dr[4].ToString();
                comboBox3.Text = dr[4].ToString();
            }
            dr.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into patient values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + comboBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("1  Record inserted");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox3.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
