using System;
using System.Collections.Generic;

namespace eShop.Models;

public partial class ThanhToan
{
    public int MaThanhToan { get; set; }

    public DateTime NgayTao { get; set; }

    public string? PhuongThucThanhToan { get; set; }

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
}
