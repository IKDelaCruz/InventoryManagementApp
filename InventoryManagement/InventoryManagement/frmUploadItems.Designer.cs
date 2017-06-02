namespace InventoryManagement
{
    partial class frmUploadItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUploadItems));
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lnkSampleFormat = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(24, 82);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(243, 23);
            this.txtFilename.TabIndex = 72;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(19, 19);
            this.label23.Margin = new System.Windows.Forms.Padding(10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(144, 26);
            this.label23.TabIndex = 71;
            this.label23.Text = "Upload Csv File";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 64);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(134, 15);
            this.label24.TabIndex = 70;
            this.label24.Text = "Select a file to upload...";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(24, 111);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 30);
            this.btnBrowse.TabIndex = 69;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lnkSampleFormat
            // 
            this.lnkSampleFormat.AutoSize = true;
            this.lnkSampleFormat.Location = new System.Drawing.Point(21, 179);
            this.lnkSampleFormat.Name = "lnkSampleFormat";
            this.lnkSampleFormat.Size = new System.Drawing.Size(148, 15);
            this.lnkSampleFormat.TabIndex = 73;
            this.lnkSampleFormat.TabStop = true;
            this.lnkSampleFormat.Text = "Download Sample Format";
            this.lnkSampleFormat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSampleFormat_LinkClicked);
            // 
            // frmUploadItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 289);
            this.Controls.Add(this.lnkSampleFormat);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.btnBrowse);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUploadItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUploadItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.LinkLabel lnkSampleFormat;
    }
}