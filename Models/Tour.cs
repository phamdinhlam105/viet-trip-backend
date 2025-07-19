using viet_trip_backend.Helpers;
using viet_trip_backend.Interfaces;

namespace viet_trip_backend.Models
{
    public class Tour:ISlug
    {
        public Guid Id {  get; set; }
        public Guid TourDetailId {  get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Thumbnail {  get; set; }
        public string Description { get; set; }
        public string StartingPlace {  get; set; }
        public List<Guid> Images { get; set; }
        public string Schedule {  get; set; }
        public string ScheduleDetail {  get; set; }
        public decimal? Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public AvailableStatus Status { get; set; }
        public int View { get; set; }
        public TourDetail TourDetail { get; set; }
        public Tour()
        {
            Images = new List<Guid>();
        }
    }
}
