using Microsoft.EntityFrameworkCore;
using viet_trip_backend.Data;
using viet_trip_backend.Interfaces;
using viet_trip_backend.Interfaces.Repositories;

namespace viet_trip_backend.Repositories
{
    public class BaseSlugRepository<T>:BaseRepository<T>, ISlugRepository<T> where T : class,ISlug
    {
        private readonly DbSet<T> _dbSet;
        public BaseSlugRepository(AppDbContext context) : base(context) { }

        public virtual async Task<T> GetBySlug(string slug)
        {
            return await _dbSet.FirstOrDefaultAsync(item => item.Slug == slug);
        }
    }
}
