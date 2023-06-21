namespace BREWPLS_POS_SYSTEM
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            panelStaff1 = new Panel();
            label13 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridViewStaff = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            picStaffSearch = new PictureBox();
            txtStaffSearch = new TextBox();
            lblStaff1 = new Label();
            lblStaff2 = new Label();
            btnStaffCancel = new Button();
            btnStaffUpdate = new Button();
            btnStaffDelete = new Button();
            btnStaffSave = new Button();
            btnStaffCreateNew = new Button();
            txtStaffRetype = new TextBox();
            txtStaffPass = new TextBox();
            lblStaffRetype = new Label();
            lblStaffPass = new Label();
            txtStaffUsername = new TextBox();
            txtStaffSched = new TextBox();
            cbStaffPosition = new ComboBox();
            txtStaffContactNo = new TextBox();
            txtStaffAdd = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtStaffMinitial = new TextBox();
            txtStaffID = new TextBox();
            lblStaffUsername = new Label();
            lblStaffSched = new Label();
            lblStaffPosition = new Label();
            lblStaffContactNo = new Label();
            lblAddress = new Label();
            lblFname = new Label();
            lblStaffMinitial = new Label();
            lblStaffLname = new Label();
            lblStaffID = new Label();
            lblStaffInfo = new Label();
            tbCDateTime = new TextBox();
            tbUser = new TextBox();
            tbUserRole = new TextBox();
            panelStaff1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStaffSearch).BeginInit();
            SuspendLayout();
            // 
            // panelStaff1
            // 
            panelStaff1.BackColor = Color.White;
            panelStaff1.Controls.Add(tbCDateTime);
            panelStaff1.Controls.Add(tbUser);
            panelStaff1.Controls.Add(tbUserRole);
            panelStaff1.Controls.Add(label13);
            panelStaff1.Controls.Add(label4);
            panelStaff1.Controls.Add(label3);
            panelStaff1.Controls.Add(label1);
            panelStaff1.Controls.Add(label2);
            panelStaff1.Dock = DockStyle.Top;
            panelStaff1.Location = new Point(0, 0);
            panelStaff1.Name = "panelStaff1";
            panelStaff1.Size = new Size(1113, 79);
            panelStaff1.TabIndex = 37;
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
            label4.Size = new Size(54, 21);
            label4.TabIndex = 4;
            label4.Text = "STAFF";
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
            // dataGridViewStaff
            // 
            dataGridViewStaff.AllowUserToAddRows = false;
            dataGridViewStaff.BackgroundColor = Color.WhiteSmoke;
            dataGridViewStaff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewStaff.ColumnHeadersHeight = 30;
            dataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewStaff.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewStaff.EnableHeadersVisualStyles = false;
            dataGridViewStaff.Location = new Point(12, 156);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.RowHeadersVisible = false;
            dataGridViewStaff.RowTemplate.Height = 25;
            dataGridViewStaff.Size = new Size(744, 432);
            dataGridViewStaff.TabIndex = 62;
            dataGridViewStaff.CellContentClick += dataGridViewStaff_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Staff ID";
            Column1.Name = "Column1";
            Column1.Width = 73;
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
            Column4.HeaderText = "Contact No";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Position";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Schedule";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Username";
            Column7.Name = "Column7";
            // 
            // picStaffSearch
            // 
            picStaffSearch.Image = (Image)resources.GetObject("picStaffSearch.Image");
            picStaffSearch.Location = new Point(737, 118);
            picStaffSearch.Name = "picStaffSearch";
            picStaffSearch.Size = new Size(19, 22);
            picStaffSearch.TabIndex = 61;
            picStaffSearch.TabStop = false;
            // 
            // txtStaffSearch
            // 
            txtStaffSearch.Location = new Point(109, 114);
            txtStaffSearch.Name = "txtStaffSearch";
            txtStaffSearch.Size = new Size(622, 25);
            txtStaffSearch.TabIndex = 60;
            // 
            // lblStaff1
            // 
            lblStaff1.AutoSize = true;
            lblStaff1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaff1.Location = new Point(30, 94);
            lblStaff1.Name = "lblStaff1";
            lblStaff1.Size = new Size(120, 17);
            lblStaff1.TabIndex = 58;
            lblStaff1.Text = "ADVANCE SEARCH";
            // 
            // lblStaff2
            // 
            lblStaff2.AutoSize = true;
            lblStaff2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaff2.Location = new Point(55, 117);
            lblStaff2.Name = "lblStaff2";
            lblStaff2.Size = new Size(48, 17);
            lblStaff2.TabIndex = 59;
            lblStaff2.Text = "Search";
            // 
            // btnStaffCancel
            // 
            btnStaffCancel.BackColor = Color.White;
            btnStaffCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaffCancel.ForeColor = Color.Black;
            btnStaffCancel.Location = new Point(990, 551);
            btnStaffCancel.Name = "btnStaffCancel";
            btnStaffCancel.Size = new Size(98, 34);
            btnStaffCancel.TabIndex = 117;
            btnStaffCancel.Text = "CANCEL";
            btnStaffCancel.UseVisualStyleBackColor = false;
            // 
            // btnStaffUpdate
            // 
            btnStaffUpdate.BackColor = Color.White;
            btnStaffUpdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaffUpdate.ForeColor = Color.Black;
            btnStaffUpdate.Location = new Point(990, 516);
            btnStaffUpdate.Name = "btnStaffUpdate";
            btnStaffUpdate.Size = new Size(98, 34);
            btnStaffUpdate.TabIndex = 116;
            btnStaffUpdate.Text = "UPDATE";
            btnStaffUpdate.UseVisualStyleBackColor = false;
            // 
            // btnStaffDelete
            // 
            btnStaffDelete.BackColor = Color.White;
            btnStaffDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaffDelete.ForeColor = Color.Black;
            btnStaffDelete.Location = new Point(893, 551);
            btnStaffDelete.Name = "btnStaffDelete";
            btnStaffDelete.Size = new Size(95, 34);
            btnStaffDelete.TabIndex = 115;
            btnStaffDelete.Text = "DELETE";
            btnStaffDelete.UseVisualStyleBackColor = false;
            // 
            // btnStaffSave
            // 
            btnStaffSave.BackColor = Color.White;
            btnStaffSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaffSave.ForeColor = Color.Black;
            btnStaffSave.Location = new Point(893, 516);
            btnStaffSave.Name = "btnStaffSave";
            btnStaffSave.Size = new Size(95, 34);
            btnStaffSave.TabIndex = 114;
            btnStaffSave.Text = "SAVE";
            btnStaffSave.UseVisualStyleBackColor = false;
            // 
            // btnStaffCreateNew
            // 
            btnStaffCreateNew.BackColor = Color.Black;
            btnStaffCreateNew.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaffCreateNew.ForeColor = Color.White;
            btnStaffCreateNew.Location = new Point(784, 516);
            btnStaffCreateNew.Name = "btnStaffCreateNew";
            btnStaffCreateNew.Size = new Size(107, 69);
            btnStaffCreateNew.TabIndex = 113;
            btnStaffCreateNew.Text = "CREATE NEW";
            btnStaffCreateNew.UseVisualStyleBackColor = false;
            // 
            // txtStaffRetype
            // 
            txtStaffRetype.Location = new Point(917, 411);
            txtStaffRetype.Name = "txtStaffRetype";
            txtStaffRetype.Size = new Size(171, 25);
            txtStaffRetype.TabIndex = 112;
            // 
            // txtStaffPass
            // 
            txtStaffPass.Location = new Point(885, 380);
            txtStaffPass.Name = "txtStaffPass";
            txtStaffPass.Size = new Size(203, 25);
            txtStaffPass.TabIndex = 111;
            // 
            // lblStaffRetype
            // 
            lblStaffRetype.AutoSize = true;
            lblStaffRetype.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaffRetype.Location = new Point(784, 415);
            lblStaffRetype.Name = "lblStaffRetype";
            lblStaffRetype.Size = new Size(127, 17);
            lblStaffRetype.TabIndex = 110;
            lblStaffRetype.Text = "Re-type Password *";
            // 
            // lblStaffPass
            // 
            lblStaffPass.AutoSize = true;
            lblStaffPass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaffPass.Location = new Point(784, 384);
            lblStaffPass.Name = "lblStaffPass";
            lblStaffPass.Size = new Size(76, 17);
            lblStaffPass.TabIndex = 109;
            lblStaffPass.Text = "Password *";
            // 
            // txtStaffUsername
            // 
            txtStaffUsername.Location = new Point(885, 349);
            txtStaffUsername.Name = "txtStaffUsername";
            txtStaffUsername.Size = new Size(203, 25);
            txtStaffUsername.TabIndex = 108;
            // 
            // txtStaffSched
            // 
            txtStaffSched.Location = new Point(885, 318);
            txtStaffSched.Name = "txtStaffSched";
            txtStaffSched.Size = new Size(203, 25);
            txtStaffSched.TabIndex = 107;
            // 
            // cbStaffPosition
            // 
            cbStaffPosition.FormattingEnabled = true;
            cbStaffPosition.Location = new Point(885, 442);
            cbStaffPosition.Name = "cbStaffPosition";
            cbStaffPosition.Size = new Size(203, 25);
            cbStaffPosition.TabIndex = 106;
            // 
            // txtStaffContactNo
            // 
            txtStaffContactNo.Location = new Point(885, 287);
            txtStaffContactNo.Name = "txtStaffContactNo";
            txtStaffContactNo.Size = new Size(203, 25);
            txtStaffContactNo.TabIndex = 105;
            // 
            // txtStaffAdd
            // 
            txtStaffAdd.Location = new Point(885, 256);
            txtStaffAdd.Name = "txtStaffAdd";
            txtStaffAdd.Size = new Size(203, 25);
            txtStaffAdd.TabIndex = 104;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(885, 225);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(203, 25);
            txtFname.TabIndex = 103;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(885, 163);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(203, 25);
            txtLname.TabIndex = 102;
            // 
            // txtStaffMinitial
            // 
            txtStaffMinitial.Location = new Point(885, 194);
            txtStaffMinitial.Name = "txtStaffMinitial";
            txtStaffMinitial.Size = new Size(203, 25);
            txtStaffMinitial.TabIndex = 101;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new Point(885, 132);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(203, 25);
            txtStaffID.TabIndex = 100;
            // 
            // lblStaffUsername
            // 
            lblStaffUsername.AutoSize = true;
            lblStaffUsername.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaffUsername.Location = new Point(784, 353);
            lblStaffUsername.Name = "lblStaffUsername";
            lblStaffUsername.Size = new Size(79, 17);
            lblStaffUsername.TabIndex = 99;
            lblStaffUsername.Text = "Username *";
            // 
            // lblStaffSched
            // 
            lblStaffSched.AutoSize = true;
            lblStaffSched.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaffSched.Location = new Point(784, 322);
            lblStaffSched.Name = "lblStaffSched";
            lblStaffSched.Size = new Size(72, 17);
            lblStaffSched.TabIndex = 98;
            lblStaffSched.Text = "Schedule *";
            // 
            // lblStaffPosition
            // 
            lblStaffPosition.AutoSize = true;
            lblStaffPosition.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaffPosition.Location = new Point(784, 445);
            lblStaffPosition.Name = "lblStaffPosition";
            lblStaffPosition.Size = new Size(67, 17);
            lblStaffPosition.TabIndex = 97;
            lblStaffPosition.Text = "Position *";
            // 
            // lblStaffContactNo
            // 
            lblStaffContactNo.AutoSize = true;
            lblStaffContactNo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaffContactNo.Location = new Point(784, 291);
            lblStaffContactNo.Name = "lblStaffContactNo";
            lblStaffContactNo.Size = new Size(90, 17);
            lblStaffContactNo.TabIndex = 96;
            lblStaffContactNo.Text = "Contact No. *";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(784, 261);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(67, 17);
            lblAddress.TabIndex = 95;
            lblAddress.Text = "Address *";
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFname.Location = new Point(784, 230);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(84, 17);
            lblFname.TabIndex = 94;
            lblFname.Text = "First Name *";
            // 
            // lblStaffMinitial
            // 
            lblStaffMinitial.AutoSize = true;
            lblStaffMinitial.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaffMinitial.Location = new Point(784, 199);
            lblStaffMinitial.Name = "lblStaffMinitial";
            lblStaffMinitial.Size = new Size(86, 17);
            lblStaffMinitial.TabIndex = 93;
            lblStaffMinitial.Text = "Middle Initial";
            // 
            // lblStaffLname
            // 
            lblStaffLname.AutoSize = true;
            lblStaffLname.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaffLname.Location = new Point(784, 168);
            lblStaffLname.Name = "lblStaffLname";
            lblStaffLname.Size = new Size(82, 17);
            lblStaffLname.TabIndex = 92;
            lblStaffLname.Text = "Last Name *";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaffID.Location = new Point(784, 136);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(62, 17);
            lblStaffID.TabIndex = 91;
            lblStaffID.Text = "Staff ID *";
            // 
            // lblStaffInfo
            // 
            lblStaffInfo.AutoSize = true;
            lblStaffInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaffInfo.Location = new Point(784, 102);
            lblStaffInfo.Name = "lblStaffInfo";
            lblStaffInfo.Size = new Size(140, 17);
            lblStaffInfo.TabIndex = 90;
            lblStaffInfo.Text = "STAFF INFORMATION";
            // 
            // tbCDateTime
            // 
            tbCDateTime.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbCDateTime.Location = new Point(996, 50);
            tbCDateTime.Name = "tbCDateTime";
            tbCDateTime.Size = new Size(100, 19);
            tbCDateTime.TabIndex = 22;
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(888, 25);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(100, 19);
            tbUser.TabIndex = 21;
            // 
            // tbUserRole
            // 
            tbUserRole.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUserRole.Location = new Point(996, 25);
            tbUserRole.Name = "tbUserRole";
            tbUserRole.Size = new Size(100, 19);
            tbUserRole.TabIndex = 20;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 600);
            ControlBox = false;
            Controls.Add(btnStaffCancel);
            Controls.Add(btnStaffUpdate);
            Controls.Add(btnStaffDelete);
            Controls.Add(btnStaffSave);
            Controls.Add(btnStaffCreateNew);
            Controls.Add(txtStaffRetype);
            Controls.Add(txtStaffPass);
            Controls.Add(lblStaffRetype);
            Controls.Add(lblStaffPass);
            Controls.Add(txtStaffUsername);
            Controls.Add(txtStaffSched);
            Controls.Add(cbStaffPosition);
            Controls.Add(txtStaffContactNo);
            Controls.Add(txtStaffAdd);
            Controls.Add(txtFname);
            Controls.Add(txtLname);
            Controls.Add(txtStaffMinitial);
            Controls.Add(txtStaffID);
            Controls.Add(lblStaffUsername);
            Controls.Add(lblStaffSched);
            Controls.Add(lblStaffPosition);
            Controls.Add(lblStaffContactNo);
            Controls.Add(lblAddress);
            Controls.Add(lblFname);
            Controls.Add(lblStaffMinitial);
            Controls.Add(lblStaffLname);
            Controls.Add(lblStaffID);
            Controls.Add(lblStaffInfo);
            Controls.Add(dataGridViewStaff);
            Controls.Add(picStaffSearch);
            Controls.Add(txtStaffSearch);
            Controls.Add(lblStaff1);
            Controls.Add(lblStaff2);
            Controls.Add(panelStaff1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStaff";
            Load += frmStaff_Load;
            panelStaff1.ResumeLayout(false);
            panelStaff1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStaffSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelStaff1;
        private Label label13;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewStaff;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private PictureBox picStaffSearch;
        private TextBox txtStaffSearch;
        private Label lblStaff1;
        private Label lblStaff2;
        private Button btnStaffCancel;
        private Button btnStaffUpdate;
        private Button btnStaffDelete;
        private Button btnStaffSave;
        private Button btnStaffCreateNew;
        private TextBox txtStaffRetype;
        private TextBox txtStaffPass;
        private Label lblStaffRetype;
        private Label lblStaffPass;
        private TextBox txtStaffUsername;
        private TextBox txtStaffSched;
        private ComboBox cbStaffPosition;
        private TextBox txtStaffContactNo;
        private TextBox txtStaffAdd;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtStaffMinitial;
        private TextBox txtStaffID;
        private Label lblStaffUsername;
        private Label lblStaffSched;
        private Label lblStaffPosition;
        private Label lblStaffContactNo;
        private Label lblAddress;
        private Label lblFname;
        private Label lblStaffMinitial;
        private Label lblStaffLname;
        private Label lblStaffID;
        private Label lblStaffInfo;
        private TextBox tbCDateTime;
        private TextBox tbUser;
        private TextBox tbUserRole;
    }
}