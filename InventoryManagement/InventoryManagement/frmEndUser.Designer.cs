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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tbMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(553, 399);
            this.pnlMain.TabIndex = 2;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tabPage1);
            this.tbMain.Controls.Add(this.tabPage2);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.ItemSize = new System.Drawing.Size(115, 30);
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(551, 397);
            this.tbMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnSubmit);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(23);
            this.tabPage1.Size = new System.Drawing.Size(543, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create new Request";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(30, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 236);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Details";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 53);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 15);
            this.label23.TabIndex = 61;
            this.label23.Text = "Item Type";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(118, 50);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(182, 23);
            this.cbxType.TabIndex = 60;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 142);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 15);
            this.label22.TabIndex = 59;
            this.label22.Text = "Requested By";
            // 
            // cbxUsers
            // 
            this.cbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.Location = new System.Drawing.Point(118, 139);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(312, 23);
            this.cbxUsers.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Request Type";
            // 
            // txtAssetTag
            // 
            this.txtRemarks.Enabled = false;
            this.txtRemarks.Location = new System.Drawing.Point(118, 168);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtAssetTag";
            this.txtRemarks.Size = new System.Drawing.Size(312, 51);
            this.txtRemarks.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Remark";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 57;
            this.label15.Text = "Date Needed";
            // 
            // cbxRequestType
            // 
            this.cbxRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRequestType.FormattingEnabled = true;
            this.cbxRequestType.Location = new System.Drawing.Point(118, 21);
            this.cbxRequestType.Name = "cbxRequestType";
            this.cbxRequestType.Size = new System.Drawing.Size(182, 23);
            this.cbxRequestType.TabIndex = 51;
            // 
            // dtpNeededDate
            // 
            this.dtpNeededDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNeededDate.Location = new System.Drawing.Point(118, 110);
            this.dtpNeededDate.Name = "dtpNeededDate";
            this.dtpNeededDate.Size = new System.Drawing.Size(182, 23);
            this.dtpNeededDate.TabIndex = 56;
            // 
            // cbxSubType
            // 
            this.cbxSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubType.FormattingEnabled = true;
            this.cbxSubType.Location = new System.Drawing.Point(118, 79);
            this.cbxSubType.Name = "cbxSubType";
            this.cbxSubType.Size = new System.Drawing.Size(182, 23);
            this.cbxSubType.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Sub Type";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 316);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(415, 316);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 58;
            this.btnSubmit.Text = "Submit Request";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(27, 23);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 0, 3, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(456, 66);
            this.label21.TabIndex = 50;
            this.label21.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean maximus turpis to" +
    "rtor, vitae mollis arcu pellentesque sit amet. Curabitur dapibus ipsum tortor, s" +
    "ed fringilla tortor tempor eu. ";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lbRequest);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage2.Size = new System.Drawing.Size(543, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Request Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(190, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 125);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request Status";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(18, 19);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(6);
            this.label18.Size = new System.Drawing.Size(53, 27);
            this.label18.TabIndex = 66;
            this.label18.Text = "Status";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 46);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(6);
            this.label17.Size = new System.Drawing.Size(80, 27);
            this.label17.TabIndex = 67;
            this.label17.Text = "Handled By";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(128, 71);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(6);
            this.label12.Size = new System.Drawing.Size(176, 65);
            this.label12.TabIndex = 71;
            this.label12.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 72);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(6);
            this.label16.Size = new System.Drawing.Size(66, 27);
            this.label16.TabIndex = 68;
            this.label16.Text = "Remarks";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(128, 46);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(6);
            this.label13.Size = new System.Drawing.Size(176, 27);
            this.label13.TabIndex = 70;
            this.label13.Text = "-";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(128, 19);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(6);
            this.label14.Size = new System.Drawing.Size(176, 27);
            this.label14.TabIndex = 69;
            this.label14.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(190, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 180);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Deails";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(6);
            this.label5.Size = new System.Drawing.Size(45, 27);
            this.label5.TabIndex = 59;
            this.label5.Text = "Type";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(128, 99);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(6);
            this.label19.Size = new System.Drawing.Size(176, 27);
            this.label19.TabIndex = 73;
            this.label19.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 126);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(6);
            this.label6.Size = new System.Drawing.Size(66, 27);
            this.label6.TabIndex = 58;
            this.label6.Text = "Remarks";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 99);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(6);
            this.label20.Size = new System.Drawing.Size(107, 27);
            this.label20.TabIndex = 72;
            this.label20.Text = "Date Requested";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 46);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(6);
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 60;
            this.label4.Text = "Sub Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6);
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 61;
            this.label2.Text = "Date Needed";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(128, 19);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(6);
            this.label9.Size = new System.Drawing.Size(176, 27);
            this.label9.TabIndex = 62;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(128, 46);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(6);
            this.label8.Size = new System.Drawing.Size(176, 27);
            this.label8.TabIndex = 63;
            this.label8.Text = "-";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 72);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(6);
            this.label7.Size = new System.Drawing.Size(176, 27);
            this.label7.TabIndex = 64;
            this.label7.Text = "-";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(128, 126);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(6);
            this.label11.Size = new System.Drawing.Size(176, 65);
            this.label11.TabIndex = 65;
            this.label11.Text = "-";
            // 
            // lbRequest
            // 
            this.lbRequest.FormattingEnabled = true;
            this.lbRequest.ItemHeight = 15;
            this.lbRequest.Location = new System.Drawing.Point(23, 23);
            this.lbRequest.Name = "lbRequest";
            this.lbRequest.Size = new System.Drawing.Size(148, 304);
            this.lbRequest.TabIndex = 0;
            // 
            // frmEndUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 428);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEndUser";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEndUser";
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbxUsers;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbxType;
    }
}