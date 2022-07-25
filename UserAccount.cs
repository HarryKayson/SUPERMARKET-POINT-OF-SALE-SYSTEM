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
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public UserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        public void Clear()
        {
            txtName.Clear();
            txtPass.Clear();
            txtRePass.Clear();
            txtUsername.Clear();
            cboRole.Text = "";
            txtUsername.Focus();
            
        }
        private void btnAccSave_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtPass.Text != txtRePass.Text)
                {
                    MessageBox.Show("PASSWORD DID NOT MATCH!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbUser(username, password, role, name) Values (@username, @password, @role, @name)", cn);
                    cm.Parameters.AddWithValue("@username", txtUsername.Text);
                    cm.Parameters.AddWithValue("@password", txtPass.Text);
                    cm.Parameters.AddWithValue("@role", cboRole.Text);
                    cm.Parameters.AddWithValue("@name", txtName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("New account has been successfully saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }

        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
