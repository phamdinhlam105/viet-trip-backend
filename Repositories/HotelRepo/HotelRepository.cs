using viet_trip_backend.Data;
using viet_trip_backend.Interfaces.Repositories.HotelRepo;
using viet_trip_backend.Models;

namespace viet_trip_backend.Repositories.HotelRepo
{
    public class HotelRepository:BaseSlugRepository<Hotel>,IHotelRepository
    {
        public HotelRepository(AppDbContext _context) : base(_context) { }
    }
}
