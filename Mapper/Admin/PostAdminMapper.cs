using viet_trip_backend.Dtos.Post.PostReq;
using viet_trip_backend.Dtos.Post.PostRes.Admin;
using viet_trip_backend.Interfaces.Mapper;
using viet_trip_backend.Interfaces.Mapper.Admin;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper.Admin
{
    public class PostAdminMapper : IPostAdminMapper
    {
        public Post MapToEntity(PostRequest request)
        {
            return new Post
            {
                Title = request.Title,
                Slug = request.Slug,
                Description = request.Description,
                Content = request.Content,
                Thumbnail = request.Thumbnail,
                Status = request.Status,
                Author = request.Author
            };
        }

        public AdminPostListItemRes MapToResponse(Post entity)
        {
            return new AdminPostListItemRes
            {
                Id = entity.Id,
                Title = entity.Title,
                UpdatedAt = entity.UpdatedAt,
                Status = entity.Status,
                Author = entity.Author,
                View = entity.View,
            };
        }

        public void UpdateToEntity(Post entity, PostRequest request)
        {
            entity.Title = request.Title;
            entity.Slug = request.Slug;
            entity.Description = request.Description;
            entity.Content = request.Content;
            entity.Thumbnail = request.Thumbnail;
            entity.Status = request.Status;
            entity.Author = request.Author;

        }
    }
}
