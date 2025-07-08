using viet_trip_backend.Dtos.Tour;
using viet_trip_backend.Interfaces.Mapper;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper
{
    public class TourMapper : ITourMapper
    {
        public TourListResponse MapToResponse(Tour entity)
        {
            return new TourListResponse
            {
                Id = entity.Id,
                Name = entity.Name,
                Slug = entity.Slug,
                Thumbnail = entity.Thumbnail,
                Description = entity.Description,
                StartingPlace = entity.StartingPlace,
                Price = entity.Price.HasValue ? entity.Price.ToString() : "Liên hệ",
            };
        }
    }
}
