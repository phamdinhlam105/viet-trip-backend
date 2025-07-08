using viet_trip_backend.Data;
using viet_trip_backend.Interfaces.Repositories.BookingRepo;
using viet_trip_backend.Models;

namespace viet_trip_backend.Repositories.BookingRepo
{
    public class BookingRepository:BaseRepository<Booking>,IBookingRepository
    {
        public BookingRepository(AppDbContext _context):base(_context) { }
    }
}
