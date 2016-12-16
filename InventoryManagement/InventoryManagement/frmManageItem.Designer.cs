namespace InventoryManagement
{
    partial class frmManageItem
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.txtCurrentValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLifetime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblLastUpdatedBy = new System.Windows.Forms.Label();
            this.txtLastUpdatedUser = new System.Windows.Forms.TextBox();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.txtLastUpdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxCurrentOwner = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSubType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(556, 357);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(652, 357);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.dtpPurchaseDate);
            this.panel1.Controls.Add(this.lblCurrentValue);
            this.panel1.Controls.Add(this.txtCurrentValue);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtLifetime);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtPurchasePrice);
            this.panel1.Controls.Add(this.lblLastUpdatedBy);
            this.panel1.Controls.Add(this.txtLastUpdatedUser);
            this.panel1.Controls.Add(this.lblLastUpdated);
            this.panel1.Controls.Add(this.txtLastUpdate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbxCurrentOwner);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbxStatus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSerial);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxBrand);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxSubType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 341);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(393, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "Purchase Date";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(516, 198);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(169, 23);
            this.dtpPurchaseDate.TabIndex = 33;
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Location = new System.Drawing.Point(393, 288);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(81, 15);
            this.lblCurrentValue.TabIndex = 32;
            this.lblCurrentValue.Text = "Current Value";
            // 
            // txtCurrentValue
            // 
            this.txtCurrentValue.Location = new System.Drawing.Point(516, 285);
            this.txtCurrentValue.Name = "txtCurrentValue";
            this.txtCurrentValue.Size = new System.Drawing.Size(169, 23);
            this.txtCurrentValue.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(393, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Lifetime";
            // 
            // txtLifetime
            // 
            this.txtLifetime.Location = new System.Drawing.Point(516, 256);
            this.txtLifetime.Name = "txtLifetime";
            this.txtLifetime.Size = new System.Drawing.Size(169, 23);
            this.txtLifetime.TabIndex = 29;
            this.txtLifetime.Text = "5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(393, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Purchase Price";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(516, 227);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(169, 23);
            this.txtPurchasePrice.TabIndex = 27;
            // 
            // lblLastUpdatedBy
            // 
            this.lblLastUpdatedBy.AutoSize = true;
            this.lblLastUpdatedBy.Location = new System.Drawing.Point(393, 117);
            this.lblLastUpdatedBy.Name = "lblLastUpdatedBy";
            this.lblLastUpdatedBy.Size = new System.Drawing.Size(69, 15);
            this.lblLastUpdatedBy.TabIndex = 26;
            this.lblLastUpdatedBy.Text = "Updated By";
            // 
            // txtLastUpdatedUser
            // 
            this.txtLastUpdatedUser.Location = new System.Drawing.Point(516, 114);
            this.txtLastUpdatedUser.Name = "txtLastUpdatedUser";
            this.txtLastUpdatedUser.Size = new System.Drawing.Size(169, 23);
            this.txtLastUpdatedUser.TabIndex = 25;
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(393, 88);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(78, 15);
            this.lblLastUpdated.TabIndex = 24;
            this.lblLastUpdated.Text = "Last Updated";
            // 
            // txtLastUpdate
            // 
            this.txtLastUpdate.Location = new System.Drawing.Point(516, 85);
            this.txtLastUpdate.Name = "txtLastUpdate";
            this.txtLastUpdate.Size = new System.Drawing.Size(169, 23);
            this.txtLastUpdate.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Current Owner";
            // 
            // cbxCurrentOwner
            // 
            this.cbxCurrentOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurrentOwner.FormattingEnabled = true;
            this.cbxCurrentOwner.Location = new System.Drawing.Point(516, 56);
            this.cbxCurrentOwner.Name = "cbxCurrentOwner";
            this.cbxCurrentOwner.Size = new System.Drawing.Size(169, 23);
            this.cbxCurrentOwner.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(516, 27);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(169, 23);
            this.cbxStatus.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Serial";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(151, 285);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(169, 23);
            this.txtSerial.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(151, 256);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(169, 23);
            this.txtModel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Brand";
            // 
            // cbxBrand
            // 
            this.cbxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(151, 227);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(169, 23);
            this.cbxBrand.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "SubType";
            // 
            // cbxSubType
            // 
            this.cbxSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubType.FormattingEnabled = true;
            this.cbxSubType.Location = new System.Drawing.Point(151, 198);
            this.cbxSubType.Name = "cbxSubType";
            this.cbxSubType.Size = new System.Drawing.Size(169, 23);
            this.cbxSubType.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(151, 169);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(169, 23);
            this.cbxType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(151, 56);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(169, 81);
            this.txtDescription.TabIndex = 6;
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 392);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAddItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSubType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxCurrentOwner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.TextBox txtCurrentValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLifetime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label lblLastUpdatedBy;
        private System.Windows.Forms.TextBox txtLastUpdatedUser;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.TextBox txtLastUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
    }
}