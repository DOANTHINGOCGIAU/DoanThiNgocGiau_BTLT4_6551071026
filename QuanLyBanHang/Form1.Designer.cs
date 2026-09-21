namespace QuanLyBanHang
{
    partial class FromBanHang
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
            lblMaSP = new Label();
            lblSoLuong = new Label();
            lblDonGia = new Label();
            txtMaSP = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            SuspendLayout();
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(46, 46);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(99, 20);
            lblMaSP.TabIndex = 0;
            lblMaSP.Text = "Mã Sản Phẩm";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(46, 98);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(72, 20);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "Số Lượng";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(46, 145);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(63, 20);
            lblDonGia.TabIndex = 2;
            lblDonGia.Text = "Đơn Giá";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(159, 43);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(584, 27);
            txtMaSP.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(159, 95);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(584, 27);
            txtSoLuong.TabIndex = 4;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(159, 145);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(584, 27);
            txtDonGia.TabIndex = 5;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(159, 201);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(125, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(575, 201);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(114, 29);
            btnXoaTrang.TabIndex = 7;
            btnXoaTrang.Text = "Xóa Trang";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(46, 251);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(724, 184);
            lstKetQua.TabIndex = 8;
            // 
            // FromBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaSP);
            Controls.Add(lblDonGia);
            Controls.Add(lblSoLuong);
            Controls.Add(lblMaSP);
            KeyPreview = true;
            Name = "FromBanHang";
            Text = "Form1";
            KeyDown += FromBanHang_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaSP;
        private Label lblSoLuong;
        private Label lblDonGia;
        private TextBox txtMaSP;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
    }
}
