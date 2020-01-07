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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet4.cleaner' table. You can move, or remove it, as needed.
            this.cleanerTableAdapter.Fill(this.Database1DataSet4.cleaner);

            this.reportViewer1.RefreshReport();
        }
    }
}
