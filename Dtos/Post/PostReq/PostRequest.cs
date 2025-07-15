using viet_trip_backend.Helpers;

namespace viet_trip_backend.Dtos.Post.PostReq
{
    public class PostRequest
    {
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public PostStatus Status { get; set; }
        public string? Author { get; set; }
    }
}
