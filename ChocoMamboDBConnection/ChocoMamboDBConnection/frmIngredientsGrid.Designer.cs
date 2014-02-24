﻿namespace ChocoMamboDBConnection
{
    partial class frmIngredientsGrid
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
            this.IngredientsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngredientsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngredientsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngredientsID,
            this.IngredientsName,
            this.IngredientsQty});
            this.dgvGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGeneral.Location = new System.Drawing.Point(0, 0);
            this.dgvGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.RowTemplate.Height = 28;
            this.dgvGeneral.Size = new System.Drawing.Size(243, 236);
            this.dgvGeneral.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 37);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(150, 6);
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
            this.btnNew.Location = new System.Drawing.Point(58, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 26);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // IngredientsID
            // 
            this.IngredientsID.DataPropertyName = "IngredientsID";
            this.IngredientsID.HeaderText = "IngredientsID";
            this.IngredientsID.Name = "IngredientsID";
            this.IngredientsID.Visible = false;
            // 
            // IngredientsName
            // 
            this.IngredientsName.DataPropertyName = "IngredientsName";
            this.IngredientsName.HeaderText = "Ingredient";
            this.IngredientsName.Name = "IngredientsName";
            // 
            // IngredientsQty
            // 
            this.IngredientsQty.DataPropertyName = "IngredientsQty";
            this.IngredientsQty.HeaderText = "Stock";
            this.IngredientsQty.Name = "IngredientsQty";
            // 
            // frmIngredientsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 273);
            this.Controls.Add(this.dgvGeneral);
            this.Controls.Add(this.panel1);
            this.Name = "frmIngredientsGrid";
            this.Text = "frmIngredientsGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientsQty;
    }
}