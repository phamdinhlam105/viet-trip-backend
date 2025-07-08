using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Repositories.TourRepo
{
    public interface ITourRepository:IRepository<Tour>,ISlugRepository<Tour>
    {
    }
}
