using System;
using System.Collections.Generic;

namespace eShop.Models;

public partial class TrangThaiDonHang
{
    public int MaTrangThaiDonHang { get; set; }

    public string TenTrangThaiDonHang { get; set; } = null!;

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
}
