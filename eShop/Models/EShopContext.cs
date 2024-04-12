using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eShop.Models;

public partial class EShopContext : DbContext
{
    public EShopContext()
    {
    }

    public EShopContext(DbContextOptions<EShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<ThanhToan> ThanhToans { get; set; }

    public virtual DbSet<TrangThaiDonHang> TrangThaiDonHangs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=eShop;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
            entity.HasKey(e => e.MaChiTietDonHang).HasName("PK__ChiTietD__4B0B45DD9D93F86F");

            entity.ToTable("ChiTietDonHang");

            entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.MaDonHangNavigation).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.MaDonHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietDonHang_DonHang");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.MaSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietDonHang_SanPham");
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.MaDonHang).HasName("PK__DonHang__129584ADC92B6621");

            entity.ToTable("DonHang");

            entity.Property(e => e.NgayDatHang).HasColumnType("datetime");
            entity.Property(e => e.NgayGiaoHang).HasColumnType("datetime");

            entity.HasOne(d => d.MaTaiKhoanNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaTaiKhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaiKhoan_DonHang");

            entity.HasOne(d => d.MaThanhToanNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaThanhToan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ThanhToan_DonHang");

            entity.HasOne(d => d.MaTrangThaiDonHangNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaTrangThaiDonHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrangThai_DonHang");
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.MaLoaiSanPham).HasName("PK__LoaiSanP__ECCF699F7E5AFB2E");

            entity.ToTable("LoaiSanPham");
        });

        modelBuilder.Entity<LoaiTaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaLoaiTaiKhoan).HasName("PK__LoaiTaiK__5F6E141C49CCE902");

            entity.ToTable("LoaiTaiKhoan");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPham__FAC7442D315F08A7");

            entity.ToTable("SanPham");

            entity.Property(e => e.GiamGia).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");

            entity.HasOne(d => d.MaLoaiSanPhamNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoaiSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoaiSanPham_SanPham");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTaiKhoan).HasName("PK__TaiKhoan__AD7C652997A17F8A");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LanDangNhapCuoi).HasColumnType("datetime");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.TaiKhoan1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TaiKhoan");
            entity.Property(e => e.TenNguoiDung).HasMaxLength(50);

            entity.HasOne(d => d.MaLoaiTaiKhoanNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.MaLoaiTaiKhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoaiTaiKhoan_TaiKhoan");
        });

        modelBuilder.Entity<ThanhToan>(entity =>
        {
            entity.HasKey(e => e.MaThanhToan).HasName("PK__ThanhToa__D4B2584415EC59F5");

            entity.ToTable("ThanhToan");

            entity.Property(e => e.NgayTao).HasColumnType("datetime");
        });

        modelBuilder.Entity<TrangThaiDonHang>(entity =>
        {
            entity.HasKey(e => e.MaTrangThaiDonHang).HasName("PK__TrangTha__B57A45F5ECC66D7E");

            entity.ToTable("TrangThaiDonHang");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
