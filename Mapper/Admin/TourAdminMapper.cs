using viet_trip_backend.Dtos.Tour.TourReq;
using viet_trip_backend.Dtos.Tour.TourRes.Admin;
using viet_trip_backend.Interfaces.Mapper.Admin;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper.Admin
{
    public class TourAdminMapper : ITourAdminMapper
    {
        public Tour MapToEntity(NewTourRequest request)
        {
            return new Tour
            {
                Name = request.Name,
                Slug = request.Slug,
                Thumbnail = request.Thumbnail,
                Description = request.Description,
                StartingPlace = request.StartingPlace,
                Price = request.Price,
                Status = request.Status,
                Images = request.Images ?? new List<string>(),
                Schedule = request.Schedule,
                ScheduleDetail = request.ScheduleDetail,
                TourDetail = new TourDetail
                {
                    Location = request.Location,
                    Transportation = request.Transportation,
                    SuitablePerson = request.SuitablePerson,
                    Food = request.Food,
                    IdealTime = request.IdealTime,
                    Promotion = request.Promotion,
                },

            };
        }

        public AdminTourListItemRes MapToResponse(Tour entity)
        {
            return new AdminTourListItemRes
            {
                Id = entity.Id,
                Name = entity.Name,
                Slug = entity.Slug,
                Description = entity.Description,
                Price = entity.Price.HasValue ? entity.Price.ToString() : "Liên hệ",
                View = entity.View,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }

        public void UpdateToEntity(Tour entity, NewTourRequest request)
        {
            entity.Name = request.Name;
            entity.Slug = request.Slug;
            entity.Thumbnail = request.Thumbnail;
            entity.Description = request.Description;
            entity.StartingPlace = request.StartingPlace;
            entity.Price = request.Price;
            entity.Images = request.Images ?? new List<string>();
            entity.Schedule = request.Schedule;
            entity.ScheduleDetail = request.ScheduleDetail;
            entity.TourDetail.Location = request.Location;
            entity.TourDetail.Transportation = request.Transportation;
            entity.TourDetail.SuitablePerson = request.SuitablePerson;
            entity.TourDetail.Food = request.Food;
            entity.TourDetail.IdealTime = request.IdealTime;
            entity.TourDetail.Promotion = request.Promotion;

        }
    }
}
