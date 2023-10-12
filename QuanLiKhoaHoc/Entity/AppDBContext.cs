using Microsoft.EntityFrameworkCore;

namespace QuanLiKhoaHoc.Entity;

public class AppDBContext : DbContext
{
    public virtual DbSet<HocVien> HocViens { get; set; }
    public virtual DbSet<NgayHoc> NgayHocs { get; set; }
    public virtual DbSet<KhoaHoc> KhoaHocs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer($"Data Source=ADMIN-PC;Initial Catalog=QuanLiKhoaHoc;Integrated Security=True; TrustServerCertificate=True");
    }
}