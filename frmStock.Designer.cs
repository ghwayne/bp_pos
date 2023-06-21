namespace BREWPLS_POS_SYSTEM
{
    partial class frmStock
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelStock1 = new Panel();
            label13 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtStockAddQty = new TextBox();
            lblStockAddQty = new Label();
            dataGridViewStock1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            picStockSearch = new PictureBox();
            txtStockSearch = new TextBox();
            lblStock1 = new Label();
            lblStockSearch = new Label();
            txtStockProName = new TextBox();
            lblStockProName = new Label();
            txtStockinDate = new TextBox();
            lblStockinDate = new Label();
            txtStockProCode = new TextBox();
            lblStockProCode = new Label();
            btnStockDelete = new Button();
            btnStockUpdate = new Button();
            btnStockSave = new Button();
            dataGridViewStock2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            tbCDateTime = new TextBox();
            tbUser = new TextBox();
            tbUserRole = new TextBox();
            panelStock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStockSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock2).BeginInit();
            SuspendLayout();
            // 
            // panelStock1
            // 
            panelStock1.BackColor = Color.White;
            panelStock1.Controls.Add(tbCDateTime);
            panelStock1.Controls.Add(tbUser);
            panelStock1.Controls.Add(tbUserRole);
            panelStock1.Controls.Add(label13);
            panelStock1.Controls.Add(label4);
            panelStock1.Controls.Add(label3);
            panelStock1.Controls.Add(label1);
            panelStock1.Controls.Add(label2);
            panelStock1.Dock = DockStyle.Top;
            panelStock1.Location = new Point(0, 0);
            panelStock1.Name = "panelStock1";
            panelStock1.Size = new Size(1113, 79);
            panelStock1.TabIndex = 38;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(157, 30);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 4;
            label4.Text = "STOCK";
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
            // txtStockAddQty
            // 
            txtStockAddQty.Location = new Point(148, 145);
            txtStockAddQty.Name = "txtStockAddQty";
            txtStockAddQty.Size = new Size(362, 25);
            txtStockAddQty.TabIndex = 99;
            // 
            // lblStockAddQty
            // 
            lblStockAddQty.AutoSize = true;
            lblStockAddQty.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStockAddQty.Location = new Point(52, 148);
            lblStockAddQty.Name = "lblStockAddQty";
            lblStockAddQty.Size = new Size(90, 17);
            lblStockAddQty.TabIndex = 98;
            lblStockAddQty.Text = "Add Quantity";
            // 
            // dataGridViewStock1
            // 
            dataGridViewStock1.AllowUserToAddRows = false;
            dataGridViewStock1.BackgroundColor = Color.WhiteSmoke;
            dataGridViewStock1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewStock1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewStock1.ColumnHeadersHeight = 30;
            dataGridViewStock1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewStock1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewStock1.EnableHeadersVisualStyles = false;
            dataGridViewStock1.Location = new Point(19, 193);
            dataGridViewStock1.Name = "dataGridViewStock1";
            dataGridViewStock1.RowHeadersVisible = false;
            dataGridViewStock1.RowTemplate.Height = 25;
            dataGridViewStock1.Size = new Size(538, 352);
            dataGridViewStock1.TabIndex = 97;
            dataGridViewStock1.CellContentClick += dataGridViewStock1_CellContentClick;
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
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Category";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Quantity";
            Column5.Name = "Column5";
            Column5.Width = 79;
            // 
            // Column6
            // 
            Column6.HeaderText = "Re-order";
            Column6.Name = "Column6";
            // 
            // picStockSearch
            // 
            picStockSearch.Image = (Image)resources.GetObject("picStockSearch.Image");
            picStockSearch.Location = new Point(516, 117);
            picStockSearch.Name = "picStockSearch";
            picStockSearch.Size = new Size(19, 22);
            picStockSearch.TabIndex = 96;
            picStockSearch.TabStop = false;
            // 
            // txtStockSearch
            // 
            txtStockSearch.Location = new Point(148, 114);
            txtStockSearch.Name = "txtStockSearch";
            txtStockSearch.Size = new Size(362, 25);
            txtStockSearch.TabIndex = 95;
            // 
            // lblStock1
            // 
            lblStock1.AutoSize = true;
            lblStock1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock1.Location = new Point(27, 94);
            lblStock1.Name = "lblStock1";
            lblStock1.Size = new Size(120, 17);
            lblStock1.TabIndex = 93;
            lblStock1.Text = "ADVANCE SEARCH";
            // 
            // lblStockSearch
            // 
            lblStockSearch.AutoSize = true;
            lblStockSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStockSearch.Location = new Point(52, 117);
            lblStockSearch.Name = "lblStockSearch";
            lblStockSearch.Size = new Size(48, 17);
            lblStockSearch.TabIndex = 94;
            lblStockSearch.Text = "Search";
            // 
            // txtStockProName
            // 
            txtStockProName.Location = new Point(670, 141);
            txtStockProName.Name = "txtStockProName";
            txtStockProName.Size = new Size(425, 25);
            txtStockProName.TabIndex = 109;
            // 
            // lblStockProName
            // 
            lblStockProName.AutoSize = true;
            lblStockProName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStockProName.Location = new Point(573, 144);
            lblStockProName.Name = "lblStockProName";
            lblStockProName.Size = new Size(96, 17);
            lblStockProName.TabIndex = 108;
            lblStockProName.Text = "Product Name";
            // 
            // txtStockinDate
            // 
            txtStockinDate.Location = new Point(887, 110);
            txtStockinDate.Name = "txtStockinDate";
            txtStockinDate.Size = new Size(208, 25);
            txtStockinDate.TabIndex = 107;
            // 
            // lblStockinDate
            // 
            lblStockinDate.AutoSize = true;
            lblStockinDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStockinDate.Location = new Point(793, 113);
            lblStockinDate.Name = "lblStockinDate";
            lblStockinDate.Size = new Size(88, 17);
            lblStockinDate.TabIndex = 106;
            lblStockinDate.Text = "Stock in Date";
            // 
            // txtStockProCode
            // 
            txtStockProCode.Location = new Point(670, 110);
            txtStockProCode.Name = "txtStockProCode";
            txtStockProCode.Size = new Size(117, 25);
            txtStockProCode.TabIndex = 105;
            // 
            // lblStockProCode
            // 
            lblStockProCode.AutoSize = true;
            lblStockProCode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStockProCode.Location = new Point(573, 113);
            lblStockProCode.Name = "lblStockProCode";
            lblStockProCode.Size = new Size(91, 17);
            lblStockProCode.TabIndex = 104;
            lblStockProCode.Text = "Product Code";
            // 
            // btnStockDelete
            // 
            btnStockDelete.BackColor = Color.White;
            btnStockDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStockDelete.ForeColor = Color.Black;
            btnStockDelete.Location = new Point(798, 553);
            btnStockDelete.Name = "btnStockDelete";
            btnStockDelete.Size = new Size(95, 34);
            btnStockDelete.TabIndex = 103;
            btnStockDelete.Text = "DELETE";
            btnStockDelete.UseVisualStyleBackColor = false;
            // 
            // btnStockUpdate
            // 
            btnStockUpdate.BackColor = Color.White;
            btnStockUpdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStockUpdate.ForeColor = Color.Black;
            btnStockUpdate.Location = new Point(899, 553);
            btnStockUpdate.Name = "btnStockUpdate";
            btnStockUpdate.Size = new Size(95, 34);
            btnStockUpdate.TabIndex = 102;
            btnStockUpdate.Text = "UPDATE";
            btnStockUpdate.UseVisualStyleBackColor = false;
            // 
            // btnStockSave
            // 
            btnStockSave.BackColor = Color.White;
            btnStockSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStockSave.ForeColor = Color.Black;
            btnStockSave.Location = new Point(1000, 553);
            btnStockSave.Name = "btnStockSave";
            btnStockSave.Size = new Size(95, 34);
            btnStockSave.TabIndex = 101;
            btnStockSave.Text = "SAVE";
            btnStockSave.UseVisualStyleBackColor = false;
            // 
            // dataGridViewStock2
            // 
            dataGridViewStock2.AllowUserToAddRows = false;
            dataGridViewStock2.BackgroundColor = Color.WhiteSmoke;
            dataGridViewStock2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewStock2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewStock2.ColumnHeadersHeight = 30;
            dataGridViewStock2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewStock2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewStock2.EnableHeadersVisualStyles = false;
            dataGridViewStock2.Location = new Point(573, 192);
            dataGridViewStock2.Name = "dataGridViewStock2";
            dataGridViewStock2.RowHeadersVisible = false;
            dataGridViewStock2.RowTemplate.Height = 25;
            dataGridViewStock2.Size = new Size(522, 352);
            dataGridViewStock2.TabIndex = 100;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "#";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 39;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Code";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 62;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Description";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 79;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.HeaderText = "Stock in Date";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 107;
            // 
            // tbCDateTime
            // 
            tbCDateTime.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbCDateTime.Location = new Point(996, 47);
            tbCDateTime.Name = "tbCDateTime";
            tbCDateTime.Size = new Size(100, 19);
            tbCDateTime.TabIndex = 22;
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(888, 22);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(100, 19);
            tbUser.TabIndex = 21;
            // 
            // tbUserRole
            // 
            tbUserRole.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUserRole.Location = new Point(996, 22);
            tbUserRole.Name = "tbUserRole";
            tbUserRole.Size = new Size(100, 19);
            tbUserRole.TabIndex = 20;
            // 
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 600);
            ControlBox = false;
            Controls.Add(txtStockProName);
            Controls.Add(lblStockProName);
            Controls.Add(txtStockinDate);
            Controls.Add(lblStockinDate);
            Controls.Add(txtStockProCode);
            Controls.Add(lblStockProCode);
            Controls.Add(btnStockDelete);
            Controls.Add(btnStockUpdate);
            Controls.Add(btnStockSave);
            Controls.Add(dataGridViewStock2);
            Controls.Add(txtStockAddQty);
            Controls.Add(lblStockAddQty);
            Controls.Add(dataGridViewStock1);
            Controls.Add(picStockSearch);
            Controls.Add(txtStockSearch);
            Controls.Add(lblStock1);
            Controls.Add(lblStockSearch);
            Controls.Add(panelStock1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStock";
            Load += frmStock_Load;
            panelStock1.ResumeLayout(false);
            panelStock1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStockSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelStock1;
        private Label label13;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtStockAddQty;
        private Label lblStockAddQty;
        private DataGridView dataGridViewStock1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private PictureBox picStockSearch;
        private TextBox txtStockSearch;
        private Label lblStock1;
        private Label lblStockSearch;
        private TextBox txtStockProName;
        private Label lblStockProName;
        private TextBox txtStockinDate;
        private Label lblStockinDate;
        private TextBox txtStockProCode;
        private Label lblStockProCode;
        private Button btnStockDelete;
        private Button btnStockUpdate;
        private Button btnStockSave;
        private DataGridView dataGridViewStock2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private TextBox tbCDateTime;
        private TextBox tbUser;
        private TextBox tbUserRole;
    }
}