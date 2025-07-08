namespace viet_trip_backend.Dtos.Tour
{
    public class TourListResponse
    {
        public Guid Id {  get; set; }
        public string Name {  get; set; }
        public string Slug {  get; set; }
        public string Thumbnail {  get; set; }
        public string Description { get; set; }
        public string Price {  get; set; }
        public string StartingPlace {  get; set; }
    }
}
