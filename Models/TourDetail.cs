namespace viet_trip_backend.Models
{
    public class TourDetail
    {
        public Guid Id {  get; set; }
        public Guid TourId { get; set; }
        public string Location { get; set; }
        public string Food { get; set; }
        public string SuitablePerson {  get; set; }
        public string IdealTime {  get; set; }
        public string Transportation {  get; set; }
        public string Promotion {  get; set; }
    }
}
