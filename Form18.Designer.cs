namespace WindowsFormsApplication5
{
    partial class Form18
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database1DataSet5 = new WindowsFormsApplication5.Database1DataSet5();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new WindowsFormsApplication5.Database1DataSet5TableAdapters.doctorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.doctorsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication5.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(632, 321);
            this.reportViewer1.TabIndex = 0;
            // 
            // Database1DataSet5
            // 
            this.Database1DataSet5.DataSetName = "Database1DataSet5";
            this.Database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.Database1DataSet5;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 321);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form18";
            this.Text = "Form18";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private Database1DataSet5 Database1DataSet5;
        private Database1DataSet5TableAdapters.doctorsTableAdapter doctorsTableAdapter;
    }
}