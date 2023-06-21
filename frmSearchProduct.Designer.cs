namespace BREWPLS_POS_SYSTEM
{
    partial class frmSearchProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchProduct));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelSP1 = new Panel();
            label1 = new Label();
            picSPSearch = new PictureBox();
            txtSPSearch = new TextBox();
            dataGridViewSearchProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            panelSP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSPSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchProduct).BeginInit();
            SuspendLayout();
            // 
            // panelSP1
            // 
            panelSP1.BackColor = Color.White;
            panelSP1.Controls.Add(label1);
            panelSP1.Dock = DockStyle.Top;
            panelSP1.Location = new Point(0, 0);
            panelSP1.Name = "panelSP1";
            panelSP1.Size = new Size(734, 37);
            panelSP1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 0;
            label1.Text = "SEARCH PRODUCT";
            // 
            // picSPSearch
            // 
            picSPSearch.Image = (Image)resources.GetObject("picSPSearch.Image");
            picSPSearch.Location = new Point(701, 45);
            picSPSearch.Name = "picSPSearch";
            picSPSearch.Size = new Size(17, 19);
            picSPSearch.TabIndex = 5;
            picSPSearch.TabStop = false;
            // 
            // txtSPSearch
            // 
            txtSPSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtSPSearch.Location = new Point(393, 43);
            txtSPSearch.Name = "txtSPSearch";
            txtSPSearch.Size = new Size(306, 25);
            txtSPSearch.TabIndex = 4;
            txtSPSearch.Text = "Type Here";
            // 
            // dataGridViewSearchProduct
            // 
            dataGridViewSearchProduct.BackgroundColor = Color.White;
            dataGridViewSearchProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSearchProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSearchProduct.ColumnHeadersHeight = 30;
            dataGridViewSearchProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewSearchProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewSearchProduct.EnableHeadersVisualStyles = false;
            dataGridViewSearchProduct.Location = new Point(12, 74);
            dataGridViewSearchProduct.Name = "dataGridViewSearchProduct";
            dataGridViewSearchProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewSearchProduct.RowHeadersVisible = false;
            dataGridViewSearchProduct.RowTemplate.Height = 25;
            dataGridViewSearchProduct.Size = new Size(710, 301);
            dataGridViewSearchProduct.TabIndex = 3;
            dataGridViewSearchProduct.CellContentClick += dataGridViewSearchProduct_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.Width = 39;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Product ID";
            Column2.Name = "Column2";
            Column2.Width = 92;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Product Name";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Category";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Price";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Quantity";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "";
            Column7.Name = "Column7";
            Column7.Text = "ADD TO CART";
            // 
            // frmSearchProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 391);
            Controls.Add(picSPSearch);
            Controls.Add(txtSPSearch);
            Controls.Add(dataGridViewSearchProduct);
            Controls.Add(panelSP1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSearchProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSearchProduct";
            panelSP1.ResumeLayout(false);
            panelSP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSPSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSP1;
        private Label label1;
        private PictureBox picSPSearch;
        private TextBox txtSPSearch;
        private DataGridView dataGridViewSearchProduct;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn Column7;
    }
}