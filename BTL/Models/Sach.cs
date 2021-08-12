﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BTL.Models
{
    public partial class Sach:IEquatable<Sach>
    {
        public Sach()
        {
            Ctdondhs = new HashSet<Ctdondh>();
            Cthoadons = new HashSet<Cthoadon>();
            Ctpnhaps = new HashSet<Ctpnhap>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int MaLoai { get; set; }
        public string TacGia { get; set; }
        public string NhaXuatBan { get; set; }
        public decimal DonGia { get; set; }

        public virtual Loaisach MaLoaiNavigation { get; set; }
        public virtual ICollection<Ctdondh> Ctdondhs { get; set; }
        public virtual ICollection<Cthoadon> Cthoadons { get; set; }
        public virtual ICollection<Ctpnhap> Ctpnhaps { get; set; }

        public bool Equals(Sach other)
        {
            return this.MaSach.Equals(other.MaSach);
        }
    }
}
