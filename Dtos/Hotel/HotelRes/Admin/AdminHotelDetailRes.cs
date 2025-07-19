﻿using viet_trip_backend.Dtos.Hotel.HotelRes.Public;
using viet_trip_backend.Helpers;

namespace viet_trip_backend.Dtos.Hotel.HotelRes.Admin
{
    public class AdminHotelDetailRes
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public decimal Price { get; set; }
        public string Content { get; set; }
        public string Ultilities { get; set; }
        public AvailableStatus Status { get; set; }
        public decimal? PromotionPrice { get; set; }
        public List<Guid> Images { get; set; }
        public int Star { get; set; }
        public string Rule { get; set; }
        public int View { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<RoomDetailResponse> RoomDetails { get; set; }
        public AdminHotelDetailRes()
        {
            Images = new List<Guid>();
            RoomDetails = new List<RoomDetailResponse>();
        }
    }
}
