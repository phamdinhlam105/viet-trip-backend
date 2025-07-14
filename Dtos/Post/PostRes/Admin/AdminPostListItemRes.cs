namespace viet_trip_backend.Dtos.Post.PostRes.Admin
{
    public class AdminPostListItemRes
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Status { get; set; }
        public string? Author { get; set; }
        public int View { get; set; }
    }
}
