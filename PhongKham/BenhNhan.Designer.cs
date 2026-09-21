namespace PhongKham
{
    partial class frmBenhNhan
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
            lblHoten = new Label();
            lblTuoi = new Label();
            lblTrieuChung = new Label();
            btnLuuTam = new Button();
            lstBenhNhan = new ListBox();
            txtHoTen = new TextBox();
            numTuoi = new NumericUpDown();
            txtTrieuChung = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numTuoi).BeginInit();
            SuspendLayout();
            // 
            // lblHoten
            // 
            lblHoten.AutoSize = true;
            lblHoten.Location = new Point(32, 28);
            lblHoten.Name = "lblHoten";
            lblHoten.Size = new Size(54, 20);
            lblHoten.TabIndex = 0;
            lblHoten.Text = "Họ tên";
            // 
            // lblTuoi
            // 
            lblTuoi.AutoSize = true;
            lblTuoi.Location = new Point(32, 82);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(38, 20);
            lblTuoi.TabIndex = 1;
            lblTuoi.Text = "Tuổi";
            // 
            // lblTrieuChung
            // 
            lblTrieuChung.AutoSize = true;
            lblTrieuChung.Location = new Point(32, 132);
            lblTrieuChung.Name = "lblTrieuChung";
            lblTrieuChung.Size = new Size(86, 20);
            lblTrieuChung.TabIndex = 2;
            lblTrieuChung.Text = "Triệu chứng";
            // 
            // btnLuuTam
            // 
            btnLuuTam.Location = new Point(380, 178);
            btnLuuTam.Name = "btnLuuTam";
            btnLuuTam.Size = new Size(94, 29);
            btnLuuTam.TabIndex = 3;
            btnLuuTam.Text = "Lưu Tạm";
            btnLuuTam.UseVisualStyleBackColor = true;
            btnLuuTam.Click += btnLuuTam_Click;
            // 
            // lstBenhNhan
            // 
            lstBenhNhan.FormattingEnabled = true;
            lstBenhNhan.Location = new Point(80, 243);
            lstBenhNhan.Name = "lstBenhNhan";
            lstBenhNhan.Size = new Size(673, 164);
            lstBenhNhan.TabIndex = 4;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(133, 21);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(620, 27);
            txtHoTen.TabIndex = 5;
            // 
            // numTuoi
            // 
            numTuoi.Location = new Point(133, 75);
            numTuoi.Name = "numTuoi";
            numTuoi.Size = new Size(620, 27);
            numTuoi.TabIndex = 6;
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Location = new Point(133, 125);
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(620, 27);
            txtTrieuChung.TabIndex = 7;
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTrieuChung);
            Controls.Add(numTuoi);
            Controls.Add(txtHoTen);
            Controls.Add(lstBenhNhan);
            Controls.Add(btnLuuTam);
            Controls.Add(lblTrieuChung);
            Controls.Add(lblTuoi);
            Controls.Add(lblHoten);
            Name = "frmBenhNhan";
            Text = "BenhNhan";
            Load += frmBenhNhan_Load;
            ((System.ComponentModel.ISupportInitialize)numTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoten;
        private Label lblTuoi;
        private Label lblTrieuChung;
        private Button btnLuuTam;
        private ListBox lstBenhNhan;
        private TextBox txtHoTen;
        private NumericUpDown numTuoi;
        private TextBox txtTrieuChung;
    }
}