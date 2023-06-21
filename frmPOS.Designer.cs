namespace BREWPLS_POS_SYSTEM
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            panelPOS3 = new Panel();
            tbCDateTime = new TextBox();
            label4 = new Label();
            tbUser = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridViewPOS = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtPOSSubtotal = new TextBox();
            txtPOSPrice = new TextBox();
            lblPOSQty = new Label();
            txtPOSQty = new TextBox();
            txtPOSProdName = new TextBox();
            txtPOSProdCode = new TextBox();
            lblPOSProdName = new Label();
            lblPOSPrice = new Label();
            lblPOSSubtotal = new Label();
            lblPOSProdCode = new Label();
            txtPOSTransactionNo = new TextBox();
            btnPOSUnsettledOrder = new Button();
            btnPOSClearCart = new Button();
            btnPOSPayment = new Button();
            btnPOSSearchProduct = new Button();
            btnPOSNewTransaction = new Button();
            lblPOSTransactionNo = new Label();
            txtChange = new TextBox();
            txtTotal = new TextBox();
            lblPOSChange = new Label();
            lblPOSTotal = new Label();
            button1 = new Button();
            panelPOS3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPOS).BeginInit();
            SuspendLayout();
            // 
            // panelPOS3
            // 
            panelPOS3.BackColor = Color.White;
            panelPOS3.Controls.Add(tbCDateTime);
            panelPOS3.Controls.Add(label4);
            panelPOS3.Controls.Add(tbUser);
            panelPOS3.Controls.Add(label3);
            panelPOS3.Controls.Add(label1);
            panelPOS3.Controls.Add(label2);
            panelPOS3.Dock = DockStyle.Top;
            panelPOS3.Location = new Point(0, 0);
            panelPOS3.Name = "panelPOS3";
            panelPOS3.Size = new Size(1113, 79);
            panelPOS3.TabIndex = 35;
            // 
            // tbCDateTime
            // 
            tbCDateTime.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbCDateTime.Location = new Point(992, 43);
            tbCDateTime.Name = "tbCDateTime";
            tbCDateTime.Size = new Size(100, 19);
            tbCDateTime.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(157, 30);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 4;
            label4.Text = "POINT OF SALE";
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(884, 21);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(100, 19);
            tbUser.TabIndex = 63;
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
            // dataGridViewPOS
            // 
            dataGridViewPOS.AllowUserToAddRows = false;
            dataGridViewPOS.BackgroundColor = Color.White;
            dataGridViewPOS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPOS.ColumnHeadersHeight = 30;
            dataGridViewPOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewPOS.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewPOS.EnableHeadersVisualStyles = false;
            dataGridViewPOS.Location = new Point(19, 179);
            dataGridViewPOS.Name = "dataGridViewPOS";
            dataGridViewPOS.RowHeadersVisible = false;
            dataGridViewPOS.RowTemplate.Height = 25;
            dataGridViewPOS.Size = new Size(734, 391);
            dataGridViewPOS.TabIndex = 48;
            dataGridViewPOS.CellContentClick += dataGridViewPOS_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Width = 43;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Product Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Price";
            Column3.Name = "Column3";
            Column3.Width = 59;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Quantity";
            Column4.Name = "Column4";
            Column4.Width = 79;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Subtotal";
            Column5.Name = "Column5";
            Column5.Width = 79;
            // 
            // txtPOSSubtotal
            // 
            txtPOSSubtotal.Location = new Point(572, 128);
            txtPOSSubtotal.Name = "txtPOSSubtotal";
            txtPOSSubtotal.Size = new Size(181, 25);
            txtPOSSubtotal.TabIndex = 47;
            // 
            // txtPOSPrice
            // 
            txtPOSPrice.Location = new Point(572, 97);
            txtPOSPrice.Name = "txtPOSPrice";
            txtPOSPrice.Size = new Size(181, 25);
            txtPOSPrice.TabIndex = 46;
            // 
            // lblPOSQty
            // 
            lblPOSQty.AutoSize = true;
            lblPOSQty.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPOSQty.Location = new Point(282, 97);
            lblPOSQty.Name = "lblPOSQty";
            lblPOSQty.Size = new Size(64, 17);
            lblPOSQty.TabIndex = 45;
            lblPOSQty.Text = "Quantity:";
            // 
            // txtPOSQty
            // 
            txtPOSQty.Location = new Point(352, 97);
            txtPOSQty.Name = "txtPOSQty";
            txtPOSQty.Size = new Size(105, 25);
            txtPOSQty.TabIndex = 44;
            // 
            // txtPOSProdName
            // 
            txtPOSProdName.Location = new Point(126, 128);
            txtPOSProdName.Multiline = true;
            txtPOSProdName.Name = "txtPOSProdName";
            txtPOSProdName.Size = new Size(331, 25);
            txtPOSProdName.TabIndex = 43;
            // 
            // txtPOSProdCode
            // 
            txtPOSProdCode.Location = new Point(126, 97);
            txtPOSProdCode.Name = "txtPOSProdCode";
            txtPOSProdCode.Size = new Size(151, 25);
            txtPOSProdCode.TabIndex = 42;
            // 
            // lblPOSProdName
            // 
            lblPOSProdName.AutoSize = true;
            lblPOSProdName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPOSProdName.Location = new Point(21, 131);
            lblPOSProdName.Name = "lblPOSProdName";
            lblPOSProdName.Size = new Size(99, 17);
            lblPOSProdName.TabIndex = 41;
            lblPOSProdName.Text = "Product Name:";
            // 
            // lblPOSPrice
            // 
            lblPOSPrice.AutoSize = true;
            lblPOSPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPOSPrice.Location = new Point(486, 100);
            lblPOSPrice.Name = "lblPOSPrice";
            lblPOSPrice.Size = new Size(46, 17);
            lblPOSPrice.TabIndex = 40;
            lblPOSPrice.Text = "PRICE:";
            // 
            // lblPOSSubtotal
            // 
            lblPOSSubtotal.AutoSize = true;
            lblPOSSubtotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPOSSubtotal.Location = new Point(486, 131);
            lblPOSSubtotal.Name = "lblPOSSubtotal";
            lblPOSSubtotal.Size = new Size(71, 17);
            lblPOSSubtotal.TabIndex = 39;
            lblPOSSubtotal.Text = "SUBTOTAL:";
            // 
            // lblPOSProdCode
            // 
            lblPOSProdCode.AutoSize = true;
            lblPOSProdCode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPOSProdCode.Location = new Point(19, 97);
            lblPOSProdCode.Name = "lblPOSProdCode";
            lblPOSProdCode.Size = new Size(94, 17);
            lblPOSProdCode.TabIndex = 38;
            lblPOSProdCode.Text = "Product Code:";
            // 
            // txtPOSTransactionNo
            // 
            txtPOSTransactionNo.BorderStyle = BorderStyle.None;
            txtPOSTransactionNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPOSTransactionNo.Location = new Point(781, 203);
            txtPOSTransactionNo.Multiline = true;
            txtPOSTransactionNo.Name = "txtPOSTransactionNo";
            txtPOSTransactionNo.Size = new Size(299, 63);
            txtPOSTransactionNo.TabIndex = 59;
            txtPOSTransactionNo.Text = "\r\n202109092983 (11)\r\n\r\n";
            txtPOSTransactionNo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPOSUnsettledOrder
            // 
            btnPOSUnsettledOrder.BackColor = Color.White;
            btnPOSUnsettledOrder.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPOSUnsettledOrder.ForeColor = Color.Black;
            btnPOSUnsettledOrder.Image = (Image)resources.GetObject("btnPOSUnsettledOrder.Image");
            btnPOSUnsettledOrder.ImageAlign = ContentAlignment.MiddleRight;
            btnPOSUnsettledOrder.Location = new Point(781, 474);
            btnPOSUnsettledOrder.Name = "btnPOSUnsettledOrder";
            btnPOSUnsettledOrder.Size = new Size(299, 46);
            btnPOSUnsettledOrder.TabIndex = 58;
            btnPOSUnsettledOrder.Text = "   UNSETTLED ORDER ";
            btnPOSUnsettledOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOSUnsettledOrder.UseVisualStyleBackColor = false;
            // 
            // btnPOSClearCart
            // 
            btnPOSClearCart.BackColor = Color.White;
            btnPOSClearCart.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPOSClearCart.ForeColor = Color.Black;
            btnPOSClearCart.Image = (Image)resources.GetObject("btnPOSClearCart.Image");
            btnPOSClearCart.ImageAlign = ContentAlignment.MiddleRight;
            btnPOSClearCart.Location = new Point(781, 423);
            btnPOSClearCart.Name = "btnPOSClearCart";
            btnPOSClearCart.Size = new Size(299, 46);
            btnPOSClearCart.TabIndex = 57;
            btnPOSClearCart.Text = "   CLEAR CART           ";
            btnPOSClearCart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOSClearCart.UseVisualStyleBackColor = false;
            // 
            // btnPOSPayment
            // 
            btnPOSPayment.BackColor = Color.White;
            btnPOSPayment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPOSPayment.ForeColor = Color.Black;
            btnPOSPayment.Image = (Image)resources.GetObject("btnPOSPayment.Image");
            btnPOSPayment.ImageAlign = ContentAlignment.MiddleRight;
            btnPOSPayment.Location = new Point(781, 372);
            btnPOSPayment.Name = "btnPOSPayment";
            btnPOSPayment.Size = new Size(299, 46);
            btnPOSPayment.TabIndex = 56;
            btnPOSPayment.Text = "   PAYMENT               ";
            btnPOSPayment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOSPayment.UseVisualStyleBackColor = false;
            // 
            // btnPOSSearchProduct
            // 
            btnPOSSearchProduct.BackColor = Color.White;
            btnPOSSearchProduct.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPOSSearchProduct.ForeColor = Color.Black;
            btnPOSSearchProduct.Image = (Image)resources.GetObject("btnPOSSearchProduct.Image");
            btnPOSSearchProduct.ImageAlign = ContentAlignment.MiddleRight;
            btnPOSSearchProduct.Location = new Point(781, 321);
            btnPOSSearchProduct.Name = "btnPOSSearchProduct";
            btnPOSSearchProduct.Size = new Size(299, 46);
            btnPOSSearchProduct.TabIndex = 55;
            btnPOSSearchProduct.Text = "   SEARCH PRODUCT  ";
            btnPOSSearchProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOSSearchProduct.UseVisualStyleBackColor = false;
            btnPOSSearchProduct.Click += btnPOSSearchProduct_Click;
            // 
            // btnPOSNewTransaction
            // 
            btnPOSNewTransaction.BackColor = Color.White;
            btnPOSNewTransaction.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPOSNewTransaction.ForeColor = Color.Black;
            btnPOSNewTransaction.Image = (Image)resources.GetObject("btnPOSNewTransaction.Image");
            btnPOSNewTransaction.ImageAlign = ContentAlignment.MiddleRight;
            btnPOSNewTransaction.Location = new Point(781, 271);
            btnPOSNewTransaction.Name = "btnPOSNewTransaction";
            btnPOSNewTransaction.Size = new Size(299, 46);
            btnPOSNewTransaction.TabIndex = 54;
            btnPOSNewTransaction.Text = "   NEW TRANSACTION";
            btnPOSNewTransaction.TextAlign = ContentAlignment.MiddleLeft;
            btnPOSNewTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOSNewTransaction.UseVisualStyleBackColor = false;
            // 
            // lblPOSTransactionNo
            // 
            lblPOSTransactionNo.AutoSize = true;
            lblPOSTransactionNo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPOSTransactionNo.ForeColor = Color.Black;
            lblPOSTransactionNo.Location = new Point(781, 181);
            lblPOSTransactionNo.Name = "lblPOSTransactionNo";
            lblPOSTransactionNo.Size = new Size(135, 19);
            lblPOSTransactionNo.TabIndex = 53;
            lblPOSTransactionNo.Text = "TRANSACTION NO:";
            // 
            // txtChange
            // 
            txtChange.BackColor = Color.DimGray;
            txtChange.BorderStyle = BorderStyle.None;
            txtChange.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtChange.ForeColor = Color.White;
            txtChange.Location = new Point(952, 122);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(128, 18);
            txtChange.TabIndex = 52;
            txtChange.Text = "0.00";
            txtChange.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.DimGray;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(952, 93);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(128, 26);
            txtTotal.TabIndex = 51;
            txtTotal.Text = "1, 345.52";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPOSChange
            // 
            lblPOSChange.AutoSize = true;
            lblPOSChange.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPOSChange.ForeColor = Color.Black;
            lblPOSChange.Location = new Point(781, 121);
            lblPOSChange.Name = "lblPOSChange";
            lblPOSChange.Size = new Size(65, 19);
            lblPOSChange.TabIndex = 50;
            lblPOSChange.Text = "CHANGE";
            // 
            // lblPOSTotal
            // 
            lblPOSTotal.AutoSize = true;
            lblPOSTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPOSTotal.ForeColor = Color.Black;
            lblPOSTotal.Location = new Point(781, 95);
            lblPOSTotal.Name = "lblPOSTotal";
            lblPOSTotal.Size = new Size(68, 25);
            lblPOSTotal.TabIndex = 49;
            lblPOSTotal.Text = "TOTAL";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(781, 524);
            button1.Name = "button1";
            button1.Size = new Size(299, 46);
            button1.TabIndex = 60;
            button1.Text = "    EXIT                       ";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // frmPOS
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 600);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(txtPOSTransactionNo);
            Controls.Add(btnPOSUnsettledOrder);
            Controls.Add(btnPOSClearCart);
            Controls.Add(btnPOSPayment);
            Controls.Add(btnPOSSearchProduct);
            Controls.Add(btnPOSNewTransaction);
            Controls.Add(lblPOSTransactionNo);
            Controls.Add(txtChange);
            Controls.Add(txtTotal);
            Controls.Add(lblPOSChange);
            Controls.Add(lblPOSTotal);
            Controls.Add(dataGridViewPOS);
            Controls.Add(txtPOSSubtotal);
            Controls.Add(txtPOSPrice);
            Controls.Add(lblPOSQty);
            Controls.Add(txtPOSQty);
            Controls.Add(txtPOSProdName);
            Controls.Add(txtPOSProdCode);
            Controls.Add(lblPOSProdName);
            Controls.Add(lblPOSPrice);
            Controls.Add(lblPOSSubtotal);
            Controls.Add(lblPOSProdCode);
            Controls.Add(panelPOS3);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPOS";
            Text = "frmPOS";
            Load += frmPOS_Load;
            panelPOS3.ResumeLayout(false);
            panelPOS3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTopPOS;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Panel panelPOS4;
        private Panel panelPOS3;
        private DataGridView dataGridViewPOS;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtPOSSubtotal;
        private TextBox txtPOSPrice;
        private Label lblPOSQty;
        private TextBox txtPOSQty;
        private TextBox txtPOSProdName;
        private TextBox txtPOSProdCode;
        private Label lblPOSProdName;
        private Label lblPOSPrice;
        private Label lblPOSSubtotal;
        private Label lblPOSProdCode;
        private TextBox txtPOSTransactionNo;
        private Button btnPOSUnsettledOrder;
        private Button btnPOSClearCart;
        private Button btnPOSPayment;
        private Button btnPOSSearchProduct;
        private Button btnPOSNewTransaction;
        private Label lblPOSTransactionNo;
        private TextBox txtChange;
        private TextBox txtTotal;
        private Label lblPOSChange;
        private Label lblPOSTotal;
        private Button button1;
        private TextBox tbCDateTime;
        private TextBox tbUser;
    }
}