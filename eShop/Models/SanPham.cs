using System;
using System.Collections.Generic;

namespace eShop.Models;

public partial class SanPham
{
    public int MaSanPham { get; set; }

    public string? TenSanPham { get; set; }

    public string? MoTa { get; set; }

    public string? HinhAnh { get; set; }

    public decimal GiamGia { get; set; }

    public int SoLuong { get; set; }

    public bool BestSeller { get; set; }

    public bool HomeFlag { get; set; }

    public bool HienThi { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int MaLoaiSanPham { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual LoaiSanPham MaLoaiSanPhamNavigation { get; set; } = null!;
}
