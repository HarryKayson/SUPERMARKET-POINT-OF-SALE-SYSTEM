﻿using System;
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
    public partial class BrandModule : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Brand brand;
        public BrandModule(Brand br)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            brand = br;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
              //To insert brand name to brand table
              try
            {
                if (MessageBox.Show("Are you sure you want to save this Brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbBramd(brand)Values(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.", "POS");
                    Clear();
                    brand.LoadBrand();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           Clear();
        }

        public void Clear()
        {
            txtBrand.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtBrand.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update brand Name
            if (MessageBox.Show("Are you sure you want to update this Brand?", "Update Record!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE INTO SET brand = @brand WHERE id LIKE'" + lblId.Text + "'", cn);
                cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Brand has been successfully updated.", "POS");
                Clear();
                this.Dispose();//To close this form after update
            }
        }
    }
}