using viet_trip_backend.Dtos.Tour.TourRes.Public;
using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Mapper.Public
{
    public interface ITourMapper:IMapToResponse<Tour,TourListResponse>
    {
    }
}
