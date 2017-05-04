namespace InventoryManagement
{
    partial class frmItemSummaryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemSummaryReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgMain = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkShowAllLocation = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.chkShowAllSubType = new System.Windows.Forms.CheckBox();
            this.chkShowAllType = new System.Windows.Forms.CheckBox();
            this.chkShowAllStatus = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSubtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dvLogs = new System.Windows.Forms.DataGridView();
            this.AssetTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemSubType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.imgMain.Images.SetKeyName(2, "admin-user.png");
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnFilter);
            this.pnlMain.Controls.Add(this.btnExport);
            this.pnlMain.Controls.Add(this.chkShowAllLocation);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.cbxLocation);
            this.pnlMain.Controls.Add(this.chkShowAllSubType);
            this.pnlMain.Controls.Add(this.chkShowAllType);
            this.pnlMain.Controls.Add(this.chkShowAllStatus);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.cbxSubtype);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.cbxType);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.cbxStatus);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.dvLogs);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(857, 493);
            this.pnlMain.TabIndex = 12;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(742, 71);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 71;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(16, 445);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export To CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkShowAllLocation
            // 
            this.chkShowAllLocation.AutoSize = true;
            this.chkShowAllLocation.Checked = true;
            this.chkShowAllLocation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllLocation.Location = new System.Drawing.Point(478, 105);
            this.chkShowAllLocation.Name = "chkShowAllLocation";
            this.chkShowAllLocation.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllLocation.TabIndex = 70;
            this.chkShowAllLocation.Text = "Show All";
            this.chkShowAllLocation.UseVisualStyleBackColor = true;
            this.chkShowAllLocation.CheckedChanged += new System.EventHandler(this.LoadItems);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 69;
            this.label7.Text = "Location";
            // 
            // cbxLocation
            // 
            this.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Location = new System.Drawing.Point(478, 76);
            this.cbxLocation.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(187, 23);
            this.cbxLocation.TabIndex = 68;
            this.cbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbxLocation_SelectedIndexChanged);
            // 
            // chkShowAllSubType
            // 
            this.chkShowAllSubType.AutoSize = true;
            this.chkShowAllSubType.Checked = true;
            this.chkShowAllSubType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllSubType.Location = new System.Drawing.Point(324, 105);
            this.chkShowAllSubType.Name = "chkShowAllSubType";
            this.chkShowAllSubType.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllSubType.TabIndex = 67;
            this.chkShowAllSubType.Text = "Show All";
            this.chkShowAllSubType.UseVisualStyleBackColor = true;
            this.chkShowAllSubType.CheckedChanged += new System.EventHandler(this.LoadItems);
            // 
            // chkShowAllType
            // 
            this.chkShowAllType.AutoSize = true;
            this.chkShowAllType.Checked = true;
            this.chkShowAllType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllType.Location = new System.Drawing.Point(170, 105);
            this.chkShowAllType.Name = "chkShowAllType";
            this.chkShowAllType.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllType.TabIndex = 66;
            this.chkShowAllType.Text = "Show All";
            this.chkShowAllType.UseVisualStyleBackColor = true;
            this.chkShowAllType.CheckedChanged += new System.EventHandler(this.LoadItems);
            // 
            // chkShowAllStatus
            // 
            this.chkShowAllStatus.AutoSize = true;
            this.chkShowAllStatus.Checked = true;
            this.chkShowAllStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllStatus.Location = new System.Drawing.Point(16, 105);
            this.chkShowAllStatus.Name = "chkShowAllStatus";
            this.chkShowAllStatus.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllStatus.TabIndex = 65;
            this.chkShowAllStatus.Text = "Show All";
            this.chkShowAllStatus.UseVisualStyleBackColor = true;
            this.chkShowAllStatus.CheckedChanged += new System.EventHandler(this.LoadItems);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "Sub-Type";
            // 
            // cbxSubtype
            // 
            this.cbxSubtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubtype.FormattingEnabled = true;
            this.cbxSubtype.Location = new System.Drawing.Point(324, 76);
            this.cbxSubtype.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbxSubtype.Name = "cbxSubtype";
            this.cbxSubtype.Size = new System.Drawing.Size(121, 23);
            this.cbxSubtype.TabIndex = 63;
            this.cbxSubtype.SelectedIndexChanged += new System.EventHandler(this.cbxSubtype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Type";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(170, 76);
            this.cbxType.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 23);
            this.cbxType.TabIndex = 61;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(16, 76);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 23);
            this.cbxStatus.TabIndex = 59;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.cbxStatus_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(214, 36);
            this.label3.TabIndex = 58;
            this.label3.Text = "Item Summary Report";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dvLogs
            // 
            this.dvLogs.AllowUserToAddRows = false;
            this.dvLogs.AllowUserToDeleteRows = false;
            this.dvLogs.AllowUserToResizeRows = false;
            this.dvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetTag,
            this.SerialNumber,
            this.ItemName,
            this.ItemType,
            this.ItemSubType,
            this.ItemStatus,
            this.CurrentOwner,
            this.DateCreated,
            this.LastUpdated,
            this.PurchaseDate,
            this.PurchaseAmount});
            this.dvLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvLogs.Location = new System.Drawing.Point(16, 139);
            this.dvLogs.Name = "dvLogs";
            this.dvLogs.RowHeadersVisible = false;
            this.dvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvLogs.ShowCellErrors = false;
            this.dvLogs.ShowCellToolTips = false;
            this.dvLogs.ShowEditingIcon = false;
            this.dvLogs.ShowRowErrors = false;
            this.dvLogs.Size = new System.Drawing.Size(826, 300);
            this.dvLogs.TabIndex = 0;
            // 
            // AssetTag
            // 
            this.AssetTag.DataPropertyName = "AssetTag";
            this.AssetTag.HeaderText = "AssetTag";
            this.AssetTag.Name = "AssetTag";
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "Serial";
            this.SerialNumber.HeaderText = "Serial Number";
            this.SerialNumber.Name = "SerialNumber";
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "Name";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // ItemType
            // 
            this.ItemType.DataPropertyName = "Type";
            this.ItemType.HeaderText = "ItemType";
            this.ItemType.Name = "ItemType";
            // 
            // ItemSubType
            // 
            this.ItemSubType.DataPropertyName = "SubType";
            this.ItemSubType.HeaderText = "ItemSubType";
            this.ItemSubType.Name = "ItemSubType";
            // 
            // ItemStatus
            // 
            this.ItemStatus.DataPropertyName = "Status";
            this.ItemStatus.HeaderText = "ItemStatus";
            this.ItemStatus.Name = "ItemStatus";
            // 
            // CurrentOwner
            // 
            this.CurrentOwner.DataPropertyName = "CurrentOwnerName";
            this.CurrentOwner.HeaderText = "CurrentOwner";
            this.CurrentOwner.Name = "CurrentOwner";
            // 
            // DateCreated
            // 
            this.DateCreated.DataPropertyName = "PurchaseDate";
            this.DateCreated.HeaderText = "DateCreated";
            this.DateCreated.Name = "DateCreated";
            // 
            // LastUpdated
            // 
            this.LastUpdated.DataPropertyName = "LastUpdatedDate";
            this.LastUpdated.HeaderText = "LastUpdated";
            this.LastUpdated.Name = "LastUpdated";
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "PurchaseDate";
            this.PurchaseDate.HeaderText = "PurchaseDate";
            this.PurchaseDate.Name = "PurchaseDate";
            // 
            // PurchaseAmount
            // 
            this.PurchaseAmount.DataPropertyName = "PurchasePrice";
            dataGridViewCellStyle1.Format = "N";
            this.PurchaseAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.PurchaseAmount.HeaderText = "Purchase Amount";
            this.PurchaseAmount.Name = "PurchaseAmount";
            // 
            // frmItemSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 513);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItemSummaryReport";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dvLogs;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkShowAllSubType;
        private System.Windows.Forms.CheckBox chkShowAllType;
        private System.Windows.Forms.CheckBox chkShowAllStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSubtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.CheckBox chkShowAllLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSubType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseAmount;
    }
}