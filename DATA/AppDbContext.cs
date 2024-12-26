using Microsoft.EntityFrameworkCore;
using CRMSardis.Models; // Modelleri kullanmak için gerekli

namespace CRMSardis.Data
{
    public class AppDbContext : DbContext
    {
        // Kullanıcı tablosunu temsil eden DbSet
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Tablo ve sütun özelliklerini yapılandırma (isteğe bağlı)
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Password).IsRequired();
            });
        }
    }
}
