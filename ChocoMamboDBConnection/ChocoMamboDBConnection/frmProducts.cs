using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChocoMamboDBConnection
{
    public partial class frmProducts : Form
    {
        #region Variable Declarations

        Products _customer = null;

        #endregion

        #region Constructor
         public frmProducts()
        {
            InitializeComponent();
            _customer = new Products();
        }

        public frmProducts(long pLongID)
        {
            InitializeComponent();
            _customer = new Products(pLongID);
            displayRecord();
        }       
        #endregion
        #region Accessors
        private void displayRecord()
        {
             txtProductsName.Text = _customer.ProductsName;
            txtStock.Text = _customer.ProductsQty;
            txtPrice.Text = _customer.ProductsCost;
        }
        #endregion

        #region Mutators

        private void assignData()
        {
            _customer.ProductsName = txtProductsName.Text;
            _customer.ProductsQty = txtStock.Text;
            _customer.ProductsCost = txtPrice.Text;
        }

        #endregion

        #region Control Events

        private void btnNew_Click(object sender, EventArgs e)
        {
            assignData();
            _customer.saveData();
            txtPrice.Text = "";
            txtProductsName.Text = "";
            txtStock.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            assignData();
            _customer.saveData();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
        #endregion

    }
}
