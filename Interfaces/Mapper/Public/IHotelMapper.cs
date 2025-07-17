using viet_trip_backend.Dtos.Hotel.HotelRes.Public;
using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Mapper.Public
{
    public interface IHotelMapper:IMapToResponse<Hotel,HotelListResponse>
    {
    }
}
