-- Kiểm tra CSLD QLHSUNGTUYEN tồn tại chưa
IF DB_ID('QLHSUNGTUYEN') IS NOT NULL
	DROP DATABASE QLHSUNGTUYEN
CREATE DATABASE QLHSUNGTUYEN
GO
-- Sử dụng CSDL đã tạo
USE QLHSUNGTUYEN
GO

-- NHANVIEN --
create table NHANVIEN
(
	MaNV integer identity(1,1) not null,
	ID as 'NV' + right('000000' + cast(MaNV as varchar(8)),6) persisted,
	Pass_word varchar(50) not null,
	Hoten nvarchar(50) not null,
	Gioitinh nvarchar(6) not null,
	Sdt char(10) not null,
	Diachi nvarchar(50) not null,
	Email nvarchar(50) not null,
	LoaiNV nvarchar(10) not null,

	constraint PK_NHANVIEN
	primary key (MaNV),

	constraint CK_NHANVIEN_Gioitinh
	check (Gioitinh = 'Male' or Gioitinh = 'Female'),

	constraint CK_NHANVIEN_LoaiNV
	check (LoaiNV = 'NV' or LoaiNV = 'GD'),
);

-- DOANHNGHIEP --
create table DOANHNGHIEP
(
	MaDN integer identity(1,1) not null,
	ID as 'DN' + right('000000' + cast(MaDN as varchar(8)),6) persisted,
	Pass_word varchar(50) not null,
	TenDN nvarchar(50) not null,
	MaSoThue char(10) not null,
	NguoiDaiDien nvarchar(50) not null,
	Diachi nvarchar(50) not null,
	Email nvarchar(50) not null,
	TiemNang char(2),
	MaPhieuDKDN integer not null,

	constraint PK_DOANHNGHIEP
	primary key (MaDN),

	constraint CK_DOANHNGHIEP_TiemNang
	check (TiemNang = '1' or TiemNang ='0')
);

-- PHIEUDKTVDN --
create table PHIEUDKTVDN
(
	MaPhieuDKDN integer identity(1,1) not null,
	ID as 'DKDN' + right('0000' + cast(MaPhieuDKDN as varchar(8)),4) persisted,
	NgayLap date not null,
	NVXetDuyet integer,
	--TenDN nvarchar(50) not null,
	--MaSoThue char(10) not null,
	--NguoiDaiDien nvarchar(50) not null,
	--Diachi nvarchar(50) not null,
	--Email nvarchar(50) not null,
	TrangThai nvarchar(15),

	constraint CK_PHIEUDKTVDN_TrangThai
	check (TrangThai = 'Pending' or TrangThai = 'Valid' or TrangThai = 'Invalid'),

	constraint PK_PHIEUDKTVDN
	primary key (MaPhieuDKDN),
);

-- THONGTINDANGTUYEN --
create table THONGTINDANGTUYEN
(
	MaDT integer identity(1,1) not null,
	ID as 'DT' + right('000000' + cast(MaDT as varchar(8)),6) persisted,
	NgDangTuyen date not null,
	MaDN integer not null,
	NgHetHan date not null,
	SoLuong integer not null,
	ViTri nvarchar(50) not null,
	YeuCau nvarchar(100) not null,

	constraint PK_THONGTINDANGTUYEN
	primary key (MaDT)
);

-- HINHTHUCDANGTUYEN --
create table HINHTHUCDANGTUYEN
(
	MaHT integer identity(1,1) not null,
	ID as 'HT' + right('000000' + cast(MaHT as varchar(8)),6) persisted,
	TenHinhThuc nvarchar(50) not null,
	MoTa nvarchar(100),
	GiaTien integer not null,

	constraint PK_HINHTHUCDANGTUYEN
	primary key (MaHT)
);

-- PHIEUDKQUANGCAO --
create table PHIEUDKQUANGCAO
(
	MaHT integer not null,
	MaDT integer not null,
	--MaNV integer not null,
	MaHDong integer not null,
	NgayLap date not null,

	constraint PK_PHIEUDKQUANGCAO
	primary key (MaHT, MaDT)
);

-- PHIEUTHU --
create table PHIEUTHU
(
	MaPT integer identity(1,1) not null,
	ID as 'PT' + right('000000' + cast(MaPT as varchar(8)),6) persisted,
	MaNV integer not null,
	DotThu char(2) not null,
	NgayThu date not null,
	SoTien integer not null,
	MaHDong integer not null,

	constraint PK_PHIEUTHU
	primary key (MaPT)
);

