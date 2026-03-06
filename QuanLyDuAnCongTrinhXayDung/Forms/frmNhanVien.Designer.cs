namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtTimKiem = new TextBox();
            label9 = new Label();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboQuyenHan = new ComboBox();
            label7 = new Label();
            txtChuyenMon = new TextBox();
            label8 = new Label();
            txtLuongCoBan = new TextBox();
            label4 = new Label();
            txtMatKhau = new TextBox();
            label5 = new Label();
            txtTenDangNhap = new TextBox();
            label6 = new Label();
            txtDienThoai = new TextBox();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvNhanVien = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            LuongCoBan = new DataGridViewTextBoxColumn();
            ChuyenMon = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            nhanVienBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhanVienBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtChuyenMon);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtLuongCoBan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1265, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Nhân Viên";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(984, 148);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(249, 34);
            txtTimKiem.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(888, 151);
            label9.Name = "label9";
            label9.Size = new Size(102, 28);
            label9.TabIndex = 24;
            label9.Text = "Tìm Kiếm: ";
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.MediumSpringGreen;
            btnNhap.ForeColor = Color.Black;
            btnNhap.Location = new Point(974, 212);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(120, 46);
            btnNhap.TabIndex = 23;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += button8_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.MediumSpringGreen;
            btnXuat.ForeColor = Color.Black;
            btnXuat.Location = new Point(1122, 212);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(121, 46);
            btnXuat.TabIndex = 22;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Silver;
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(838, 212);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 46);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Fuchsia;
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(695, 212);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(111, 46);
            btnTimKiem.TabIndex = 20;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(255, 128, 0);
            btnHuyBo.ForeColor = Color.Black;
            btnHuyBo.Location = new Point(564, 212);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 46);
            btnHuyBo.TabIndex = 19;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Cyan;
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(423, 212);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 46);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(284, 212);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 46);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Yellow;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(148, 212);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 46);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(18, 212);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 46);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Kỹ Sư", "Nhân Viên" });
            cboQuyenHan.Location = new Point(984, 37);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(249, 36);
            cboQuyenHan.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(872, 39);
            label7.Name = "label7";
            label7.Size = new Size(118, 28);
            label7.TabIndex = 14;
            label7.Text = "Quyền Hạn: ";
            // 
            // txtChuyenMon
            // 
            txtChuyenMon.Location = new Point(984, 86);
            txtChuyenMon.Name = "txtChuyenMon";
            txtChuyenMon.Size = new Size(249, 34);
            txtChuyenMon.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(858, 89);
            label8.Name = "label8";
            label8.Size = new Size(132, 28);
            label8.TabIndex = 12;
            label8.Text = "Chuyên Môn: ";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(601, 148);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(249, 34);
            txtLuongCoBan.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 148);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 10;
            label4.Text = "Lương Cơ Bản: ";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(601, 91);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(249, 34);
            txtMatKhau.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 91);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 8;
            label5.Text = "Mật Khẩu: ";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(601, 39);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(249, 34);
            txtTenDangNhap.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 39);
            label6.Name = "label6";
            label6.Size = new Size(155, 28);
            label6.TabIndex = 6;
            label6.Text = "Tên Đăng Nhập: ";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(122, 148);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(299, 34);
            txtDienThoai.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 148);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 4;
            label3.Text = "Điện Thoại: ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(122, 94);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(299, 34);
            txtDiaChi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 94);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 2;
            label2.Text = "Địa Chỉ: ";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(122, 42);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(299, 34);
            txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "Họ Và Tên: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvNhanVien);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1265, 468);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Nhân Viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeight = 29;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { STT, colID, HoVaTen, DiaChi, DienThoai, TenDangNhap, MatKhau, LuongCoBan, ChuyenMon, QuyenHan });
            dgvNhanVien.DataSource = nhanVienBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.Location = new Point(3, 30);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(1259, 435);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // STT
            // 
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 50;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 50;
            // 
            // HoVaTen
            // 
            HoVaTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.FillWeight = 489.575745F;
            HoVaTen.HeaderText = "Họ và Tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.SortMode = DataGridViewColumnSortMode.NotSortable;
            HoVaTen.Width = 200;
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 13.5776281F;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 150;
            // 
            // DienThoai
            // 
            DienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.FillWeight = 24.8486176F;
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.Width = 140;
            // 
            // TenDangNhap
            // 
            TenDangNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.FillWeight = 37.272213F;
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.Width = 155;
            // 
            // MatKhau
            // 
            MatKhau.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MatKhau.DataPropertyName = "MatKhau";
            MatKhau.FillWeight = 27.3957462F;
            MatKhau.HeaderText = "Mật khẩu";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            MatKhau.Width = 125;
            // 
            // LuongCoBan
            // 
            LuongCoBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            LuongCoBan.DataPropertyName = "LuongCoBan";
            LuongCoBan.FillWeight = 32.14602F;
            LuongCoBan.HeaderText = "Lương Cơ Bản";
            LuongCoBan.MinimumWidth = 6;
            LuongCoBan.Name = "LuongCoBan";
            LuongCoBan.Width = 150;
            // 
            // ChuyenMon
            // 
            ChuyenMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ChuyenMon.DataPropertyName = "ChuyenMon";
            ChuyenMon.FillWeight = 40.57492F;
            ChuyenMon.HeaderText = "Chuyên Môn";
            ChuyenMon.MinimumWidth = 6;
            ChuyenMon.Name = "ChuyenMon";
            ChuyenMon.Width = 120;
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.FillWeight = 40.6288452F;
            QuyenHan.HeaderText = "Quyền Hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.Width = 120;
            // 
            // nhanVienBindingSource
            // 
            nhanVienBindingSource.DataSource = typeof(Data.NhanVien);
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 764);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "NHÂN VIÊN";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhanVienBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDiaChi;
        private Label label2;
        private TextBox txtHoTen;
        private Label label1;
        private TextBox txtLuongCoBan;
        private Label label4;
        private TextBox txtMatKhau;
        private Label label5;
        private TextBox txtTenDangNhap;
        private Label label6;
        private TextBox txtDienThoai;
        private Label label3;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboQuyenHan;
        private Label label7;
        private TextBox txtChuyenMon;
        private Label label8;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThoat;
        private GroupBox groupBox2;
        private DataGridView dgvNhanVien;
        private BindingSource nhanVienBindingSource;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn LuongCoBan;
        private DataGridViewTextBoxColumn ChuyenMon;
        private DataGridViewTextBoxColumn QuyenHan;
        private TextBox txtTimKiem;
        private Label label9;
    }
}