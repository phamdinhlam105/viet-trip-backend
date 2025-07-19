using viet_trip_backend.Dtos.Hotel;
using viet_trip_backend.Dtos.Hotel.HotelRes.Public;
using viet_trip_backend.Interfaces.Mapper.Public;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper.Public
{
    public class HotelDetailMapper : IHotelDetailMapper
    {
        public HotelDetailResponse MapToResponse(Hotel entity)
        {
            return new HotelDetailResponse
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Address = entity.Address,
                Slug = entity.Slug,
                Star = entity.Star,
                Price = entity.Price,
                PromotionPrice = entity.PromotionPrice,
                Ultilities = entity.Ultilities,
                Images = entity.Images,
                Rule = entity.Rule,
                Content = entity.Content,
                RoomDetails = entity.RoomDetails.Select(rd => new RoomDetailResponse
                {
                    Id=rd.Id,
                    HotelId=rd.HotelId,
                    Capacity=rd.Capacity,
                    Name=rd.Name,
                    Included=rd.Included,
                }).ToList(),
            };
        }
    }
}