-- HOPDONG --
create table HOPDONG
(
	MaHDong integer identity(1,1) not null,
	ID as 'HD' + right('000000' + cast(MaHDong as varchar(8)),6) persisted,
	MaNV integer not null,
	MaDN integer not null,
	NgKy date not null,
	NgHetHan date not null,
	NoiDung nvarchar(100) not null,
	PhuLuc integer,
	SoDotTT integer not null,
	SoTienTT integer not null,
	TinhTrangKyDuyet char(2) not null,
	UuDai tinyint,

	constraint PK_HOPDONG
	primary key (MaHDong),

	constraint CK_HOPDONG_TinhTrangKyDuyet
	check (TinhTrangKyDuyet = '1' or TinhTrangKyDuyet ='0')
);

-- HOADON --
create table HOADON
(
	MaHD integer identity(1,1) not null,
	ID as 'HDON' + right('0000' + cast(MaHD as varchar(8)),4) persisted,
	MaNV integer not null,
	MaHDong integer not null,
	NgLap date,
	TongTien integer,

	constraint PK_HOADON
	primary key (MaHD)
);

-- UNGVIEN --
create table UNGVIEN
(
	MaUV integer identity(1,1) not null,
	ID as 'UV' + right('000000' + cast(MaUV as varchar(8)),6) persisted,
	Pass_word varchar(50) not null,
	Hoten nvarchar(50) not null,
	Gioitinh nvarchar(6) not null,
	Sdt char(10) not null,
	Diachi nvarchar(50) not null,
	Email nvarchar(50) not null,
	MaPhieuDKUV integer not null,

	constraint CK_UNGVIEN_Gioitinh
	check (Gioitinh = 'Male' or Gioitinh = 'Female'),

	constraint PK_UNGVIEN
	primary key (MaUV)
);

-- PHIEUDKTVUV --
create table PHIEUDKTVUV
(
	MaPhieuDKUV integer identity(1,1) not null,
	ID as 'DKUV' + right('0000' + cast(MaPhieuDKUV as varchar(8)),4) persisted,
	NgayLap date not null,
	NVXetDuyet integer,
	--Hoten nvarchar(50) not null,
	--Gioitinh nvarchar(3) not null,
	--Sdt char(10) not null,
	--Diachi nvarchar(50) not null,
	--Email nvarchar(50) not null,
	TrangThai nvarchar(15),

	constraint CK_PHIEUDKTVUV_TrangThai
	check (TrangThai = 'Pending' or TrangThai = 'Valid' or TrangThai = 'Invalid'),

	constraint PK_PHIEUDKTVUV
	primary key (MaPhieuDKUV),
);

-- PHIEUDKUNGTUYEN --
create table PHIEUDKUNGTUYEN
(
	MaUV integer not null,
	MaDT integer not null,
	NgayLap date not null,

	constraint PK_PHIEUDKUNGTUYEN
	primary key (MaUV, MaDT)
);

-- BANGCAP --
create table BANGCAP
(
	MaBang integer identity(1,1) not null,
	ID as 'B' + right('0000000' + cast(MaBang as varchar(8)),7) persisted,
	TenBang nvarchar(50) not null,
	MaUV integer not null,

	constraint PK_BANGCAP
	primary key (MaBang)
);

-- HOSOUNGTUYEN --
create table HOSOUNGTUYEN
(
	MaDT integer not null,
	MaUV integer not null,
	MaNV integer not null,
	TinhTrang nvarchar(10) not null,

	constraint PK_HOSOUNGTUYEN
	primary key (MaDT, MaUV)
);

-- HSUT_BANGCAP --
create table HSUT_BANGCAP
(
	MaDT integer not null,
	MaUV integer not null,
	--MaNV integer not null,
	MaBang integer not null,
	TinhTrang nvarchar(10) not null,

	constraint PK_HSUT_BANGCAP
	primary key (MaDT, MaUV, MaBang)
);

---------------------------------------------------------
-- FOREIGN KEY --
-- DOANHNGHIEP
alter table DOANHNGHIEP
add 
	constraint FK_DOANHNGHIEP_PHIEUDKTVDN
	foreign key (MaPhieuDKDN) references PHIEUDKTVDN(MaPhieuDKDN);

-- UNGVIEN
alter table UNGVIEN
add 
	constraint FK_UNGVIEN_PHIEUDKTVUV
	foreign key (MaPhieuDKUV) references PHIEUDKTVUV(MaPhieuDKUV);

