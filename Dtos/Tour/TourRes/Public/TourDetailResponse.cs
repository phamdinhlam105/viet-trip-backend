namespace viet_trip_backend.Dtos.Tour.TourRes.Public
{
    public class TourDetailResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public string Schedule { get; set; }
        public string ScheduleDetail { get; set; }
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
        public TourDetailResponse()
        {
            Images = new List<string>();
        }
    }
}
