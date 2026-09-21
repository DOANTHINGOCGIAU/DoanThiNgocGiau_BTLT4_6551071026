using static PhongKham.frmLichHen;

namespace PhongKham
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void mnuThongTinBenhNhan_Click(object sender, EventArgs e)
        {
            frmBenhNhan frm = new frmBenhNhan();

            frm.MdiParent = this;

            frm.Show();
        }

        private void mnuDatLichHen_Click(object sender, EventArgs e)
        {
            frmLichHen frm = new frmLichHen();

            frm.MdiParent = this;

            frm.Show();
        }
    }
}
