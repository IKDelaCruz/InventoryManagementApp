namespace InventoryManagement
{
    partial class frmEndUser
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
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbxUsers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxRequestType = new System.Windows.Forms.ComboBox();
            this.dtpNeededDate = new System.Windows.Forms.DateTimePicker();
            this.cbxSubType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblAdminRemarks = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblHandedBy = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateRequested = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRequestType = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblDateNeeded = new System.Windows.Forms.Label();
            this.lblUserRemarks = new System.Windows.Forms.Label();
            this.lbRequest = new System.Windows.Forms.ListBox();
            this.pnlMain.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 5000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tbMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(560, 457);
            this.pnlMain.TabIndex = 2;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tabPage1);
            this.tbMain.Controls.Add(this.tabPage2);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.ItemSize = new System.Drawing.Size(30, 35);
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.Padding = new System.Drawing.Point(20, 5);
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(560, 457);
            this.tbMain.TabIndex = 1;
            this.tbMain.SelectedIndexChanged += new System.EventHandler(this.tbMain_SelectedIndexChanged);
            this.tbMain.Click += new System.EventHandler(this.tbMain_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(23);
            this.tabPage1.Size = new System.Drawing.Size(552, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create new Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.cbxUsers);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbxRequestType);
            this.groupBox1.Controls.Add(this.dtpNeededDate);
            this.groupBox1.Controls.Add(this.cbxSubType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 308);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Details";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(203, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 15);
            this.label23.TabIndex = 61;
            this.label23.Text = "Item Type";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(383, 265);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 58;
            this.btnSubmit.Text = "Submit Request";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 265);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(206, 42);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(182, 23);
            this.cbxType.TabIndex = 60;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 112);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 15);
            this.label22.TabIndex = 59;
            this.label22.Text = "Requested By";
            // 
            // cbxUsers
            // 
            this.cbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.Location = new System.Drawing.Point(18, 130);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(370, 23);
            this.cbxUsers.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Request Type";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(18, 174);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(465, 85);
            this.txtRemarks.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Remark";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 57;
            this.label15.Text = "Date Needed";
            // 
            // cbxRequestType
            // 
            this.cbxRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRequestType.FormattingEnabled = true;
            this.cbxRequestType.Location = new System.Drawing.Point(18, 42);
            this.cbxRequestType.Name = "cbxRequestType";
            this.cbxRequestType.Size = new System.Drawing.Size(182, 23);
            this.cbxRequestType.TabIndex = 51;
            // 
            // dtpNeededDate
            // 
            this.dtpNeededDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNeededDate.Location = new System.Drawing.Point(18, 86);
            this.dtpNeededDate.Name = "dtpNeededDate";
            this.dtpNeededDate.Size = new System.Drawing.Size(182, 23);
            this.dtpNeededDate.TabIndex = 56;
            // 
            // cbxSubType
            // 
            this.cbxSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubType.FormattingEnabled = true;
            this.cbxSubType.Location = new System.Drawing.Point(206, 86);
            this.cbxSubType.Name = "cbxSubType";
            this.cbxSubType.Size = new System.Drawing.Size(182, 23);
            this.cbxSubType.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Sub Type";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(26, 23);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 0, 3, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(499, 52);
            this.label21.TabIndex = 50;
            this.label21.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean maximus turpis to" +
    "rtor, vitae mollis arcu pellentesque sit amet. Curabitur dapibus ipsum tortor, s" +
    "ed fringilla tortor tempor eu. ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lbRequest);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage2.Size = new System.Drawing.Size(552, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Request";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblAdminRemarks);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lblHandedBy);
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Location = new System.Drawing.Point(145, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 158);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request Status";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 15);
            this.label18.TabIndex = 66;
            this.label18.Text = "Status";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 15);
            this.label17.TabIndex = 67;
            this.label17.Text = "Handled By";
            // 
            // lblAdminRemarks
            // 
            this.lblAdminRemarks.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminRemarks.Location = new System.Drawing.Point(130, 73);
            this.lblAdminRemarks.Name = "lblAdminRemarks";
            this.lblAdminRemarks.Size = new System.Drawing.Size(228, 65);
            this.lblAdminRemarks.TabIndex = 71;
            this.lblAdminRemarks.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 68;
            this.label16.Text = "Remarks";
            // 
            // lblHandedBy
            // 
            this.lblHandedBy.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandedBy.Location = new System.Drawing.Point(130, 48);
            this.lblHandedBy.Name = "lblHandedBy";
            this.lblHandedBy.Size = new System.Drawing.Size(176, 27);
            this.lblHandedBy.TabIndex = 70;
            this.lblHandedBy.Text = "-";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(130, 21);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(176, 27);
            this.lblStatus.TabIndex = 69;
            this.lblStatus.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblDateRequested);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblRequestType);
            this.groupBox2.Controls.Add(this.lblItemType);
            this.groupBox2.Controls.Add(this.lblDateNeeded);
            this.groupBox2.Controls.Add(this.lblUserRemarks);
            this.groupBox2.Location = new System.Drawing.Point(145, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 200);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Deails";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 59;
            this.label5.Text = "Type";
            // 
            // lblDateRequested
            // 
            this.lblDateRequested.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRequested.Location = new System.Drawing.Point(130, 100);
            this.lblDateRequested.Name = "lblDateRequested";
            this.lblDateRequested.Size = new System.Drawing.Size(176, 27);
            this.lblDateRequested.TabIndex = 73;
            this.lblDateRequested.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 58;
            this.label6.Text = "Remarks";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(20, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 15);
            this.label20.TabIndex = 72;
            this.label20.Text = "Date Requested";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "ItemType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Date Needed";
            // 
            // lblRequestType
            // 
            this.lblRequestType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestType.Location = new System.Drawing.Point(130, 20);
            this.lblRequestType.Name = "lblRequestType";
            this.lblRequestType.Size = new System.Drawing.Size(176, 27);
            this.lblRequestType.TabIndex = 62;
            this.lblRequestType.Text = "-";
            // 
            // lblItemType
            // 
            this.lblItemType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.Location = new System.Drawing.Point(130, 47);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(176, 27);
            this.lblItemType.TabIndex = 63;
            this.lblItemType.Text = "-";
            // 
            // lblDateNeeded
            // 
            this.lblDateNeeded.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNeeded.Location = new System.Drawing.Point(130, 73);
            this.lblDateNeeded.Name = "lblDateNeeded";
            this.lblDateNeeded.Size = new System.Drawing.Size(176, 27);
            this.lblDateNeeded.TabIndex = 64;
            this.lblDateNeeded.Text = "-";
            // 
            // lblUserRemarks
            // 
            this.lblUserRemarks.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRemarks.Location = new System.Drawing.Point(130, 127);
            this.lblUserRemarks.Name = "lblUserRemarks";
            this.lblUserRemarks.Size = new System.Drawing.Size(228, 65);
            this.lblUserRemarks.TabIndex = 65;
            this.lblUserRemarks.Text = "-";
            // 
            // lbRequest
            // 
            this.lbRequest.FormattingEnabled = true;
            this.lbRequest.ItemHeight = 15;
            this.lbRequest.Location = new System.Drawing.Point(23, 23);
            this.lbRequest.Name = "lbRequest";
            this.lbRequest.Size = new System.Drawing.Size(110, 364);
            this.lbRequest.TabIndex = 0;
            this.lbRequest.SelectedIndexChanged += new System.EventHandler(this.lbRequest_SelectedIndexChanged);
            // 
            // frmEndUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 481);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(600, 520);
            this.Name = "frmEndUser";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEndUser_FormClosing);
            this.Load += new System.EventHandler(this.frmEndUser_Load);
            this.pnlMain.ResumeLayout(false);
            this.tbMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSubType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxRequestType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpNeededDate;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lbRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserRemarks;
        private System.Windows.Forms.Label lblDateNeeded;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Label lblRequestType;
        private System.Windows.Forms.Label lblAdminRemarks;
        private System.Windows.Forms.Label lblHandedBy;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDateRequested;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbxUsers;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}