-- THONGTINDANGTUYEN --
alter table THONGTINDANGTUYEN
add 
	constraint FK_THONGTINDANGTUYEN_DOANHNGHIEP
	foreign key (MaDN) references DOANHNGHIEP(MaDN);

-- PHIEUDKQUANGCAO --
alter table PHIEUDKQUANGCAO
add 
	constraint FK_PHIEUDKQUANGCAO_THONGTINDANGTUYEN
	foreign key (MaDT) references THONGTINDANGTUYEN(MaDT),
	
	constraint FK_PHIEUDKQUANGCAO_HINHTHUCDANGTUYEN
	foreign key (MaHT) references HINHTHUCDANGTUYEN(MaHT);

-- PHIEUDKUNGTUYEN --
alter table PHIEUDKUNGTUYEN
add 
	constraint FK_PHIEUDKUNGTUYEN_UNGVIEN
	foreign key (MaUV) references UNGVIEN(MaUV),
	
	constraint FK_PHIEUDKUNGTUYEN_THONGTINDANGTUYEN
	foreign key (MaDT) references THONGTINDANGTUYEN(MaDT);

-- BANGCAP --
alter table BANGCAP
add 
	constraint FK_BANGCAP_UNGVIEN
	foreign key (MaUV) references UNGVIEN(MaUV);

-- PHIEUDKTVUV --
alter table PHIEUDKTVUV
add 
	constraint FK_PHIEUDKTVUV_NHANVIEN
	foreign key (NVXetDuyet) references NHANVIEN(MaNV);

-- PHIEUDKTVDN --
alter table PHIEUDKTVDN
add 
	constraint FK_PHIEUDKTVDN_NHANVIEN
	foreign key (NVXetDuyet) references NHANVIEN(MaNV);

-- HOADON --
alter table HOADON
add 
	constraint FK_HOADON_NHANVIEN
	foreign key (MaNV) references NHANVIEN(MaNV),

	constraint FK_HOADON_HOPDONG
	foreign key (MaHDong) references HOPDONG(MaHDong);

-- HOPDONG --
alter table HOPDONG
add 
	constraint FK_HOPDONG_DOANHNGHIEP
	foreign key (MaDN) references DOANHNGHIEP(MaDN),

	constraint FK_HOPDONG_NHANVIEN
	foreign key (MaNV) references NHANVIEN(MaNV),
	
	constraint FK_HOPDONG_HOPDONG
	foreign key (PhuLuc) references HOPDONG(MaHDong);

-- PHIEUTHU --
alter table PHIEUTHU
add 
	constraint FK_PHIEUTHU_NHANVIEN
	foreign key (MaNV) references NHANVIEN(MaNV),
	
	constraint FK_PHIEUTHU_HOPDONG
	foreign key (MaHDong) references HOPDONG(MaHDong)
/*
-- HOPDONG_PHIEUTHU --
alter table HOPDONG_PHIEUTHU
add 
	constraint FK_HOPDONG_PHIEUTHU_HOPDONG
	foreign key (MaHDong) references HOPDONG(MaHDong),

	constraint FK_HOPDONG_PHIEUTHU_PHIEUTHU
	foreign key (MaPT) references PHIEUTHU(MaPT);
*/
-- HOSOUNGTUYEN --
alter table HOSOUNGTUYEN
add 
	constraint FK_HOSOUNGTUYEN_UNGVIEN
	foreign key (MaUV) references UNGVIEN(MaUV),
	
	constraint FK_HOSOUNGTUYEN_NHANVIEN
	foreign key (MaNV) references NHANVIEN(MaNV),

	constraint FK_HOSOUNGTUYEN_THONGTINDANGTUYEN
	foreign key (MaDT) references THONGTINDANGTUYEN(MaDT);

-- HSUT_BANGCAP --
alter table HSUT_BANGCAP
add 
	constraint FK_HSUT_BANGCAP_UNGVIEN
	foreign key (MaUV) references UNGVIEN(MaUV),
	
	/*constraint FK_HSUT_BANGCAP_NHANVIEN
	foreign key (MaNV) references NHANVIEN(MaNV),*/

	constraint FK_HSUT_BANGCAP_THONGTINDANGTUYEN
	foreign key (MaDT) references THONGTINDANGTUYEN(MaDT),

	constraint FK_HSUT_BANGCAP_BANGCAP
	foreign key (MaBang) references BANGCAP(MaBang);