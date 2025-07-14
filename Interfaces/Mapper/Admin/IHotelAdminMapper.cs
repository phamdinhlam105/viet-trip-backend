using viet_trip_backend.Dtos.Hotel.HotelReq;
using viet_trip_backend.Dtos.Hotel.HotelRes.Admin;
using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Mapper.Admin
{
    public interface IHotelAdminMapper:IMapToEntity<Hotel, HotelRequest>,
        IMapToResponse<Hotel, AdminHotelListItemRes>,
        IUpdateToUpdate<Hotel, HotelRequest>
    {
    }
}
