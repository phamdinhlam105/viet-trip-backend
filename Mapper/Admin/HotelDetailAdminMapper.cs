using viet_trip_backend.Dtos.Hotel.HotelRes.Admin;
using viet_trip_backend.Dtos.Hotel.HotelRes.Public;
using viet_trip_backend.Interfaces.Mapper.Admin;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper.Admin
{
    public class HotelDetailAdminMapper : IHotelDetailAdminMapper
    {
        public AdminHotelDetailRes MapToResponse(Hotel entity)
        {
            return new AdminHotelDetailRes
            {
                Id = entity.Id,
                Name = entity.Name,
                Slug = entity.Slug,
                Address = entity.Address,
                Description = entity.Description,
                Thumbnail = entity.Thumbnail,
                Price = entity.Price,
                Content = entity.Content,
                Status = entity.Status,
                PromotionPrice = entity.PromotionPrice,
                Images = entity.Images ?? new List<string>(),
                Star = entity.Star,
                Rule = entity.Rule,
                View = entity.View,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                RoomDetails = entity.RoomDetails.Select(rd => new RoomDetailResponse
                {
                    Id = rd.Id,
                    Name = rd.Name,
                    Included = rd.Included,
                    Price = rd.Price,
                    Capacity = rd.Capacity
                }).ToList()
            };
        }
    }
}
