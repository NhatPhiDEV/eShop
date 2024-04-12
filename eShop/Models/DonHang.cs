using System;
using System.Collections.Generic;

namespace eShop.Models;

public partial class DonHang
{
    public int MaDonHang { get; set; }

    public int MaTaiKhoan { get; set; }

    public DateTime NgayDatHang { get; set; }

    public DateTime NgayGiaoHang { get; set; }

    public int MaTrangThaiDonHang { get; set; }

    public string DiaChiGiaoHang { get; set; } = null!;

    public int MaThanhToan { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual TaiKhoan MaTaiKhoanNavigation { get; set; } = null!;

    public virtual ThanhToan MaThanhToanNavigation { get; set; } = null!;

    public virtual TrangThaiDonHang MaTrangThaiDonHangNavigation { get; set; } = null!;
}
