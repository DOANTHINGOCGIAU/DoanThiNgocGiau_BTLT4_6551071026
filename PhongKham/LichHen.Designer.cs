namespace PhongKham
{
    partial class frmLichHen
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
            dtpNgayHen = new DateTimePicker();
            lblNgayHen = new Label();
            lblTenBenhNhan = new Label();
            btnDatLich = new Button();
            txtTenBenhNhan = new TextBox();
            lstLichHen = new ListBox();
            SuspendLayout();
            // 
            // dtpNgayHen
            // 
            dtpNgayHen.Location = new Point(162, 48);
            dtpNgayHen.Name = "dtpNgayHen";
            dtpNgayHen.Size = new Size(270, 27);
            dtpNgayHen.TabIndex = 0;
            // 
            // lblNgayHen
            // 
            lblNgayHen.AutoSize = true;
            lblNgayHen.Location = new Point(26, 53);
            lblNgayHen.Name = "lblNgayHen";
            lblNgayHen.Size = new Size(72, 20);
            lblNgayHen.TabIndex = 1;
            lblNgayHen.Text = "Ngày hẹn";
            // 
            // lblTenBenhNhan
            // 
            lblTenBenhNhan.AutoSize = true;
            lblTenBenhNhan.Location = new Point(26, 109);
            lblTenBenhNhan.Name = "lblTenBenhNhan";
            lblTenBenhNhan.Size = new Size(105, 20);
            lblTenBenhNhan.TabIndex = 2;
            lblTenBenhNhan.Text = "Tên bệnh nhân";
            // 
            // btnDatLich
            // 
            btnDatLich.Location = new Point(394, 175);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(94, 29);
            btnDatLich.TabIndex = 3;
            btnDatLich.Text = "Đặt Lịch";
            btnDatLich.UseVisualStyleBackColor = true;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(162, 109);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(556, 27);
            txtTenBenhNhan.TabIndex = 4;
            // 
            // lstLichHen
            // 
            lstLichHen.FormattingEnabled = true;
            lstLichHen.Location = new Point(57, 211);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(707, 224);
            lstLichHen.TabIndex = 5;
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstLichHen);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(btnDatLich);
            Controls.Add(lblTenBenhNhan);
            Controls.Add(lblNgayHen);
            Controls.Add(dtpNgayHen);
            Name = "frmLichHen";
            Text = "LichHen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgayHen;
        private Label lblNgayHen;
        private Label lblTenBenhNhan;
        private Button btnDatLich;
        private TextBox txtTenBenhNhan;
        private ListBox lstLichHen;
    }
}