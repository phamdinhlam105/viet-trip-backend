namespace viet_trip_backend.Dtos.Hotel.HotelRes.Public
{
    public class HotelListResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Address {  get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int Star { get; set; }
        public string Thumbnail { get; set; }
    }
}
