﻿use master
go
drop database ATVSTP
go
create database ATVSTP
go
use ATVSTP
go

create table QuanHuyen( 
	IDQuanHuyen int primary key NOT NULL,
	TenQuanHuyen nvarchar(255)
)


create table PhuongXa( 
	IDPhuongXa int primary key NOT NULL,
	TenPhuongXa nvarchar(255),
	IDQuanHuyen int,
	foreign key (IDQuanHuyen) references QuanHuyen(IDQuanHuyen)
)
go

CREATE TABLE VaiTro (
    Id varchar(450) NOT NULL PRIMARY KEY,
    TenVaiTro nvarchar(256) NULL,
    TenChuanHoa nvarchar(256) NULL,
    DauVetDongBo nvarchar(max) NULL
);
CREATE TABLE NguoiDung (
    Id varchar(450) NOT NULL PRIMARY KEY,
	CCCD varchar(12) NULL,
    DiaChiNha nvarchar(400) NULL,
    NgaySinh datetime2(7) NULL,
    TenDangNhap nvarchar(256) NULL,
    TenDangNhapChuanHoa nvarchar(256) NULL,
    Email nvarchar(256) NULL,
    EmailChuanHoa nvarchar(256) NULL,
    EmailDaXacNhan bit NOT NULL,
    MatKhauHash nvarchar(max) NULL,
    DauVetBaoMat nvarchar(max) NULL,
    DauVetDongBo nvarchar(max) NULL,
    SoDienThoai nvarchar(max) NULL,
    SoDienThoaiDaXacNhan bit NOT NULL,
    XacThucHaiYeuTo bit NOT NULL,
    ThoiGianKhoaCuoiCung datetimeoffset(7) NULL,
    DaKhoaTaiKhoan bit NOT NULL,
    SoLanDangNhapThatBai int NOT NULL
);

go
CREATE TABLE NguoiDungVaiTro (
    NguoiDungId varchar(450) NOT NULL,
    VaiTroId varchar(450) NOT NULL,
    PRIMARY KEY (NguoiDungId, VaiTroId),
    FOREIGN KEY (NguoiDungId) REFERENCES NguoiDung(Id),
    FOREIGN KEY (VaiTroId) REFERENCES VaiTro(Id)
);
CREATE TABLE XacThucNguoiDung (
    NguoiDungId varchar(450) NOT NULL,
    NhaCungCapDangNhap varchar(450) NOT NULL,
    Ten varchar(450) NOT NULL,
    GiaTri nvarchar(max) NULL,
    PRIMARY KEY (NguoiDungId, NhaCungCapDangNhap, Ten),
    FOREIGN KEY (NguoiDungId) REFERENCES NguoiDung(Id)
);

create table CoSo
(
	IDCoSo int primary key identity(1, 1),
	IDChuCoSo varchar(450),
	TenCoSo nvarchar(max),
	DiaChi nvarchar(max),
	IDPhuongXa int,
	LoaiHinhKinhDoanh nvarchar(max),
	SoGiayPhepKD varchar(max),
	NgayCapGiayPhepKD date,
	NgayCapCNATTP date,
	NgayHetHanCNATTP date,
	foreign key (IDChuCoSo) references NguoiDung(Id),
	foreign key (IDPhuongXa) references PhuongXa(IDPhuongXa)
)
go

create table HoSoCapGiayChungNhan
(
	IDGiayChungNhan int primary key identity(1, 1),
	IDCoSo int,
	NgayDangKy date default GETDATE(),
	LoaiThucPham nvarchar(max),
	HinhAnhMinhChung varchar(max),
	TrangThai int default 0,
	foreign key (IDCoSo) references CoSo(IDCoSo)
)
go

create table BanCongBoSP
(
	IDBanCongBoSP int primary key identity(1, 1),
	IDCoSo int,
	NgayCongBo date,
	TenSanPham nvarchar(max),
	ThanhPhan nvarchar(max),
	ThoiHanSuDung date,
	CachDongGoi_BaoBi nvarchar(max),
	Ten_DiaChiSX nvarchar(max),
	MauNhanSP varchar(max),
	HinhAnhMinhChung varchar(max),
	TrangThai int,
	foreign key (IDCoSo) references CoSo(IDCoSo)
)
go

create table ThongBaoThayDoi
(
	IDThongBao int primary key identity(1, 1),
	IDCoSo int,
	IDChuCoSoMoi varchar(450),
	TenCoSoMoi nvarchar(max),
	DiaChiMoi nvarchar(max),
	TrangThai int,
	foreign key (IDCoSo) references CoSo(IDCoSo),
	foreign key (IDChuCoSoMoi) references NguoiDung(Id)
)
go

create table BaoCaoViPham
(
	IDBaoCao bigint primary key identity(1, 1),
	HoTen nvarchar(max),
	SDT varchar(11),
	CCCD varchar(12),
	NgayBaoCao date,
	HinhAnhMinhChung varchar(max),
	IDCoSo int,
	foreign key (IDCoSo) references CoSo(IDCoSo)
)
go

