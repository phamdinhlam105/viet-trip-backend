using viet_trip_backend.Data;
using viet_trip_backend.Interfaces.Repositories.ComboRepo;
using viet_trip_backend.Models;

namespace viet_trip_backend.Repositories.ComboRepo
{
    public class ComboRepository : BaseSlugRepository<Combo>, IComboRepository
    {
        public ComboRepository(AppDbContext dbContext) : base(dbContext) { }
    }
}
