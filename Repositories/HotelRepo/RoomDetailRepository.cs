using Microsoft.EntityFrameworkCore;
using viet_trip_backend.Data;
using viet_trip_backend.Interfaces.Repositories.HotelRepo;
using viet_trip_backend.Models;

namespace viet_trip_backend.Repositories.HotelRepo
{
    public class RoomDetailRepository:BaseRepository<RoomDetail>, IRoomDetailRepository
    {
        public RoomDetailRepository(AppDbContext _context) : base(_context) { }

        public async Task<List<RoomDetail>> GetByHotelId(Guid hotelId)
        {
            return await _context.RoomDetails
                .Where(rd => rd.HotelId == hotelId)
                .ToListAsync();
        }
    }
}
