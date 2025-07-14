using viet_trip_backend.Dtos.Post.PostRes.Admin;
using viet_trip_backend.Interfaces.Mapper.Admin;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper.Admin
{
    public class PostDetailAdminMapper : IPostDetailAdminMapper
    {
        public AdminPostDetailRes MapToResponse(Post entity)
        {
            return new AdminPostDetailRes
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                Slug = entity.Slug,
                Content = entity.Content,
                Thumbnail = entity.Thumbnail,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                Author = entity.Author,
                Status = entity.Status,
                Tags = entity.Tags,
                View = entity.View
            };
        }
    }
}
