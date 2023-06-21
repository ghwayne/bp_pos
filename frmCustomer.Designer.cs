namespace BREWPLS_POS_SYSTEM
{
    partial class frmCustomer
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label13 = new Label();
            panelCustomer1 = new Panel();
            btnCustomerCancel = new Button();
            dataGridViewCustomer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tbDateTime = new TextBox();
            tbUser = new TextBox();
            tbUserRole = new TextBox();
            panelCustomer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
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
            label4.Size = new Size(95, 21);
            label4.TabIndex = 4;
            label4.Text = "CUSTOMER";
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
            // panelCustomer1
            // 
            panelCustomer1.BackColor = Color.White;
            panelCustomer1.Controls.Add(tbDateTime);
            panelCustomer1.Controls.Add(tbUser);
            panelCustomer1.Controls.Add(tbUserRole);
            panelCustomer1.Controls.Add(label13);
            panelCustomer1.Controls.Add(label4);
            panelCustomer1.Controls.Add(label3);
            panelCustomer1.Controls.Add(label1);
            panelCustomer1.Controls.Add(label2);
            panelCustomer1.Dock = DockStyle.Top;
            panelCustomer1.Location = new Point(0, 0);
            panelCustomer1.Name = "panelCustomer1";
            panelCustomer1.Size = new Size(1113, 79);
            panelCustomer1.TabIndex = 39;
            // 
            // btnCustomerCancel
            // 
            btnCustomerCancel.BackColor = Color.White;
            btnCustomerCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerCancel.ForeColor = Color.Black;
            btnCustomerCancel.Location = new Point(984, 548);
            btnCustomerCancel.Name = "btnCustomerCancel";
            btnCustomerCancel.Size = new Size(111, 34);
            btnCustomerCancel.TabIndex = 90;
            btnCustomerCancel.Text = "CANCEL";
            btnCustomerCancel.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.AllowUserToAddRows = false;
            dataGridViewCustomer.BackgroundColor = Color.White;
            dataGridViewCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCustomer.ColumnHeadersHeight = 30;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCustomer.EnableHeadersVisualStyles = false;
            dataGridViewCustomer.Location = new Point(12, 85);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersVisible = false;
            dataGridViewCustomer.RowTemplate.Height = 25;
            dataGridViewCustomer.Size = new Size(1083, 457);
            dataGridViewCustomer.TabIndex = 89;
            dataGridViewCustomer.CellContentClick += dataGridViewCustomer_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Customer ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Address";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Contact No.";
            Column4.Name = "Column4";
            // 
            // tbDateTime
            // 
            tbDateTime.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDateTime.Location = new Point(996, 48);
            tbDateTime.Name = "tbDateTime";
            tbDateTime.Size = new Size(100, 19);
            tbDateTime.TabIndex = 19;
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(888, 23);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(100, 19);
            tbUser.TabIndex = 18;
            // 
            // tbUserRole
            // 
            tbUserRole.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUserRole.Location = new Point(996, 23);
            tbUserRole.Name = "tbUserRole";
            tbUserRole.Size = new Size(100, 19);
            tbUserRole.TabIndex = 17;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 600);
            Controls.Add(btnCustomerCancel);
            Controls.Add(dataGridViewCustomer);
            Controls.Add(panelCustomer1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomer";
            Load += frmCustomer_Load;
            panelCustomer1.ResumeLayout(false);
            panelCustomer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label13;
        private Panel panelCustomer1;
        private Button btnCustomerCancel;
        private DataGridView dataGridViewCustomer;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox tbDateTime;
        private TextBox tbUser;
        private TextBox tbUserRole;
    }
}