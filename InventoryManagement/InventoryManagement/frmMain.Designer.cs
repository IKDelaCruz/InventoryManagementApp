namespace InventoryManagement
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imgMainImage = new System.Windows.Forms.ImageList(this.components);
            this.cntxtMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBorrow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBroken = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRetire = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBarcode = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvMain = new System.Windows.Forms.ListView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.chkShowAllUser = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkShowAllLocation = new System.Windows.Forms.CheckBox();
            this.chkShowAllSubType = new System.Windows.Forms.CheckBox();
            this.chkShowAllType = new System.Windows.Forms.CheckBox();
            this.chkShowAllStatus = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSubtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.pnlRightInfo = new System.Windows.Forms.Panel();
            this.pnlRightContent = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbId = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPrintBarcode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLifeSpan = new System.Windows.Forms.Label();
            this.lblAssetTag = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDatePurchase = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblSubType = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSelectedItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxtMenuStrip.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlRightInfo.SuspendLayout();
            this.pnlRightContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbId)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgMainImage
            // 
            this.imgMainImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgMainImage.ImageSize = new System.Drawing.Size(48, 48);
            this.imgMainImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cntxtMenuStrip
            // 
            this.cntxtMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem,
            this.tsAction,
            this.tsBarcode});
            this.cntxtMenuStrip.Name = "cntxtMenuStrip";
            this.cntxtMenuStrip.Size = new System.Drawing.Size(153, 92);
            this.cntxtMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.cntxtMenuStrip_Opening);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.ownerToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sortByToolStripMenuItem.Text = "Sort By";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // ownerToolStripMenuItem
            // 
            this.ownerToolStripMenuItem.Name = "ownerToolStripMenuItem";
            this.ownerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ownerToolStripMenuItem.Text = "Owner";
            this.ownerToolStripMenuItem.Click += new System.EventHandler(this.ownerToolStripMenuItem_Click);
            // 
            // tsAction
            // 
            this.tsAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignToolStripMenuItem,
            this.tsBorrow,
            this.tsReserve,
            this.tsReturn,
            this.toolStripSeparator2,
            this.tsBroken,
            this.tsRetire,
            this.viewDetailsToolStripMenuItem});
            this.tsAction.Name = "tsAction";
            this.tsAction.Size = new System.Drawing.Size(152, 22);
            this.tsAction.Text = "Action";
            this.tsAction.Click += new System.EventHandler(this.tsAction_Click);
            // 
            // tsBorrow
            // 
            this.tsBorrow.Name = "tsBorrow";
            this.tsBorrow.Size = new System.Drawing.Size(152, 22);
            this.tsBorrow.Text = "Borrow";
            this.tsBorrow.Click += new System.EventHandler(this.tsBorrow_Click);
            // 
            // tsReserve
            // 
            this.tsReserve.Name = "tsReserve";
            this.tsReserve.Size = new System.Drawing.Size(152, 22);
            this.tsReserve.Text = "Reserve";
            this.tsReserve.Click += new System.EventHandler(this.tsReserve_Click);
            // 
            // tsReturn
            // 
            this.tsReturn.Name = "tsReturn";
            this.tsReturn.Size = new System.Drawing.Size(152, 22);
            this.tsReturn.Text = "Return";
            this.tsReturn.Click += new System.EventHandler(this.tsReturn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // tsBroken
            // 
            this.tsBroken.Name = "tsBroken";
            this.tsBroken.Size = new System.Drawing.Size(152, 22);
            this.tsBroken.Text = "Repair";
            this.tsBroken.Click += new System.EventHandler(this.tsBroken_Click_1);
            // 
            // tsRetire
            // 
            this.tsRetire.Name = "tsRetire";
            this.tsRetire.Size = new System.Drawing.Size(152, 22);
            this.tsRetire.Text = "Dispose";
            this.tsRetire.Click += new System.EventHandler(this.tsRetire_Click_1);
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // tsBarcode
            // 
            this.tsBarcode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.tsBarcode.Name = "tsBarcode";
            this.tsBarcode.Size = new System.Drawing.Size(152, 22);
            this.tsBarcode.Text = "Barcode";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMain.Size = new System.Drawing.Size(1035, 683);
            this.pnlMain.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 93);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1025, 585);
            this.panel1.TabIndex = 2;
            // 
            // lvMain
            // 
            this.lvMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMain.ContextMenuStrip = this.cntxtMenuStrip;
            this.lvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMain.LargeImageList = this.imgMainImage;
            this.lvMain.Location = new System.Drawing.Point(0, 5);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(1025, 580);
            this.lvMain.SmallImageList = this.imgMainImage;
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.SelectedIndexChanged += new System.EventHandler(this.lvMain_SelectedIndexChanged);
            this.lvMain.Click += new System.EventHandler(this.lvMain_Click);
            this.lvMain.DoubleClick += new System.EventHandler(this.lvMain_DoubleClick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.chkShowAllUser);
            this.pnlTop.Controls.Add(this.label15);
            this.pnlTop.Controls.Add(this.cbxUser);
            this.pnlTop.Controls.Add(this.txtScan);
            this.pnlTop.Controls.Add(this.label13);
            this.pnlTop.Controls.Add(this.chkShowAllLocation);
            this.pnlTop.Controls.Add(this.chkShowAllSubType);
            this.pnlTop.Controls.Add(this.chkShowAllType);
            this.pnlTop.Controls.Add(this.chkShowAllStatus);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Controls.Add(this.cbxLocation);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.cbxSubtype);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.cbxType);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.cbxStatus);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(5, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1025, 88);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // chkShowAllUser
            // 
            this.chkShowAllUser.AutoSize = true;
            this.chkShowAllUser.Checked = true;
            this.chkShowAllUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllUser.Location = new System.Drawing.Point(805, 61);
            this.chkShowAllUser.Name = "chkShowAllUser";
            this.chkShowAllUser.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllUser.TabIndex = 51;
            this.chkShowAllUser.Text = "Show All";
            this.chkShowAllUser.UseVisualStyleBackColor = true;
            this.chkShowAllUser.CheckedChanged += new System.EventHandler(this.UpdateView);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(802, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 15);
            this.label15.TabIndex = 50;
            this.label15.Text = "User";
            // 
            // cbxUser
            // 
            this.cbxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(805, 32);
            this.cbxUser.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(184, 23);
            this.cbxUser.TabIndex = 49;
            this.cbxUser.SelectedIndexChanged += new System.EventHandler(this.UpdateView);
            // 
            // txtScan
            // 
            this.txtScan.BackColor = System.Drawing.Color.Gainsboro;
            this.txtScan.Location = new System.Drawing.Point(35, 32);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(121, 23);
            this.txtScan.TabIndex = 48;
            this.txtScan.Click += new System.EventHandler(this.txtScan_Click);
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            this.txtScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScan_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 47;
            this.label13.Text = "&Scan Barcode:";
            // 
            // chkShowAllLocation
            // 
            this.chkShowAllLocation.AutoSize = true;
            this.chkShowAllLocation.Checked = true;
            this.chkShowAllLocation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllLocation.Location = new System.Drawing.Point(651, 61);
            this.chkShowAllLocation.Name = "chkShowAllLocation";
            this.chkShowAllLocation.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllLocation.TabIndex = 46;
            this.chkShowAllLocation.Text = "Show All";
            this.chkShowAllLocation.UseVisualStyleBackColor = true;
            this.chkShowAllLocation.CheckedChanged += new System.EventHandler(this.UpdateView);
            // 
            // chkShowAllSubType
            // 
            this.chkShowAllSubType.AutoSize = true;
            this.chkShowAllSubType.Checked = true;
            this.chkShowAllSubType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllSubType.Location = new System.Drawing.Point(497, 61);
            this.chkShowAllSubType.Name = "chkShowAllSubType";
            this.chkShowAllSubType.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllSubType.TabIndex = 45;
            this.chkShowAllSubType.Text = "Show All";
            this.chkShowAllSubType.UseVisualStyleBackColor = true;
            this.chkShowAllSubType.CheckedChanged += new System.EventHandler(this.UpdateView);
            // 
            // chkShowAllType
            // 
            this.chkShowAllType.AutoSize = true;
            this.chkShowAllType.Checked = true;
            this.chkShowAllType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllType.Location = new System.Drawing.Point(343, 61);
            this.chkShowAllType.Name = "chkShowAllType";
            this.chkShowAllType.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllType.TabIndex = 44;
            this.chkShowAllType.Text = "Show All";
            this.chkShowAllType.UseVisualStyleBackColor = true;
            this.chkShowAllType.CheckedChanged += new System.EventHandler(this.UpdateView);
            // 
            // chkShowAllStatus
            // 
            this.chkShowAllStatus.AutoSize = true;
            this.chkShowAllStatus.Checked = true;
            this.chkShowAllStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAllStatus.Location = new System.Drawing.Point(189, 61);
            this.chkShowAllStatus.Name = "chkShowAllStatus";
            this.chkShowAllStatus.Size = new System.Drawing.Size(73, 19);
            this.chkShowAllStatus.TabIndex = 43;
            this.chkShowAllStatus.Text = "Show All";
            this.chkShowAllStatus.UseVisualStyleBackColor = true;
            this.chkShowAllStatus.CheckedChanged += new System.EventHandler(this.UpdateView);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(648, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Location";
            // 
            // cbxLocation
            // 
            this.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Location = new System.Drawing.Point(651, 32);
            this.cbxLocation.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(121, 23);
            this.cbxLocation.TabIndex = 41;
            this.cbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbxLocation_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Sub-Type";
            // 
            // cbxSubtype
            // 
            this.cbxSubtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubtype.FormattingEnabled = true;
            this.cbxSubtype.Location = new System.Drawing.Point(497, 32);
            this.cbxSubtype.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbxSubtype.Name = "cbxSubtype";
            this.cbxSubtype.Size = new System.Drawing.Size(121, 23);
            this.cbxSubtype.TabIndex = 39;
            this.cbxSubtype.SelectedIndexChanged += new System.EventHandler(this.UpdateView);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Type";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(343, 32);
            this.cbxType.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 23);
            this.cbxType.TabIndex = 37;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(189, 32);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 23);
            this.cbxStatus.TabIndex = 0;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.UpdateView);
            // 
            // pnlRightInfo
            // 
            this.pnlRightInfo.Controls.Add(this.pnlRightContent);
            this.pnlRightInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightInfo.Location = new System.Drawing.Point(1035, 24);
            this.pnlRightInfo.Name = "pnlRightInfo";
            this.pnlRightInfo.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.pnlRightInfo.Size = new System.Drawing.Size(315, 683);
            this.pnlRightInfo.TabIndex = 2;
            // 
            // pnlRightContent
            // 
            this.pnlRightContent.BackColor = System.Drawing.Color.White;
            this.pnlRightContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRightContent.Controls.Add(this.groupBox1);
            this.pnlRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightContent.Location = new System.Drawing.Point(0, 5);
            this.pnlRightContent.Name = "pnlRightContent";
            this.pnlRightContent.Size = new System.Drawing.Size(310, 673);
            this.pnlRightContent.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbId);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnPrintBarcode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCurrentValue);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblLifeSpan);
            this.groupBox1.Controls.Add(this.lblAssetTag);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblDatePurchase);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblLastUpdate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.lblSubType);
            this.groupBox1.Controls.Add(this.lblOwner);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.lblBrand);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblSerial);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 646);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // pbId
            // 
            this.pbId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbId.Location = new System.Drawing.Point(25, 413);
            this.pbId.Name = "pbId";
            this.pbId.Size = new System.Drawing.Size(240, 180);
            this.pbId.TabIndex = 48;
            this.pbId.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 375);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label11.Size = new System.Drawing.Size(72, 35);
            this.label11.TabIndex = 37;
            this.label11.Text = "ITEM IMAGE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 90);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label9.Size = new System.Drawing.Size(78, 35);
            this.label9.TabIndex = 36;
            this.label9.Text = "ITEM DETAILS";
            // 
            // btnPrintBarcode
            // 
            this.btnPrintBarcode.Enabled = false;
            this.btnPrintBarcode.Location = new System.Drawing.Point(25, 599);
            this.btnPrintBarcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrintBarcode.Name = "btnPrintBarcode";
            this.btnPrintBarcode.Size = new System.Drawing.Size(240, 30);
            this.btnPrintBarcode.TabIndex = 35;
            this.btnPrintBarcode.Text = "Print Barcode Label";
            this.btnPrintBarcode.UseVisualStyleBackColor = true;
            this.btnPrintBarcode.Click += new System.EventHandler(this.btnPrintBarcode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.Location = new System.Drawing.Point(107, 360);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(174, 15);
            this.lblCurrentValue.TabIndex = 34;
            this.lblCurrentValue.Text = "-";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(107, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(167, 15);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "-";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(15, 360);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(81, 15);
            this.label35.TabIndex = 33;
            this.label35.Text = "Current Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Asset Tag";
            // 
            // lblLifeSpan
            // 
            this.lblLifeSpan.Location = new System.Drawing.Point(107, 345);
            this.lblLifeSpan.Name = "lblLifeSpan";
            this.lblLifeSpan.Size = new System.Drawing.Size(174, 15);
            this.lblLifeSpan.TabIndex = 32;
            this.lblLifeSpan.Text = "-";
            // 
            // lblAssetTag
            // 
            this.lblAssetTag.Location = new System.Drawing.Point(107, 43);
            this.lblAssetTag.Name = "lblAssetTag";
            this.lblAssetTag.Size = new System.Drawing.Size(167, 15);
            this.lblAssetTag.TabIndex = 3;
            this.lblAssetTag.Text = "-";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(15, 345);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 15);
            this.label28.TabIndex = 31;
            this.label28.Text = "LifeSpan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(107, 330);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(174, 15);
            this.lblAmount.TabIndex = 30;
            this.lblAmount.Text = "-";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(107, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(167, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "-";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(15, 330);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 15);
            this.label30.TabIndex = 29;
            this.label30.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Description";
            // 
            // lblDatePurchase
            // 
            this.lblDatePurchase.Location = new System.Drawing.Point(107, 315);
            this.lblDatePurchase.Name = "lblDatePurchase";
            this.lblDatePurchase.Size = new System.Drawing.Size(174, 15);
            this.lblDatePurchase.TabIndex = 28;
            this.lblDatePurchase.Text = "-";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(107, 73);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(167, 52);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "-";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(15, 315);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(86, 15);
            this.label32.TabIndex = 27;
            this.label32.Text = "Date Purchase";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Type";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(15, 280);
            this.label33.Name = "label33";
            this.label33.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label33.Size = new System.Drawing.Size(114, 35);
            this.label33.TabIndex = 26;
            this.label33.Text = "ITEM DEPRECIATION";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(107, 125);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(167, 15);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "-";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.Location = new System.Drawing.Point(107, 265);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(174, 15);
            this.lblLastUpdate.TabIndex = 25;
            this.lblLastUpdate.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Sub-Type";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(15, 265);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 15);
            this.label26.TabIndex = 24;
            this.label26.Text = "Last Update";
            // 
            // lblSubType
            // 
            this.lblSubType.Location = new System.Drawing.Point(107, 140);
            this.lblSubType.Name = "lblSubType";
            this.lblSubType.Size = new System.Drawing.Size(167, 15);
            this.lblSubType.TabIndex = 11;
            this.lblSubType.Text = "-";
            // 
            // lblOwner
            // 
            this.lblOwner.Location = new System.Drawing.Point(107, 250);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(174, 15);
            this.lblOwner.TabIndex = 23;
            this.lblOwner.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Brand";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(15, 250);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 15);
            this.label24.TabIndex = 22;
            this.label24.Text = "Current Owner";
            // 
            // lblBrand
            // 
            this.lblBrand.Location = new System.Drawing.Point(107, 155);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(167, 15);
            this.lblBrand.TabIndex = 13;
            this.lblBrand.Text = "-";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(107, 235);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(174, 15);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "Model";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 235);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 15);
            this.label22.TabIndex = 20;
            this.label22.Text = "Status";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(107, 170);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(167, 15);
            this.lblModel.TabIndex = 15;
            this.lblModel.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(15, 200);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label20.Size = new System.Drawing.Size(74, 35);
            this.label20.TabIndex = 19;
            this.label20.Text = "ITEM STATUS";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 15);
            this.label18.TabIndex = 16;
            this.label18.Text = "Serial";
            // 
            // lblSerial
            // 
            this.lblSerial.Location = new System.Drawing.Point(107, 185);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(174, 15);
            this.lblSerial.TabIndex = 17;
            this.lblSerial.Text = "-";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUsername,
            this.tsSelectedItem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssUsername
            // 
            this.tssUsername.Name = "tssUsername";
            this.tssUsername.Size = new System.Drawing.Size(84, 17);
            this.tssUsername.Text = "Current User []";
            // 
            // tsSelectedItem
            // 
            this.tsSelectedItem.Name = "tsSelectedItem";
            this.tsSelectedItem.Size = new System.Drawing.Size(81, 17);
            this.tsSelectedItem.Text = "Selected Item:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.requestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Visible = false;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.toolStripSeparator1,
            this.addToolStripMenuItem,
            this.addItemTypeToolStripMenuItem,
            this.manageBrandToolStripMenuItem,
            this.uploadItemsToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addToolStripMenuItem.Text = "Add Item";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addItemTypeToolStripMenuItem
            // 
            this.addItemTypeToolStripMenuItem.Name = "addItemTypeToolStripMenuItem";
            this.addItemTypeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addItemTypeToolStripMenuItem.Text = "Manage Types";
            this.addItemTypeToolStripMenuItem.Click += new System.EventHandler(this.addItemTypeToolStripMenuItem_Click);
            // 
            // manageBrandToolStripMenuItem
            // 
            this.manageBrandToolStripMenuItem.Name = "manageBrandToolStripMenuItem";
            this.manageBrandToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.manageBrandToolStripMenuItem.Text = "Manage Brand";
            this.manageBrandToolStripMenuItem.Click += new System.EventHandler(this.manageBrandToolStripMenuItem_Click);
            // 
            // uploadItemsToolStripMenuItem
            // 
            this.uploadItemsToolStripMenuItem.Name = "uploadItemsToolStripMenuItem";
            this.uploadItemsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.uploadItemsToolStripMenuItem.Text = "Upload Items";
            this.uploadItemsToolStripMenuItem.Click += new System.EventHandler(this.uploadItemsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.syncToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // syncToolStripMenuItem
            // 
            this.syncToolStripMenuItem.Name = "syncToolStripMenuItem";
            this.syncToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.syncToolStripMenuItem.Text = "Sync";
            this.syncToolStripMenuItem.Click += new System.EventHandler(this.syncToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSummaryToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // itemSummaryToolStripMenuItem
            // 
            this.itemSummaryToolStripMenuItem.Name = "itemSummaryToolStripMenuItem";
            this.itemSummaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itemSummaryToolStripMenuItem.Text = "Item Summary";
            this.itemSummaryToolStripMenuItem.Click += new System.EventHandler(this.itemSummaryToolStripMenuItem_Click);
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem1,
            this.createNewToolStripMenuItem});
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.requestToolStripMenuItem.Text = "Request";
            // 
            // manageToolStripMenuItem1
            // 
            this.manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            this.manageToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.manageToolStripMenuItem1.Text = "Manage";
            this.manageToolStripMenuItem1.Click += new System.EventHandler(this.manageToolStripMenuItem1_Click_1);
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.createNewToolStripMenuItem.Text = "Create New";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.createNewToolStripMenuItem_Click);
            // 
            // assignToolStripMenuItem
            // 
            this.assignToolStripMenuItem.Name = "assignToolStripMenuItem";
            this.assignToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.assignToolStripMenuItem.Text = "Assign";
            this.assignToolStripMenuItem.Click += new System.EventHandler(this.assignToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlRightInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cntxtMenuStrip.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlRightInfo.ResumeLayout(false);
            this.pnlRightContent.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbId)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imgMainImage;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssUsername;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.CheckBox chkShowAllLocation;
        private System.Windows.Forms.CheckBox chkShowAllSubType;
        private System.Windows.Forms.CheckBox chkShowAllType;
        private System.Windows.Forms.CheckBox chkShowAllStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSubtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRightInfo;
        private System.Windows.Forms.Panel pnlRightContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrintBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLifeSpan;
        private System.Windows.Forms.Label lblAssetTag;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDatePurchase;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblSubType;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem addItemTypeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem manageBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSummaryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cntxtMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAction;
        private System.Windows.Forms.ToolStripMenuItem tsBorrow;
        private System.Windows.Forms.ToolStripMenuItem tsReserve;
        private System.Windows.Forms.ToolStripMenuItem tsReturn;
        private System.Windows.Forms.ToolStripMenuItem tsRetire;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsBroken;
        private System.Windows.Forms.ToolStripMenuItem tsBarcode;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbId;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem1;
        private System.Windows.Forms.CheckBox chkShowAllUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.ToolStripMenuItem ownerToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsSelectedItem;
        private System.Windows.Forms.ToolStripMenuItem uploadItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignToolStripMenuItem;
    }
}

