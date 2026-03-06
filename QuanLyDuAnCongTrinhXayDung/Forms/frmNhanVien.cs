using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata;
using QuanLyDuAnCongTrinhXayDung.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using System.IO;

namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    public partial class frmNhanVien : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        string connStr = @"Data Source=.;Initial Catalog=QLDACTXD;Integrated Security=True;TrustServerCertificate=True";
        public frmNhanVien()
        {
            InitializeComponent();
            dgvNhanVien.RowHeadersVisible = false;
        }
        private void ClearBinding()
        {
            txtHoTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            txtChuyenMon.DataBindings.Clear();
            txtLuongCoBan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Clear();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            txtChuyenMon.Enabled = giaTri;
            txtLuongCoBan.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void dgvNhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;*.xls";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage p = new ExcelPackage(new FileInfo(ofd.FileName)))
                {
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];
                    int rowCount = ws.Dimension.End.Row;

                    // Chạy từ dòng 2 (bỏ qua tiêu đề)
                    for (int row = 2; row <= rowCount; row++)
                    {
                        NhanVien nv = new NhanVien
                        {
                            HoVaTen = ws.Cells[row, 2].Value?.ToString(),
                            DiaChi = ws.Cells[row, 3].Value?.ToString(),
                            DienThoai = ws.Cells[row, 4].Value?.ToString(),
                            TenDangNhap = ws.Cells[row, 5].Value?.ToString(),
                            MatKhau = "123", // Mật khẩu mặc định
                            QuyenHan = false,
                            LuongCoBan = Convert.ToDecimal(ws.Cells[row, 7].Value ?? 0)
                        };
                        context.NhanVien.Add(nv);
                    }
                    context.SaveChanges();
                    frmNhanVien_Load(sender, e); // Tải lại lưới dữ liệu
                    MessageBox.Show("Nhập dữ liệu từ Excel thành công!");
                }
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            ClearBinding();
            dgvNhanVien.AutoGenerateColumns = false;
            List<NhanVien> nv = new List<NhanVien>();

            nv = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
            txtChuyenMon.DataBindings.Add("Text", bindingSource, "ChuyenMon", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);
            txtMatKhau.DataBindings.Add("Text", bindingSource, "MatKhau", false, DataSourceUpdateMode.Never);
            txtLuongCoBan.DataBindings.Add("Text", bindingSource, "LuongCoBan", false, DataSourceUpdateMode.Never);
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);
            dgvNhanVien.DataSource = bindingSource;            
            dgvNhanVien.RowPostPaint += dgvNhanVien_RowPostPaint;

            dgvNhanVien.DataSource = context.NhanVien.ToList();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            ClearBinding();
            cboQuyenHan.Text = "";
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dgvNhanVien.CurrentRow == null) return;

            txtHoTen.Text = dgvNhanVien.CurrentRow.Cells["HoVaTen"].Value?.ToString();
            txtDienThoai.Text = dgvNhanVien.CurrentRow.Cells["DienThoai"].Value?.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value?.ToString();
            txtTenDangNhap.Text = dgvNhanVien.CurrentRow.Cells["TenDangNhap"].Value?.ToString();
            txtMatKhau.Text = dgvNhanVien.CurrentRow.Cells["MatKhau"].Value?.ToString();
            txtChuyenMon.Text = dgvNhanVien.CurrentRow.Cells["ChuyenMon"].Value?.ToString();
            txtLuongCoBan.Text = dgvNhanVien.CurrentRow.Cells["LuongCoBan"].Value?.ToString();

            bool quyen = Convert.ToBoolean(dgvNhanVien.CurrentRow.Cells["QuyenHan"].Value);
            cboQuyenHan.Text = quyen ? "Quản lí" : "Nhân viên";*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["colID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(cboQuyenHan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (xulyThem)
                {
                    NhanVien nv = new NhanVien();
                    nv.HoVaTen = txtHoTen.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.MatKhau = txtMatKhau.Text;
                    nv.ChuyenMon = txtChuyenMon.Text;
                    nv.LuongCoBan = Convert.ToDecimal(txtLuongCoBan.Text);
                    nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;
                    context.NhanVien.Add(nv);
                    context.SaveChanges();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoTen.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = txtMatKhau.Text;
                        nv.ChuyenMon = txtChuyenMon.Text;
                        nv.LuongCoBan = Convert.ToDecimal(txtLuongCoBan.Text);
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;
                        context.NhanVien.Update(nv);
                        context.SaveChanges();
                        MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                frmNhanVien_Load(sender, e);
                ClearBinding();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["colID"].Value);
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(
                            "DELETE FROM NhanVien; DBCC CHECKIDENT ('NhanVien', RESEED, 0)", conn);

                        cmd.ExecuteNonQuery();
                    }*/
                    txtHoTen.Clear();
                    txtDiaChi.Clear();
                    txtDienThoai.Clear();
                    txtLuongCoBan.Clear();
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    txtChuyenMon.Clear();
                    cboQuyenHan.Text = "";
                    frmNhanVien_Load(sender, e);
                    ClearBinding();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtHoTen.Text.Trim(); // Lấy dữ liệu từ ô nhập liệu 
            if (string.IsNullOrEmpty(tuKhoa))
            {
                frmNhanVien_Load(sender, e); // Nếu để trống thì tải lại tất cả 
                return;
            }

            // 1. Kiểm tra nếu người dùng nhập số (Tìm theo ID)
            if (int.TryParse(tuKhoa, out int idCanTim))
            {
                var nv = context.NhanVien.Find(idCanTim); // Tìm theo ID trong DbContext
                if (nv != null)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = new List<NhanVien> { nv };
                    dgvNhanVien.DataSource = bs;
                }
                else MessageBox.Show("Không tìm thấy nhân viên có ID này!");
            }
            // 2. Nếu là chữ (Tìm theo Tên hoặc Điện thoại)
            else
            {
                var ketQua = context.NhanVien
                    .Where(x => x.HoVaTen.Contains(tuKhoa) || x.DienThoai.Contains(tuKhoa))
                    .ToList(); // Truy xuất danh sách khớp điều kiện [cite: 327]

                BindingSource bs = new BindingSource();
                bs.DataSource = ketQua;
                dgvNhanVien.DataSource = bs;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.FileName = "DanhSachNhanVien.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    var ws = p.Workbook.Worksheets.Add("NhanVien");

                    // 1. Xuất tiêu đề cột
                    for (int i = 1; i <= dgvNhanVien.Columns.Count; i++)
                    {
                        ws.Cells[1, i].Value = dgvNhanVien.Columns[i - 1].HeaderText;
                    }

                    // 2. Xuất dữ liệu hàng
                    for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvNhanVien.Columns.Count; j++)
                        {
                            ws.Cells[i + 2, j + 1].Value = dgvNhanVien.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(sfd.FileName, bin);
                }
                MessageBox.Show("Xuất file Excel thành công!");
            }
        }
    }
}
