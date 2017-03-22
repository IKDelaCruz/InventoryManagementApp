namespace InventoryManagement
{
    partial class frmManageUserRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUserRequest));
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.txtUserRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminRemarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dvLogs = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeededDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnApproved = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 10000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.tabControl1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(730, 520);
            this.pnlMain.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 514);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFilter);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtpTo);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.dtpFrom);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.cbxStatus);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dvLogs);
            this.tabPage1.Controls.Add(this.btnDecline);
            this.tabPage1.Controls.Add(this.btnApproved);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pending Requests";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(610, 5);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 69;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "End Date";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(258, 10);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(99, 23);
            this.dtpTo.TabIndex = 66;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 13);
            this.label15.Margin = new System.Windows.Forms.Padding(5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 65;
            this.label15.Text = "Begin Date";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(83, 10);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(100, 23);
            this.dtpFrom.TabIndex = 64;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(367, 13);
            this.label23.Margin = new System.Windows.Forms.Padding(5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 15);
            this.label23.TabIndex = 63;
            this.label23.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(418, 10);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(5);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 23);
            this.cbxStatus.TabIndex = 62;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.cbxStatus_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxItems);
            this.groupBox1.Controls.Add(this.txtUserRemarks);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdminRemarks);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(6, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 208);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "Assign Item";
            // 
            // cbxItems
            // 
            this.cbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(9, 163);
            this.cbxItems.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(256, 23);
            this.cbxItems.TabIndex = 56;
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            // 
            // txtUserRemarks
            // 
            this.txtUserRemarks.Location = new System.Drawing.Point(9, 41);
            this.txtUserRemarks.Multiline = true;
            this.txtUserRemarks.Name = "txtUserRemarks";
            this.txtUserRemarks.ReadOnly = true;
            this.txtUserRemarks.Size = new System.Drawing.Size(689, 40);
            this.txtUserRemarks.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "User Remarks";
            // 
            // txtAdminRemarks
            // 
            this.txtAdminRemarks.Location = new System.Drawing.Point(9, 102);
            this.txtAdminRemarks.Multiline = true;
            this.txtAdminRemarks.Name = "txtAdminRemarks";
            this.txtAdminRemarks.Size = new System.Drawing.Size(689, 40);
            this.txtAdminRemarks.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Admin Remarks";
            // 
            // dvLogs
            // 
            this.dvLogs.AllowUserToAddRows = false;
            this.dvLogs.AllowUserToDeleteRows = false;
            this.dvLogs.AllowUserToResizeRows = false;
            this.dvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TransactionDate,
            this.SystemUserName,
            this.TransactionTypeId,
            this.SubTypeId,
            this.OtherUserName,
            this.NeededDate,
            this.DateReturn,
            this.Remarks,
            this.AdminRemarks,
            this.CustomerId});
            this.dvLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvLogs.Location = new System.Drawing.Point(6, 39);
            this.dvLogs.Name = "dvLogs";
            this.dvLogs.RowHeadersVisible = false;
            this.dvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvLogs.ShowCellToolTips = false;
            this.dvLogs.ShowEditingIcon = false;
            this.dvLogs.ShowRowErrors = false;
            this.dvLogs.Size = new System.Drawing.Size(704, 191);
            this.dvLogs.TabIndex = 1;
            this.dvLogs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvLogs_CellClick);
            this.dvLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvLogs_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 50;
            // 
            // TransactionDate
            // 
            this.TransactionDate.DataPropertyName = "RequestedDate";
            this.TransactionDate.HeaderText = "Date";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.Width = 130;
            // 
            // SystemUserName
            // 
            this.SystemUserName.DataPropertyName = "RequestType";
            this.SystemUserName.HeaderText = "Type";
            this.SystemUserName.Name = "SystemUserName";
            // 
            // TransactionTypeId
            // 
            this.TransactionTypeId.DataPropertyName = "Subtype";
            this.TransactionTypeId.HeaderText = "Sub Type";
            this.TransactionTypeId.Name = "TransactionTypeId";
            // 
            // SubTypeId
            // 
            this.SubTypeId.DataPropertyName = "RequestSecondaryItemType";
            this.SubTypeId.HeaderText = "SubTypeId";
            this.SubTypeId.Name = "SubTypeId";
            this.SubTypeId.Visible = false;
            // 
            // OtherUserName
            // 
            this.OtherUserName.DataPropertyName = "UserFullnameEmail";
            this.OtherUserName.HeaderText = "User";
            this.OtherUserName.Name = "OtherUserName";
            this.OtherUserName.Width = 150;
            // 
            // NeededDate
            // 
            this.NeededDate.DataPropertyName = "NeededDate";
            this.NeededDate.HeaderText = "Date Needed";
            this.NeededDate.Name = "NeededDate";
            this.NeededDate.Width = 130;
            // 
            // DateReturn
            // 
            this.DateReturn.DataPropertyName = "ExpectedReturnDate";
            this.DateReturn.HeaderText = "DateReturn";
            this.DateReturn.Name = "DateReturn";
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.Visible = false;
            // 
            // AdminRemarks
            // 
            this.AdminRemarks.DataPropertyName = "AdminRemarks";
            this.AdminRemarks.HeaderText = "AdminRemarks";
            this.AdminRemarks.Name = "AdminRemarks";
            this.AdminRemarks.Visible = false;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "RequestedById";
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(496, 450);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(100, 30);
            this.btnDecline.TabIndex = 5;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnApproved
            // 
            this.btnApproved.Location = new System.Drawing.Point(604, 450);
            this.btnApproved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(100, 30);
            this.btnApproved.TabIndex = 4;
            this.btnApproved.Text = "Approve";
            this.btnApproved.UseVisualStyleBackColor = true;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // frmManageUserRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 540);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageUserRequest";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Request";
            this.pnlMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dvLogs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdminRemarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.TextBox txtUserRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeededDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
    }
}