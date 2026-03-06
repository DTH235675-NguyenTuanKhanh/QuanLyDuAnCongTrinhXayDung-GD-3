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
    public partial class frmNhaDauTu : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmNhaDauTu()
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
            txtTenNhaDauTu.Enabled = b;
            txtDiaChi.Enabled = b;
            txtDienThoai.Enabled = b;
            txtMaSoThue.Enabled = b;
        }
        private void ClearText()
        {
            txtTenNhaDauTu.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtMaSoThue.DataBindings.Clear();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa NĐT này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                NhaDauTu ndt = context.NhaDauTu.Find(id);
                if (ndt != null)
                {
                    context.NhaDauTu.Remove(ndt);
                    context.SaveChanges();
                    MessageBox.Show("Xóa Loại dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                    frmNhaDauTu_Load(sender, e);
                }
            }
        }

        private void frmNhaDauTu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            ClearText();
            List<NhaDauTu> ndt = new List<NhaDauTu>();
            ndt = context.NhaDauTu.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ndt;
            txtTenNhaDauTu.DataBindings.Add("Text", bindingSource, "TenNhaDauTu", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            txtMaSoThue.DataBindings.Add("Text", bindingSource, "MaSoThue", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhaDauTu.Text))
                MessageBox.Show("Vui lòng nhập nhà đàu tư?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulyThem)
                {
                    NhaDauTu ndt = new NhaDauTu();
                    ndt.TenNhaDauTu = txtTenNhaDauTu.Text;
                    context.NhaDauTu.Add(ndt);
                    context.SaveChanges();
                }
                else
                {
                    NhaDauTu ndt = context.NhaDauTu.Find(id);
                    if (ndt != null)
                    {
                        ndt.TenNhaDauTu = txtTenNhaDauTu.Text;
                        context.NhaDauTu.Update(ndt);
                        context.SaveChanges();
                    }
                }
                frmNhaDauTu_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhaDauTu_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
