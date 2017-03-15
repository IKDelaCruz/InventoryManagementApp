namespace InventoryManagement
{
    partial class frmUserLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLogs));
            this.imgMain = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dvLogs = new System.Windows.Forms.DataGridView();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMain.ImageStream")));
            this.imgMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMain.Images.SetKeyName(0, "admin-admin.png");
            this.imgMain.Images.SetKeyName(1, "admin-custodian.png");
            this.imgMain.Images.SetKeyName(2, "user1.png");
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.btnExport);
            this.pnlMain.Controls.Add(this.btnFilter);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.dtpTo);
            this.pnlMain.Controls.Add(this.label15);
            this.pnlMain.Controls.Add(this.dtpFrom);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.dvLogs);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(764, 483);
            this.pnlMain.TabIndex = 11;
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
            this.label1.Location = new System.Drawing.Point(388, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "End Date";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(453, 56);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(186, 23);
            this.dtpTo.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(117, 62);
            this.label15.Margin = new System.Windows.Forms.Padding(5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 59;
            this.label15.Text = "Begin Date";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(192, 56);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(186, 23);
            this.dtpFrom.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = "User Logs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvLogs
            // 
            this.dvLogs.AllowUserToAddRows = false;
            this.dvLogs.AllowUserToDeleteRows = false;
            this.dvLogs.AllowUserToResizeRows = false;
            this.dvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionDate,
            this.TransactionType,
            this.SystemUser,
            this.CustomerName,
            this.ItemName});
            this.dvLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvLogs.Location = new System.Drawing.Point(16, 90);
            this.dvLogs.Name = "dvLogs";
            this.dvLogs.RowHeadersVisible = false;
            this.dvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvLogs.ShowCellErrors = false;
            this.dvLogs.ShowCellToolTips = false;
            this.dvLogs.ShowEditingIcon = false;
            this.dvLogs.ShowRowErrors = false;
            this.dvLogs.Size = new System.Drawing.Size(732, 335);
            this.dvLogs.TabIndex = 0;
            // 
            // TransactionDate
            // 
            this.TransactionDate.DataPropertyName = "TransactionDate";
            this.TransactionDate.HeaderText = "TransactionDate";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.Width = 120;
            // 
            // TransactionType
            // 
            this.TransactionType.DataPropertyName = "TransactionType";
            this.TransactionType.HeaderText = "TransactionType";
            this.TransactionType.Name = "TransactionType";
            // 
            // SystemUser
            // 
            this.SystemUser.DataPropertyName = "SystemUserName";
            this.SystemUser.HeaderText = "SystemUser";
            this.SystemUser.Name = "SystemUser";
            this.SystemUser.Width = 120;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "OtherUserName";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 120;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 150;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(540, 431);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export To CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            // 
            // frmUserLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 503);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserLogs";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserLogs";
            this.Load += new System.EventHandler(this.frmUserLogs_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dvLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClose;
    }
}