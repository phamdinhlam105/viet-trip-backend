using viet_trip_backend.Models;

namespace viet_trip_backend.Dtos.Tour.TourReq
{
    public class NewTourRequest
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public string StartingPlace { get; set; }
        public List<string> Images { get; set; }
        public string Schedule { get; set; }
        public string ScheduleDetail { get; set; }
        public decimal? Price { get; set; }
        //Tour Detail
        public string Location { get; set; }
        public string Food { get; set; }
        public string SuitablePerson { get; set; }
        public string IdealTime { get; set; }
        public string Transportation { get; set; }
        public string Promotion { get; set; }
        public NewTourRequest()
        {
            Images = new List<string>();
        }
    }
}
