
USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='LIBMANAGEMENT')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'LIBMANAGEMENT') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [LIBMANAGEMENT]
END

CREATE DATABASE LIBMANAGEMENT
USE LIBMANAGEMENT

CREATE TABLE SACH
(
	MaSach varchar(30) PRIMARY KEY,
	MaDauSach varchar(30),
	NgayNhap datetime,
	NXB varchar(50),
	NamXuatBan datetime,
	Gia money,
	DaMuon bit
)

CREATE TABLE TACGIA
(
	MaTacGia varchar(30) PRIMARY KEY,
	HoTen varchar (50),
	NgaySinh datetime,
)

CREATE TABLE THEDOCGIA
(
	MaThe varchar(30) PRIMARY KEY,
	MaLoai varchar(30),
	HoTen varchar(50),
	NgaySinh date,
	DiaChi varchar(50),
	Email varchar(30),
	NgayLapThe datetime,
)

CREATE TABLE LOAIDOCGIA
(
	MaLoai varchar(30) PRIMARY KEY,
	TenLoai varchar(30)
)

CREATE TABLE NGUOIDUNG
(
	MaNguoiDung varchar(30) PRIMARY KEY,
	HoTen varchar(50),
	DiaChi varchar(50),
	Email varchar(30),
	TenDangNhap varchar(30),
	MatKhau varchar(30)
)

CREATE TABLE THELOAISACH
(
	MaTheLoai varchar(30) PRIMARY KEY,
	TenTheLoai varchar(50)
)

CREATE TABLE DAUSACH
(
	MaDauSach varchar(30) PRIMARY KEY,
	TenDauSach varchar(50),
	TongSoLuong int,
	SoLuongDaMuon int,
	SoLuongConLai int
)

CREATE TABLE DAUSACH_TACGIA
(
	MaDauSach varchar(30),
	MaTacGia varchar(30),
	PRIMARY KEY (MaDauSach, MaTacGia)
)

CREATE TABLE DAUSACH_THELOAI
(
	MaDauSach varchar(30),
	MaTheLoai varchar(30),
	PRIMARY KEY (MaDauSach, MaTheLoai)
)

CREATE TABLE MUONSACH
(
	MaThe varchar(30),
	MaNguoiDung varchar(30),
	MaSach varchar(30),
	MaMuonSach varchar(30),
	NgayMuon datetime,
	NgayTra datetime,
	NgayTraThucTe datetime,
	PRIMARY KEY (MaThe, MaNguoiDung, MaSach, MaMuonSach)
)

CREATE TABLE THAMSO
(
	TuoiToiDaDocGia int,
	TuoiToiThieuDocGia int,
	ThoiHanThe int,
	SoTheLoaiToiDa int,
	SoTacGiaToiDa int,
	NamXuatBanToiDa int, /*Give data about maxium year of book can be received */
	SoSachMuonToiDa int,
	SoNgayMuonToiDa int,
)
/*PK FOR TABLES*/


	ALTER TABLE SACH ADD
		CONSTRAINT SACH_MaDauSach_FK FOREIGN KEY (MaDauSach)
			REFERENCES DAUSACH (MaDauSach)

	ALTER TABLE THEDOCGIA ADD
		CONSTRAINT THEDOCGIA_MaLoai_FK FOREIGN KEY (MaLoai)
			REFERENCES LOAIDOCGIA (MaLoai)

	ALTER TABLE DAUSACH_TACGIA ADD
		CONSTRAINT DAUSACH_TACGIA_MaDauSach_FK FOREIGN KEY (MaDauSach)
			REFERENCES DAUSACH (MaDauSach)

	ALTER TABLE DAUSACH_TACGIA ADD
		CONSTRAINT DAUSACH_TACGIA_MaTacGia_FK FOREIGN KEY (MaTacGia)
			REFERENCES TACGIA (MaTacGia)

	ALTER TABLE DAUSACH_THELOAI ADD
		CONSTRAINT DAUSACH_THELOAI_MaDauSach_FK FOREIGN KEY (MaDauSach)
			REFERENCES DAUSACH (MaDauSach)

	ALTER TABLE DAUSACH_THELOAI ADD
		CONSTRAINT DAUSACH_THELOAI_MaTheLoai_FK FOREIGN KEY (MaTheLoai)
			REFERENCES THELOAISACH (MaTheLoai)

	ALTER TABLE MUONSACH ADD
		CONSTRAINT MUONSACH_MaThe_FK FOREIGN KEY (MaThe)
			REFERENCES THEDOCGIA (MaThe)
	
	ALTER TABLE MUONSACH ADD
		CONSTRAINT MUONSACH_MaNguoiDung_FK FOREIGN KEY (MaNguoiDung)
			REFERENCES NGUOIDUNG (MaNguoiDung)

	ALTER TABLE MUONSACH ADD
		CONSTRAINT MUONSACH_MaSach_FK FOREIGN KEY (MaSach)
			REFERENCES SACH (MaSach)

	

SELECT DAUSACH.TenDauSach, MUONSACH.NgayMuon, DATEDIFF(dd, MUONSACH.NgayMuon, MUONSACH.NgayTraThucTe) AS SONGAYTRATRE
FROM MUONSACH INNER JOIN
                  THEDOCGIA ON MUONSACH.MaThe = THEDOCGIA.MaThe INNER JOIN
                  NGUOIDUNG ON NGUOIDUNG.MaNguoiDung = MUONSACH.MaNguoiDung INNER JOIN
                  SACH ON SACH.MaSach = MUONSACH.MaSach INNER JOIN
                  DAUSACH ON DAUSACH.MaDauSach = SACH.MaDauSach
WHERE  (DATEDIFF(dd, MUONSACH.NgayMuon, MUONSACH.NgayTraThucTe) > 0)






SELECT THELOAISACH.TenTheLoai, COUNT (MUONSACH.MaSach) AS SOLUONGMUON
FROM     DAUSACH ,
                  DAUSACH_THELOAI,
                  THELOAISACH ,
                  SACH , MUONSACH
WHERE DAUSACH.MaDauSach = DAUSACH_THELOAI.MaTheLoai 
		AND THELOAISACH.MaTheLoai = DAUSACH_THELOAI.MaTheLoai
			AND SACH.MaSach = MUONSACH.MaSach
				AND DAUSACH.MaDauSach = SACH.MaDauSach
GROUP BY  THELOAISACH.TenTheLoai

