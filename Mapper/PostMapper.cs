using viet_trip_backend.Dtos.Post;
using viet_trip_backend.Interfaces.Mapper;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper
{
    public class PostMapper : IPostMapper
    {
        public PostListResponse MapToResponse(Post entity)
        {
            return new PostListResponse
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                Slug = entity.Slug,
                Thumbnail = entity.Thumbnail,
                UpdatedAt = entity.UpdatedAt,
            };
        }
    }
}
