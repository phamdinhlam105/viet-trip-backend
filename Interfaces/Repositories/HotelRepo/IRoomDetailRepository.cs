using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Repositories.HotelRepo
{
    public interface IRoomDetailRepository:IRepository<RoomDetail>
    {
        Task<List<RoomDetail>> GetByHotelId(Guid hotelId);
    }
}
