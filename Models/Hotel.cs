using viet_trip_backend.Interfaces;

namespace viet_trip_backend.Models
{
    public class Hotel:ISlug
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug {  get; set; }
        public string Description { get; set; }
        public string Address {  get; set; }
        public string Content {  get; set; }
        public string Thumbnail {  get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice {  get; set; }
        public string Ultilities {  get; set; }
        public int Star { get; set; }
        public string Rule {  get; set; }
        public int View {  get; set; }
        public List<string> Images { get; set; }
        public ICollection<RoomDetail> RoomDetails { get; set; }
        public Hotel()
        {
            RoomDetails = new List<RoomDetail>(); 
        }
    }
}
