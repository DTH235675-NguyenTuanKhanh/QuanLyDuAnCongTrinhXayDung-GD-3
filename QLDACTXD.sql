-- Thay đổi tên DB của bạn tại đây (Ví dụ: USE QuanLyXayDung;)
USE QLDACTXD
GO

-- 1. Xóa dữ liệu các bảng cũ (Xóa theo thứ tự bảng con trước, bảng cha sau)
DELETE FROM PhanCong;
DELETE FROM DuAn;
DELETE FROM CongViec;
DELETE FROM NhanVien;
DELETE FROM NhaDauTu;
DELETE FROM KhachHang;
DELETE FROM LoaiDuAn;
DELETE FROM BangLuong;
DELETE FROM VatTu;
DELETE FROM VatTuChiTiet
DELETE FROM NhatKyCongTrinh;

-- 2. Reset Identity (Đặt lại các cột ID tự tăng về 0)
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'PhanCong' AND last_value IS NOT NULL)
DBCC CHECKIDENT ('PhanCong', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'DuAn' AND last_value IS NOT NULL)
DBCC CHECKIDENT ('DuAn', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'CongViec' AND last_value IS NOT NULL)
DBCC CHECKIDENT ('CongViec', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'NhanVien' AND last_value IS NOT NULL)
DBCC CHECKIDENT ('NhanVien', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'NhaDauTu' AND last_value IS NOT NULL)
DBCC CHECKIDENT ('NhaDauTu', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'KhachHang' AND last_value IS NOT NULL)
DBCC CHECKIDENT ('KhachHang', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'LoaiDuAn' AND last_value IS NOT NULL)
DBCC CHECKIDENT ('LoaiDuAn', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'BangLuong' AND last_value IS NOT NULL)
DBCC CHECKIDENT ('BangLuong', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'VatTu' AND last_value IS NOT NULL)
DBCC CHECKIDENT ('VatTu', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'VatTuChiTiet' AND last_value IS NOT NULL)
DBCC CHECKIDENT ('VatTuChiTiet', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'NhatKyCongTrinh' AND last_value IS NOT NULL)
DBCC CHECKIDENT ('NhatKyCongTrinh', RESEED, 0);


-----------------------------------------------------------
-- 3. Thêm dữ liệu mẫu
-----------------------------------------------------------

-- 3.1. Loại Dự Án
SET IDENTITY_INSERT LoaiDuAn ON
INSERT INTO LoaiDuAn (ID, TenLoai) VALUES 
(1, N'Xây dựng Dân dụng'),
(2, N'Công trình Giao thông'),
(3, N'Công trình Công nghiệp');
SET IDENTITY_INSERT LoaiDuAn OFF

-- 3.2. Khách Hàng
INSERT INTO KhachHang (TenCongTy, MaSoThue, DiaChi, SoDienThoai, NguoiDaiDien)
VALUES 
(N'Tập đoàn Xây dựng An Gia', '0101234567', N'123 Đường Lê Lợi, Quận 1, TP.HCM', '02838221122', N'Nguyễn Văn A'),
(N'Công ty Cổ phần Đầu tư Nam Long', '0309876543', N'456 Nguyễn Hữu Thọ, Quận 7, TP.HCM', '02839102030', N'Trần Thị B'),
(N'Tổng Công ty Xây dựng Trường Sơn', '0100112233', N'259 Giải Phóng, Hai Bà Trưng, Hà Nội', '02436644221', N'Lê Văn C'),
(N'Công ty TNHH MTV Nhà Xanh', '3701223344', N'Số 10 Đại lộ Độc Lập, Dĩ An, Bình Dương', '02743889977', N'Phạm Minh D');

-- 3.3. Nhà Đầu Tư
INSERT INTO NhaDauTu (TenNhaDauTu, MaSoThue, DiaChi, DienThoai)
VALUES 
(N'Quỹ Đầu tư VinaCapital', '0304523581', N'Lầu 17, Sun Wah Tower, 115 Nguyễn Huệ, Quận 1, TP.HCM', '02838219930'),
(N'Tập đoàn Tài chính Dragon Capital', '0100776655', N'1501 Me Linh Point Tower, Quận 1, TP.HCM', '02838239355'),
(N'Ngân hàng TMCP Ngoại thương Việt Nam (Vietcombank)', '0100112437', N'198 Trần Quang Khải, Hoàn Kiếm, Hà Nội', '1900545413');

