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
    public partial class Form9 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
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
            cmd = new SqlCommand("select *from cleaner",con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into cleaner values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + maskedTextBox1.Text + "')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("1 record inserted");
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            maskedTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from cleaner where id='" + comboBox1.Text + "'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("1 record deleted");
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            maskedTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update cleaner set name='" + textBox1.Text + "',age='" + textBox2.Text + "',address='" + textBox4.Text + "',salary='" + textBox5.Text + "',contact='" + maskedTextBox1.Text + "'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("1  record edited");
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            maskedTextBox1.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from cleaner where id='"+comboBox1.Text+"'",con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();
                maskedTextBox1.Text = dr[5].ToString();
                
            }
            dr.Close();
        }
    }
}
