namespace WindowsFormsApplication5
{
    partial class Form16
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
            this.Database1DataSet4 = new WindowsFormsApplication5.Database1DataSet4();
            this.cleanerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cleanerTableAdapter = new WindowsFormsApplication5.Database1DataSet4TableAdapters.cleanerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleanerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cleanerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication5.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(647, 355);
            this.reportViewer1.TabIndex = 0;
            // 
            // Database1DataSet4
            // 
            this.Database1DataSet4.DataSetName = "Database1DataSet4";
            this.Database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cleanerBindingSource
            // 
            this.cleanerBindingSource.DataMember = "cleaner";
            this.cleanerBindingSource.DataSource = this.Database1DataSet4;
            // 
            // cleanerTableAdapter
            // 
            this.cleanerTableAdapter.ClearBeforeFill = true;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 355);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleanerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cleanerBindingSource;
        private Database1DataSet4 Database1DataSet4;
        private Database1DataSet4TableAdapters.cleanerTableAdapter cleanerTableAdapter;
    }
}