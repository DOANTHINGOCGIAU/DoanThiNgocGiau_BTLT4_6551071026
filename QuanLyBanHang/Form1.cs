namespace QuanLyBanHang
{
    public partial class FromBanHang : Form
    {
        public FromBanHang()
        {
            InitializeComponent();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string dong = "Mã SP: " + txtMaSP.Text +
                 "    SL: " + txtSoLuong.Text +
                 "    ĐG: " + txtDonGia.Text;

            lstKetQua.Items.Add(dong);
        }

        private void FromBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                txtMaSP.Clear();
                txtSoLuong.Clear();
                txtDonGia.Clear();

                txtMaSP.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult ketQua = MessageBox.Show(
                    "Bạn có muốn thoát?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (ketQua == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();

            txtMaSP.Focus();
        }
    }
}
