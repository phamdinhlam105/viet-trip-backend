using viet_trip_backend.Dtos.Tour.TourReq;
using viet_trip_backend.Dtos.Tour.TourRes.Admin;
using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Services.AdminService
{
    public interface ITourAdminService:IAdd<NewTourRequest>, 
        IUpdate<NewTourRequest, AdminTourDetailRes>, 
        IDeleteById, 
        IGetById<AdminTourDetailRes>, 
        IGetAll<AdminTourListItemRes>
    {
    }
}
