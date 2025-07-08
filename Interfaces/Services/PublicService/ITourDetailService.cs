using viet_trip_backend.Dtos.Tour;
using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Services.PublicService
{
    public interface ITourDetailService:IGetById<TourDetailResponse>,IGetBySlug<TourDetailResponse>
    {
    }
}
