using Microsoft.EntityFrameworkCore;
using My_Mane.Model;

namespace My_Mane
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<CommercialRentLease> CommercialRentLeases { get; set; }
        public DbSet<HouseRent> HouseRents { get; set; }
        public DbSet<Owners> Owners { get; set; }
        public DbSet<PG> PGs { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owners>()
                .Property(o => o.created_at)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Owners>()
                .Property(o => o.updated_at)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Property>()
                .Property(p => p.created_at)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Property>()
                .Property(p => p.updated_at)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Property>()
                .Property(p => p.admin_approval)
                .HasDefaultValue(false);

            modelBuilder.Entity<Property>()
                .HasOne(p => p.Owner)
                .WithMany()
                .HasForeignKey(p => p.owner_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CommercialRentLease>()
                .HasOne(p => p.Property)
                .WithMany()
                .HasForeignKey(p => p.property_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HouseRent>()
                .HasOne(p => p.Property)
                .WithMany()
                .HasForeignKey(p => p.property_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PG>()
                .HasOne(p => p.Property)
                .WithMany()
                .HasForeignKey(p => p.property_id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
