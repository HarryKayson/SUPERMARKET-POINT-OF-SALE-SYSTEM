using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POSProject
{
    public partial class ProductStockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string stitle = "Point Of Sales";
        StockIn stockIn;


        public ProductStockIn(StockIn stk)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            stockIn = stk;
            LoadProduct();
        }
        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT pcode, pdesc, qty FROM tbProduct WHERE pdesc LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //For update and delete product by cell click from tbProduct
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                if(stockIn.txtStockInBy.Text == String.Empty)
                {
                    MessageBox.Show("Please enter stock in by name", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stockIn.txtStockInBy.Focus();
                    this.Dispose();
                    stockIn.txtStockInBy.Focus();
                    return;

                }
                if (MessageBox.Show("Add this Item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tbInStock (refno, pcode, sdate, stockIn by, supplierid)VALUES (@refno, @pcode, @sdate, @stockinby, @supplierid)", cn);
                        cm.Parameters.AddWithValue("@refno", stockIn.txtRefNo.Text);
                        cm.Parameters.AddWithValue("@pcode", dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@sdate", stockIn.dtStockInDate.Text);
                        cm.Parameters.AddWithValue("@stockInby", stockIn.txtStockInBy.Text);
                        cm.Parameters.AddWithValue("@supplierid", stockIn.lblid.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        stockIn.LoadStockIn();
                        MessageBox.Show("Successfully added", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, stitle);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}

