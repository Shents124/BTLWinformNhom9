using System;
using System.Collections.Generic;

#nullable disable

namespace BTL.Models
{
    public partial class Cthoadon
    {
        public int MaHd { get; set; }
        public int MaSach { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }

        public virtual Hoadon MaHdNavigation { get; set; }
        public virtual Sach MaSachNavigation { get; set; }
    }
}
