using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Repositories.HotelRepo
{
    public interface IHotelRepository:IRepository<Hotel>,ISlugRepository<Hotel>
    {
        Task<IEnumerable<Hotel>> GetAllAvailableHotel();
    }
}
