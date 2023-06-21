namespace BREWPLS_POS_SYSTEM
{
    partial class frmDashboard
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            panelDashboard1 = new Panel();
            tbDateTime = new TextBox();
            tbUser = new TextBox();
            tbUserRole = new TextBox();
            btnCriticalStocks = new Button();
            btnTotalItems = new Button();
            btnTotalSales = new Button();
            btnItemSold = new Button();
            panelDashboard1.SuspendLayout();
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
            label4.Size = new Size(109, 21);
            label4.TabIndex = 4;
            label4.Text = "DASHBOARD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(990, 26);
            label6.Name = "label6";
            label6.Size = new Size(11, 15);
            label6.TabIndex = 6;
            label6.Text = "|";
            // 
            // panelDashboard1
            // 
            panelDashboard1.BackColor = Color.White;
            panelDashboard1.Controls.Add(tbDateTime);
            panelDashboard1.Controls.Add(tbUser);
            panelDashboard1.Controls.Add(tbUserRole);
            panelDashboard1.Controls.Add(label6);
            panelDashboard1.Controls.Add(label4);
            panelDashboard1.Controls.Add(label3);
            panelDashboard1.Controls.Add(label1);
            panelDashboard1.Controls.Add(label2);
            panelDashboard1.Dock = DockStyle.Top;
            panelDashboard1.Location = new Point(0, 0);
            panelDashboard1.Name = "panelDashboard1";
            panelDashboard1.Size = new Size(1111, 81);
            panelDashboard1.TabIndex = 33;
            // 
            // tbDateTime
            // 
            tbDateTime.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDateTime.Location = new Point(999, 48);
            tbDateTime.Name = "tbDateTime";
            tbDateTime.Size = new Size(100, 19);
            tbDateTime.TabIndex = 13;
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(891, 23);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(100, 19);
            tbUser.TabIndex = 12;
            // 
            // tbUserRole
            // 
            tbUserRole.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUserRole.Location = new Point(999, 23);
            tbUserRole.Name = "tbUserRole";
            tbUserRole.Size = new Size(100, 19);
            tbUserRole.TabIndex = 11;
            tbUserRole.TextChanged += tbUserRole_TextChanged;
            // 
            // btnCriticalStocks
            // 
            btnCriticalStocks.BackColor = Color.White;
            btnCriticalStocks.BackgroundImageLayout = ImageLayout.None;
            btnCriticalStocks.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCriticalStocks.ForeColor = Color.Black;
            btnCriticalStocks.Location = new Point(538, 323);
            btnCriticalStocks.Name = "btnCriticalStocks";
            btnCriticalStocks.Size = new Size(289, 110);
            btnCriticalStocks.TabIndex = 41;
            btnCriticalStocks.Text = "Critical Stocks";
            btnCriticalStocks.UseVisualStyleBackColor = false;
            // 
            // btnTotalItems
            // 
            btnTotalItems.BackColor = Color.White;
            btnTotalItems.BackgroundImageLayout = ImageLayout.None;
            btnTotalItems.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTotalItems.ForeColor = Color.Black;
            btnTotalItems.Location = new Point(231, 323);
            btnTotalItems.Name = "btnTotalItems";
            btnTotalItems.Size = new Size(289, 110);
            btnTotalItems.TabIndex = 40;
            btnTotalItems.Text = "Total Items";
            btnTotalItems.UseVisualStyleBackColor = false;
            // 
            // btnTotalSales
            // 
            btnTotalSales.BackColor = Color.White;
            btnTotalSales.BackgroundImageLayout = ImageLayout.None;
            btnTotalSales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTotalSales.ForeColor = Color.Black;
            btnTotalSales.Location = new Point(231, 177);
            btnTotalSales.Name = "btnTotalSales";
            btnTotalSales.Size = new Size(289, 110);
            btnTotalSales.TabIndex = 38;
            btnTotalSales.Text = "Total Sales";
            btnTotalSales.UseVisualStyleBackColor = false;
            // 
            // btnItemSold
            // 
            btnItemSold.BackColor = Color.White;
            btnItemSold.BackgroundImageLayout = ImageLayout.None;
            btnItemSold.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnItemSold.ForeColor = Color.Black;
            btnItemSold.Location = new Point(538, 177);
            btnItemSold.Name = "btnItemSold";
            btnItemSold.Size = new Size(289, 110);
            btnItemSold.TabIndex = 39;
            btnItemSold.Text = "Item Sold";
            btnItemSold.UseVisualStyleBackColor = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1111, 598);
            ControlBox = false;
            Controls.Add(btnCriticalStocks);
            Controls.Add(btnTotalItems);
            Controls.Add(btnTotalSales);
            Controls.Add(btnItemSold);
            Controls.Add(panelDashboard1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmDashboard_Load_1;
            panelDashboard1.ResumeLayout(false);
            panelDashboard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Panel panelDashboard1;
        private Button btnCriticalStocks;
        private Button btnTotalItems;
        private Button btnTotalSales;
        private Button btnItemSold;
        private TextBox tbUserRole;
        private TextBox tbUser;
        private TextBox tbDateTime;
    }
}