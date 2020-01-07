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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet2.doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.Database1DataSet2.doctors);

            this.reportViewer1.RefreshReport();
        }
    }
}
