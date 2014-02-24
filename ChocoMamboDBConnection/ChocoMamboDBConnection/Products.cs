using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBConnection;
using System.Data;

namespace ChocoMamboDBConnection
{
    public class Products
    {
        #region Class Variables
        long _lngPKID = 0;
        string _strTableName = "Products";
        string _strPKName = "ProductsID";
        dbConnection _dbConn = new dbConnection("ChocoMambo.accdb");
        DataSet _dst = new DataSet();
        DataRow _drwRecord = null;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor for the new customer
        /// </summary>
        public Products()
        {
            loadDataSet();
        }
        /// <summary>
        /// Constructor for the existing customer
        /// </summary>
        public Products(long pLongID)
        {
            _lngPKID = pLongID;
            loadDataSet();
            assignFields();
        }
        
        #endregion

        #region Properties

        public string ProductsName { get; set; }
        public string ProductsQty { get; set; }
        public string ProductsCost { get; set; }

        #endregion

        #region Accessors

        private void loadDataSet()
        {
            string strQuery = "SELECT * FROM " + _strTableName;

            if (_lngPKID > 0)
                strQuery += " WHERE " + _strPKName + " = " + _lngPKID;

            _dbConn.fillDataSet(_dst, strQuery, _strTableName);
        }

        private void assignFields()
        {
            ProductsName = _dst.Tables[_strTableName].Rows[0]["ProdustsName"].ToString();
            ProductsQty = _dst.Tables[_strTableName].Rows[0]["ProductsQty"].ToString();
            ProductsCost = _dst.Tables[_strTableName].Rows[0]["ProductsCost"].ToString();
        }

        #endregion

        #region Mutators

        public void saveData()
        {
            if (_lngPKID == 0)
                addNewRecord();
            else
                updateRecord();

            _dbConn.SaveData(_dst, _strTableName);
        }

        private void addNewRecord()
        {
            _drwRecord = _dst.Tables[_strTableName].NewRow();
            _drwRecord.BeginEdit();
            _drwRecord["ProdustsName"] = ProductsName;
            _drwRecord["ProductsQty"] = ProductsQty;
            _drwRecord["ProductsCost"] = ProductsCost;
            _drwRecord.EndEdit();
            _dst.Tables[_strTableName].Rows.Add(_drwRecord);
        }

        private void updateRecord()
        {
            _drwRecord = _dst.Tables[_strTableName].Rows.Find(_lngPKID);
            _drwRecord.BeginEdit();
            _drwRecord["ProdustsName"] = ProductsName;
            _drwRecord["ProductsQty"] = ProductsQty;
            _drwRecord["ProductsCost"] = ProductsCost;
            _drwRecord.EndEdit();
        }

        #endregion
    }
}
