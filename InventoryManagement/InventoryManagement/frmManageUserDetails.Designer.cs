namespace InventoryManagement
{
    partial class frmManageUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUserDetails));
            this.imgMainImage = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlUserInformation = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.lvMain = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dvLogs = new System.Windows.Forms.DataGridView();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlUserInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpUser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMainImage
            // 
            this.imgMainImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgMainImage.ImageSize = new System.Drawing.Size(48, 48);
            this.imgMainImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tabControl1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(555, 484);
            this.pnlMain.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 478);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.pnlUserInformation);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 408);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 26);
            this.label11.TabIndex = 101;
            this.label11.Text = "Account Information";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(317, 408);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlUserInformation
            // 
            this.pnlUserInformation.BackColor = System.Drawing.Color.White;
            this.pnlUserInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserInformation.Controls.Add(this.groupBox1);
            this.pnlUserInformation.Controls.Add(this.grpUser);
            this.pnlUserInformation.Location = new System.Drawing.Point(17, 52);
            this.pnlUserInformation.Name = "pnlUserInformation";
            this.pnlUserInformation.Padding = new System.Windows.Forms.Padding(20);
            this.pnlUserInformation.Size = new System.Drawing.Size(400, 350);
            this.pnlUserInformation.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxUserType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxCompany);
            this.groupBox1.Controls.Add(this.cbxDepartment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(22, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 126);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membership Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "User Type";
            // 
            // cbxUserType
            // 
            this.cbxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Location = new System.Drawing.Point(127, 25);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(196, 23);
            this.cbxUserType.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "Department";
            // 
            // cbxCompany
            // 
            this.cbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(127, 54);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(196, 23);
            this.cbxCompany.TabIndex = 44;
            this.cbxCompany.SelectedIndexChanged += new System.EventHandler(this.cbxCompany_SelectedIndexChanged);
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(127, 83);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(196, 23);
            this.cbxDepartment.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Company";
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.label1);
            this.grpUser.Controls.Add(this.label7);
            this.grpUser.Controls.Add(this.txtPassword);
            this.grpUser.Controls.Add(this.txtLastname);
            this.grpUser.Controls.Add(this.txtUsername);
            this.grpUser.Controls.Add(this.label6);
            this.grpUser.Controls.Add(this.label2);
            this.grpUser.Controls.Add(this.txtFirstname);
            this.grpUser.Location = new System.Drawing.Point(23, 23);
            this.grpUser.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(348, 166);
            this.grpUser.TabIndex = 52;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "User Information";
            this.grpUser.Enter += new System.EventHandler(this.grpUser_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "Lastname";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(127, 50);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(127, 125);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(196, 23);
            this.txtLastname.TabIndex = 50;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(127, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(196, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(127, 96);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(196, 23);
            this.txtFirstname.TabIndex = 48;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lvMain);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 26);
            this.label9.TabIndex = 102;
            this.label9.Text = "User Items";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvMain
            // 
            this.lvMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMain.Location = new System.Drawing.Point(18, 52);
            this.lvMain.MultiSelect = false;
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(508, 384);
            this.lvMain.TabIndex = 1;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.DoubleClick += new System.EventHandler(this.lvMain_DoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btnFilter);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.dtpTo);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.dtpFrom);
            this.tabPage3.Controls.Add(this.dvLogs);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(545, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User Logs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 26);
            this.label10.TabIndex = 103;
            this.label10.Text = "User Logs";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(428, 60);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 68;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 67;
            this.label8.Text = "End Date";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(319, 62);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(100, 23);
            this.dtpTo.TabIndex = 66;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(69, 68);
            this.label15.Margin = new System.Windows.Forms.Padding(5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 65;
            this.label15.Text = "Begin Date";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(144, 62);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(100, 23);
            this.dtpFrom.TabIndex = 64;
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
            this.ItemName});
            this.dvLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvLogs.Location = new System.Drawing.Point(18, 96);
            this.dvLogs.Name = "dvLogs";
            this.dvLogs.RowHeadersVisible = false;
            this.dvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvLogs.ShowCellErrors = false;
            this.dvLogs.ShowCellToolTips = false;
            this.dvLogs.ShowEditingIcon = false;
            this.dvLogs.ShowRowErrors = false;
            this.dvLogs.Size = new System.Drawing.Size(510, 337);
            this.dvLogs.TabIndex = 63;
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
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 150;
            // 
            // frmManageUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 508);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageUserDetails";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage User";
            this.Load += new System.EventHandler(this.frmManageUserInfo_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlUserInformation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlUserInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUserType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ImageList imgMainImage;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DataGridView dvLogs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.Panel pnlMain;
    }
}