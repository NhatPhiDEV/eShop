using System;
using System.Collections.Generic;

namespace eShop.Models;

public partial class LoaiTaiKhoan
{
    public int MaLoaiTaiKhoan { get; set; }

    public string? TenLoaiTaiKhoan { get; set; }

    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
}
