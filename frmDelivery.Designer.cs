namespace BREWPLS_POS_SYSTEM
{
    partial class frmDelivery
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
            panelDelivery1 = new Panel();
            label13 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnDeliveryCancel = new Button();
            dataGridViewDelivery = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            tbCDateTime = new TextBox();
            tbUser = new TextBox();
            tbUserRole = new TextBox();
            panelDelivery1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDelivery).BeginInit();
            SuspendLayout();
            // 
            // panelDelivery1
            // 
            panelDelivery1.BackColor = Color.White;
            panelDelivery1.Controls.Add(tbCDateTime);
            panelDelivery1.Controls.Add(tbUser);
            panelDelivery1.Controls.Add(tbUserRole);
            panelDelivery1.Controls.Add(label13);
            panelDelivery1.Controls.Add(label4);
            panelDelivery1.Controls.Add(label3);
            panelDelivery1.Controls.Add(label1);
            panelDelivery1.Controls.Add(label2);
            panelDelivery1.Dock = DockStyle.Top;
            panelDelivery1.Location = new Point(0, 0);
            panelDelivery1.Name = "panelDelivery1";
            panelDelivery1.Size = new Size(1113, 79);
            panelDelivery1.TabIndex = 40;
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
            label4.Size = new Size(84, 21);
            label4.TabIndex = 4;
            label4.Text = "DELIVERY";
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
            // btnDeliveryCancel
            // 
            btnDeliveryCancel.BackColor = Color.White;
            btnDeliveryCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeliveryCancel.ForeColor = Color.Black;
            btnDeliveryCancel.Location = new Point(984, 548);
            btnDeliveryCancel.Name = "btnDeliveryCancel";
            btnDeliveryCancel.Size = new Size(111, 34);
            btnDeliveryCancel.TabIndex = 90;
            btnDeliveryCancel.Text = "CANCEL";
            btnDeliveryCancel.UseVisualStyleBackColor = false;
            btnDeliveryCancel.Click += btnDeliveryCancel_Click;
            // 
            // dataGridViewDelivery
            // 
            dataGridViewDelivery.AllowUserToAddRows = false;
            dataGridViewDelivery.BackgroundColor = Color.White;
            dataGridViewDelivery.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDelivery.ColumnHeadersHeight = 30;
            dataGridViewDelivery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewDelivery.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewDelivery.EnableHeadersVisualStyles = false;
            dataGridViewDelivery.Location = new Point(12, 85);
            dataGridViewDelivery.Name = "dataGridViewDelivery";
            dataGridViewDelivery.RowHeadersVisible = false;
            dataGridViewDelivery.RowTemplate.Height = 25;
            dataGridViewDelivery.Size = new Size(1083, 457);
            dataGridViewDelivery.TabIndex = 89;
            dataGridViewDelivery.CellContentClick += dataGridViewDelivery_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Delivery ID";
            Column1.Name = "Column1";
            Column1.Width = 93;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Order ID";
            Column2.Name = "Column2";
            Column2.Width = 82;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Customer ID";
            Column3.Name = "Column3";
            Column3.Width = 103;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Courier ID";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Delivery Time";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Delivery Status";
            Column6.Name = "Column6";
            // 
            // tbCDateTime
            // 
            tbCDateTime.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbCDateTime.Location = new Point(996, 49);
            tbCDateTime.Name = "tbCDateTime";
            tbCDateTime.Size = new Size(100, 19);
            tbCDateTime.TabIndex = 19;
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(888, 24);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(100, 19);
            tbUser.TabIndex = 18;
            // 
            // tbUserRole
            // 
            tbUserRole.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUserRole.Location = new Point(996, 24);
            tbUserRole.Name = "tbUserRole";
            tbUserRole.Size = new Size(100, 19);
            tbUserRole.TabIndex = 17;
            // 
            // frmDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 600);
            ControlBox = false;
            Controls.Add(btnDeliveryCancel);
            Controls.Add(dataGridViewDelivery);
            Controls.Add(panelDelivery1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDelivery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDelivery";
            Load += frmDelivery_Load_1;
            panelDelivery1.ResumeLayout(false);
            panelDelivery1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDelivery).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDelivery1;
        private Label label13;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btnDeliveryCancel;
        private DataGridView dataGridViewDelivery;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox tbCDateTime;
        private TextBox tbUser;
        private TextBox tbUserRole;
    }
}