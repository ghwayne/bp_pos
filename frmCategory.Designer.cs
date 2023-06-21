namespace BREWPLS_POS_SYSTEM
{
    partial class frmCategory
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            panelCategory1 = new Panel();
            tbDateTime = new TextBox();
            tbUser = new TextBox();
            tbUserRole = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtCategorySearch = new TextBox();
            lblCategory1 = new Label();
            lblCategory2 = new Label();
            txtCategoryCode = new TextBox();
            btnCategoryCancel = new Button();
            btnCategoryUpdate = new Button();
            btnCategoryDelete = new Button();
            btnCategorySave = new Button();
            btnCategoryCreateNew = new Button();
            label14 = new Label();
            txtCategoryName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dataGridViewCategory = new DataGridView();
            CategoryId = new DataGridViewTextBoxColumn();
            CategoryCode = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            label9 = new Label();
            txtCategoryId = new TextBox();
            panelCategory1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            SuspendLayout();
            // 
            // panelCategory1
            // 
            panelCategory1.BackColor = Color.White;
            panelCategory1.Controls.Add(tbDateTime);
            panelCategory1.Controls.Add(tbUser);
            panelCategory1.Controls.Add(tbUserRole);
            panelCategory1.Controls.Add(label1);
            panelCategory1.Controls.Add(label4);
            panelCategory1.Controls.Add(label3);
            panelCategory1.Controls.Add(label2);
            panelCategory1.Controls.Add(label5);
            panelCategory1.Dock = DockStyle.Top;
            panelCategory1.Location = new Point(0, 0);
            panelCategory1.Name = "panelCategory1";
            panelCategory1.Size = new Size(1113, 74);
            panelCategory1.TabIndex = 42;
            // 
            // tbDateTime
            // 
            tbDateTime.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDateTime.Location = new Point(996, 48);
            tbDateTime.Name = "tbDateTime";
            tbDateTime.Size = new Size(100, 19);
            tbDateTime.TabIndex = 16;
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(888, 23);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(100, 19);
            tbUser.TabIndex = 15;
            // 
            // tbUserRole
            // 
            tbUserRole.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUserRole.Location = new Point(996, 23);
            tbUserRole.Name = "tbUserRole";
            tbUserRole.Size = new Size(100, 19);
            tbUserRole.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(987, 26);
            label1.Name = "label1";
            label1.Size = new Size(11, 15);
            label1.TabIndex = 11;
            label1.Text = "|";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(157, 30);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 4;
            label4.Text = "CATEGORY";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(19, 21);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 1;
            label2.Text = "b r e w, p l s.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 41);
            label5.Name = "label5";
            label5.Size = new Size(87, 12);
            label5.TabIndex = 2;
            label5.Text = "COFFEE + MILKTEA";
            // 
            // txtCategorySearch
            // 
            txtCategorySearch.Location = new Point(99, 120);
            txtCategorySearch.Name = "txtCategorySearch";
            txtCategorySearch.Size = new Size(522, 25);
            txtCategorySearch.TabIndex = 60;
            txtCategorySearch.TextChanged += txtCategorySearch_TextChanged;
            // 
            // lblCategory1
            // 
            lblCategory1.AutoSize = true;
            lblCategory1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory1.Location = new Point(20, 100);
            lblCategory1.Name = "lblCategory1";
            lblCategory1.Size = new Size(120, 17);
            lblCategory1.TabIndex = 58;
            lblCategory1.Text = "ADVANCE SEARCH";
            // 
            // lblCategory2
            // 
            lblCategory2.AutoSize = true;
            lblCategory2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory2.Location = new Point(45, 123);
            lblCategory2.Name = "lblCategory2";
            lblCategory2.Size = new Size(48, 17);
            lblCategory2.TabIndex = 59;
            lblCategory2.Text = "Search";
            // 
            // txtCategoryCode
            // 
            txtCategoryCode.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryCode.Location = new Point(788, 227);
            txtCategoryCode.Multiline = true;
            txtCategoryCode.Name = "txtCategoryCode";
            txtCategoryCode.Size = new Size(271, 17);
            txtCategoryCode.TabIndex = 92;
            // 
            // btnCategoryCancel
            // 
            btnCategoryCancel.BackColor = Color.White;
            btnCategoryCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategoryCancel.ForeColor = Color.Black;
            btnCategoryCancel.Location = new Point(955, 500);
            btnCategoryCancel.Name = "btnCategoryCancel";
            btnCategoryCancel.Size = new Size(116, 34);
            btnCategoryCancel.TabIndex = 90;
            btnCategoryCancel.Text = "CANCEL";
            btnCategoryCancel.UseVisualStyleBackColor = false;
            // 
            // btnCategoryUpdate
            // 
            btnCategoryUpdate.BackColor = Color.White;
            btnCategoryUpdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategoryUpdate.ForeColor = Color.Black;
            btnCategoryUpdate.Location = new Point(955, 465);
            btnCategoryUpdate.Name = "btnCategoryUpdate";
            btnCategoryUpdate.Size = new Size(116, 34);
            btnCategoryUpdate.TabIndex = 89;
            btnCategoryUpdate.Text = "UPDATE";
            btnCategoryUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCategoryDelete
            // 
            btnCategoryDelete.BackColor = Color.White;
            btnCategoryDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategoryDelete.ForeColor = Color.Black;
            btnCategoryDelete.Location = new Point(839, 500);
            btnCategoryDelete.Name = "btnCategoryDelete";
            btnCategoryDelete.Size = new Size(116, 34);
            btnCategoryDelete.TabIndex = 88;
            btnCategoryDelete.Text = "DELETE";
            btnCategoryDelete.UseVisualStyleBackColor = false;
            // 
            // btnCategorySave
            // 
            btnCategorySave.BackColor = Color.White;
            btnCategorySave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategorySave.ForeColor = Color.Black;
            btnCategorySave.Location = new Point(839, 465);
            btnCategorySave.Name = "btnCategorySave";
            btnCategorySave.Size = new Size(116, 34);
            btnCategorySave.TabIndex = 87;
            btnCategorySave.Text = "SAVE";
            btnCategorySave.UseVisualStyleBackColor = false;
            // 
            // btnCategoryCreateNew
            // 
            btnCategoryCreateNew.BackColor = Color.Black;
            btnCategoryCreateNew.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategoryCreateNew.ForeColor = Color.White;
            btnCategoryCreateNew.Location = new Point(708, 465);
            btnCategoryCreateNew.Name = "btnCategoryCreateNew";
            btnCategoryCreateNew.Size = new Size(125, 69);
            btnCategoryCreateNew.TabIndex = 86;
            btnCategoryCreateNew.Text = "CREATE NEW";
            btnCategoryCreateNew.UseVisualStyleBackColor = false;
            btnCategoryCreateNew.Click += btnCategoryCreateNew_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(645, 157);
            label14.Name = "label14";
            label14.Size = new Size(167, 17);
            label14.TabIndex = 83;
            label14.Text = "CATEGORY INFORMATION";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Location = new Point(788, 262);
            txtCategoryName.Multiline = true;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(271, 17);
            txtCategoryName.TabIndex = 96;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(668, 259);
            label7.Name = "label7";
            label7.Size = new Size(114, 17);
            label7.TabIndex = 95;
            label7.Text = "Category Name *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(668, 227);
            label8.Name = "label8";
            label8.Size = new Size(109, 17);
            label8.TabIndex = 97;
            label8.Text = "Category Code *";
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.AllowUserToAddRows = false;
            dataGridViewCategory.BackgroundColor = Color.White;
            dataGridViewCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCategory.ColumnHeadersHeight = 30;
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCategory.Columns.AddRange(new DataGridViewColumn[] { CategoryId, CategoryCode, CategoryName, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCategory.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCategory.EnableHeadersVisualStyles = false;
            dataGridViewCategory.Location = new Point(19, 157);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.RowHeadersVisible = false;
            dataGridViewCategory.RowTemplate.Height = 25;
            dataGridViewCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategory.Size = new Size(602, 366);
            dataGridViewCategory.TabIndex = 98;
            // 
            // CategoryId
            // 
            CategoryId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CategoryId.DataPropertyName = "colCategoryId";
            CategoryId.HeaderText = "Category ID";
            CategoryId.Name = "CategoryId";
            // 
            // CategoryCode
            // 
            CategoryCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryCode.DataPropertyName = "colCategoryCode";
            CategoryCode.HeaderText = "Category Code";
            CategoryCode.Name = "CategoryCode";
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryName.DataPropertyName = "colCategoryName";
            CategoryName.HeaderText = "Category Name";
            CategoryName.Name = "CategoryName";
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.Name = "Edit";
            Edit.Width = 5;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.Width = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(668, 195);
            label9.Name = "label9";
            label9.Size = new Size(91, 17);
            label9.TabIndex = 100;
            label9.Text = "Category ID *";
            // 
            // txtCategoryId
            // 
            txtCategoryId.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryId.Location = new Point(788, 195);
            txtCategoryId.Multiline = true;
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(271, 17);
            txtCategoryId.TabIndex = 99;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 600);
            ControlBox = false;
            Controls.Add(label9);
            Controls.Add(txtCategoryId);
            Controls.Add(dataGridViewCategory);
            Controls.Add(label8);
            Controls.Add(txtCategoryName);
            Controls.Add(label7);
            Controls.Add(txtCategoryCode);
            Controls.Add(btnCategoryCancel);
            Controls.Add(btnCategoryUpdate);
            Controls.Add(btnCategoryDelete);
            Controls.Add(btnCategorySave);
            Controls.Add(btnCategoryCreateNew);
            Controls.Add(label14);
            Controls.Add(txtCategorySearch);
            Controls.Add(lblCategory1);
            Controls.Add(lblCategory2);
            Controls.Add(panelCategory1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panelCategory1.ResumeLayout(false);
            panelCategory1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelCategory1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtCategorySearch;
        private Label lblCategory1;
        private Label lblCategory2;
        private TextBox txtCategoryCode;
        private Button btnCategoryCancel;
        private Button btnCategoryUpdate;
        private Button btnCategoryDelete;
        private Button btnCategorySave;
        private Button btnCategoryCreateNew;
        private Label label14;

        private Label label6;
        private TextBox txtCategoryName;
        private Label label7;
        private Label label8;
        private DataGridView dataGridViewCategory;
        private Label label9;
        private TextBox txtCategoryId;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn CategoryCode;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private TextBox tbDateTime;
        private TextBox tbUser;
        private TextBox tbUserRole;
    }
}