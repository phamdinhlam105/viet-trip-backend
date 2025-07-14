namespace viet_trip_backend.Dtos.Hotel.HotelReq
{
    public class RoomDetailRequest
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Capacity { get; set; }
        public string Included { get; set; }
        public decimal Price { get; set; }
    }
}
