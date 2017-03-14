namespace InventoryManagement
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.imgMain = new System.Windows.Forms.ImageList(this.components);
            this.btnNew = new System.Windows.Forms.Button();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMain.ImageStream")));
            this.imgMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMain.Images.SetKeyName(0, "admin.png");
            this.imgMain.Images.SetKeyName(1, "support.png");
            this.imgMain.Images.SetKeyName(2, "user1.png");
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 30);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lvUsers
            // 
            this.lvUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUsers.LargeImageList = this.imgMain;
            this.lvUsers.Location = new System.Drawing.Point(6, 42);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(712, 376);
            this.lvUsers.TabIndex = 0;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.SelectedIndexChanged += new System.EventHandler(this.lvUsers_SelectedIndexChanged);
            this.lvUsers.DoubleClick += new System.EventHandler(this.lvUsers_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.lvUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 428);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(522, 9);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(196, 23);
            this.txtFilter.TabIndex = 11;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 448);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageUsers";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ImageList imgMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
    }
}