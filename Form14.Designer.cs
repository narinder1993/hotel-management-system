namespace WindowsFormsApplication5
{
    partial class Form14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database1DataSet2 = new WindowsFormsApplication5.Database1DataSet2();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new WindowsFormsApplication5.Database1DataSet2TableAdapters.doctorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.doctorsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication5.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(473, 348);
            this.reportViewer1.TabIndex = 0;
            // 
            // Database1DataSet2
            // 
            this.Database1DataSet2.DataSetName = "Database1DataSet2";
            this.Database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.Database1DataSet2;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 348);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private Database1DataSet2 Database1DataSet2;
        private Database1DataSet2TableAdapters.doctorsTableAdapter doctorsTableAdapter;
    }
}