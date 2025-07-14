using viet_trip_backend.Dtos.Tour.TourReq;
using viet_trip_backend.Dtos.Tour.TourRes.Admin;
using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Mapper.Admin
{
    public interface ITourAdminMapper:IMapToResponse<Tour,AdminTourListItemRes>, IMapToEntity<Tour, NewTourRequest>, IUpdateToUpdate<Tour, NewTourRequest>
    {
    }
}
