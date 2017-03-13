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
            this.pnlTab1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlTab2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAdminRemarks = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRequestStatus = new System.Windows.Forms.TextBox();
            this.txtRequestHandledBy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserRemarks = new System.Windows.Forms.TextBox();
            this.txtDateRequested = new System.Windows.Forms.TextBox();
            this.txtDateNeeded = new System.Windows.Forms.TextBox();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.txtRequestType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trMain = new System.Windows.Forms.TreeView();
            this.pnlMain.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlTab1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlTab2.SuspendLayout();
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
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tbMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(553, 537);
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
            this.tbMain.Size = new System.Drawing.Size(551, 535);
            this.tbMain.TabIndex = 1;
            this.tbMain.SelectedIndexChanged += new System.EventHandler(this.tbMain_SelectedIndexChanged);
            this.tbMain.Click += new System.EventHandler(this.tbMain_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create new Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlTab1
            // 
            this.pnlTab1.Controls.Add(this.label11);
            this.pnlTab1.Controls.Add(this.label21);
            this.pnlTab1.Controls.Add(this.groupBox1);
            this.pnlTab1.Controls.Add(this.btnSubmit);
            this.pnlTab1.Controls.Add(this.btnCancel);
            this.pnlTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTab1.Location = new System.Drawing.Point(3, 3);
            this.pnlTab1.Name = "pnlTab1";
            this.pnlTab1.Size = new System.Drawing.Size(537, 486);
            this.pnlTab1.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 26);
            this.label11.TabIndex = 99;
            this.label11.Text = "Create New Request";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(9, 46);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 0, 3, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(414, 52);
            this.label21.TabIndex = 50;
            this.label21.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean maximus turpis to" +
    "rtor, vitae mollis arcu pellentesque sit amet. Curabitur dapibus ipsum tortor, s" +
    "ed fringilla tortor tempor eu. ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 289);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Details";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(161, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 15);
            this.label23.TabIndex = 61;
            this.label23.Text = "Item Type";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(164, 42);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(140, 23);
            this.cbxType.TabIndex = 60;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(164, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 15);
            this.label22.TabIndex = 59;
            this.label22.Text = "Requested By";
            // 
            // cbxUsers
            // 
            this.cbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.Location = new System.Drawing.Point(165, 86);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(285, 23);
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
            this.txtRemarks.Location = new System.Drawing.Point(18, 130);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(474, 140);
            this.txtRemarks.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 112);
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
            this.cbxRequestType.Size = new System.Drawing.Size(140, 23);
            this.cbxRequestType.TabIndex = 51;
            // 
            // dtpNeededDate
            // 
            this.dtpNeededDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNeededDate.Location = new System.Drawing.Point(18, 86);
            this.dtpNeededDate.Name = "dtpNeededDate";
            this.dtpNeededDate.Size = new System.Drawing.Size(140, 23);
            this.dtpNeededDate.TabIndex = 56;
            // 
            // cbxSubType
            // 
            this.cbxSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubType.FormattingEnabled = true;
            this.cbxSubType.Location = new System.Drawing.Point(310, 42);
            this.cbxSubType.Name = "cbxSubType";
            this.cbxSubType.Size = new System.Drawing.Size(140, 23);
            this.cbxSubType.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Sub Type";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(418, 398);
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
            this.btnCancel.Location = new System.Drawing.Point(310, 398);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlTab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Request";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlTab2
            // 
            this.pnlTab2.Controls.Add(this.label19);
            this.pnlTab2.Controls.Add(this.txtAdminRemarks);
            this.pnlTab2.Controls.Add(this.label9);
            this.pnlTab2.Controls.Add(this.txtRequestStatus);
            this.pnlTab2.Controls.Add(this.txtRequestHandledBy);
            this.pnlTab2.Controls.Add(this.label7);
            this.pnlTab2.Controls.Add(this.label8);
            this.pnlTab2.Controls.Add(this.txtUserRemarks);
            this.pnlTab2.Controls.Add(this.txtDateRequested);
            this.pnlTab2.Controls.Add(this.txtDateNeeded);
            this.pnlTab2.Controls.Add(this.txtItemType);
            this.pnlTab2.Controls.Add(this.txtRequestType);
            this.pnlTab2.Controls.Add(this.label5);
            this.pnlTab2.Controls.Add(this.label6);
            this.pnlTab2.Controls.Add(this.label20);
            this.pnlTab2.Controls.Add(this.label4);
            this.pnlTab2.Controls.Add(this.label2);
            this.pnlTab2.Controls.Add(this.trMain);
            this.pnlTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTab2.Location = new System.Drawing.Point(3, 3);
            this.pnlTab2.Name = "pnlTab2";
            this.pnlTab2.Size = new System.Drawing.Size(537, 486);
            this.pnlTab2.TabIndex = 77;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 10);
            this.label19.Margin = new System.Windows.Forms.Padding(10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 26);
            this.label19.TabIndex = 98;
            this.label19.Text = "Ticket Details";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // txtAdminRemarks
            // 
            this.txtAdminRemarks.Location = new System.Drawing.Point(316, 300);
            this.txtAdminRemarks.Multiline = true;
            this.txtAdminRemarks.Name = "txtAdminRemarks";
            this.txtAdminRemarks.ReadOnly = true;
            this.txtAdminRemarks.Size = new System.Drawing.Size(176, 74);
            this.txtAdminRemarks.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(205, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 96;
            this.label9.Text = "Remarks";
            // 
            // txtRequestStatus
            // 
            this.txtRequestStatus.Location = new System.Drawing.Point(316, 271);
            this.txtRequestStatus.Name = "txtRequestStatus";
            this.txtRequestStatus.ReadOnly = true;
            this.txtRequestStatus.Size = new System.Drawing.Size(176, 23);
            this.txtRequestStatus.TabIndex = 95;
            // 
            // txtRequestHandledBy
            // 
            this.txtRequestHandledBy.Location = new System.Drawing.Point(316, 242);
            this.txtRequestHandledBy.Name = "txtRequestHandledBy";
            this.txtRequestHandledBy.ReadOnly = true;
            this.txtRequestHandledBy.Size = new System.Drawing.Size(176, 23);
            this.txtRequestHandledBy.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 92;
            this.label7.Text = "Handled By";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 93;
            this.label8.Text = "Status";
            // 
            // txtUserRemarks
            // 
            this.txtUserRemarks.Location = new System.Drawing.Point(316, 162);
            this.txtUserRemarks.Multiline = true;
            this.txtUserRemarks.Name = "txtUserRemarks";
            this.txtUserRemarks.ReadOnly = true;
            this.txtUserRemarks.Size = new System.Drawing.Size(176, 74);
            this.txtUserRemarks.TabIndex = 91;
            // 
            // txtDateRequested
            // 
            this.txtDateRequested.Location = new System.Drawing.Point(316, 133);
            this.txtDateRequested.Name = "txtDateRequested";
            this.txtDateRequested.ReadOnly = true;
            this.txtDateRequested.Size = new System.Drawing.Size(176, 23);
            this.txtDateRequested.TabIndex = 90;
            // 
            // txtDateNeeded
            // 
            this.txtDateNeeded.Location = new System.Drawing.Point(316, 104);
            this.txtDateNeeded.Name = "txtDateNeeded";
            this.txtDateNeeded.ReadOnly = true;
            this.txtDateNeeded.Size = new System.Drawing.Size(176, 23);
            this.txtDateNeeded.TabIndex = 89;
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(316, 75);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.ReadOnly = true;
            this.txtItemType.Size = new System.Drawing.Size(176, 23);
            this.txtItemType.TabIndex = 88;
            // 
            // txtRequestType
            // 
            this.txtRequestType.Location = new System.Drawing.Point(316, 46);
            this.txtRequestType.Name = "txtRequestType";
            this.txtRequestType.ReadOnly = true;
            this.txtRequestType.Size = new System.Drawing.Size(176, 23);
            this.txtRequestType.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 78;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 77;
            this.label6.Text = "Remarks";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(205, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 15);
            this.label20.TabIndex = 85;
            this.label20.Text = "Date Requested";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 79;
            this.label4.Text = "ItemType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "Date Needed";
            // 
            // trMain
            // 
            this.trMain.Location = new System.Drawing.Point(12, 49);
            this.trMain.Name = "trMain";
            this.trMain.Size = new System.Drawing.Size(183, 325);
            this.trMain.TabIndex = 76;
            this.trMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trMain_AfterSelect);
            // 
            // frmEndUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 561);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEndUser";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEndUser_FormClosing);
            this.Load += new System.EventHandler(this.frmEndUser_Load);
            this.pnlMain.ResumeLayout(false);
            this.tbMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlTab1.ResumeLayout(false);
            this.pnlTab1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlTab2.ResumeLayout(false);
            this.pnlTab2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbxUsers;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.TreeView trMain;
        private System.Windows.Forms.Panel pnlTab1;
        private System.Windows.Forms.Panel pnlTab2;
        private System.Windows.Forms.TextBox txtDateRequested;
        private System.Windows.Forms.TextBox txtDateNeeded;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.TextBox txtRequestType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminRemarks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRequestStatus;
        private System.Windows.Forms.TextBox txtRequestHandledBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserRemarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
    }
}