CREATE TABLE TinTuc(
	IDTinTuc int IDENTITY(1,1) Primary key NOT NULL,
	TieuDe nvarchar(160) NOT NULL,
	MoTa nvarchar(max) NOT NULL,
	Slug nvarchar(160) NOT NULL,
	NoiDung nvarchar(max) NOT NULL,
	Published bit NOT NULL,
	IDCanBo varchar(450) NOT NULL ,
	NgayTao datetime2(7) NOT NULL,
	NgayCapNhat datetime2(7) NOT NULL,

	foreign key (IDCanBo) references NguoiDung(Id)
)
CREATE TABLE DanhMuc(
	Id int IDENTITY(1,1) Primary Key NOT NULL,
	TenDanhMuc nvarchar(100) NOT NULL,
	NoiDung nvarchar(max) NOT NULL,
	Slug nvarchar(100) NOT NULL,
	IdDanhMucCha int NULL,
	foreign key (IdDanhMucCha) references DanhMuc(Id)
)
GO
CREATE TABLE DanhMucBaiDang(
	IDTinTuc int NOT NULL,
	IDDanhMuc int NOT NULL,

	primary key(IDTinTuc, IDDanhMuc),

	foreign key (IDTinTuc) references TinTuc(IDTinTuc),
	foreign key (IDDanhMuc) references DanhMuc(Id))	
go

create table KeHoach
(
	IDKeHoach int primary key identity(1, 1),
	ThoiGianBatDau datetime,
	DoanSo int,
	Loai nvarchar(max)
)

create table ChiTietDoanThanhTra
(
	IDKeHoach int,
	IDCanBo varchar(450),
	ChucVu nvarchar(max),
	primary key(IDKeHoach, IDCanBo),
	foreign key (IDKeHoach) references KeHoach(IDKeHoach),
	foreign key (IDCanBo) references NguoiDung(Id)
)

create table KeHoach_CoSo
(
	IDKeHoachCoSo int primary key identity(1, 1),
	IDKeHoach int,
	IDCoSo int,
	ThoiGianKiemTra datetime,
	NgayTao date,
	KetLuan nvarchar(max),
	KhacPhuc nvarchar(max),
	YKienChuCoSo nvarchar(max),
	foreign key (IDKeHoach) references KeHoach(IDKeHoach),
	foreign key (IDCoSo) references CoSo(IDCoSo)
)

create table MucKiemTra
(
	IDMucKT int primary key identity(1, 1),
	NoiDung nvarchar(max),
)

create table ChiTietKetQua
(
	IDKeHoachCoSo int,
	IDMucKT int,
	Dat bit,
	primary key(IDKeHoachCoSo, IDMucKT),
	foreign key (IDKeHoachCoSo) references KeHoach_CoSo(IDKeHoachCoSo),
	foreign key (IDMucKT) references MucKiemTra(IDMucKT)
)

go
insert into QuanHuyen(IDQuanHuyen,TenQuanHuyen)
values(1,N'Quận Cẩm Lệ'),
(2,N'Quận Hải Châu'),
(3,N'Quận Liên Chiểu'),
(4,N'Quận Ngũ Hành Sơn'),
(5,N'Quận Sơn Trà'),
(6,N'Quận Thanh Khê'),
(7,N'Huyện Hòa Vang'),
(8,N'Huyện Hoàng Sa')

go
insert into PhuongXa(IDPhuongXa,TenPhuongXa,IDQuanHuyen)
values(1,N'Phường Khuê Trung',1),
(2,N'Phường Hòa Phát',1),
(3,N'Phường Hòa An',1),
(4,N'Phường Hòa Thọ Tây',1),
(5,N'Phường Hòa Thọ Đông',1),
(6,N'Phường Hòa Xuân',1),
(7,N'Phường Thanh Bình',2),
(8,N'Phường Thuận Phước',2),
(9,N'Phường Thạch Thang',2),
(10,N'Phường Hải Châu I',2),
(11,N'Phường Hải Châu II',2),
(12,N'Phường Phước Ninh',2),
(13,N'Phường Hòa Thuận Tây',2),
(14,N'Phường Hòa Thuận Đông',2),
(15,N'Phường Nam Dương',2),
(16,N'Phường Bình Hiên',2),
(17,N'Phường Bình Thuận',2),
(18,N'Phường Hòa Cường Bắc',2),
(19,N'Phường Hòa Cường Nam',2),
(20,N'Phường Hòa Hiệp Bắc',3),
(21,N'Phường Hòa Hiệp Nam',3),
(22,N'Phường Hòa Khánh Bắc',3),
(23,N'Phường Hòa Khánh Nam',3),
(24,N'Phường Hòa Hòa Minh',3),
(25,N'Phường Hòa Hải',4),
(26,N'Phường Hòa Quý',4),
(27,N'Phường Khuê Mỹ',4),
(28,N'Phường Mỹ An',4),
(29,N'Phường An Hải Bắc',5),
(30,N'Phường An Hải Đông',5),
(31,N'Phường An Hải Tây',5),
(32,N'Phường Mân Thái',5),
(33,N'Phường Nại Hiên Đông',5),
(34,N'Phường Phước Mỹ',5),
(35,N'Phường Thọ Quang',5),
(36,N'Phường An Khê',6),
(37,N'Phường Chính Gián',6),
(38,N'Phường Hòa Khê',6),
(39,N'Phường Tam Thuận',6),
(40,N'Phường Tân Chính',6),
(41,N'Phường Thạc Gián',6),
(42,N'Phường Thạch Khê Đông',6),
(43,N'Phường Thạch Khê Tây',6),
(44,N'Phường Vĩnh Trung',6),
(45,N'Phường Xuân Hà',6),
(46,N'Xã Hòa Bắc',7),
(47,N'Xã Hòa Châu',7),
(48,N'Xã Hòa Khương',7),
(49,N'Xã Hòa Liên',7),
(50,N'Xã Hòa Nhơn',7),
(51,N'Xã Hòa Ninh',7),
(52,N'Xã Hòa Phong',7),
(53,N'Xã Hòa Phú',7),
(54,N'Xã Hòa Phước',7),
(55,N'Xã Hòa Sơn',7),
(56,N'Xã Hòa Tiến',7)

