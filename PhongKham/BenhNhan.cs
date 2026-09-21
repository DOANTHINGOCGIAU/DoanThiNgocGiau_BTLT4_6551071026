using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhongKham
{
    public partial class frmBenhNhan : Form
    {
        private List<string> danhSachBenhNhan = new List<string>();
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {

        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân.");
                return;
            }

            string benhNhan =
                "Họ tên: " + txtHoTen.Text +
                " - Tuổi: " + numTuoi.Value +
                " - Triệu chứng: " + txtTrieuChung.Text;

            danhSachBenhNhan.Add(benhNhan);

            lstBenhNhan.Items.Add(benhNhan);

            txtHoTen.Clear();
            txtTrieuChung.Clear();
            numTuoi.Value = numTuoi.Minimum;

            txtHoTen.Focus();
        }
    }
}
