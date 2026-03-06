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

    public partial class frmCongViec : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmCongViec()
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
            txtTenCongViec.Enabled = b;
        }

        private void frmCongViec_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<CongViec> cv = new List<CongViec>();
            cv = context.CongViec.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = cv;
            txtTenCongViec.DataBindings.Clear();
            txtTenCongViec.DataBindings.Add("Text", bindingSource, "TenCongViec", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenCongViec.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa công việc này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                CongViec cv = context.CongViec.Find(id);
                if (cv != null)
                {
                    context.CongViec.Remove(cv);
                    context.SaveChanges();
                    MessageBox.Show("Xóa công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenCongViec.Clear();
                    frmCongViec_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenCongViec.Text))
                MessageBox.Show("Vui lòng nhập tên công việc?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulyThem)
                {
                    CongViec cv = new CongViec();
                    cv.TenCongViec = txtTenCongViec.Text;
                    context.CongViec.Add(cv);
                    context.SaveChanges();
                }
                else
                {
                    LoaiDuAn lda = context.LoaiDuAn.Find(id);
                    if (lda != null)
                    {
                        lda.TenLoai = txtTenCongViec.Text;
                        context.LoaiDuAn.Update(lda);
                        context.SaveChanges();
                    }
                }
                frmCongViec_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmCongViec_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