go
insert into NguoiDung(Id,TenDangNhap,MatKhauHash,SoLanDangNhapThatBai,EmailDaXacNhan,SoDienThoaiDaXacNhan,XacThucHaiYeuTo,DaKhoaTaiKhoan)
values(NEWID(),'user','user',0,0,0,0,0),
(NEWID(),'user2','user2',0,0,0,0,0)

go
--tao procedure
-- insert hồ sơ với cơ sở mới 
create procedure insertGiayChungNhan_CoSo
	@IDChuCoSo varchar(450),
	@TenCoSo nvarchar(max),
	@IDPhuongXa int,
	@DiaChi nvarchar(max),
	@LoaiHinhKinhDoanh nvarchar(max),
	@SoGiayPhepKD nvarchar(max),
	@NgayCapGiayPhepKD date,
	@LoaiThucPham nvarchar(max),
	@HinhAnhMinhChung varchar(max)
as
begin
	insert into CoSo(IDChuCoSo,TenCoSo,IDPhuongXa,DiaChi,LoaiHinhKinhDoanh,SoGiayPhepKD,NgayCapGiayPhepKD)
	values(@IDChuCoSo,@TenCoSo,@IDPhuongXa,@DiaChi,@LoaiHinhKinhDoanh,@SoGiayPhepKD,@NgayCapGiayPhepKD)
	declare @IDCoSo int = SCOPE_IDENTITY()
	insert into HoSoCapGiayChungNhan(IDCoSo,LoaiThucPham,HinhAnhMinhChung)
	values (@IDCoSo,@LoaiThucPham,@HinhAnhMinhChung)
	select SCOPE_IDENTITY()
end

go
-- insert hồ sơ với cơ sở đã có sẵn
create procedure insertGiayChungNhan
	@IDCoSo int,
	@LoaiThucPham nvarchar(max),
	@HinhAnhMinhChung varchar(max)
as
begin 
	declare @NgayDangKy date = getdate()
	declare @TrangThai int = 0 --Trang thai -1: huybo	0:cho xet duyet	1:da duoc duyet
	insert into HoSoCapGiayChungNhan(IDCoSo,NgayDangKy,LoaiThucPham,HinhAnhMinhChung,TrangThai)
	values (@IDCoSo,@NgayDangKy,@LoaiThucPham,@HinhAnhMinhChung,@TrangThai)
	select SCOPE_IDENTITY()
end
go
--exec insertGiayChungNhan 1,N'Banh canh','hinhanh1.jpg'
--exec insertGiayChungNhan_CoSo null,N'Co So A',N'48 Cao Thang',N'Nha Hang','KD123/456','3-20-2022',N'Com tam','hinhanh1.jpg'

--select * from CoSo
--select * from HoSoCapGiayChungNhan
go

--duyet ho so cap giay chung nhan
create procedure duyetGiayChungNhan
	@IDGiayChungNhan int
as
begin 
--0:chua duyet, 1:duyet, -1:huybo
	update HoSoCapGiayChungNhan
	set TrangThai= 1 
	where IDGiayChungNhan=@IDGiayChungNhan

	declare @IDCoSo int = ( select IDCoSo from HoSoCapGiayChungNhan where IDGiayChungNhan=@IDGiayChungNhan)
	declare @NgayXetDuyet date = getdate()
	declare @NgayHetHan date = dateadd(year,3,@NgayXetDuyet)
	update CoSo
	set NgayCapCNATTP=@NgayXetDuyet, NgayHetHanCNATTP=@NgayHetHan
	where IDCoSo = @IDCoSo
end
go
--64676508-1EB8-4748-BE53-8A5A623B4639
--DB179DE4-DBE4-4129-9165-2BAF71056DF2
select * from NguoiDung
--execute insertGiayChungNhan_CoSo 'DB179DE4-DBE4-4129-9165-2BAF71056DF2','tencoso5',1,'diachi','loaihinhkinhdoanh','makinhdoanh','2023-5-5','mathang','hinhanh'
select * from CoSo












