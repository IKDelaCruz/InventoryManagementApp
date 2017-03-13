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
            this.typeImageList = new System.Windows.Forms.ImageList(this.components);
            this.subTypeImageList = new System.Windows.Forms.ImageList(this.components);
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.lvMain = new System.Windows.Forms.ListView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // lvMain
            // 
            this.lvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMain.LargeImageList = this.typeImageList;
            this.lvMain.Location = new System.Drawing.Point(0, 24);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(582, 319);
            this.lvMain.SmallImageList = this.typeImageList;
            this.lvMain.TabIndex = 1;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.DoubleClick += new System.EventHandler(this.lvMain_DoubleClick);
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lvMain);
            this.pnlMain.Controls.Add(this.menuStrip1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(584, 345);
            this.pnlMain.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.mainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click_1);
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click_1);
            // 
            // frmItemSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 365);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmItemSummary";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Summary";
            this.Load += new System.EventHandler(this.FrmItemSummary_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ImageList typeImageList;
        private System.Windows.Forms.ImageList subTypeImageList;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
    }
}