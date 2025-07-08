using viet_trip_backend.Dtos.Post;
using viet_trip_backend.Interfaces.Mapper;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper
{
    public class PostDetailMapper : IPostDetailMapper
    {
        public PostDetailResponse MapToResponse(Post entity)
        {
            return new PostDetailResponse
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                Slug = entity.Slug,
                Thumbnail = entity.Thumbnail,
                UpdatedAt = entity.UpdatedAt,
                Content = entity.Content,
                Attachments = entity.Attachments,
                Author = entity.Author,
                Tags = entity.Tags,
            };
        }
    }
}
