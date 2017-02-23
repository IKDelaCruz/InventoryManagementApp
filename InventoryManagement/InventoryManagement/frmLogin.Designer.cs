namespace InventoryManagement
{
    partial class frmLogin
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoEllipsis = true;
            this.btnCancel.Location = new System.Drawing.Point(17, 217);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtPassord);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtUsername);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.pbox);
            this.pnlMain.Controls.Add(this.btnLogin);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(240, 261);
            this.pnlMain.TabIndex = 5;
            // 
            // pbox
            // 
            this.pbox.BackgroundImage = global::InventoryManagement.Properties.Resources.jakalogo;
            this.pbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbox.Location = new System.Drawing.Point(18, 12);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(207, 98);
            this.pbox.TabIndex = 51;
            this.pbox.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(125, 217);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Username";
            // 
            // txtPassord
            // 
            this.txtPassord.Location = new System.Drawing.Point(18, 188);
            this.txtPassord.Name = "txtPassord";
            this.txtPassord.Size = new System.Drawing.Size(207, 23);
            this.txtPassord.TabIndex = 53;
            this.txtPassord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(17, 144);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(208, 23);
            this.txtUsername.TabIndex = 52;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 281);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
    }
}