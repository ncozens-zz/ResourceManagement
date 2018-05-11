using Microsoft.EntityFrameworkCore;
using ResourceManagementData.Models;

namespace ResourceManagementData
{
    public class ResourceManagementContext : DbContext
    {
        public ResourceManagementContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<AssetHours> AssetHours { get;set;} 
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<CheckoutHistory> CheckoutHistories { get; set; }
        public DbSet<Hold> Holds { get; set; }

    }
}
