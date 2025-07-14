﻿namespace viet_trip_backend.Dtos.Post.PostRes.Public
{
    public class PostDetailResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Author { get; set; }
        public List<string> Attachments { get; set; }
        public List<string>? Tags { get; set; }
    }
}
