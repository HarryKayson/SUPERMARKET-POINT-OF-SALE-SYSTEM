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
    public partial class StockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string stitle = "Point Of Sales";
        
       
        public StockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadSupplier();
            GetRefNo();
        }

        public void GetRefNo()
        {
            Random rnd = new Random();
            txtRefNo.Clear();
            txtRefNo.Text += rnd.Next();
        }
        public void LoadSupplier()
        {
            cboSupplier.Items.Clear();
            cboSupplier.DataSource =dbcon.getTable("SELECT * FROM tbSupplier");
            cboSupplier.DisplayMember = "supplier";
        }

        public void LoadStockIn()
        {
            int i = 0;
            dgvStockIn.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM viewInStock WHERE refno LIKE '" + txtRefNo.Text + "AND status LIKE 'Pending'", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

            }
            dr.Close();
            cn.Close();
        }
       

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockIn productStock = new ProductStockIn(this);
            productStock.ShowDialog();
        }

        private void txtRefNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbSupplier WHERE supplier LIKE '" + cboSupplier.Text + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                lblid.Text = dr["id"].ToString();
                txtContact.Text = dr["contactperson"].ToString();
                txtAddress.Text = dr["address"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void cboSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lblGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetRefNo();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvStockIn.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to save this records?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for(int i=0; i<dgvStockIn.Rows.Count; i++)
                        {
                            //update product quantity
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbProduct SET qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode LIKE '" + dgvStockIn.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            
                            //update stockIn quantity
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbInStock SET qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode LIKE '" + dgvStockIn.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                        }
                        Clear();
                        LoadStockIn();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Clear()
        {
            txtRefNo.Clear();
            txtStockInBy.Clear();
            dtStockInDate.Value = DateTime.Now;
        }

        private void dgvStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //For update and delete product by cell click from tbProduct
            string colName = dgvStockIn.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {

                if (MessageBox.Show("Are you sure you want to save this records?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbInStock WHERE id= '" + dgvStockIn.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been successfully removed", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }

    }

}
