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
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Category category;
            
        public CategoryModule(Category ct)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            category = ct;
        }


        public void Clear()
        {
            txtCategory.Clear();
            txtCategory.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //To insert brand name to brand table
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbCategory(category)Values(@category)", cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.", "POS");
                    Clear();
                   }
                category.LoadCategory();
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
            //Update Category Name
            if (MessageBox.Show("Are you sure you want to update this Category?", "Update Record!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE INTO SET category = @category WHERE id LIKE'" + lblId.Text + "'", cn);
                cm.Parameters.AddWithValue("@category", txtCategory.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Category has been successfully updated.", "POS");
                Clear();
                this.Dispose();//To close this form after update
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CategoryModule_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
