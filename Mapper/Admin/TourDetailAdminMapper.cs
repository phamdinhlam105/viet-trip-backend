using viet_trip_backend.Dtos.Tour.TourRes;
using viet_trip_backend.Dtos.Tour.TourRes.Admin;
using viet_trip_backend.Interfaces.Mapper.Admin;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper.Admin
{
    public class TourDetailAdminMapper : ITourDetailAdminMapper
    {
        public AdminTourDetailRes MapToResponse(Tour entity)
        {
            return new AdminTourDetailRes
            {
                Name = entity.Name,
                Slug = entity.Slug,
                Thumbnail = entity.Thumbnail,
                Description = entity.Description,
                StartingPlace = entity.StartingPlace,
                Price = entity.Price.HasValue ? entity.Price.ToString() : "Liên hệ",
                Images = entity.Images ?? new List<Guid>(),
                Schedule = entity.Schedule,
                ScheduleDetail = entity.ScheduleDetail,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                Status = entity.Status,
                TourDetail=new TourDetailRes {
                    Id = entity.TourDetail.Id,
                    Food = entity.TourDetail.Food,
                    Location=entity.TourDetail.Location,
                    SuitablePerson = entity.TourDetail.SuitablePerson,
                    IdealTime = entity.TourDetail.IdealTime,
                    Promotion = entity.TourDetail.Promotion,
                    Transportation=entity.TourDetail.Transportation,
                }
            };
        }
    }
}
