using Microsoft.EntityFrameworkCore;
using viet_trip_backend.Data;
using viet_trip_backend.Helpers;
using viet_trip_backend.Interfaces.Repositories.HotelRepo;
using viet_trip_backend.Models;

namespace viet_trip_backend.Repositories.HotelRepo
{
    public class HotelRepository:BaseSlugRepository<Hotel>,IHotelRepository
    {
        public HotelRepository(AppDbContext _context) : base(_context) { }
        public override async Task<Hotel> GetById(Guid id)
        {
            return await _context.Hotels
                .Include(h => h.RoomDetails)
                .FirstOrDefaultAsync(h => h.Id == id);
        }
        public async Task<IEnumerable<Hotel>> GetAllAvailableHotel()
        {
            return await _context.Hotels
                .Where(h => h.Status == AvailableStatus.Available)
                .ToListAsync();
        }
    }
}
