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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDecline = new System.Windows.Forms.Button();
            this.txtAdminRemarks = new System.Windows.Forms.TextBox();
            this.btnApproved = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dvLogs = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeededDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dvProcessed = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dvDeclined = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProcessed)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDeclined)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 456);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dvLogs);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pending Requests";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserRemarks);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDecline);
            this.groupBox1.Controls.Add(this.txtAdminRemarks);
            this.groupBox1.Controls.Add(this.btnApproved);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(9, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 228);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Details";
            // 
            // txtUserRemarks
            // 
            this.txtUserRemarks.Location = new System.Drawing.Point(40, 37);
            this.txtUserRemarks.Multiline = true;
            this.txtUserRemarks.Name = "txtUserRemarks";
            this.txtUserRemarks.ReadOnly = true;
            this.txtUserRemarks.Size = new System.Drawing.Size(638, 52);
            this.txtUserRemarks.TabIndex = 51;
            this.txtUserRemarks.TextChanged += new System.EventHandler(this.txtUserRemarks_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "User Remarks";
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(470, 168);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(100, 30);
            this.btnDecline.TabIndex = 5;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // txtAdminRemarks
            // 
            this.txtAdminRemarks.Location = new System.Drawing.Point(40, 110);
            this.txtAdminRemarks.Multiline = true;
            this.txtAdminRemarks.Name = "txtAdminRemarks";
            this.txtAdminRemarks.Size = new System.Drawing.Size(638, 52);
            this.txtAdminRemarks.TabIndex = 48;
            // 
            // btnApproved
            // 
            this.btnApproved.Location = new System.Drawing.Point(578, 168);
            this.btnApproved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(100, 30);
            this.btnApproved.TabIndex = 4;
            this.btnApproved.Text = "Approve";
            this.btnApproved.UseVisualStyleBackColor = true;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 92);
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
            this.RequestTypeId,
            this.SystemUserName,
            this.SubtypeId,
            this.TransactionTypeId,
            this.UserId,
            this.OtherUserName,
            this.NeededDate,
            this.UserRemarks});
            this.dvLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvLogs.Location = new System.Drawing.Point(3, 3);
            this.dvLogs.Name = "dvLogs";
            this.dvLogs.RowHeadersVisible = false;
            this.dvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvLogs.ShowCellToolTips = false;
            this.dvLogs.ShowEditingIcon = false;
            this.dvLogs.ShowRowErrors = false;
            this.dvLogs.Size = new System.Drawing.Size(716, 205);
            this.dvLogs.TabIndex = 1;
            this.dvLogs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvLogs_CellClick);
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
            // RequestTypeId
            // 
            this.RequestTypeId.DataPropertyName = "RequestTypeInt";
            this.RequestTypeId.HeaderText = "Request Type Id";
            this.RequestTypeId.Name = "RequestTypeId";
            // 
            // SystemUserName
            // 
            this.SystemUserName.DataPropertyName = "RequestType";
            this.SystemUserName.HeaderText = "Request Type";
            this.SystemUserName.Name = "SystemUserName";
            // 
            // SubtypeId
            // 
            this.SubtypeId.DataPropertyName = "RequestSecondaryItemType";
            this.SubtypeId.HeaderText = "Subtype Id";
            this.SubtypeId.Name = "SubtypeId";
            // 
            // TransactionTypeId
            // 
            this.TransactionTypeId.DataPropertyName = "Subtype";
            this.TransactionTypeId.HeaderText = "Item Subtype";
            this.TransactionTypeId.Name = "TransactionTypeId";
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User Id";
            this.UserId.Name = "UserId";
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
            // UserRemarks
            // 
            this.UserRemarks.DataPropertyName = "Remarks";
            this.UserRemarks.HeaderText = "UserRemarks";
            this.UserRemarks.Name = "UserRemarks";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dvProcessed);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Approved Requests";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dvProcessed
            // 
            this.dvProcessed.AllowUserToAddRows = false;
            this.dvProcessed.AllowUserToDeleteRows = false;
            this.dvProcessed.AllowUserToResizeRows = false;
            this.dvProcessed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvProcessed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dvProcessed.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvProcessed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvProcessed.Location = new System.Drawing.Point(3, 3);
            this.dvProcessed.Name = "dvProcessed";
            this.dvProcessed.RowHeadersVisible = false;
            this.dvProcessed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvProcessed.ShowCellToolTips = false;
            this.dvProcessed.ShowEditingIcon = false;
            this.dvProcessed.ShowRowErrors = false;
            this.dvProcessed.Size = new System.Drawing.Size(716, 253);
            this.dvProcessed.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransactionDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransactionDate";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SystemUserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SystemUserName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TransactionTypeId";
            this.dataGridViewTextBoxColumn3.HeaderText = "TransactionTypeId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OtherUserName";
            this.dataGridViewTextBoxColumn4.HeaderText = "OtherUserName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dvDeclined);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(722, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Declined Requests";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dvDeclined
            // 
            this.dvDeclined.AllowUserToAddRows = false;
            this.dvDeclined.AllowUserToDeleteRows = false;
            this.dvDeclined.AllowUserToResizeRows = false;
            this.dvDeclined.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDeclined.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvDeclined.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvDeclined.Location = new System.Drawing.Point(0, 0);
            this.dvDeclined.Name = "dvDeclined";
            this.dvDeclined.RowHeadersVisible = false;
            this.dvDeclined.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDeclined.ShowCellToolTips = false;
            this.dvDeclined.ShowEditingIcon = false;
            this.dvDeclined.ShowRowErrors = false;
            this.dvDeclined.Size = new System.Drawing.Size(722, 253);
            this.dvDeclined.TabIndex = 3;
            // 
            // frmManageUserRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 476);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageUserRequest";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Request";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvProcessed)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvDeclined)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dvLogs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdminRemarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.DataGridView dvProcessed;
        private System.Windows.Forms.TextBox txtUserRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dvDeclined;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeededDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRemarks;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}