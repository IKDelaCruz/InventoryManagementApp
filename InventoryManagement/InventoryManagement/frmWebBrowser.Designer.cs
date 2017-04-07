namespace InventoryManagement
{
    partial class frmWebBrowser
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
            this.wbMain = new System.Windows.Forms.WebBrowser();
            this.btnPrintBarcode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbMain
            // 
            this.wbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMain.Location = new System.Drawing.Point(0, 0);
            this.wbMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMain.Name = "wbMain";
            this.wbMain.Size = new System.Drawing.Size(915, 647);
            this.wbMain.TabIndex = 0;
            // 
            // btnPrintBarcode
            // 
            this.btnPrintBarcode.Location = new System.Drawing.Point(13, 605);
            this.btnPrintBarcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrintBarcode.Name = "btnPrintBarcode";
            this.btnPrintBarcode.Size = new System.Drawing.Size(100, 30);
            this.btnPrintBarcode.TabIndex = 5;
            this.btnPrintBarcode.Text = "Print";
            this.btnPrintBarcode.UseVisualStyleBackColor = true;
            this.btnPrintBarcode.Click += new System.EventHandler(this.btnPrintBarcode_Click);
            // 
            // frmWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 647);
            this.Controls.Add(this.btnPrintBarcode);
            this.Controls.Add(this.wbMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmWebBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWebBrowser";
            this.Load += new System.EventHandler(this.frmWebBrowser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.Button btnPrintBarcode;
    }
}