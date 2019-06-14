
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
	HoTen varchar(50),
	NgaySinh date,
	DiaChi varchar(50),
	Email varchar(30),
	NgayLapThe date,
	LoaiDocGia varchar(50),
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

/*PK FOR TABLES*/
alter table muonsach drop MUONSACH_MaSach_FK
alter table sach drop SACH_MaDauSach_FK
DROP TABLE SACH

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
	
	insert DAUSACH (MaDauSach) values ('1')
	insert into TACGIA(MaTacGia) values ('1')
	insert into DAUSACH_TACGIA values ('1','1')
	delete from DAUSACH_TACGIA WHERE (MaDauSach='1')
	delete from DAUSACH where (MaDauSach='1')
	select MaDauSach,TenDauSach from DAUSACH
	select * from TACGIA where MaTacGia='23'
	update TACGIA set MaTacGia='4'
	delete from DAUSACH where MaDauSach='124124'