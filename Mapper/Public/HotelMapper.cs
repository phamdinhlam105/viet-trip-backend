using viet_trip_backend.Dtos.Hotel.HotelRes.Public;
using viet_trip_backend.Interfaces.Mapper.Public;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper.Public
{
    public class HotelMapper : IHotelMapper
    {
        public HotelListResponse MapToResponse(Hotel entity)
        {
            return new HotelListResponse
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Address = entity.Address,
                Slug = entity.Slug,
                Star = entity.Star,
                Price = entity.Price,
                PromotionPrice = entity.PromotionPrice,
                Thumbnail = entity.Thumbnail,
            };
        }
    }
}
