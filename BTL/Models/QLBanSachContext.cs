using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BTL.Models
{
    public partial class QLBanSachContext : DbContext
    {
        public QLBanSachContext()
        {
        }

        public QLBanSachContext(DbContextOptions<QLBanSachContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ctdondh> Ctdondhs { get; set; }
        public virtual DbSet<Cthoadon> Cthoadons { get; set; }
        public virtual DbSet<Ctpnhap> Ctpnhaps { get; set; }
        public virtual DbSet<Dondh> Dondhs { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Loaisach> Loaisaches { get; set; }
        public virtual DbSet<Nhacc> Nhaccs { get; set; }
        public virtual DbSet<Pnhap> Pnhaps { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAMDH\\SQLEXPRESS01;Initial Catalog=QLBanSach;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Ctdondh>(entity =>
            {
                entity.HasKey(e => new { e.MaDonDh, e.MaSach })
                    .HasName("PK__CTDONDH__1687C589E697CBF2");

                entity.ToTable("CTDONDH");

                entity.Property(e => e.MaDonDh).HasColumnName("MaDonDH");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.MaDonDhNavigation)
                    .WithMany(p => p.Ctdondhs)
                    .HasForeignKey(d => d.MaDonDh)
                    .HasConstraintName("FK_CTDONDH_DONDH");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.Ctdondhs)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTDONDH_SACH");
            });

            modelBuilder.Entity<Cthoadon>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaSach })
                    .HasName("PK__CTHOADON__EC06F1A22DE83C20");

                entity.ToTable("CTHOADON");

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.Cthoadons)
                    .HasForeignKey(d => d.MaHd)
                    .HasConstraintName("FK_CTHOADON_HOADON");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.Cthoadons)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHOADON_SACH");
            });

            modelBuilder.Entity<Ctpnhap>(entity =>
            {
                entity.HasKey(e => new { e.MaPn, e.MaSach })
                    .HasName("PK__CTPNHAP__EC06B0B208889E67");

                entity.ToTable("CTPNHAP");

                entity.Property(e => e.MaPn).HasColumnName("MaPN");

                entity.Property(e => e.DgNhap).HasColumnType("money");

                entity.HasOne(d => d.MaPnNavigation)
                    .WithMany(p => p.Ctpnhaps)
                    .HasForeignKey(d => d.MaPn)
                    .HasConstraintName("FK_CTPNHAP_PNHAP");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.Ctpnhaps)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTPNHAP_SACH");
            });

            modelBuilder.Entity<Dondh>(entity =>
            {
                entity.HasKey(e => e.MaDonDh)
                    .HasName("PK__DONDH__DDA492CBC6CC6F7F");

                entity.ToTable("DONDH");

                entity.Property(e => e.MaDonDh).HasColumnName("MaDonDH");

                entity.Property(e => e.NgayDh).HasColumnType("datetime");

                entity.Property(e => e.TrangThai).HasMaxLength(200);

                entity.HasOne(d => d.MaNhaCcNavigation)
                    .WithMany(p => p.Dondhs)
                    .HasForeignKey(d => d.MaNhaCc)
                    .HasConstraintName("FK_NHACC_DONDH");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HOADON__2725A6E0697B6EEA");

                entity.ToTable("HOADON");

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaTk).HasColumnName("MaTK");

                entity.Property(e => e.NgayLap)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_HOADON_KHACHHANG");

                entity.HasOne(d => d.MaTkNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.MaTk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_HOADON_TAIKHOAN");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KHACHHAN__2725CF1E029AFDE7");

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.SoDt)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SoDT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<Loaisach>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LOAISACH__730A57591FDEA082");

                entity.ToTable("LOAISACH");

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Nhacc>(entity =>
            {
                entity.HasKey(e => e.MaNhaCc)
                    .HasName("PK__NHACC__C87CD311517DF8B5");

                entity.ToTable("NHACC");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DienThoai)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenNhaCc)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Pnhap>(entity =>
            {
                entity.HasKey(e => e.MaPn)
                    .HasName("PK__PNHAP__2725E7F0CFCF4F02");

                entity.ToTable("PNHAP");

                entity.Property(e => e.MaPn).HasColumnName("MaPN");

                entity.Property(e => e.MaDonDh).HasColumnName("MaDonDH");

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.HasOne(d => d.MaDonDhNavigation)
                    .WithMany(p => p.Pnhaps)
                    .HasForeignKey(d => d.MaDonDh)
                    .HasConstraintName("FK_PNHAP_DONDH");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.MaSach)
                    .HasName("PK__SACH__B235742D8BCC949A");

                entity.ToTable("SACH");

                entity.Property(e => e.DonGiaBan).HasColumnType("money");

                entity.Property(e => e.DonGiaNhap).HasColumnType("money");

                entity.Property(e => e.NhaXuatBan)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TacGia)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TenSach)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MaLoai");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.HasKey(e => e.MaTk)
                    .HasName("PK__TAIKHOAN__2725007092817A0F");

                entity.ToTable("TAIKHOAN");

                entity.Property(e => e.MaTk).HasColumnName("MaTK");

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LoaiTk).HasColumnName("LoaiTK");

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenDangNhap)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
