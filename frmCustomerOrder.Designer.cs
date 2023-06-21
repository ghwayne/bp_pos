namespace BREWPLS_POS_SYSTEM
{
    partial class frmCustomerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerOrder));
            panelCustomerOrder1 = new Panel();
            picOrderOptionClose = new PictureBox();
            lblCustomerOrderOption = new Label();
            btnCustomerOrderOption2 = new Button();
            btnCustomerOrderOption1 = new Button();
            panelCustomerOrder1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOrderOptionClose).BeginInit();
            SuspendLayout();
            // 
            // panelCustomerOrder1
            // 
            panelCustomerOrder1.BackColor = Color.Black;
            panelCustomerOrder1.BackgroundImageLayout = ImageLayout.Stretch;
            panelCustomerOrder1.Controls.Add(picOrderOptionClose);
            panelCustomerOrder1.Controls.Add(lblCustomerOrderOption);
            panelCustomerOrder1.Dock = DockStyle.Top;
            panelCustomerOrder1.Location = new Point(0, 0);
            panelCustomerOrder1.Name = "panelCustomerOrder1";
            panelCustomerOrder1.Size = new Size(300, 120);
            panelCustomerOrder1.TabIndex = 1;
            // 
            // picOrderOptionClose
            // 
            picOrderOptionClose.Image = (Image)resources.GetObject("picOrderOptionClose.Image");
            picOrderOptionClose.Location = new Point(268, 12);
            picOrderOptionClose.Name = "picOrderOptionClose";
            picOrderOptionClose.Size = new Size(20, 20);
            picOrderOptionClose.TabIndex = 2;
            picOrderOptionClose.TabStop = false;
            picOrderOptionClose.Click += picOrderOptionClose_Click;
            // 
            // lblCustomerOrderOption
            // 
            lblCustomerOrderOption.AutoSize = true;
            lblCustomerOrderOption.BackColor = Color.Transparent;
            lblCustomerOrderOption.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomerOrderOption.ForeColor = Color.White;
            lblCustomerOrderOption.Location = new Point(7, 45);
            lblCustomerOrderOption.Name = "lblCustomerOrderOption";
            lblCustomerOrderOption.Size = new Size(287, 37);
            lblCustomerOrderOption.TabIndex = 0;
            lblCustomerOrderOption.Text = "O R D E R  O P T I O N";
            lblCustomerOrderOption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCustomerOrderOption2
            // 
            btnCustomerOrderOption2.FlatStyle = FlatStyle.Popup;
            btnCustomerOrderOption2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerOrderOption2.Location = new Point(12, 226);
            btnCustomerOrderOption2.Name = "btnCustomerOrderOption2";
            btnCustomerOrderOption2.Size = new Size(276, 94);
            btnCustomerOrderOption2.TabIndex = 3;
            btnCustomerOrderOption2.Text = "ONLINE ORDER";
            btnCustomerOrderOption2.UseVisualStyleBackColor = true;
            btnCustomerOrderOption2.Click += btnCustomerOrderOption2_Click;
            // 
            // btnCustomerOrderOption1
            // 
            btnCustomerOrderOption1.BackColor = Color.Transparent;
            btnCustomerOrderOption1.FlatStyle = FlatStyle.Popup;
            btnCustomerOrderOption1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerOrderOption1.ForeColor = Color.Black;
            btnCustomerOrderOption1.Location = new Point(12, 126);
            btnCustomerOrderOption1.Name = "btnCustomerOrderOption1";
            btnCustomerOrderOption1.Size = new Size(276, 94);
            btnCustomerOrderOption1.TabIndex = 2;
            btnCustomerOrderOption1.Text = "IN-STORE ORDER";
            btnCustomerOrderOption1.UseVisualStyleBackColor = false;
            btnCustomerOrderOption1.Click += btnCustomerOrderOption1_Click_1;
            // 
            // frmCustomerOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 328);
            ControlBox = false;
            Controls.Add(btnCustomerOrderOption2);
            Controls.Add(btnCustomerOrderOption1);
            Controls.Add(panelCustomerOrder1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomerOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomerOrder";
            Load += frmCustomerOrder_Load;
            panelCustomerOrder1.ResumeLayout(false);
            panelCustomerOrder1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOrderOptionClose).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCustomerOrder1;
        private Label lblCustomerOrderOption;
        private PictureBox picOrderOptionClose;
        private Button btnCustomerOrderOption2;
        private Button btnCustomerOrderOption1;
    }
}