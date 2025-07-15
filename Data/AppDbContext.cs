using Microsoft.EntityFrameworkCore;
using viet_trip_backend.Models;

namespace viet_trip_backend.Data
{
    public class AppDbContext: DbContext
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
    }
}
