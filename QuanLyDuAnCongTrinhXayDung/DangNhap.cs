using QuanLyDuAnCongTrinhXayDung.Forms;

namespace QuanLyDuAnCongTrinhXayDung
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f1 = new frmNhanVien();
            f1.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang f2 = new frmKhachHang();
            f2.Show();
        }

        private void btnLoaiDA_Click(object sender, EventArgs e)
        {
            frmLoaiDuAn f3 = new frmLoaiDuAn();
            f3.Show();
        }

        private void btnCongViec_Click(object sender, EventArgs e)
        {
            frmCongViec f4 = new frmCongViec();
            f4.Show();
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            frmBangLuong f5 = new frmBangLuong();
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhaDauTu f6 = new frmNhaDauTu();
            f6.Show();
        }

        private void btnNhatKy_Click(object sender, EventArgs e)
        {
            frmNhatKyCongTrinh f7 = new frmNhatKyCongTrinh();
            f7.Show();
        }
    }
}
