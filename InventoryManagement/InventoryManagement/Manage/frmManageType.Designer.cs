namespace InventoryManagement.Manage
{
    partial class frmManageType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageType));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnChangeIcon = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.chkIsParentCateogry = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dvTypes = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.clnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxParent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnChangeIcon);
            this.pnlMain.Controls.Add(this.btnImage);
            this.pnlMain.Controls.Add(this.chkIsParentCateogry);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.dvTypes);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtDescription);
            this.pnlMain.Controls.Add(this.label16);
            this.pnlMain.Controls.Add(this.cbxParent);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.btnAddType);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(746, 460);
            this.pnlMain.TabIndex = 6;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnChangeIcon
            // 
            this.btnChangeIcon.AutoEllipsis = true;
            this.btnChangeIcon.Location = new System.Drawing.Point(412, 389);
            this.btnChangeIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeIcon.Name = "btnChangeIcon";
            this.btnChangeIcon.Size = new System.Drawing.Size(100, 30);
            this.btnChangeIcon.TabIndex = 68;
            this.btnChangeIcon.Text = "Change Icon";
            this.btnChangeIcon.UseVisualStyleBackColor = true;
            this.btnChangeIcon.Click += new System.EventHandler(this.btnChangeIcon_Click);
            // 
            // btnImage
            // 
            this.btnImage.AutoEllipsis = true;
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImage.Location = new System.Drawing.Point(173, 63);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(51, 46);
            this.btnImage.TabIndex = 67;
            this.btnImage.Text = "...";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // chkIsParentCateogry
            // 
            this.chkIsParentCateogry.AutoSize = true;
            this.chkIsParentCateogry.Location = new System.Drawing.Point(16, 224);
            this.chkIsParentCateogry.Name = "chkIsParentCateogry";
            this.chkIsParentCateogry.Size = new System.Drawing.Size(162, 19);
            this.chkIsParentCateogry.TabIndex = 66;
            this.chkIsParentCateogry.Text = "This is a Parent Cateogry";
            this.chkIsParentCateogry.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoEllipsis = true;
            this.btnDelete.Location = new System.Drawing.Point(304, 389);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Types";
            // 
            // dvTypes
            // 
            this.dvTypes.AllowUserToAddRows = false;
            this.dvTypes.AllowUserToDeleteRows = false;
            this.dvTypes.AllowUserToResizeRows = false;
            this.dvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnName,
            this.Usage,
            this.Picture,
            this.clnDescription});
            this.dvTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvTypes.Location = new System.Drawing.Point(304, 71);
            this.dvTypes.MultiSelect = false;
            this.dvTypes.Name = "dvTypes";
            this.dvTypes.ReadOnly = true;
            this.dvTypes.RowHeadersVisible = false;
            this.dvTypes.RowTemplate.Height = 60;
            this.dvTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvTypes.ShowEditingIcon = false;
            this.dvTypes.Size = new System.Drawing.Size(413, 312);
            this.dvTypes.TabIndex = 61;
            this.dvTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvTypes_CellClick);
            this.dvTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvTypes_CellContentClick);
            this.dvTypes.SelectionChanged += new System.EventHandler(this.dvTypes_SelectionChanged);
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "Id";
            this.clnId.HeaderText = "Id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 50;
            // 
            // clnName
            // 
            this.clnName.DataPropertyName = "Name";
            this.clnName.HeaderText = "Name";
            this.clnName.Name = "clnName";
            this.clnName.ReadOnly = true;
            this.clnName.Width = 150;
            // 
            // Usage
            // 
            this.Usage.DataPropertyName = "Count";
            this.Usage.HeaderText = "Usage";
            this.Usage.Name = "Usage";
            this.Usage.ReadOnly = true;
            this.Usage.Width = 50;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Picture";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            // 
            // clnDescription
            // 
            this.clnDescription.DataPropertyName = "Description";
            this.clnDescription.HeaderText = "Description";
            this.clnDescription.Name = "clnDescription";
            this.clnDescription.ReadOnly = true;
            this.clnDescription.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 159);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(208, 59);
            this.txtDescription.TabIndex = 59;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 15);
            this.label16.TabIndex = 58;
            this.label16.Text = "Parent";
            // 
            // cbxParent
            // 
            this.cbxParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParent.FormattingEnabled = true;
            this.cbxParent.Location = new System.Drawing.Point(16, 71);
            this.cbxParent.Name = "cbxParent";
            this.cbxParent.Size = new System.Drawing.Size(150, 23);
            this.cbxParent.TabIndex = 57;
            this.cbxParent.SelectedIndexChanged += new System.EventHandler(this.cbxParent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 33);
            this.label3.TabIndex = 56;
            this.label3.Text = "Item Types";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Type Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 23);
            this.txtName.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.Location = new System.Drawing.Point(16, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Type";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.AutoEllipsis = true;
            this.btnAddType.Location = new System.Drawing.Point(16, 249);
            this.btnAddType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(100, 30);
            this.btnAddType.TabIndex = 4;
            this.btnAddType.Text = "Add Type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // frmManageType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 480);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageType";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageType";
            this.Load += new System.EventHandler(this.frmManageType_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxParent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dvTypes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkIsParentCateogry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnChangeIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usage;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescription;
    }
}