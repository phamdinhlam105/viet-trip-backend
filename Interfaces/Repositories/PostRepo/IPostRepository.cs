using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Repositories.PostRepo
{
    public interface IPostRepository:IRepository<Post>, ISlugRepository<Post>
    {
    }
}
