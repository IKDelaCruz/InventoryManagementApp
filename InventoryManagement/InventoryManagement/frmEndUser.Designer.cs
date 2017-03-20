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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEndUser));
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlTab1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpExpectedReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbxUsers = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpNeededDate = new System.Windows.Forms.DateTimePicker();
            this.cbxSubType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitReserve = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlRepair = new System.Windows.Forms.Panel();
            this.btnSubmitRepair = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxUserItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlTab2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtRequestStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRequestHandledBy = new System.Windows.Forms.TextBox();
            this.txtRequestType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDateNeeded = new System.Windows.Forms.TextBox();
            this.txtUserRemarks = new System.Windows.Forms.TextBox();
            this.txtDateRequested = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.trMain = new System.Windows.Forms.TreeView();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxUsersRepair = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlTab1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlRepair.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlTab2.SuspendLayout();
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
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tbMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(553, 484);
            this.pnlMain.TabIndex = 2;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tabPage1);
            this.tbMain.Controls.Add(this.tabPage3);
            this.tbMain.Controls.Add(this.tabPage2);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.ItemSize = new System.Drawing.Size(30, 30);
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.Padding = new System.Drawing.Point(10, 5);
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(551, 482);
            this.tbMain.TabIndex = 1;
            this.tbMain.SelectedIndexChanged += new System.EventHandler(this.tbMain_SelectedIndexChanged);
            this.tbMain.Click += new System.EventHandler(this.tbMain_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reserve";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlTab1
            // 
            this.pnlTab1.Controls.Add(this.label11);
            this.pnlTab1.Controls.Add(this.label21);
            this.pnlTab1.Controls.Add(this.groupBox1);
            this.pnlTab1.Controls.Add(this.btnSubmitReserve);
            this.pnlTab1.Controls.Add(this.btnCancel);
            this.pnlTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTab1.Location = new System.Drawing.Point(3, 3);
            this.pnlTab1.Name = "pnlTab1";
            this.pnlTab1.Size = new System.Drawing.Size(537, 438);
            this.pnlTab1.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 26);
            this.label11.TabIndex = 99;
            this.label11.Text = "Reserve Item";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(9, 46);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 0, 3, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(509, 44);
            this.label21.TabIndex = 50;
            this.label21.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean maximus turpis to" +
    "rtor, vitae mollis arcu pellentesque sit amet. Curabitur dapibus ipsum tortor, s" +
    "ed fringilla tortor tempor eu. ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpExpectedReturnDate);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.cbxUsers);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.dtpNeededDate);
            this.groupBox1.Controls.Add(this.cbxSubType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 282);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(237, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 15);
            this.label12.TabIndex = 63;
            this.label12.Text = "Expected Return Date";
            // 
            // dtpExpectedReturnDate
            // 
            this.dtpExpectedReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpectedReturnDate.Location = new System.Drawing.Point(237, 41);
            this.dtpExpectedReturnDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpExpectedReturnDate.Name = "dtpExpectedReturnDate";
            this.dtpExpectedReturnDate.Size = new System.Drawing.Size(186, 23);
            this.dtpExpectedReturnDate.TabIndex = 62;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 74);
            this.label23.Margin = new System.Windows.Forms.Padding(5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 15);
            this.label23.TabIndex = 61;
            this.label23.Text = "Item Type";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(15, 92);
            this.cbxType.Margin = new System.Windows.Forms.Padding(5);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(185, 23);
            this.cbxType.TabIndex = 60;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 125);
            this.label22.Margin = new System.Windows.Forms.Padding(5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 15);
            this.label22.TabIndex = 59;
            this.label22.Text = "Requested By";
            // 
            // cbxUsers
            // 
            this.cbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.Location = new System.Drawing.Point(15, 143);
            this.cbxUsers.Margin = new System.Windows.Forms.Padding(5);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(411, 23);
            this.cbxUsers.TabIndex = 58;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(16, 194);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(474, 68);
            this.txtRemarks.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Remark";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 57;
            this.label15.Text = "Date Needed";
            // 
            // dtpNeededDate
            // 
            this.dtpNeededDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNeededDate.Location = new System.Drawing.Point(15, 41);
            this.dtpNeededDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpNeededDate.Name = "dtpNeededDate";
            this.dtpNeededDate.Size = new System.Drawing.Size(186, 23);
            this.dtpNeededDate.TabIndex = 56;
            // 
            // cbxSubType
            // 
            this.cbxSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubType.FormattingEnabled = true;
            this.cbxSubType.Location = new System.Drawing.Point(237, 92);
            this.cbxSubType.Margin = new System.Windows.Forms.Padding(5);
            this.cbxSubType.Name = "cbxSubType";
            this.cbxSubType.Size = new System.Drawing.Size(186, 23);
            this.cbxSubType.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Sub Type";
            // 
            // btnSubmitReserve
            // 
            this.btnSubmitReserve.Location = new System.Drawing.Point(418, 383);
            this.btnSubmitReserve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmitReserve.Name = "btnSubmitReserve";
            this.btnSubmitReserve.Size = new System.Drawing.Size(100, 30);
            this.btnSubmitReserve.TabIndex = 58;
            this.btnSubmitReserve.Text = "Submit Request";
            this.btnSubmitReserve.UseVisualStyleBackColor = true;
            this.btnSubmitReserve.Click += new System.EventHandler(this.btnSubmitReserve_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 383);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlRepair);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(543, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Repair";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlRepair
            // 
            this.pnlRepair.Controls.Add(this.btnSubmitRepair);
            this.pnlRepair.Controls.Add(this.button2);
            this.pnlRepair.Controls.Add(this.label14);
            this.pnlRepair.Controls.Add(this.groupBox3);
            this.pnlRepair.Controls.Add(this.label16);
            this.pnlRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRepair.Location = new System.Drawing.Point(3, 3);
            this.pnlRepair.Name = "pnlRepair";
            this.pnlRepair.Size = new System.Drawing.Size(537, 438);
            this.pnlRepair.TabIndex = 103;
            // 
            // btnSubmitRepair
            // 
            this.btnSubmitRepair.Location = new System.Drawing.Point(418, 383);
            this.btnSubmitRepair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmitRepair.Name = "btnSubmitRepair";
            this.btnSubmitRepair.Size = new System.Drawing.Size(100, 30);
            this.btnSubmitRepair.TabIndex = 103;
            this.btnSubmitRepair.Text = "Submit Request";
            this.btnSubmitRepair.UseVisualStyleBackColor = true;
            this.btnSubmitRepair.Click += new System.EventHandler(this.btnSubmitRepair_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 383);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 104;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(10, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 26);
            this.label14.TabIndex = 101;
            this.label14.Text = "Repair Item";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.cbxUsersRepair);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cbxUserItem);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(9, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 282);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 15);
            this.label13.TabIndex = 58;
            this.label13.Text = "Select which user item:";
            // 
            // cbxUserItem
            // 
            this.cbxUserItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserItem.FormattingEnabled = true;
            this.cbxUserItem.Location = new System.Drawing.Point(18, 93);
            this.cbxUserItem.Margin = new System.Windows.Forms.Padding(5);
            this.cbxUserItem.Name = "cbxUserItem";
            this.cbxUserItem.Size = new System.Drawing.Size(411, 23);
            this.cbxUserItem.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "Remark";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 68);
            this.textBox1.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(9, 46);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 0, 3, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(509, 44);
            this.label16.TabIndex = 100;
            this.label16.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean maximus turpis to" +
    "rtor, vitae mollis arcu pellentesque sit amet. Curabitur dapibus ipsum tortor, s" +
    "ed fringilla tortor tempor eu. ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlTab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Request";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlTab2
            // 
            this.pnlTab2.Controls.Add(this.groupBox2);
            this.pnlTab2.Controls.Add(this.label19);
            this.pnlTab2.Controls.Add(this.trMain);
            this.pnlTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTab2.Location = new System.Drawing.Point(3, 3);
            this.pnlTab2.Name = "pnlTab2";
            this.pnlTab2.Size = new System.Drawing.Size(537, 438);
            this.pnlTab2.TabIndex = 77;
            this.pnlTab2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTab2_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAdminRemarks);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtRequestStatus);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRequestHandledBy);
            this.groupBox2.Controls.Add(this.txtRequestType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtItemType);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDateNeeded);
            this.groupBox2.Controls.Add(this.txtUserRemarks);
            this.groupBox2.Controls.Add(this.txtDateRequested);
            this.groupBox2.Location = new System.Drawing.Point(201, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 372);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 78;
            this.label5.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "Date Needed";
            // 
            // txtAdminRemarks
            // 
            this.txtAdminRemarks.Location = new System.Drawing.Point(128, 300);
            this.txtAdminRemarks.Multiline = true;
            this.txtAdminRemarks.Name = "txtAdminRemarks";
            this.txtAdminRemarks.ReadOnly = true;
            this.txtAdminRemarks.Size = new System.Drawing.Size(176, 54);
            this.txtAdminRemarks.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 79;
            this.label4.Text = "ItemType";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 96;
            this.label9.Text = "Remarks";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(17, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 15);
            this.label20.TabIndex = 85;
            this.label20.Text = "Date Requested";
            // 
            // txtRequestStatus
            // 
            this.txtRequestStatus.Location = new System.Drawing.Point(128, 271);
            this.txtRequestStatus.Name = "txtRequestStatus";
            this.txtRequestStatus.ReadOnly = true;
            this.txtRequestStatus.Size = new System.Drawing.Size(176, 23);
            this.txtRequestStatus.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 77;
            this.label6.Text = "Remarks";
            // 
            // txtRequestHandledBy
            // 
            this.txtRequestHandledBy.Location = new System.Drawing.Point(128, 242);
            this.txtRequestHandledBy.Name = "txtRequestHandledBy";
            this.txtRequestHandledBy.ReadOnly = true;
            this.txtRequestHandledBy.Size = new System.Drawing.Size(176, 23);
            this.txtRequestHandledBy.TabIndex = 94;
            // 
            // txtRequestType
            // 
            this.txtRequestType.Location = new System.Drawing.Point(128, 26);
            this.txtRequestType.Name = "txtRequestType";
            this.txtRequestType.ReadOnly = true;
            this.txtRequestType.Size = new System.Drawing.Size(176, 23);
            this.txtRequestType.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 92;
            this.label7.Text = "Handled By";
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(128, 55);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.ReadOnly = true;
            this.txtItemType.Size = new System.Drawing.Size(176, 23);
            this.txtItemType.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 93;
            this.label8.Text = "Status";
            // 
            // txtDateNeeded
            // 
            this.txtDateNeeded.Location = new System.Drawing.Point(128, 84);
            this.txtDateNeeded.Name = "txtDateNeeded";
            this.txtDateNeeded.ReadOnly = true;
            this.txtDateNeeded.Size = new System.Drawing.Size(176, 23);
            this.txtDateNeeded.TabIndex = 89;
            // 
            // txtUserRemarks
            // 
            this.txtUserRemarks.Location = new System.Drawing.Point(128, 142);
            this.txtUserRemarks.Multiline = true;
            this.txtUserRemarks.Name = "txtUserRemarks";
            this.txtUserRemarks.ReadOnly = true;
            this.txtUserRemarks.Size = new System.Drawing.Size(176, 54);
            this.txtUserRemarks.TabIndex = 91;
            // 
            // txtDateRequested
            // 
            this.txtDateRequested.Location = new System.Drawing.Point(128, 113);
            this.txtDateRequested.Name = "txtDateRequested";
            this.txtDateRequested.ReadOnly = true;
            this.txtDateRequested.Size = new System.Drawing.Size(176, 23);
            this.txtDateRequested.TabIndex = 90;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(10, 10);
            this.label19.Margin = new System.Windows.Forms.Padding(10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 26);
            this.label19.TabIndex = 98;
            this.label19.Text = "Ticket Details";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // trMain
            // 
            this.trMain.Location = new System.Drawing.Point(10, 49);
            this.trMain.Name = "trMain";
            this.trMain.Size = new System.Drawing.Size(183, 365);
            this.trMain.TabIndex = 76;
            this.trMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trMain_AfterSelect);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 24);
            this.label17.Margin = new System.Windows.Forms.Padding(5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 15);
            this.label17.TabIndex = 61;
            this.label17.Text = "Requested By";
            // 
            // cbxUsersRepair
            // 
            this.cbxUsersRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsersRepair.FormattingEnabled = true;
            this.cbxUsersRepair.Location = new System.Drawing.Point(18, 42);
            this.cbxUsersRepair.Margin = new System.Windows.Forms.Padding(5);
            this.cbxUsersRepair.Name = "cbxUsersRepair";
            this.cbxUsersRepair.Size = new System.Drawing.Size(411, 23);
            this.cbxUsersRepair.TabIndex = 60;
            this.cbxUsersRepair.SelectedIndexChanged += new System.EventHandler(this.cbxUsersRepair_SelectedIndexChanged);
            // 
            // frmEndUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 508);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.tabPage3.ResumeLayout(false);
            this.pnlRepair.ResumeLayout(false);
            this.pnlRepair.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlTab2.ResumeLayout(false);
            this.pnlTab2.PerformLayout();
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpNeededDate;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSubmitReserve;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpExpectedReturnDate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUserItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnlRepair;
        private System.Windows.Forms.Button btnSubmitRepair;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxUsersRepair;
    }
}