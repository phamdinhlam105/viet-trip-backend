using viet_trip_backend.Helpers;

namespace viet_trip_backend.Dtos.Hotel.HotelRes.Admin
{
    public class AdminHotelListItemRes
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
        public int Star { get; set; }
        public int RoomCount { get; set; }
        public int View { get; set; }
        public AvailableStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
