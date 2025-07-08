using viet_trip_backend.Data;
using viet_trip_backend.Interfaces.Repositories.TourRepo;
using viet_trip_backend.Models;

namespace viet_trip_backend.Repositories.TourRepo
{
    public class TourRepository:BaseSlugRepository<Tour>,ITourRepository
    {
        public TourRepository(AppDbContext _context):base(_context) { }
    }
}
