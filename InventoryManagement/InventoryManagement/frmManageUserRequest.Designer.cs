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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminRemarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dvLogs = new System.Windows.Forms.DataGridView();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnApproved = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeededDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 10000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 476);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.cbxStatus);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dvLogs);
            this.tabPage1.Controls.Add(this.btnDecline);
            this.tabPage1.Controls.Add(this.btnApproved);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pending Requests";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(539, 11);
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
            this.cbxStatus.Location = new System.Drawing.Point(590, 8);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(5);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 23);
            this.cbxStatus.TabIndex = 62;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.cbxStatus_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserRemarks);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdminRemarks);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(6, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 170);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // txtUserRemarks
            // 
            this.txtUserRemarks.Location = new System.Drawing.Point(9, 37);
            this.txtUserRemarks.Multiline = true;
            this.txtUserRemarks.Name = "txtUserRemarks";
            this.txtUserRemarks.ReadOnly = true;
            this.txtUserRemarks.Size = new System.Drawing.Size(689, 48);
            this.txtUserRemarks.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "User Remarks";
            // 
            // txtAdminRemarks
            // 
            this.txtAdminRemarks.Location = new System.Drawing.Point(9, 106);
            this.txtAdminRemarks.Multiline = true;
            this.txtAdminRemarks.Name = "txtAdminRemarks";
            this.txtAdminRemarks.Size = new System.Drawing.Size(689, 48);
            this.txtAdminRemarks.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 88);
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
            this.OtherUserName,
            this.NeededDate,
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
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(502, 412);
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
            this.btnApproved.Location = new System.Drawing.Point(610, 412);
            this.btnApproved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(100, 30);
            this.btnApproved.TabIndex = 4;
            this.btnApproved.Text = "Approve";
            this.btnApproved.UseVisualStyleBackColor = true;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.tabControl1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(730, 482);
            this.pnlMain.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // TransactionDate
            // 
            this.TransactionDate.DataPropertyName = "RequestedDate";
            this.TransactionDate.HeaderText = "Date";
            this.TransactionDate.Name = "TransactionDate";
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
            // OtherUserName
            // 
            this.OtherUserName.DataPropertyName = "UserFullnameEmail";
            this.OtherUserName.HeaderText = "User";
            this.OtherUserName.Name = "OtherUserName";
            this.OtherUserName.Width = 200;
            // 
            // NeededDate
            // 
            this.NeededDate.DataPropertyName = "NeededDate";
            this.NeededDate.HeaderText = "Date Needed";
            this.NeededDate.Name = "NeededDate";
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
            // frmManageUserRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 502);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageUserRequest";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Request";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).EndInit();
            this.pnlMain.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeededDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
    }
}