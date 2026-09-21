using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhongKham
{
    public partial class frmLichHen : Form
    {
        private List<string> danhSachLichHen = new List<string>();
        public frmLichHen()
        {
            InitializeComponent();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân.");
                return;
            }

            string lichHen =
                "Bệnh nhân: " + txtTenBenhNhan.Text +
                " - Ngày giờ: " + dtpNgayHen.Value.ToString("dd/MM/yyyy HH:mm");

            danhSachLichHen.Add(lichHen);

            lstLichHen.Items.Add(lichHen);

            txtTenBenhNhan.Clear();
            txtTenBenhNhan.Focus();
        }
    }
}
