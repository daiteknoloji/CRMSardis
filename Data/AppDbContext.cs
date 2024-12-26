using Microsoft.EntityFrameworkCore;
using CRMSardis.Models;

namespace CRMSardis.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Kullanıcı modelini ekleyin
        public DbSet<User> Users { get; set; }
    }
}
