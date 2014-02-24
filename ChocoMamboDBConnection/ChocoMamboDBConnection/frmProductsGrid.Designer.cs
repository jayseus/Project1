namespace ChocoMamboDBConnection
{
    partial class frmProductsGrid
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
            this.dgvGeneral = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.ProductsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdustsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductsID,
            this.ProdustsName,
            this.ProductsQty,
            this.ProductsCost});
            this.dgvGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGeneral.Location = new System.Drawing.Point(0, 0);
            this.dgvGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.RowTemplate.Height = 28;
            this.dgvGeneral.Size = new System.Drawing.Size(443, 250);
            this.dgvGeneral.TabIndex = 3;
            this.dgvGeneral.DoubleClick += new System.EventHandler(this.dgvGeneral_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 250);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 37);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(352, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(260, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 26);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ProductsID
            // 
            this.ProductsID.DataPropertyName = "ProductsID";
            this.ProductsID.HeaderText = "ProductsID";
            this.ProductsID.Name = "ProductsID";
            this.ProductsID.Visible = false;
            // 
            // ProdustsName
            // 
            this.ProdustsName.DataPropertyName = "ProdustsName";
            this.ProdustsName.HeaderText = "Products";
            this.ProdustsName.Name = "ProdustsName";
            this.ProdustsName.Width = 200;
            // 
            // ProductsQty
            // 
            this.ProductsQty.DataPropertyName = "ProductsQty";
            this.ProductsQty.HeaderText = "Stock";
            this.ProductsQty.Name = "ProductsQty";
            // 
            // ProductsCost
            // 
            this.ProductsCost.DataPropertyName = "ProductsCost";
            this.ProductsCost.HeaderText = "Price";
            this.ProductsCost.Name = "ProductsCost";
            // 
            // frmProductsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 287);
            this.Controls.Add(this.dgvGeneral);
            this.Controls.Add(this.panel1);
            this.Name = "frmProductsGrid";
            this.Text = "frmProductsGrid";
            this.Activated += new System.EventHandler(this.frmProductsGrid_Activated);
            this.Load += new System.EventHandler(this.frmProductsGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdustsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsCost;
    }
}