namespace GymFitLife
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            lblGoiTap = new Label();
            cboGoiTap = new ComboBox();
            lblSoBuoitap = new Label();
            numSoBuoiTap = new NumericUpDown();
            btnDangKy = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTap).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(155, 45);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(601, 27);
            txtHoTen.TabIndex = 0;
            toolTip1.SetToolTip(txtHoTen, "Nhập họ và tên hội viên");
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(24, 52);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(56, 20);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ Tên";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(24, 97);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(102, 20);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số Điện Thoại";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(155, 94);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(601, 27);
            txtSDT.TabIndex = 3;
            toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 141);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(601, 27);
            txtEmail.TabIndex = 5;
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(155, 189);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(601, 27);
            dtpNgaySinh.TabIndex = 6;
            toolTip1.SetToolTip(dtpNgaySinh, "Chọn ngày tháng năm sinh của hội viên");
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(24, 194);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(76, 20);
            lblNgaySinh.TabIndex = 7;
            lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblGoiTap
            // 
            lblGoiTap.AutoSize = true;
            lblGoiTap.Location = new Point(24, 251);
            lblGoiTap.Name = "lblGoiTap";
            lblGoiTap.Size = new Size(61, 20);
            lblGoiTap.TabIndex = 8;
            lblGoiTap.Text = "Gói Tập";
            // 
            // cboGoiTap
            // 
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            cboGoiTap.Location = new Point(155, 248);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(601, 28);
            cboGoiTap.TabIndex = 9;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            // 
            // lblSoBuoitap
            // 
            lblSoBuoitap.AutoSize = true;
            lblSoBuoitap.Location = new Point(24, 309);
            lblSoBuoitap.Name = "lblSoBuoitap";
            lblSoBuoitap.Size = new Size(89, 20);
            lblSoBuoitap.TabIndex = 10;
            lblSoBuoitap.Text = "Số Buổi Tập";
            // 
            // numSoBuoiTap
            // 
            numSoBuoiTap.Location = new Point(155, 309);
            numSoBuoiTap.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSoBuoiTap.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoBuoiTap.Name = "numSoBuoiTap";
            numSoBuoiTap.Size = new Size(601, 27);
            numSoBuoiTap.TabIndex = 11;
            toolTip1.SetToolTip(numSoBuoiTap, "Chọn số buổi tập trong tuần, từ 1 đến 7 buổi");
            numSoBuoiTap.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(369, 388);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangKy);
            Controls.Add(numSoBuoiTap);
            Controls.Add(lblSoBuoitap);
            Controls.Add(cboGoiTap);
            Controls.Add(lblGoiTap);
            Controls.Add(lblNgaySinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private Label lblHoTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblEmail;
        private TextBox txtEmail;
        private DateTimePicker dtpNgaySinh;
        private Label lblNgaySinh;
        private Label lblGoiTap;
        private ComboBox cboGoiTap;
        private Label lblSoBuoitap;
        private NumericUpDown numSoBuoiTap;
        private Button btnDangKy;
        private ToolTip toolTip1;
    }
}
