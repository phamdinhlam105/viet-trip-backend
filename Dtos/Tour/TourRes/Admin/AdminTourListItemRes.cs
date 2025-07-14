namespace viet_trip_backend.Dtos.Tour.TourRes.Admin
{
    public class AdminTourListItemRes
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int View { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public AdminTourListItemRes()
        {
           
        }
    }
}
