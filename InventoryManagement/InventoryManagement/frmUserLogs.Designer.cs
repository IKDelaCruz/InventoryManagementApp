namespace InventoryManagement
{
    partial class frmUserLogs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvLogs = new System.Windows.Forms.DataGridView();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
           
            this.inventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).BeginInit();
         
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dvLogs);
            this.panel1.Location = new System.Drawing.Point(8, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 450);
            this.panel1.TabIndex = 0;
            // 
            // dvLogs
            // 
            this.dvLogs.AllowUserToAddRows = false;
            this.dvLogs.AllowUserToDeleteRows = false;
            this.dvLogs.AllowUserToResizeRows = false;
            this.dvLogs.AutoGenerateColumns = false;
            this.dvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionDate,
            this.SystemUserId,
            this.TransactionTypeId,
            this.OtherUserName});
            this.dvLogs.DataSource = this.inventoryDataSetBindingSource;
            this.dvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvLogs.Location = new System.Drawing.Point(0, 0);
            this.dvLogs.Name = "dvLogs";
            this.dvLogs.ReadOnly = true;
            this.dvLogs.RowHeadersVisible = false;
            this.dvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvLogs.ShowCellToolTips = false;
            this.dvLogs.ShowEditingIcon = false;
            this.dvLogs.ShowRowErrors = false;
            this.dvLogs.Size = new System.Drawing.Size(637, 450);
            this.dvLogs.TabIndex = 2;
            // 
            // TransactionDate
            // 
            this.TransactionDate.DataPropertyName = "TransactionDate";
            this.TransactionDate.HeaderText = "TransactionDate";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            this.TransactionDate.Width = 150;
            // 
            // SystemUserId
            // 
            this.SystemUserId.DataPropertyName = "SystemUserId";
            this.SystemUserId.HeaderText = "SystemUserId";
            this.SystemUserId.Name = "SystemUserId";
            this.SystemUserId.ReadOnly = true;
            this.SystemUserId.Width = 150;
            // 
            // TransactionTypeId
            // 
            this.TransactionTypeId.DataPropertyName = "TransactionTypeId";
            this.TransactionTypeId.HeaderText = "TransactionTypeId";
            this.TransactionTypeId.Name = "TransactionTypeId";
            this.TransactionTypeId.ReadOnly = true;
            this.TransactionTypeId.Width = 150;
            // 
            // OtherUserName
            // 
            this.OtherUserName.DataPropertyName = "OtherUserName";
            this.OtherUserName.HeaderText = "OtherUserName";
            this.OtherUserName.Name = "OtherUserName";
            this.OtherUserName.ReadOnly = true;
            this.OtherUserName.Visible = false;
            this.OtherUserName.Width = 150;
            // 
            // inventoryDataSet
            // 
           
            // 
            // inventoryDataSetBindingSource
            // 
      
            // 
            // frmUserLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 464);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmUserLogs";
            this.Text = "User Logs";
            this.Load += new System.EventHandler(this.frmUserLogs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).EndInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherUserName;
        private System.Windows.Forms.BindingSource inventoryDataSetBindingSource;
        
    }
}