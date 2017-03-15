namespace InventoryManagement
{
    partial class frmItemSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemSummary));
            this.typeImageList = new System.Windows.Forms.ImageList(this.components);
            this.subTypeImageList = new System.Windows.Forms.ImageList(this.components);
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lnkNavigation = new System.Windows.Forms.LinkLabel();
            this.lvMain = new System.Windows.Forms.ListView();
            this.pnlMain.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeImageList
            // 
            this.typeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.typeImageList.ImageSize = new System.Drawing.Size(96, 96);
            this.typeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // subTypeImageList
            // 
            this.subTypeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.subTypeImageList.ImageSize = new System.Drawing.Size(96, 96);
            this.subTypeImageList.TransparentColor = System.Drawing.Color.Transparent;
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
            this.pnlMain.Controls.Add(this.pnlNavigation);
            this.pnlMain.Controls.Add(this.lvMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(584, 345);
            this.pnlMain.TabIndex = 3;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.lnkNavigation);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(582, 29);
            this.pnlNavigation.TabIndex = 3;
            // 
            // lnkNavigation
            // 
            this.lnkNavigation.AutoSize = true;
            this.lnkNavigation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNavigation.LinkColor = System.Drawing.Color.Black;
            this.lnkNavigation.Location = new System.Drawing.Point(3, 5);
            this.lnkNavigation.Name = "lnkNavigation";
            this.lnkNavigation.Size = new System.Drawing.Size(64, 19);
            this.lnkNavigation.TabIndex = 0;
            this.lnkNavigation.TabStop = true;
            this.lnkNavigation.Text = "Home / ";
            this.lnkNavigation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNavigation_LinkClicked);
            // 
            // lvMain
            // 
            this.lvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMain.LargeImageList = this.typeImageList;
            this.lvMain.Location = new System.Drawing.Point(0, 35);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(582, 308);
            this.lvMain.SmallImageList = this.typeImageList;
            this.lvMain.TabIndex = 1;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.DoubleClick += new System.EventHandler(this.lvMain_DoubleClick);
            // 
            // frmItemSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 365);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItemSummary";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Summary";
            this.Load += new System.EventHandler(this.FrmItemSummary_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ImageList typeImageList;
        private System.Windows.Forms.ImageList subTypeImageList;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.LinkLabel lnkNavigation;
    }
}