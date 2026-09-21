namespace GhiChuNhanhBangTay
{
    public partial class Form1 : Form
    {
        bool dangVe = false;
        Point diemCu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = true;
                diemCu = e.Location;
                lblViTri.Text = "Đang vẽ...";
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblViTri.Text = "X: " + e.X + ", Y: " + e.Y;

            if (dangVe)
            {
                using (Graphics g = pnlCanvas.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, diemCu, e.Location);
                }

                diemCu = e.Location;
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = false;
                lblViTri.Text = "Sẵn sàng";
            }
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pnlCanvas.Invalidate();
                lblViTri.Text = "Sẵn sàng";
            }
        }
    }
}
