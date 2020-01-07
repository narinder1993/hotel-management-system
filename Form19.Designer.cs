namespace WindowsFormsApplication5
{
    partial class Form19
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database1DataSet6 = new WindowsFormsApplication5.Database1DataSet6();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nurseTableAdapter = new WindowsFormsApplication5.Database1DataSet6TableAdapters.nurseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.nurseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication5.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(643, 215);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(289, 269);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(396, 246);
            this.reportViewer2.TabIndex = 1;
            // 
            // Database1DataSet6
            // 
            this.Database1DataSet6.DataSetName = "Database1DataSet6";
            this.Database1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataMember = "nurse";
            this.nurseBindingSource.DataSource = this.Database1DataSet6;
            // 
            // nurseTableAdapter
            // 
            this.nurseTableAdapter.ClearBeforeFill = true;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 215);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form19";
            this.Text = "Form19";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private Database1DataSet6 Database1DataSet6;
        private Database1DataSet6TableAdapters.nurseTableAdapter nurseTableAdapter;
    }
}