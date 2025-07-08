namespace viet_trip_backend.Models
{
    public class Combo
    {
        public Guid Id { get; set; }
        public Guid TourId {  get; set; }
        public Guid HotelId { get; set; }
        public DateOnly ApplyDate {  get; set; }
        public decimal Price {  get; set; }
        public int View {  get; set; }
        public Hotel Hotel { get; set; }
        public Tour Tour { get; set; }
    }
}
