﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAnToanVeSinhThucPhamDemo.Models;

#nullable disable

namespace WebAnToanVeSinhThucPhamDemo.Migrations
{
    [DbContext(typeof(QlattpContext))]
    [Migration("20240602045533_UpdatePost")]
    partial class UpdatePost
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CCCD")
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("HoTen")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("HomeAdress")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("ChiTietDoanThanhTra", b =>
                {
                    b.Property<int>("IdkeHoach")
                        .HasColumnType("int")
                        .HasColumnName("IDKeHoach");

                    b.Property<int>("IdCanBo")
                        .HasColumnType("int")
                        .HasColumnName("IDCanBo");

                    b.Property<string>("CanBoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChucVu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdkeHoach", "IdCanBo")
                        .HasName("PK__ChiTietD__4EE32992008214FC");

                    b.HasIndex("CanBoId");

                    b.ToTable("ChiTietDoanThanhTra", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("ThongBaoThayDoi", b =>
                {
                    b.Property<int>("IdthongBao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDThongBao");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdthongBao"));

                    b.Property<string>("ChuCoSoMoiId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChiMoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdchuCoSoMoi")
                        .HasColumnType("int")
                        .HasColumnName("IDChuCoSoMoi");

                    b.Property<int?>("IdcoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    b.Property<string>("TenCoSoMoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdthongBao")
                        .HasName("PK__ThongBao__3EBBFAAEC5198DAB");

                    b.HasIndex("ChuCoSoMoiId");

                    b.HasIndex("IdcoSo");

                    b.ToTable("ThongBaoThayDoi", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.BanCongBoSp", b =>
                {
                    b.Property<int>("IdbanCongBoSp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDBanCongBoSP");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdbanCongBoSp"));

                    b.Property<string>("CachDongGoiBaoBi")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CachDongGoi_BaoBi");

                    b.Property<string>("HinhAnhMinhChung")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("IdcoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    b.Property<string>("MauNhanSp")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("MauNhanSP");

                    b.Property<DateOnly?>("NgayCongBo")
                        .HasColumnType("date");

                    b.Property<string>("TenDiaChiSx")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ten_DiaChiSX");

                    b.Property<string>("TenSanPham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThanhPhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("ThoiHanSuDung")
                        .HasColumnType("date");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdbanCongBoSp")
                        .HasName("PK__BanCongB__57824418B2AEB7B3");

                    b.HasIndex("IdcoSo");

                    b.ToTable("BanCongBoSP", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.BaoCaoViPham", b =>
                {
                    b.Property<long>("IdbaoCao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("IDBaoCao");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdbaoCao"));

                    b.Property<string>("Cccd")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("CCCD");

                    b.Property<string>("HinhAnhMinhChung")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdcoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    b.Property<DateOnly?>("NgayBaoCao")
                        .HasColumnType("date");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("SDT");

                    b.HasKey("IdbaoCao")
                        .HasName("PK__BaoCaoVi__BC216EF0A853FDD6");

                    b.HasIndex("IdcoSo");

                    b.ToTable("BaoCaoViPham", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.Blog.DanhMuc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenDanhMuc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("DanhMuc");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.Blog.DanhMucBaiDang", b =>
                {
                    b.Property<int>("IDBaiDang")
                        .HasColumnType("int");

                    b.Property<int>("IDDanhMuc")
                        .HasColumnType("int");

                    b.HasKey("IDBaiDang", "IDDanhMuc");

                    b.HasIndex("IDDanhMuc");

                    b.ToTable("DanhMucBaiDang");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.Blog.TinTuc", b =>
                {
                    b.Property<int>("IDTinTuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDTinTuc"));

                    b.Property<string>("AnhBia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDCanBo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("Slug")
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<string>("TieuDe")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.HasKey("IDTinTuc");

                    b.HasIndex("IDCanBo");

                    b.HasIndex("Slug")
                        .IsUnique()
                        .HasFilter("[Slug] IS NOT NULL");

                    b.ToTable("TinTuc");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ChiTietKetQua", b =>
                {
                    b.Property<int>("IdkeHoachCoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDKeHoachCoSo");

                    b.Property<int>("IdmucKt")
                        .HasColumnType("int")
                        .HasColumnName("IDMucKT");

                    b.Property<bool?>("Dat")
                        .HasColumnType("bit");

                    b.HasKey("IdkeHoachCoSo", "IdmucKt")
                        .HasName("PK__ChiTietK__E62BAC593B114B18");

                    b.HasIndex("IdmucKt");

                    b.ToTable("ChiTietKetQua", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.CoSo", b =>
                {
                    b.Property<int>("IdcoSo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdcoSo"));

                    b.Property<string>("ChuCoSoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IDPhuongXa")
                        .HasColumnType("int");

                    b.Property<string>("LoaiHinhKinhDoanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("NgayCapCnattp")
                        .HasColumnType("date")
                        .HasColumnName("NgayCapCNATTP");

                    b.Property<DateOnly?>("NgayCapGiayPhepKd")
                        .HasColumnType("date")
                        .HasColumnName("NgayCapGiayPhepKD");

                    b.Property<DateOnly?>("NgayHetHanCnattp")
                        .HasColumnType("date")
                        .HasColumnName("NgayHetHanCNATTP");

                    b.Property<string>("SoGiayPhepKd")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("SoGiayPhepKD");

                    b.Property<string>("TenCoSo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdcoSo")
                        .HasName("PK__CoSo__344441C5716816E6");

                    b.HasIndex("ChuCoSoId");

                    b.HasIndex("IDPhuongXa");

                    b.ToTable("CoSo", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.Contact.LienHe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime?>("NgayGui")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("LienHe");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.HoSoCapGiayChungNhan", b =>
                {
                    b.Property<int>("IdgiayChungNhan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDGiayChungNhan");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdgiayChungNhan"));

                    b.Property<string>("HinhAnhMinhChung")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("IdcoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    b.Property<string>("LoaiThucPham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("NgayDangKy")
                        .HasColumnType("date");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdgiayChungNhan")
                        .HasName("PK__HoSoCapG__729C7BB617160CD8");

                    b.HasIndex("IdcoSo");

                    b.ToTable("HoSoCapGiayChungNhan", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.KeHoach", b =>
                {
                    b.Property<int>("IdkeHoach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDKeHoach");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdkeHoach"));

                    b.Property<int?>("DoanSo")
                        .HasColumnType("int");

                    b.Property<string>("Loai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ThoiGianBatDau")
                        .HasColumnType("datetime");

                    b.HasKey("IdkeHoach")
                        .HasName("PK__KeHoach__936F11C8A85196CC");

                    b.ToTable("KeHoach", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.KeHoachCoSo", b =>
                {
                    b.Property<int>("IdkeHoachCoSo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDKeHoachCoSo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdkeHoachCoSo"));

                    b.Property<int?>("IdcoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    b.Property<int?>("IdkeHoach")
                        .HasColumnType("int")
                        .HasColumnName("IDKeHoach");

                    b.Property<string>("KetLuan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KhacPhuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("NgayTao")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ThoiGianKiemTra")
                        .HasColumnType("datetime");

                    b.Property<string>("YkienChuCoSo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("YKienChuCoSo");

                    b.HasKey("IdkeHoachCoSo")
                        .HasName("PK__KeHoach___146E827EF1EC716F");

                    b.HasIndex("IdcoSo");

                    b.HasIndex("IdkeHoach");

                    b.ToTable("KeHoach_CoSo", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.MucKiemTra", b =>
                {
                    b.Property<int>("IdmucKt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDMucKT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdmucKt"));

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdmucKt")
                        .HasName("PK__MucKiemT__2452E27ECB438FBA");

                    b.ToTable("MucKiemTra", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.PhuongXa", b =>
                {
                    b.Property<int>("IDPhuongXa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDPhuongXa"));

                    b.Property<int>("IDQuanHuyen")
                        .HasColumnType("int");

                    b.Property<string>("TenPhuongXa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IDPhuongXa");

                    b.HasIndex("IDQuanHuyen");

                    b.ToTable("PhuongXa");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.QuanHuyen", b =>
                {
                    b.Property<int>("IDQuanHuyen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDQuanHuyen"));

                    b.Property<string>("TenQuanHuyen")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IDQuanHuyen");

                    b.ToTable("QuanHuyen");
                });

            modelBuilder.Entity("ChiTietDoanThanhTra", b =>
                {
                    b.HasOne("App.Models.AppUser", "CanBo")
                        .WithMany()
                        .HasForeignKey("CanBoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.KeHoach", "IdkeHoachNavigation")
                        .WithMany("ChiTietDoanThanhTras")
                        .HasForeignKey("IdkeHoach")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietDo__IDKeH__52593CB8");

                    b.Navigation("CanBo");

                    b.Navigation("IdkeHoachNavigation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("App.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("App.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("App.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ThongBaoThayDoi", b =>
                {
                    b.HasOne("App.Models.AppUser", "ChuCoSoMoi")
                        .WithMany()
                        .HasForeignKey("ChuCoSoMoiId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CoSo", "IdcoSoNavigation")
                        .WithMany("ThongBaoThayDois")
                        .HasForeignKey("IdcoSo")
                        .HasConstraintName("FK__ThongBaoT__IDCoS__46E78A0C");

                    b.Navigation("ChuCoSoMoi");

                    b.Navigation("IdcoSoNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.BanCongBoSp", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CoSo", "IdcoSoNavigation")
                        .WithMany("BanCongBoSps")
                        .HasForeignKey("IdcoSo")
                        .HasConstraintName("FK__BanCongBo__IDCoS__440B1D61");

                    b.Navigation("IdcoSoNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.BaoCaoViPham", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CoSo", "IdcoSoNavigation")
                        .WithMany("BaoCaoViPhams")
                        .HasForeignKey("IdcoSo")
                        .HasConstraintName("FK__BaoCaoViP__IDCoS__4AB81AF0");

                    b.Navigation("IdcoSoNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.Blog.DanhMuc", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.Blog.DanhMuc", "ParentCategory")
                        .WithMany("CategoryChildren")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.Blog.DanhMucBaiDang", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.Blog.TinTuc", "TinTuc")
                        .WithMany("DanhMucBaiDangs")
                        .HasForeignKey("IDBaiDang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.Blog.DanhMuc", "DanhMuc")
                        .WithMany()
                        .HasForeignKey("IDDanhMuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DanhMuc");

                    b.Navigation("TinTuc");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.Blog.TinTuc", b =>
                {
                    b.HasOne("App.Models.AppUser", "CanBo")
                        .WithMany()
                        .HasForeignKey("IDCanBo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CanBo");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ChiTietKetQua", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.KeHoachCoSo", "IdkeHoachCoSoNavigation")
                        .WithMany("ChiTietKetQuas")
                        .HasForeignKey("IdkeHoachCoSo")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietKe__IDKeH__5BE2A6F2");

                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.MucKiemTra", "IdmucKtNavigation")
                        .WithMany("ChiTietKetQuas")
                        .HasForeignKey("IdmucKt")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietKe__IDMuc__5CD6CB2B");

                    b.Navigation("IdkeHoachCoSoNavigation");

                    b.Navigation("IdmucKtNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.CoSo", b =>
                {
                    b.HasOne("App.Models.AppUser", "ChuCoSo")
                        .WithMany()
                        .HasForeignKey("ChuCoSoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.PhuongXa", "PhuongXa")
                        .WithMany()
                        .HasForeignKey("IDPhuongXa")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ChuCoSo");

                    b.Navigation("PhuongXa");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.HoSoCapGiayChungNhan", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CoSo", "IdcoSoNavigation")
                        .WithMany("HoSoCapGiayChungNhans")
                        .HasForeignKey("IdcoSo")
                        .HasConstraintName("FK__HoSoCapGi__IDCoS__412EB0B6");

                    b.Navigation("IdcoSoNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.KeHoachCoSo", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CoSo", "IdcoSoNavigation")
                        .WithMany("KeHoachCoSos")
                        .HasForeignKey("IdcoSo")
                        .HasConstraintName("FK__KeHoach_C__IDCoS__571DF1D5");

                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.KeHoach", "IdkeHoachNavigation")
                        .WithMany("KeHoachCoSos")
                        .HasForeignKey("IdkeHoach")
                        .HasConstraintName("FK__KeHoach_C__IDKeH__5629CD9C");

                    b.Navigation("IdcoSoNavigation");

                    b.Navigation("IdkeHoachNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.PhuongXa", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.QuanHuyen", "QuanHuyen")
                        .WithMany()
                        .HasForeignKey("IDQuanHuyen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuanHuyen");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.Blog.DanhMuc", b =>
                {
                    b.Navigation("CategoryChildren");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.Blog.TinTuc", b =>
                {
                    b.Navigation("DanhMucBaiDangs");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.CoSo", b =>
                {
                    b.Navigation("BanCongBoSps");

                    b.Navigation("BaoCaoViPhams");

                    b.Navigation("HoSoCapGiayChungNhans");

                    b.Navigation("KeHoachCoSos");

                    b.Navigation("ThongBaoThayDois");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.KeHoach", b =>
                {
                    b.Navigation("ChiTietDoanThanhTras");

                    b.Navigation("KeHoachCoSos");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.KeHoachCoSo", b =>
                {
                    b.Navigation("ChiTietKetQuas");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.MucKiemTra", b =>
                {
                    b.Navigation("ChiTietKetQuas");
                });
#pragma warning restore 612, 618
        }
    }
}
