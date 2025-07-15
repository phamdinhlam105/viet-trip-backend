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
        public List<string> Images { get; set; }
        public string Schedule { get; set; }
        public string ScheduleDetail { get; set; }
        public AvailableStatus Status { get; set; }
        public string Price { get; set; }
        public string Location { get; set; }
        public string Food { get; set; }
        public string SuitablePerson { get; set; }
        public string IdealTime { get; set; }
        public string Transportation { get; set; }
        public string Promotion { get; set; }
        public string PriceIncluded { get; set; }
        public string PriceNotIncluded { get; set; }
        public string ChildrenNotice { get; set; }
        public int View { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public AdminTourDetailRes()
        {
            Images = new List<string>();
        }
    }
}
