using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBConnection;

namespace ChocoMamboDBConnection
{
    public partial class frmProductsGrid : Form
    {
        public frmProductsGrid()
        {
            InitializeComponent();
        }

        private void frmProductsGrid_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void populateGrid()
        {
            DataTable dtb = loadDataTable();

            // assign the DataTable as the grid's data source
            dgvGeneral.DataSource = dtb;
        }

        private DataTable loadDataTable()
        {
            // create a dbConnection object and pass the database name
            dbConnection dbConn = new dbConnection("ChocoMambo.accdb");

            // create a DataTable to store the table tblCustomers
            DataTable dtb = dbConn.GetDataTable("Products");

            return dtb;
        }

        private void frmProductsGrid_Activated(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void dgvGeneral_DoubleClick(object sender, EventArgs e)
        {
            long lngPKID = 0;
            frmProducts frm;

            if (dgvGeneral["ProductsID", dgvGeneral.CurrentCell.RowIndex].Value.ToString() != "")
            {
                lngPKID = long.Parse(dgvGeneral["ProductsID",
                                    dgvGeneral.CurrentCell.RowIndex].Value.ToString());
                frm = new frmProducts(lngPKID);
            }
            else
                frm = new frmProducts();

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            frm.ShowDialog();
        }

    }
}
