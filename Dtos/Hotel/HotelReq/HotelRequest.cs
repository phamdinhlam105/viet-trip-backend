namespace viet_trip_backend.Dtos.Hotel.HotelReq
{
    public class HotelRequest
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Address { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Content { get; set; }
        public decimal? PromotionPrice { get; set; }
        public List<string> Images { get; set; }
        public int Star { get; set; }
        public string Rule { get; set; }
        public bool? ShouldUpdateRoom { get; set; } = false;
        public List<RoomDetailRequest> RoomDetails { get; set; }
        public HotelRequest()
        {
            Images = new List<string>();
            RoomDetails = new List<RoomDetailRequest>();
        }
    }
}
