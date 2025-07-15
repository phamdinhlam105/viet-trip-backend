using viet_trip_backend.Dtos.Hotel.HotelReq;
using viet_trip_backend.Dtos.Hotel.HotelRes.Admin;
using viet_trip_backend.Interfaces.Mapper.Admin;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper.Admin
{
    public class HotelAdminMapper : IHotelAdminMapper
    {
        public Hotel MapToEntity(HotelRequest request)
        {
            return new Hotel
            {
                Name = request.Name,
                Address = request.Address,
                Price = request.Price,
                Star = request.Star,
                Description = request.Description,
                Slug = request.Slug,
                Thumbnail = request.Thumbnail,
                Content = request.Content,
                Status = request.Status,
                PromotionPrice = request.PromotionPrice,
                Rule = request.Rule,
                RoomDetails = request.RoomDetails.Select(rd => new RoomDetail
                {
                    Name = rd.Name,
                    Included = rd.Included,
                    Price = rd.Price,
                    Capacity = rd.Capacity,
                }).ToList(),
            };
        }

        public AdminHotelListItemRes MapToResponse(Hotel entity)
        {
           return new AdminHotelListItemRes
            {
                Id = entity.Id,
                Name = entity.Name,
                Address = entity.Address,
                Price = entity.Price,
                Star = entity.Star,
                RoomCount = entity.RoomDetails.Count,
                View = entity.View,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }

        public void UpdateToEntity(Hotel entity, HotelRequest request)
        {
            entity.Name = request.Name;
            entity.Address = request.Address;
            entity.Price = request.Price;
            entity.Star = request.Star;
            entity.Description = request.Description;
            entity.Slug = request.Slug;
            entity.Thumbnail = request.Thumbnail;
            entity.Content = request.Content;
            entity.PromotionPrice = request.PromotionPrice;
            entity.Rule = request.Rule;
            entity.UpdatedAt = DateTime.UtcNow;
            if(request.ShouldUpdateRoom== true)
            {
                entity.RoomDetails.Clear();
                foreach (var room in request.RoomDetails)
                {
                    entity.RoomDetails.Add(new RoomDetail
                    {
                        HotelId = entity.Id,
                        Name = room.Name,
                        Included = room.Included,
                        Price = room.Price,
                        Capacity = room.Capacity,
                    });
                }
            }
        }
    }
}
