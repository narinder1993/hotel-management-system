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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void secutiryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 obj = new Form6();
            obj.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 obj=new Form5();
            obj.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void nearbyHospitalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 ne = new Form8();
            ne.Show();
        }

        private void cleanersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 obj = new Form9();
            obj.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 obj = new Form10();
            obj.Show();
        }

        private void bedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 ob = new Form11();
            ob.Show();
        }

        private void facilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 obj = new Form12();
            obj.Show();
        }

        private void doctorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form14 ob = new Form14();
            ob.Show();
        }

        private void nursesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form15 ob = new Form15();
            ob.Show();
        }

        private void cleanersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form16  ob= new Form16();
            ob.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 n = new Form17();
            n.Show();
        }

        private void doctorsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form18 c = new Form18();
            c.Show();
        }

        private void nursesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form19 v = new Form19();
            v.Show();
        }

        private void cleanerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 m = new Form20();
            m.Show();
        }

        private void patientsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form21 c = new Form21();
            c.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
