using System;
using System.Collections.Generic;

#nullable disable

namespace BTL.Models
{
    public partial class Cthoadon:IEquatable<Cthoadon>
    {
        public int MaHd { get; set; }
        public int MaSach { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }

        public virtual Hoadon MaHdNavigation { get; set; }
        public virtual Sach MaSachNavigation { get; set; }

        public bool Equals(Cthoadon other)
        {
            if (this.MaHd == other.MaHd && this.MaSach == other.MaSach)
                return true;
            return false;
        }
    }
}
