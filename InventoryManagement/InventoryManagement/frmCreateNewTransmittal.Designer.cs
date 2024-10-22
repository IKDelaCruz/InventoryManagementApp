﻿namespace InventoryManagement
{
    partial class frmCreateNewTransmittal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewTransmittal));
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btbDelete = new System.Windows.Forms.Button();
            this.dvItems = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpApprovedDate = new System.Windows.Forms.DateTimePicker();
            this.cbxNotedBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxApproved = new System.Windows.Forms.ComboBox();
            this.cbxPrepared = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUsers = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "Department";
            // 
            // cbxCompany
            // 
            this.cbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(20, 39);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(196, 23);
            this.cbxCompany.TabIndex = 48;
            this.cbxCompany.SelectedIndexChanged += new System.EventHandler(this.cbxCompany_SelectedIndexChanged);
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(20, 83);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(196, 23);
            this.cbxDepartment.TabIndex = 50;
            this.cbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxDepartment_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Company";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 565);
            this.panel1.TabIndex = 52;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(537, 522);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btbDelete);
            this.groupBox3.Controls.Add(this.dvItems);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(15, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 249);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // btbDelete
            // 
            this.btbDelete.Location = new System.Drawing.Point(60, 205);
            this.btbDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btbDelete.Name = "btbDelete";
            this.btbDelete.Size = new System.Drawing.Size(30, 30);
            this.btbDelete.TabIndex = 82;
            this.btbDelete.Text = "-";
            this.btbDelete.UseVisualStyleBackColor = true;
            this.btbDelete.Click += new System.EventHandler(this.btbDelete_Click);
            // 
            // dvItems
            // 
            this.dvItems.AllowUserToAddRows = false;
            this.dvItems.AllowUserToDeleteRows = false;
            this.dvItems.AllowUserToResizeRows = false;
            this.dvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AssetTag,
            this.ItemDescription,
            this.ItemModel,
            this.ItemSerial});
            this.dvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvItems.Location = new System.Drawing.Point(20, 22);
            this.dvItems.Name = "dvItems";
            this.dvItems.RowHeadersVisible = false;
            this.dvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvItems.ShowCellErrors = false;
            this.dvItems.ShowCellToolTips = false;
            this.dvItems.ShowEditingIcon = false;
            this.dvItems.ShowRowErrors = false;
            this.dvItems.Size = new System.Drawing.Size(697, 177);
            this.dvItems.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // AssetTag
            // 
            this.AssetTag.DataPropertyName = "AssetTag";
            this.AssetTag.HeaderText = "AssetTag";
            this.AssetTag.Name = "AssetTag";
            this.AssetTag.Width = 120;
            // 
            // ItemDescription
            // 
            this.ItemDescription.DataPropertyName = "LongDescription";
            this.ItemDescription.HeaderText = "Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Width = 250;
            // 
            // ItemModel
            // 
            this.ItemModel.DataPropertyName = "Model";
            this.ItemModel.HeaderText = "ItemModel";
            this.ItemModel.Name = "ItemModel";
            this.ItemModel.Width = 150;
            // 
            // ItemSerial
            // 
            this.ItemSerial.DataPropertyName = "Serial";
            this.ItemSerial.HeaderText = "ItemSerial";
            this.ItemSerial.Name = "ItemSerial";
            this.ItemSerial.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 205);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 81;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpApprovedDate);
            this.groupBox2.Controls.Add(this.cbxNotedBy);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxApproved);
            this.groupBox2.Controls.Add(this.cbxPrepared);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(395, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 210);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Approval";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 77;
            this.label3.Text = "Approved Date";
            // 
            // dtpApprovedDate
            // 
            this.dtpApprovedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpApprovedDate.Location = new System.Drawing.Point(19, 173);
            this.dtpApprovedDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpApprovedDate.Name = "dtpApprovedDate";
            this.dtpApprovedDate.Size = new System.Drawing.Size(118, 23);
            this.dtpApprovedDate.TabIndex = 76;
            // 
            // cbxNotedBy
            // 
            this.cbxNotedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNotedBy.FormattingEnabled = true;
            this.cbxNotedBy.Location = new System.Drawing.Point(19, 81);
            this.cbxNotedBy.Name = "cbxNotedBy";
            this.cbxNotedBy.Size = new System.Drawing.Size(282, 23);
            this.cbxNotedBy.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Prepared By";
            // 
            // cbxApproved
            // 
            this.cbxApproved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxApproved.FormattingEnabled = true;
            this.cbxApproved.Location = new System.Drawing.Point(19, 125);
            this.cbxApproved.Name = "cbxApproved";
            this.cbxApproved.Size = new System.Drawing.Size(282, 23);
            this.cbxApproved.TabIndex = 50;
            // 
            // cbxPrepared
            // 
            this.cbxPrepared.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrepared.FormattingEnabled = true;
            this.cbxPrepared.Location = new System.Drawing.Point(19, 37);
            this.cbxPrepared.Name = "cbxPrepared";
            this.cbxPrepared.Size = new System.Drawing.Size(282, 23);
            this.cbxPrepared.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Approved By";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 78;
            this.label7.Text = "Noted By";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(647, 522);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 79;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPurpose);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxCompany);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxDepartment);
            this.groupBox1.Controls.Add(this.cbxUsers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 212);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmitted To";
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(20, 175);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(292, 23);
            this.txtPurpose.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 73;
            this.label8.Text = "Purpose:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 72;
            this.label2.Text = "End User";
            // 
            // cbxUsers
            // 
            this.cbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.Location = new System.Drawing.Point(20, 127);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(292, 23);
            this.cbxUsers.TabIndex = 71;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(10, 10);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(158, 26);
            this.lblHeader.TabIndex = 73;
            this.lblHeader.Text = "Transmittal Form";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCreateNewTransmittal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 585);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateNewTransmittal";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transmittal Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPrepared;
        private System.Windows.Forms.ComboBox cbxApproved;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpApprovedDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dvItems;
        private System.Windows.Forms.Button btbDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSerial;
        private System.Windows.Forms.ComboBox cbxNotedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label label8;
    }
}