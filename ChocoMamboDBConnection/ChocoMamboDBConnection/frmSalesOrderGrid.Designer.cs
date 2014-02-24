namespace ChocoMamboDBConnection
{
    partial class frmSalesOrderGrid
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dvgGeneral = new System.Windows.Forms.DataGridView();
            this.SalesOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 310);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 37);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(250, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(163, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 26);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // dvgGeneral
            // 
            this.dvgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesOrderID,
            this.EmployesID,
            this.RetailerID,
            this.SalesDate});
            this.dvgGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgGeneral.Location = new System.Drawing.Point(0, 0);
            this.dvgGeneral.Name = "dvgGeneral";
            this.dvgGeneral.RowTemplate.Height = 24;
            this.dvgGeneral.Size = new System.Drawing.Size(343, 310);
            this.dvgGeneral.TabIndex = 3;
            // 
            // SalesOrderID
            // 
            this.SalesOrderID.DataPropertyName = "SalesOrderID";
            this.SalesOrderID.HeaderText = "SalesOrderID";
            this.SalesOrderID.Name = "SalesOrderID";
            this.SalesOrderID.Visible = false;
            // 
            // EmployesID
            // 
            this.EmployesID.DataPropertyName = "EmployesID";
            this.EmployesID.HeaderText = "Employee";
            this.EmployesID.Name = "EmployesID";
            // 
            // RetailerID
            // 
            this.RetailerID.DataPropertyName = "RetailerID";
            this.RetailerID.HeaderText = "Retailer";
            this.RetailerID.Name = "RetailerID";
            // 
            // SalesDate
            // 
            this.SalesDate.DataPropertyName = "SalesDate";
            this.SalesDate.HeaderText = "Sales Date";
            this.SalesDate.Name = "SalesDate";
            // 
            // frmSalesOrderGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 347);
            this.Controls.Add(this.dvgGeneral);
            this.Controls.Add(this.panel1);
            this.Name = "frmSalesOrderGrid";
            this.Text = "frmSalesOrderGrid";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dvgGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesDate;
    }
}