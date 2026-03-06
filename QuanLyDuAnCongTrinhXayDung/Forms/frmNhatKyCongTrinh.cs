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

namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    public partial class frmNhatKyCongTrinh : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmNhatKyCongTrinh()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool b)
        {
            btnThem.Enabled = !b;
            btnSua.Enabled = !b;
            btnXoa.Enabled = !b;
            btnLuu.Enabled = b;
            btnHuyBo.Enabled = b;
            btnTimKiem.Enabled = !b;
            btnThoat.Enabled = !b;
            btnNhap.Enabled = !b;
            btnXuat.Enabled = !b;
            cboDuAn.Enabled = b;
            txtGhiChu.Enabled = b;
            txtNoiDungCongViec.Enabled = b;
            dtpNgayGhi.Enabled = b;
        }
        private void ClearText()
        {
            txtGhiChu.DataBindings.Clear();
            txtNoiDungCongViec.DataBindings.Clear();
            dtpNgayGhi.DataBindings.Clear();
            cboDuAn.DataBindings.Clear();
        }
        public void LayDuAnVaoComboBox()
        {
            // Lấy danh sách dự án từ bảng DuAn trong cơ sở dữ liệu
            List<DuAn> dsDuAn = context.DuAn.ToList();
            cboDuAn.DataSource = dsDuAn;
            cboDuAn.DisplayMember = "TenDuAn";
            cboDuAn.ValueMember = "ID";
        }

        private void frmNhatKyCongTrinh_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            ClearText();
            LayDuAnVaoComboBox();
            List<NhatKyCongTrinh> nk = new List<NhatKyCongTrinh>();
            nk = context.NhatKyCongTrinh.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nk;
            txtGhiChu.DataBindings.Add("Text", bindingSource, "GhiChu", false, DataSourceUpdateMode.Never);
            txtNoiDungCongViec.DataBindings.Add("Text", bindingSource, "NoiDungCongViec", false, DataSourceUpdateMode.Never);
            dtpNgayGhi.DataBindings.Add("Value", bindingSource, "NgayGhi", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            ClearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra nếu chưa chọn dự án
                if (cboDuAn.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn dự án!");
                    return;
                }

                // 2. Lấy ID dự án (tương tự như cách lấy ID nhân viên)
                int idDuAn = Convert.ToInt32(cboDuAn.SelectedValue);

                if (xulyThem) // Chế độ Thêm mới
                {
                    NhatKyCongTrinh nk = new NhatKyCongTrinh
                    {
                        DuAnID = idDuAn, // Gán ID dự án vừa lấy được
                        NgayGhi = dtpNgayGhi.Value, // Lấy ngày từ DateTimePicker
                        NoiDungCongViec = txtNoiDungCongViec.Text, // Nội dung nhập tay
                        GhiChu = txtGhiChu.Text
                    };
                    context.NhatKyCongTrinh.Add(nk);
                }
                else // Chế độ Sửa
                {
                    // Lấy ID của dòng nhật ký đang chọn trên bảng
                    int idNK = int.Parse(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    var nkUpdate = context.NhatKyCongTrinh.Find(idNK);

                    if (nkUpdate != null)
                    {
                        nkUpdate.DuAnID = idDuAn;
                        nkUpdate.NgayGhi = dtpNgayGhi.Value;
                        nkUpdate.NoiDungCongViec = txtNoiDungCongViec.Text;
                        nkUpdate.GhiChu = txtGhiChu.Text;
                    }
                }

                // 3. Lưu thay đổi xuống Database
                context.SaveChanges();
                frmNhatKyCongTrinh_Load(sender, e); // Tải lại dữ liệu để cập nhật trên giao diện
                MessageBox.Show("Đã lưu nhật ký thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào trong bảng chưa
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bản ghi nhật ký cần xóa!");
                return;
            }

            // 2. Hiện hộp thoại xác nhận để tránh xóa nhầm
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhật ký này không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 3. Lấy ID của dòng đang chọn
                    int idNK = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                    // 4. Tìm bản ghi trong Database
                    var nhatKy = context.NhatKyCongTrinh.Find(idNK);

                    if (nhatKy != null)
                    {
                        // 5. Thực hiện xóa và lưu thay đổi
                        context.NhatKyCongTrinh.Remove(nhatKy);
                        context.SaveChanges();

                        // 6. Thông báo và làm mới dữ liệu trên bảng
                        MessageBox.Show("Đã xóa nhật ký công trình thành công!");
                        frmNhatKyCongTrinh_Load(sender, e); // Tải lại dữ liệu để cập nhật trên giao diện
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhatKyCongTrinh_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
