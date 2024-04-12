using System;
using System.Collections.Generic;

namespace eShop.Models;

public partial class TaiKhoan
{
    public int MaTaiKhoan { get; set; }

    public string TaiKhoan1 { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string? Email { get; set; }

    public string? TenNguoiDung { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime LanDangNhapCuoi { get; set; }

    public int MaLoaiTaiKhoan { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();

    public virtual LoaiTaiKhoan MaLoaiTaiKhoanNavigation { get; set; } = null!;
}
