namespace BREWPLS_POS_SYSTEM
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label13 = new Label();
            panelProduct1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            label10 = new Label();
            dataGridViewProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            textBox4 = new TextBox();
            txtProductPrice = new TextBox();
            txtProductCategory = new TextBox();
            txtProuctName = new TextBox();
            txtProductID = new TextBox();
            btnProductCancel = new Button();
            btnProductUpdate = new Button();
            btnProductDelete = new Button();
            btnProductSave = new Button();
            btnProductCreateNew = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label11 = new Label();
            label12 = new Label();
            tbCDateTime = new TextBox();
            tbUser = new TextBox();
            tbUserRole = new TextBox();
            panelProduct1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 41);
            label2.Name = "label2";
            label2.Size = new Size(87, 12);
            label2.TabIndex = 2;
            label2.Text = "COFFEE + MILKTEA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 1;
            label1.Text = "b r e w, p l s.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(123, 12);
            label3.Name = "label3";
            label3.Size = new Size(28, 47);
            label3.TabIndex = 3;
            label3.Text = "|";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(157, 30);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 4;
            label4.Text = "PRODUCT";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.AppWorkspace;
            label13.Location = new Point(987, 26);
            label13.Name = "label13";
            label13.Size = new Size(11, 15);
            label13.TabIndex = 11;
            label13.Text = "|";
            // 
            // panelProduct1
            // 
            panelProduct1.BackColor = Color.White;
            panelProduct1.Controls.Add(tbCDateTime);
            panelProduct1.Controls.Add(tbUser);
            panelProduct1.Controls.Add(tbUserRole);
            panelProduct1.Controls.Add(label13);
            panelProduct1.Controls.Add(label4);
            panelProduct1.Controls.Add(label3);
            panelProduct1.Controls.Add(label1);
            panelProduct1.Controls.Add(label2);
            panelProduct1.Dock = DockStyle.Top;
            panelProduct1.Location = new Point(0, 0);
            panelProduct1.Name = "panelProduct1";
            panelProduct1.Size = new Size(1113, 79);
            panelProduct1.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(38, 107);
            label8.Name = "label8";
            label8.Size = new Size(129, 17);
            label8.TabIndex = 51;
            label8.Text = "ADVANCED SEARCH";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(548, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 20);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.DarkGray;
            txtSearch.Location = new Point(119, 127);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(423, 25);
            txtSearch.TabIndex = 49;
            txtSearch.Text = "Type here";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(65, 130);
            label10.Name = "label10";
            label10.Size = new Size(48, 17);
            label10.TabIndex = 48;
            label10.Text = "Search";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewProduct.BackgroundColor = Color.White;
            dataGridViewProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewProduct.EnableHeadersVisualStyles = false;
            dataGridViewProduct.Location = new Point(25, 169);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersVisible = false;
            dataGridViewProduct.RowTemplate.Height = 25;
            dataGridViewProduct.Size = new Size(596, 404);
            dataGridViewProduct.TabIndex = 47;
            dataGridViewProduct.CellContentClick += dataGridViewProduct_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Product ID";
            Column1.Name = "Column1";
            Column1.Width = 92;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Product Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Category ID";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(638, 124);
            label9.Name = "label9";
            label9.Size = new Size(64, 17);
            label9.TabIndex = 67;
            label9.Text = "Category";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox4.ForeColor = Color.DarkGray;
            textBox4.Location = new Point(708, 121);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(360, 25);
            textBox4.TabIndex = 66;
            // 
            // txtProductPrice
            // 
            txtProductPrice.BorderStyle = BorderStyle.FixedSingle;
            txtProductPrice.Location = new Point(797, 360);
            txtProductPrice.Multiline = true;
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(271, 27);
            txtProductPrice.TabIndex = 65;
            // 
            // txtProductCategory
            // 
            txtProductCategory.BorderStyle = BorderStyle.FixedSingle;
            txtProductCategory.Location = new Point(797, 327);
            txtProductCategory.Multiline = true;
            txtProductCategory.Name = "txtProductCategory";
            txtProductCategory.Size = new Size(271, 27);
            txtProductCategory.TabIndex = 64;
            // 
            // txtProuctName
            // 
            txtProuctName.BorderStyle = BorderStyle.FixedSingle;
            txtProuctName.Location = new Point(797, 248);
            txtProuctName.Multiline = true;
            txtProuctName.Name = "txtProuctName";
            txtProuctName.Size = new Size(271, 73);
            txtProuctName.TabIndex = 63;
            // 
            // txtProductID
            // 
            txtProductID.BorderStyle = BorderStyle.FixedSingle;
            txtProductID.Location = new Point(797, 215);
            txtProductID.Multiline = true;
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(271, 27);
            txtProductID.TabIndex = 62;
            // 
            // btnProductCancel
            // 
            btnProductCancel.BackColor = Color.White;
            btnProductCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductCancel.ForeColor = Color.Black;
            btnProductCancel.Location = new Point(933, 533);
            btnProductCancel.Name = "btnProductCancel";
            btnProductCancel.Size = new Size(116, 34);
            btnProductCancel.TabIndex = 61;
            btnProductCancel.Text = "CANCEL";
            btnProductCancel.UseVisualStyleBackColor = false;
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.BackColor = Color.White;
            btnProductUpdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductUpdate.ForeColor = Color.Black;
            btnProductUpdate.Location = new Point(933, 498);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(116, 34);
            btnProductUpdate.TabIndex = 60;
            btnProductUpdate.Text = "UPDATE";
            btnProductUpdate.UseVisualStyleBackColor = false;
            // 
            // btnProductDelete
            // 
            btnProductDelete.BackColor = Color.White;
            btnProductDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductDelete.ForeColor = Color.Black;
            btnProductDelete.Location = new Point(817, 533);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(116, 34);
            btnProductDelete.TabIndex = 59;
            btnProductDelete.Text = "DELETE";
            btnProductDelete.UseVisualStyleBackColor = false;
            // 
            // btnProductSave
            // 
            btnProductSave.BackColor = Color.White;
            btnProductSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductSave.ForeColor = Color.Black;
            btnProductSave.Location = new Point(817, 498);
            btnProductSave.Name = "btnProductSave";
            btnProductSave.Size = new Size(116, 34);
            btnProductSave.TabIndex = 58;
            btnProductSave.Text = "SAVE";
            btnProductSave.UseVisualStyleBackColor = false;
            // 
            // btnProductCreateNew
            // 
            btnProductCreateNew.BackColor = Color.Black;
            btnProductCreateNew.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductCreateNew.ForeColor = Color.White;
            btnProductCreateNew.Location = new Point(686, 498);
            btnProductCreateNew.Name = "btnProductCreateNew";
            btnProductCreateNew.Size = new Size(125, 69);
            btnProductCreateNew.TabIndex = 57;
            btnProductCreateNew.Text = "CREATE NEW";
            btnProductCreateNew.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(689, 360);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 56;
            label7.Text = "Price *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(689, 327);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 55;
            label6.Text = "Category *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(685, 250);
            label5.Name = "label5";
            label5.Size = new Size(106, 17);
            label5.TabIndex = 54;
            label5.Text = "Product Name *";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(689, 215);
            label11.Name = "label11";
            label11.Size = new Size(83, 17);
            label11.TabIndex = 53;
            label11.Text = "Product ID *";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(657, 182);
            label12.Name = "label12";
            label12.Size = new Size(161, 17);
            label12.TabIndex = 52;
            label12.Text = "PRODUCT INFORMATION";
            // 
            // tbCDateTime
            // 
            tbCDateTime.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbCDateTime.Location = new Point(996, 49);
            tbCDateTime.Name = "tbCDateTime";
            tbCDateTime.Size = new Size(100, 19);
            tbCDateTime.TabIndex = 22;
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(888, 24);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(100, 19);
            tbUser.TabIndex = 21;
            // 
            // tbUserRole
            // 
            tbUserRole.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUserRole.Location = new Point(996, 24);
            tbUserRole.Name = "tbUserRole";
            tbUserRole.Size = new Size(100, 19);
            tbUserRole.TabIndex = 20;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 600);
            ControlBox = false;
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductCategory);
            Controls.Add(txtProuctName);
            Controls.Add(txtProductID);
            Controls.Add(btnProductCancel);
            Controls.Add(btnProductUpdate);
            Controls.Add(btnProductDelete);
            Controls.Add(btnProductSave);
            Controls.Add(btnProductCreateNew);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(label10);
            Controls.Add(dataGridViewProduct);
            Controls.Add(panelProduct1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            panelProduct1.ResumeLayout(false);
            panelProduct1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label13;
        private Panel panelProduct1;
        private Label label8;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
        private Label label10;
        private DataGridView dataGridViewProduct;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label9;
        private TextBox textBox4;
        private TextBox txtProductPrice;
        private TextBox txtProductCategory;
        private TextBox txtProuctName;
        private TextBox txtProductID;
        private Button btnProductCancel;
        private Button btnProductUpdate;
        private Button btnProductDelete;
        private Button btnProductSave;
        private Button btnProductCreateNew;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label11;
        private Label label12;
        private TextBox tbCDateTime;
        private TextBox tbUser;
        private TextBox tbUserRole;
    }
}