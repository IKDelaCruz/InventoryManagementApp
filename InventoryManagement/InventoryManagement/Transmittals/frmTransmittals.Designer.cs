namespace InventoryManagement
{
    partial class frmTransmittals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransmittals));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dvTransmittals = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreparedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printGatePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgMain = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTransmittals)).BeginInit();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnCreateNew);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.btnExport);
            this.pnlMain.Controls.Add(this.btnFilter);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.dtpTo);
            this.pnlMain.Controls.Add(this.label15);
            this.pnlMain.Controls.Add(this.dtpFrom);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.dvTransmittals);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(764, 475);
            this.pnlMain.TabIndex = 12;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(16, 431);
            this.btnCreateNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(150, 30);
            this.btnCreateNew.TabIndex = 64;
            this.btnCreateNew.Text = "New Transmittal";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(648, 431);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(174, 431);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export To CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(648, 54);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 62;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "End Date";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(540, 56);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(99, 23);
            this.dtpTo.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(290, 62);
            this.label15.Margin = new System.Windows.Forms.Padding(5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 59;
            this.label15.Text = "Begin Date";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(365, 56);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(100, 23);
            this.dtpFrom.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = "Transmittal Logs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvTransmittals
            // 
            this.dvTransmittals.AllowUserToAddRows = false;
            this.dvTransmittals.AllowUserToDeleteRows = false;
            this.dvTransmittals.AllowUserToResizeRows = false;
            this.dvTransmittals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTransmittals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Receiver,
            this.Company,
            this.Department,
            this.PreparedBy,
            this.ApprovedBy});
            this.dvTransmittals.ContextMenuStrip = this.cmsMain;
            this.dvTransmittals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvTransmittals.Location = new System.Drawing.Point(16, 90);
            this.dvTransmittals.Name = "dvTransmittals";
            this.dvTransmittals.RowHeadersVisible = false;
            this.dvTransmittals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvTransmittals.ShowCellErrors = false;
            this.dvTransmittals.ShowCellToolTips = false;
            this.dvTransmittals.ShowEditingIcon = false;
            this.dvTransmittals.ShowRowErrors = false;
            this.dvTransmittals.Size = new System.Drawing.Size(732, 335);
            this.dvTransmittals.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 120;
            // 
            // Receiver
            // 
            this.Receiver.DataPropertyName = "TransmittedToUser";
            this.Receiver.HeaderText = "Receiver";
            this.Receiver.Name = "Receiver";
            // 
            // Company
            // 
            this.Company.DataPropertyName = "TransmittedToCompany";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Department
            // 
            this.Department.DataPropertyName = "TransmittedToDepartment";
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // PreparedBy
            // 
            this.PreparedBy.DataPropertyName = "PreparedBy";
            this.PreparedBy.HeaderText = "PreparedBy";
            this.PreparedBy.Name = "PreparedBy";
            this.PreparedBy.Width = 120;
            // 
            // ApprovedBy
            // 
            this.ApprovedBy.DataPropertyName = "ApprovedBy";
            this.ApprovedBy.HeaderText = "ApprovedBy";
            this.ApprovedBy.Name = "ApprovedBy";
            this.ApprovedBy.Width = 120;
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.printGatePassToolStripMenuItem});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(162, 48);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.printToolStripMenuItem.Text = "Print Transmittal";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printGatePassToolStripMenuItem
            // 
            this.printGatePassToolStripMenuItem.Name = "printGatePassToolStripMenuItem";
            this.printGatePassToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.printGatePassToolStripMenuItem.Text = "Print Gate Pass";
            this.printGatePassToolStripMenuItem.Click += new System.EventHandler(this.printGatePassToolStripMenuItem_Click);
            // 
            // imgMain
            // 
            this.imgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMain.ImageStream")));
            this.imgMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMain.Images.SetKeyName(0, "admin-admin.png");
            this.imgMain.Images.SetKeyName(1, "admin-custodian.png");
            this.imgMain.Images.SetKeyName(2, "user1.png");
            // 
            // frmTransmittals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 495);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransmittals";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transmittals";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTransmittals)).EndInit();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dvTransmittals;
        private System.Windows.Forms.ImageList imgMain;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreparedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovedBy;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printGatePassToolStripMenuItem;
    }
}