using viet_trip_backend.Dtos.Hotel;

namespace viet_trip_backend.Interfaces.Services.PublicService
{
    public interface IHotelDetailService:IGetById<HotelDetailResponse>,IGetBySlug<HotelDetailResponse>
    {
    }
}
