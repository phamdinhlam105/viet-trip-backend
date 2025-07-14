namespace viet_trip_backend.Dtos.Post.PostRes.Public
{
    public class PostListResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Slug { get; set; }
        public string Thumbnail {  get; set; }
    }
}
