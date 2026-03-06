namespace QuanLyDuAnCongTrinhXayDung
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NhanVien = new Button();
            btnKhachHang = new Button();
            btnLoaiDA = new Button();
            btnCongViec = new Button();
            btnBangLuong = new Button();
            button1 = new Button();
            btnNhatKy = new Button();
            SuspendLayout();
            // 
            // NhanVien
            // 
            NhanVien.Location = new Point(91, 56);
            NhanVien.Name = "NhanVien";
            NhanVien.Size = new Size(94, 29);
            NhanVien.TabIndex = 0;
            NhanVien.Text = "Nhân Viên";
            NhanVien.UseVisualStyleBackColor = true;
            NhanVien.Click += NhanVien_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Location = new Point(226, 56);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(130, 29);
            btnKhachHang.TabIndex = 1;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnLoaiDA
            // 
            btnLoaiDA.Location = new Point(389, 56);
            btnLoaiDA.Name = "btnLoaiDA";
            btnLoaiDA.Size = new Size(94, 29);
            btnLoaiDA.TabIndex = 2;
            btnLoaiDA.Text = "Loại dự án";
            btnLoaiDA.UseVisualStyleBackColor = true;
            btnLoaiDA.Click += btnLoaiDA_Click;
            // 
            // btnCongViec
            // 
            btnCongViec.Location = new Point(544, 56);
            btnCongViec.Name = "btnCongViec";
            btnCongViec.Size = new Size(94, 29);
            btnCongViec.TabIndex = 3;
            btnCongViec.Text = "Công việc";
            btnCongViec.UseVisualStyleBackColor = true;
            btnCongViec.Click += btnCongViec_Click;
            // 
            // btnBangLuong
            // 
            btnBangLuong.Location = new Point(91, 123);
            btnBangLuong.Name = "btnBangLuong";
            btnBangLuong.Size = new Size(94, 29);
            btnBangLuong.TabIndex = 4;
            btnBangLuong.Text = "Bảng lương";
            btnBangLuong.UseVisualStyleBackColor = true;
            btnBangLuong.Click += btnBangLuong_Click;
            // 
            // button1
            // 
            button1.Location = new Point(226, 123);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Nhà đầu tư";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnNhatKy
            // 
            btnNhatKy.Location = new Point(389, 123);
            btnNhatKy.Name = "btnNhatKy";
            btnNhatKy.Size = new Size(94, 29);
            btnNhatKy.TabIndex = 6;
            btnNhatKy.Text = "Nhật ký";
            btnNhatKy.UseVisualStyleBackColor = true;
            btnNhatKy.Click += btnNhatKy_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNhatKy);
            Controls.Add(button1);
            Controls.Add(btnBangLuong);
            Controls.Add(btnCongViec);
            Controls.Add(btnLoaiDA);
            Controls.Add(btnKhachHang);
            Controls.Add(NhanVien);
            Name = "DangNhap";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button NhanVien;
        private Button btnKhachHang;
        private Button btnLoaiDA;
        private Button btnCongViec;
        private Button btnBangLuong;
        private Button button1;
        private Button btnNhatKy;
    }
}
