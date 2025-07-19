using viet_trip_backend.Helpers;

namespace viet_trip_backend.Dtos.Tour.TourRes.Admin
{
    public class AdminTourDetailRes
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string StartingPlace { get; set; }
        public List<Guid> Images { get; set; }
        public string Schedule { get; set; }
        public string ScheduleDetail { get; set; }
        public AvailableStatus Status { get; set; }
        public string Price { get; set; }
        public TourDetailRes TourDetail { get; set; }
        public int View { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public AdminTourDetailRes()
        {
            Images = new List<Guid>();
        }
    }
}
