namespace viet_trip_backend.Dtos.Hotel
{
    public class HotelDetailResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Address {  get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Content { get; set; }
        public decimal? PromotionPrice { get; set; }
        public List<string> Images { get; set; }
        public int Star { get; set; }
        public string Rule { get; set; }
        public List<RoomDetailResponse> RoomDetails { get; set; }
        public HotelDetailResponse()
        {
            Images = new List<string>();
            RoomDetails = new List<RoomDetailResponse>();
        }
    }
}
