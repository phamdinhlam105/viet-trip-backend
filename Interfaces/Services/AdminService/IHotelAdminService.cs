using System.Collections.Generic;
using viet_trip_backend.Dtos.Hotel.HotelReq;
using viet_trip_backend.Dtos.Hotel.HotelRes.Admin;
using viet_trip_backend.Dtos.Hotel.HotelRes.Public;

namespace viet_trip_backend.Interfaces.Services.AdminService
{
    public interface IHotelAdminService:IAdd<HotelRequest>,
        IGetById<AdminHotelDetailRes>,
        IGetAll<AdminHotelListItemRes>,
        IUpdate<HotelRequest, AdminHotelDetailRes>,
        IDeleteById
    {
        Task<IEnumerable<RoomDetailResponse>> GetRoomDetailByHotelId(Guid hotelId);
    }
}
