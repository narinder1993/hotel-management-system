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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet5.doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.Database1DataSet5.doctors);

            this.reportViewer1.RefreshReport();
        }
    }
}
