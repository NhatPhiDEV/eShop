using System;
using System.Collections.Generic;

namespace eShop.Models;

public partial class LoaiSanPham
{
    public int MaLoaiSanPham { get; set; }

    public string? TenLoaiSanPham { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
