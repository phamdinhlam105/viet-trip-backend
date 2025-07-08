namespace viet_trip_backend.Models
{
    public class RoomDetail
    {
        public Guid Id {  get; set; }
        public Guid HotelId {  get; set; }
        public string Name { get; set; }
        public string Capacity {  get; set; }
        public string Included {  get; set; }
        public decimal Price {  get; set; }
        public Hotel Hotel { get; set; }
    }
}
