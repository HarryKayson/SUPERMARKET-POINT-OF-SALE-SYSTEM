namespace POSProject
{
    partial class StockIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEntry = new System.Windows.Forms.Button();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblManageProduct = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvStockIn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LinkProduct = new System.Windows.Forms.LinkLabel();
            this.lblGenerate = new System.Windows.Forms.LinkLabel();
            this.dtStockInDate = new System.Windows.Forms.DateTimePicker();
            this.txtStockInBy = new System.Windows.Forms.TextBox();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnEntry);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblManageProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 57);
            this.panel1.TabIndex = 3;
            // 
            // btnEntry
            // 
            this.btnEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntry.BackColor = System.Drawing.Color.Green;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.Location = new System.Drawing.Point(877, 12);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(95, 30);
            this.btnEntry.TabIndex = 19;
            this.btnEntry.Text = "Entry";
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(-18, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(352, 21);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search Here";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(0, 19);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search Here";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblManageProduct
            // 
            this.lblManageProduct.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageProduct.ForeColor = System.Drawing.Color.White;
            this.lblManageProduct.Location = new System.Drawing.Point(12, 7);
            this.lblManageProduct.Name = "lblManageProduct";
            this.lblManageProduct.Size = new System.Drawing.Size(119, 38);
            this.lblManageProduct.TabIndex = 0;
            this.lblManageProduct.Text = "Stock In Module";
            this.lblManageProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(984, 504);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dgvStockIn);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(976, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stock In";
            // 
            // dgvStockIn
            // 
            this.dgvStockIn.AllowUserToAddRows = false;
            this.dgvStockIn.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockIn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockIn.ColumnHeadersHeight = 30;
            this.dgvStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStockIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column10,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Delete});
            this.dgvStockIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStockIn.EnableHeadersVisualStyles = false;
            this.dgvStockIn.Location = new System.Drawing.Point(0, 145);
            this.dgvStockIn.Name = "dgvStockIn";
            this.dgvStockIn.RowHeadersVisible = false;
            this.dgvStockIn.Size = new System.Drawing.Size(976, 321);
            this.dgvStockIn.TabIndex = 4;
            this.dgvStockIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockIn_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 57;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "id";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Reference#";
            this.Column10.Name = "Column10";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "PCode";
            this.Column2.Name = "Column2";
            this.Column2.Width = 83;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Qty";
            this.Column5.Name = "Column5";
            this.Column5.Width = 58;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Stock In Date";
            this.Column6.Name = "Column6";
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Stock In By";
            this.Column7.Name = "Column7";
            this.Column7.Width = 111;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Supplier";
            this.Column8.Name = "Column8";
            this.Column8.Width = 89;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Width = 62;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtContact);
            this.panel2.Controls.Add(this.cboSupplier);
            this.panel2.Controls.Add(this.lblid);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.LinkProduct);
            this.panel2.Controls.Add(this.lblGenerate);
            this.panel2.Controls.Add(this.dtStockInDate);
            this.panel2.Controls.Add(this.txtStockInBy);
            this.panel2.Controls.Add(this.txtRefNo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 145);
            this.panel2.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(701, 81);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(267, 26);
            this.txtAddress.TabIndex = 20;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(701, 45);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(267, 26);
            this.txtContact.TabIndex = 19;
            // 
            // cboSupplier
            // 
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(701, 8);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(267, 28);
            this.cboSupplier.TabIndex = 18;
            this.cboSupplier.SelectedIndexChanged += new System.EventHandler(this.cboSupplier_SelectedIndexChanged);
            this.cboSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSupplier_KeyPress);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(551, 122);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(38, 20);
            this.lblid.TabIndex = 17;
            this.lblid.Text = "lblid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Address : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contact Person : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Supplier :";
            // 
            // LinkProduct
            // 
            this.LinkProduct.AutoSize = true;
            this.LinkProduct.LinkColor = System.Drawing.Color.Silver;
            this.LinkProduct.Location = new System.Drawing.Point(165, 122);
            this.LinkProduct.Name = "LinkProduct";
            this.LinkProduct.Size = new System.Drawing.Size(245, 20);
            this.LinkProduct.TabIndex = 13;
            this.LinkProduct.TabStop = true;
            this.LinkProduct.Text = "[ Click here to browse Product  ]";
            this.LinkProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // lblGenerate
            // 
            this.lblGenerate.AutoSize = true;
            this.lblGenerate.LinkColor = System.Drawing.Color.Silver;
            this.lblGenerate.Location = new System.Drawing.Point(422, 12);
            this.lblGenerate.Name = "lblGenerate";
            this.lblGenerate.Size = new System.Drawing.Size(96, 20);
            this.lblGenerate.TabIndex = 12;
            this.lblGenerate.TabStop = true;
            this.lblGenerate.Text = "[ generate ]";
            this.lblGenerate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGenerate_LinkClicked);
            // 
            // dtStockInDate
            // 
            this.dtStockInDate.Location = new System.Drawing.Point(169, 81);
            this.dtStockInDate.Name = "dtStockInDate";
            this.dtStockInDate.Size = new System.Drawing.Size(349, 26);
            this.dtStockInDate.TabIndex = 10;
            // 
            // txtStockInBy
            // 
            this.txtStockInBy.Location = new System.Drawing.Point(169, 45);
            this.txtStockInBy.Name = "txtStockInBy";
            this.txtStockInBy.Size = new System.Drawing.Size(349, 26);
            this.txtStockInBy.TabIndex = 9;
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(169, 9);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(232, 26);
            this.txtRefNo.TabIndex = 8;
            this.txtRefNo.TextChanged += new System.EventHandler(this.txtRefNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock In Date :  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stock In By :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reference No : ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(976, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock In Record";
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockIn";
            this.Text = "STOCK ENTRY";
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.Label lblManageProduct;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvStockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LinkProduct;
        private System.Windows.Forms.LinkLabel lblGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnEntry;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtContact;
        public System.Windows.Forms.ComboBox cboSupplier;
        public System.Windows.Forms.DateTimePicker dtStockInDate;
        public System.Windows.Forms.TextBox txtStockInBy;
        public System.Windows.Forms.TextBox txtRefNo;
        public System.Windows.Forms.Label lblid;
    }
}