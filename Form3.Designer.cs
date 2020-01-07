namespace WindowsFormsApplication5
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nursesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nearbyHospitalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nursesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.facilitiesToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.nearbyHospitalsToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsToolStripMenuItem,
            this.nursesToolStripMenuItem,
            this.cleanersToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.staffToolStripMenuItem.Text = "STAFF";
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            this.doctorsToolStripMenuItem.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);
            // 
            // nursesToolStripMenuItem
            // 
            this.nursesToolStripMenuItem.Name = "nursesToolStripMenuItem";
            this.nursesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nursesToolStripMenuItem.Text = "Nurses";
            this.nursesToolStripMenuItem.Click += new System.EventHandler(this.nursesToolStripMenuItem_Click);
            // 
            // cleanersToolStripMenuItem
            // 
            this.cleanersToolStripMenuItem.Name = "cleanersToolStripMenuItem";
            this.cleanersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cleanersToolStripMenuItem.Text = "Cleaners";
            this.cleanersToolStripMenuItem.Click += new System.EventHandler(this.cleanersToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.patientsToolStripMenuItem.Text = "PATIENTS";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // facilitiesToolStripMenuItem
            // 
            this.facilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bedsToolStripMenuItem});
            this.facilitiesToolStripMenuItem.Name = "facilitiesToolStripMenuItem";
            this.facilitiesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.facilitiesToolStripMenuItem.Text = "FACILITIES";
            this.facilitiesToolStripMenuItem.Click += new System.EventHandler(this.facilitiesToolStripMenuItem_Click);
            // 
            // bedsToolStripMenuItem
            // 
            this.bedsToolStripMenuItem.Name = "bedsToolStripMenuItem";
            this.bedsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bedsToolStripMenuItem.Text = "Beds";
            this.bedsToolStripMenuItem.Click += new System.EventHandler(this.bedsToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem1,
            this.staffToolStripMenuItem1});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.accountsToolStripMenuItem.Text = "ACCOUNTS";
            // 
            // patientsToolStripMenuItem1
            // 
            this.patientsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billsToolStripMenuItem});
            this.patientsToolStripMenuItem1.Name = "patientsToolStripMenuItem1";
            this.patientsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.patientsToolStripMenuItem1.Text = "Patients";
            // 
            // billsToolStripMenuItem
            // 
            this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
            this.billsToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.billsToolStripMenuItem.Text = "bills";
            this.billsToolStripMenuItem.Click += new System.EventHandler(this.billsToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem1
            // 
            this.staffToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaryToolStripMenuItem});
            this.staffToolStripMenuItem1.Name = "staffToolStripMenuItem1";
            this.staffToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.staffToolStripMenuItem1.Text = "Staff";
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsToolStripMenuItem1,
            this.nursesToolStripMenuItem1,
            this.cleanersToolStripMenuItem1});
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.salaryToolStripMenuItem.Text = "salary";
            this.salaryToolStripMenuItem.Click += new System.EventHandler(this.salaryToolStripMenuItem_Click);
            // 
            // doctorsToolStripMenuItem1
            // 
            this.doctorsToolStripMenuItem1.Name = "doctorsToolStripMenuItem1";
            this.doctorsToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.doctorsToolStripMenuItem1.Text = "Doctors";
            this.doctorsToolStripMenuItem1.Click += new System.EventHandler(this.doctorsToolStripMenuItem1_Click);
            // 
            // nursesToolStripMenuItem1
            // 
            this.nursesToolStripMenuItem1.Name = "nursesToolStripMenuItem1";
            this.nursesToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.nursesToolStripMenuItem1.Text = "Nurses";
            this.nursesToolStripMenuItem1.Click += new System.EventHandler(this.nursesToolStripMenuItem1_Click);
            // 
            // cleanersToolStripMenuItem1
            // 
            this.cleanersToolStripMenuItem1.Name = "cleanersToolStripMenuItem1";
            this.cleanersToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.cleanersToolStripMenuItem1.Text = "Cleaners";
            this.cleanersToolStripMenuItem1.Click += new System.EventHandler(this.cleanersToolStripMenuItem1_Click);
            // 
            // nearbyHospitalsToolStripMenuItem
            // 
            this.nearbyHospitalsToolStripMenuItem.Name = "nearbyHospitalsToolStripMenuItem";
            this.nearbyHospitalsToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.nearbyHospitalsToolStripMenuItem.Text = "NEARBY HOSPITALS";
            this.nearbyHospitalsToolStripMenuItem.Click += new System.EventHandler(this.nearbyHospitalsToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.locationToolStripMenuItem.Text = "LOCATION";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsToolStripMenuItem2,
            this.nursesToolStripMenuItem2,
            this.cleanerToolStripMenuItem,
            this.patientsToolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "REPORT";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // doctorsToolStripMenuItem2
            // 
            this.doctorsToolStripMenuItem2.Name = "doctorsToolStripMenuItem2";
            this.doctorsToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.doctorsToolStripMenuItem2.Text = "Doctors";
            this.doctorsToolStripMenuItem2.Click += new System.EventHandler(this.doctorsToolStripMenuItem2_Click);
            // 
            // nursesToolStripMenuItem2
            // 
            this.nursesToolStripMenuItem2.Name = "nursesToolStripMenuItem2";
            this.nursesToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.nursesToolStripMenuItem2.Text = "Nurses";
            this.nursesToolStripMenuItem2.Click += new System.EventHandler(this.nursesToolStripMenuItem2_Click);
            // 
            // cleanerToolStripMenuItem
            // 
            this.cleanerToolStripMenuItem.Name = "cleanerToolStripMenuItem";
            this.cleanerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cleanerToolStripMenuItem.Text = "Cleaner";
            this.cleanerToolStripMenuItem.Click += new System.EventHandler(this.cleanerToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem2
            // 
            this.patientsToolStripMenuItem2.Name = "patientsToolStripMenuItem2";
            this.patientsToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.patientsToolStripMenuItem2.Text = "Patients";
            this.patientsToolStripMenuItem2.Click += new System.EventHandler(this.patientsToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(42, 20);
            this.toolStripMenuItem2.Text = "EXIT";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApplication5.Properties.Resources.hospital_monument;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Hospital Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nearbyHospitalsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nursesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cleanersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nursesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cleanerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}