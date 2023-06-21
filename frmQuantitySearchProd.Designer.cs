namespace BREWPLS_POS_SYSTEM
{
    partial class frmQuantitySearchProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuantitySearchProd));
            panelSPQ1 = new Panel();
            btnCloseSP = new PictureBox();
            lblQtySP = new Label();
            txtSPQty = new TextBox();
            panelSPQ1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseSP).BeginInit();
            SuspendLayout();
            // 
            // panelSPQ1
            // 
            panelSPQ1.BackColor = Color.White;
            panelSPQ1.Controls.Add(btnCloseSP);
            panelSPQ1.Controls.Add(lblQtySP);
            panelSPQ1.Dock = DockStyle.Top;
            panelSPQ1.Location = new Point(0, 0);
            panelSPQ1.Name = "panelSPQ1";
            panelSPQ1.Size = new Size(199, 29);
            panelSPQ1.TabIndex = 0;
            // 
            // btnCloseSP
            // 
            btnCloseSP.Image = (Image)resources.GetObject("btnCloseSP.Image");
            btnCloseSP.Location = new Point(177, 6);
            btnCloseSP.Name = "btnCloseSP";
            btnCloseSP.Size = new Size(19, 17);
            btnCloseSP.TabIndex = 1;
            btnCloseSP.TabStop = false;
            // 
            // lblQtySP
            // 
            lblQtySP.AutoSize = true;
            lblQtySP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblQtySP.Location = new Point(3, 6);
            lblQtySP.Name = "lblQtySP";
            lblQtySP.Size = new Size(74, 17);
            lblQtySP.TabIndex = 0;
            lblQtySP.Text = "QUANTITY";
            // 
            // txtSPQty
            // 
            txtSPQty.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtSPQty.Location = new Point(12, 43);
            txtSPQty.Multiline = true;
            txtSPQty.Name = "txtSPQty";
            txtSPQty.Size = new Size(175, 40);
            txtSPQty.TabIndex = 1;
            txtSPQty.Text = "6";
            txtSPQty.TextAlign = HorizontalAlignment.Center;
            txtSPQty.TextChanged += txtSPQty_TextChanged;
            // 
            // frmQuantitySearchProd
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 99);
            ControlBox = false;
            Controls.Add(txtSPQty);
            Controls.Add(panelSPQ1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuantitySearchProd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuantitySearchProd";
            panelSPQ1.ResumeLayout(false);
            panelSPQ1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSPQ1;
        private PictureBox btnCloseSP;
        private Label lblQtySP;
        private TextBox txtSPQty;
    }
}