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
    public partial class ProductModule : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point Of Sales";
        Product product;

        public ProductModule(Product pd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            product = pd;
            LoadBrand();
            LoadCategory();
            
        }

        public void LoadBrand()
        {
            cboBrand.Items.Clear();
            cboBrand.DataSource = dbcon.getTable("SELECT * FROM tbBrand");
            cboBrand.DisplayMember = "brand";
            cboBrand.ValueMember = "id";
        }

        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            cboCategory.DataSource = dbcon.getTable("SELECT * FROM tbCategory");
            cboCategory.DisplayMember = "category";
            cboCategory.ValueMember = "id";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            txtPcode.Clear();
            txtBarcode.Clear();
            txtPdesc.Clear();
            txtPrice.Clear();
            cboBrand.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            UDReorder.Value = 1;

            txtPcode.Enabled = true;
            txtPcode.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pcode, barcode, pdesc, bid, cid, price, reorder)Values(@pcode, @barcode, @pdesc, @bid, @cid, @price, @reorder)", cn);
                    cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtPdesc.Text);
                    cm.Parameters.AddWithValue("@bid", cboBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@pcode", cboCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", UDReorder.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully saved.",  stitle);
                    Clear();
                    product.LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pcode, barcode, pdesc, bid, cid, price, reorder)Values(@pcode, @barcode, @pdesc, @bid, @cid, @price, @reorder)", cn);
                    cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtPdesc.Text);
                    cm.Parameters.AddWithValue("@bid", cboBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@pcode", cboCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", UDReorder.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully updated.", stitle);
                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
