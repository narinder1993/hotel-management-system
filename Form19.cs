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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet6.nurse' table. You can move, or remove it, as needed.
            this.nurseTableAdapter.Fill(this.Database1DataSet6.nurse);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
