using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15_EFCore.Entities
{
    public class MyDBContext : DbContext
    {
        //Định nghĩa các Table
        public DbSet<Loai> Loais { get; set; }

        public DbSet<HangHoa> HangHoas { get; set; }

        public DbSet<KhachHang> KhachHangs { get; set; }

        public DbSet<HoaDon> HoaDons { get; set; }

        public DbSet<ChiTietHD> ChiTietHDs { get; set; }

        public MyDBContext()
        { }
        public MyDBContext(DbContextOptions option) : base(option)
        { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>(entity => {
                entity.ToTable("Order");
                entity.HasKey(e => e.MaHoaDon);
                entity.Property(e => e.DiaChi).IsRequired().HasMaxLength(150);
            });

            modelBuilder.Entity<ChiTietHD>(entity => {
                entity.ToTable("OrderDetail");
                entity.HasKey(e => new { e.MaHoaDon, e.MaHangHoa });
                entity.HasOne(e => e.HoaDon).WithMany(hd => hd.chiTietHDs).HasForeignKey(e => e.MaHoaDon).HasConstraintName("FK_CTHD_HD");
            });
        }
    }
}
