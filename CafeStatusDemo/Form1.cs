namespace CafeStatusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime gioHienTai = DateTime.Now;

            lblGioHienTai.Text = gioHienTai.ToString("HH:mm:ss");

            if (gioHienTai.Hour >= 6 && gioHienTai.Hour < 22)
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đã đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private void mnuDoiMauNen_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
