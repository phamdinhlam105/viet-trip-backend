using Microsoft.EntityFrameworkCore;
using viet_trip_backend.Data;
using viet_trip_backend.Helpers;
using viet_trip_backend.Interfaces.Repositories;
using viet_trip_backend.Interfaces.Repositories.PostRepo;
using viet_trip_backend.Models;

namespace viet_trip_backend.Repositories.PostRepo
{
    public class PostRepository:BaseSlugRepository<Post>, IPostRepository
    {
        public PostRepository(AppDbContext _context) : base(_context) { }
        public async Task<IEnumerable<Post>> GetAllPublishedPost()
        {
            return await _context.Posts
                .Where(p => p.Status==PostStatus.Published)
                .ToListAsync();
        }
}
