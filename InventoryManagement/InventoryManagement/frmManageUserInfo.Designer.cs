namespace InventoryManagement
{
    partial class frmManageUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUserInfo));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 391);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(298, 391);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grpUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(386, 373);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxUserType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxCompany);
            this.groupBox1.Controls.Add(this.cbxDepartment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 227);
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
            this.grpUser.Location = new System.Drawing.Point(14, 48);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 26);
            this.label11.TabIndex = 100;
            this.label11.Text = "Create New User";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmManageUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 436);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageUserInfo";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label label11;
    }
}