-- 3.4. Nhân Viên
INSERT INTO NhanVien (HoVaTen, DienThoai, DiaChi, ChuyenMon, LuongCoBan, TenDangNhap, MatKhau, QuyenHan)
VALUES 
(N'Nguyễn Văn Hùng', '0912345678', N'Hà Nội', N'Kỹ sư xây dựng', 15000000, 'hungnv', '123456', 1),
(N'Lê Thị Mai', '0988776655', N'TP.HCM', N'Kế toán công trình', 12000000, 'mait', '654321', 0),
(N'Trần Minh Tâm', '0909112233', N'Đà Nẵng', N'Kiến trúc sư', 18000000, 'tamtm', 'password', 1);

-- 3.5. Công Việc
SET IDENTITY_INSERT CongViec ON
INSERT INTO CongViec (ID, TenCongViec) VALUES 
(1, N'Thi công móng'),
(2, N'Xây tường bao'),
(3, N'Lắp đặt hệ thống điện'),
(4, N'Sơn hoàn thiện'),
(5, N'Lắp đặt nội thất'),
(6, N'San lấp mặt bằng'),
(7, N'Ép cọc bê tông cốt thép'),
(8, N'Xây dựng phần thô'),
(9, N'Lắp đặt hệ thống nước'),
(10, N'Hoàn thiện nội thất');
SET IDENTITY_INSERT CongViec OFF

-- 3.6. Dự Án (Giả sử lấy ID từ các bảng trên)
-- Cột: TenDuAn, DiaDiem, NgayBatDau, NgayKetThuc, NganSach, LoaiDuAnID, KhachHangID, NhaDauTuID
INSERT INTO DuAn (TenDuAn, DiaDiem, NgayBatDau, NgayKetThuc, NganSach, LoaiDuAnID, KhachHangID, NhaDauTuID) VALUES 
(N'Chung cư Blue Sky', N'Bình Thạnh, HCM', '2026-01-01', '2027-12-31', 5000000000, 1, 1, 1),
(N'Cầu Mỹ Thuận 3', N'Vĩnh Long', '2026-03-01', '2028-06-30', 10000000000, 2, 2, 2);

-- 3.7. Phân Công (Bảng quan trọng nhất)
-- Cột: DuAnID, NhanVienID, CongViecID, VaiTro, PhuCap, NgayBatDau, NgayKetThuc, PhanTramHoanThanh
INSERT INTO PhanCong (DuAnID, NhanVienID, CongViecID, VaiTro, PhuCap, NgayBatDau, NgayKetThuc, PhanTramHoanThanh) VALUES 
(1, 1, 5, N'Chủ trì thiết kế', 2000000, '2026-01-05', '2026-03-01', 100),
(1, 2, 1, N'Giám sát móng', 1500000, '2026-03-02', '2026-06-30', 20),
(2, 1, 10, N'Kỹ sư tư vấn', 3000000, '2026-03-10', '2026-05-20', 10);
-- 3.8. Bảng Lương 
INSERT INTO BangLuong (NhanVienID, Thang, Nam, SoNgayCong, TongPhuCap, ThucLinh)
VALUES 
(1, 3, 2026, 22, 500000.00, 15500000.00),
(2, 3, 2026, 20, 300000.00, 12300000.00),
(3, 3, 2026, 26, 1000000.00, 21000000.00);
-- 3.9. Nhật ký
INSERT INTO NhatKyCongTrinh (DuAnID, NgayGhi, NoiDungCongViec, GhiChu)
VALUES 
(1, '2026-03-05', N'Đổ bê tông sàn tầng 1', N'Thời tiết tốt, đủ vật tư'),
(1, '2026-03-05', N'Lắp cốt thép cột', N'Thiếu 2 nhân công');
--3.10. Vật Tư
INSERT INTO VatTu (TenVatTu, DonViTinh, DonGia)
VALUES 
(N'Xi măng PC40', N'Bao', 85000),
(N'Thép Hòa Phát phi 10', N'Cây', 115000),
(N'Cát xây tô', N'Khối', 210000);
--3.11. Vật tư chi tiết
INSERT INTO VatTuChiTiet (DuAnID, VatTuID, SoLuong, DonGiaTaiThoiDiem, NgayCapPhat, HinhAnh)
VALUES (1, 1, 100, 90000, '2026-03-06', 'img_ximang_01.jpg');