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
    public partial class frmLoaiDuAn : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmLoaiDuAn()
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
            txtTenLoaiDuAn.Enabled = !b;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenLoaiDuAn.Clear();
        }

        private void frmLoaiDuAn_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<LoaiDuAn> lda = new List<LoaiDuAn>();
            lda = context.LoaiDuAn.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lda;
            txtTenLoaiDuAn.DataBindings.Clear();
            txtTenLoaiDuAn.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Loại dự án này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                LoaiDuAn lda = context.LoaiDuAn.Find(id);
                if (lda != null)
                {
                    context.LoaiDuAn.Remove(lda);
                    context.SaveChanges();
                    MessageBox.Show("Xóa Loại dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenLoaiDuAn.Clear();
                    frmLoaiDuAn_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoaiDuAn.Text))
                MessageBox.Show("Vui lòng nhập tên loại dự án?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulyThem)
                {
                    LoaiDuAn lda = new LoaiDuAn();
                    lda.TenLoai = txtTenLoaiDuAn.Text;
                    context.LoaiDuAn.Add(lda);
                    context.SaveChanges();
                }
                else
                {
                    LoaiDuAn lda = context.LoaiDuAn.Find(id);
                    if (lda != null)
                    {
                        lda.TenLoai = txtTenLoaiDuAn.Text;
                        context.LoaiDuAn.Update(lda);
                        context.SaveChanges();
                    }
                }
                frmLoaiDuAn_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiDuAn_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtTenLoaiDuAn.Enabled = true;
            string tukhoa = txtTenLoaiDuAn.Text.Trim();
            if (!string.IsNullOrEmpty(tukhoa))
            {
                frmLoaiDuAn_Load(sender, e);
            }
            if (int.TryParse(tukhoa, out int tenCanTim))

            {
                var lda = context.LoaiDuAn.Find(tenCanTim);
                if (lda != null)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = new List<LoaiDuAn> { lda };
                    dataGridView.DataSource = bs;
                }
            }
            else { MessageBox.Show("Vui lòng nhập Tên loại cần tìm"); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
