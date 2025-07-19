using Microsoft.EntityFrameworkCore;
using viet_trip_backend.Models;

namespace viet_trip_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions)
          : base(dbContextOptions) { }

        public DbSet<Image> Images { get; set; }
        public DbSet<TourDetail> TourDetails { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<NoticeInformation> NoticeInformations { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<RoomDetail> RoomDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tour>()
                .HasOne(t => t.TourDetail)
                .WithOne() // no reverse navigation
                .HasForeignKey<Tour>(t => t.TourDetailId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Hotel>()
                .HasMany(h=>h.RoomDetails)
                .WithOne(r=>r.Hotel)
                .HasForeignKey(r => r.HotelId);
            modelBuilder.Entity<Hotel>()
                .HasIndex(h => h.Slug).IsUnique();
            modelBuilder.Entity<Tour>()
                .HasIndex(t => t.Slug).IsUnique();
            modelBuilder.Entity<Post>()
                .HasIndex(p=>p.Slug).IsUnique();
        }
    }
}
