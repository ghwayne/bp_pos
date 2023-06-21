namespace BREWPLS_POS_SYSTEM
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            lblHome1 = new Label();
            lblHome2 = new Label();
            panelHome = new Panel();
            btnHome1 = new Button();
            btnLogout = new PictureBox();
            panel1 = new Panel();
            btnCustomer = new PictureBox();
            btnCategory = new PictureBox();
            btnProduct = new PictureBox();
            btnReport = new PictureBox();
            btnDelivery = new PictureBox();
            btnStaff = new PictureBox();
            btnDashboard = new PictureBox();
            btnStock = new PictureBox();
            btnPOS = new PictureBox();
            btnHome = new PictureBox();
            panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogout).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelivery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPOS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            SuspendLayout();
            // 
            // lblHome1
            // 
            lblHome1.AutoSize = true;
            lblHome1.BackColor = Color.Transparent;
            lblHome1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHome1.ForeColor = Color.White;
            lblHome1.Location = new Point(32, 33);
            lblHome1.Name = "lblHome1";
            lblHome1.Size = new Size(227, 47);
            lblHome1.TabIndex = 3;
            lblHome1.Text = "b r e w, p l s.";
            // 
            // lblHome2
            // 
            lblHome2.AutoSize = true;
            lblHome2.BackColor = Color.Transparent;
            lblHome2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHome2.ForeColor = Color.White;
            lblHome2.Location = new Point(49, 78);
            lblHome2.Name = "lblHome2";
            lblHome2.Size = new Size(181, 25);
            lblHome2.TabIndex = 4;
            lblHome2.Text = "COFFEE + MILKTEA";
            // 
            // panelHome
            // 
            panelHome.BackgroundImage = (Image)resources.GetObject("panelHome.BackgroundImage");
            panelHome.Controls.Add(btnHome1);
            panelHome.Controls.Add(lblHome2);
            panelHome.Controls.Add(lblHome1);
            panelHome.Dock = DockStyle.Fill;
            panelHome.Location = new Point(87, 0);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1113, 600);
            panelHome.TabIndex = 2;
            // 
            // btnHome1
            // 
            btnHome1.BackColor = Color.White;
            btnHome1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome1.ForeColor = Color.Black;
            btnHome1.Location = new Point(850, 532);
            btnHome1.Name = "btnHome1";
            btnHome1.Size = new Size(234, 43);
            btnHome1.TabIndex = 5;
            btnHome1.Text = "ORDER NOW";
            btnHome1.UseVisualStyleBackColor = false;
            btnHome1.Click += btnHomeOrderNow_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Location = new Point(29, 549);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(24, 26);
            btnLogout.TabIndex = 9;
            btnLogout.TabStop = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnProduct);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnDelivery);
            panel1.Controls.Add(btnStaff);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnStock);
            panel1.Controls.Add(btnPOS);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(87, 600);
            panel1.TabIndex = 1;
            // 
            // btnCustomer
            // 
            btnCustomer.BackgroundImage = (Image)resources.GetObject("btnCustomer.BackgroundImage");
            btnCustomer.BackgroundImageLayout = ImageLayout.None;
            btnCustomer.Location = new Point(29, 339);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(24, 26);
            btnCustomer.TabIndex = 25;
            btnCustomer.TabStop = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackgroundImage = (Image)resources.GetObject("btnCategory.BackgroundImage");
            btnCategory.BackgroundImageLayout = ImageLayout.None;
            btnCategory.Location = new Point(29, 118);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(24, 26);
            btnCategory.TabIndex = 24;
            btnCategory.TabStop = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackgroundImage = (Image)resources.GetObject("btnProduct.BackgroundImage");
            btnProduct.BackgroundImageLayout = ImageLayout.None;
            btnProduct.Location = new Point(29, 205);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(24, 26);
            btnProduct.TabIndex = 23;
            btnProduct.TabStop = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnReport
            // 
            btnReport.BackgroundImage = (Image)resources.GetObject("btnReport.BackgroundImage");
            btnReport.BackgroundImageLayout = ImageLayout.None;
            btnReport.Location = new Point(29, 427);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(24, 26);
            btnReport.TabIndex = 22;
            btnReport.TabStop = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnDelivery
            // 
            btnDelivery.BackgroundImage = (Image)resources.GetObject("btnDelivery.BackgroundImage");
            btnDelivery.BackgroundImageLayout = ImageLayout.None;
            btnDelivery.Location = new Point(29, 383);
            btnDelivery.Name = "btnDelivery";
            btnDelivery.Size = new Size(24, 26);
            btnDelivery.TabIndex = 21;
            btnDelivery.TabStop = false;
            btnDelivery.Click += btnDelivery_Click;
            // 
            // btnStaff
            // 
            btnStaff.BackgroundImage = (Image)resources.GetObject("btnStaff.BackgroundImage");
            btnStaff.BackgroundImageLayout = ImageLayout.None;
            btnStaff.Location = new Point(29, 248);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(24, 26);
            btnStaff.TabIndex = 20;
            btnStaff.TabStop = false;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.Location = new Point(29, 75);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(24, 26);
            btnDashboard.TabIndex = 19;
            btnDashboard.TabStop = false;
            btnDashboard.Click += btnDashboard_Click_1;
            // 
            // btnStock
            // 
            btnStock.BackgroundImage = (Image)resources.GetObject("btnStock.BackgroundImage");
            btnStock.BackgroundImageLayout = ImageLayout.None;
            btnStock.Location = new Point(29, 293);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(24, 26);
            btnStock.TabIndex = 18;
            btnStock.TabStop = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnPOS
            // 
            btnPOS.BackgroundImage = (Image)resources.GetObject("btnPOS.BackgroundImage");
            btnPOS.BackgroundImageLayout = ImageLayout.None;
            btnPOS.Location = new Point(29, 161);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(24, 26);
            btnPOS.TabIndex = 17;
            btnPOS.TabStop = false;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnHome
            // 
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.None;
            btnHome.Location = new Point(29, 32);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(24, 26);
            btnHome.TabIndex = 16;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            ControlBox = false;
            Controls.Add(panelHome);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            Text = "frmHome";
            Load += frmHome_Load;
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogout).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelivery).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPOS).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblHome1;
        private Label lblHome2;
        private Panel panel2;
        private PictureBox btnLogout;
        private Panel panel1;
        private PictureBox btnCategory;
        private PictureBox btnProduct;
        private PictureBox btnReport;
        private PictureBox btnDelivery;
        private PictureBox btnStaff;
        private PictureBox btnDashboard;
        private PictureBox btnStock;
        private PictureBox btnPOS;
        private PictureBox btnHome;
        private PictureBox btnCustomer;
        private Panel panelHome;
        private Button btnHome1;
    }
}