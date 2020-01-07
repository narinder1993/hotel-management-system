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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet8.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.Database1DataSet8.patient);

            this.reportViewer1.RefreshReport();
        }
    }
}
