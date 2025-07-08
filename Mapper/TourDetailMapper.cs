using viet_trip_backend.Dtos.Tour;
using viet_trip_backend.Interfaces.Mapper;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper
{
    public class TourDetailMapper : ITourDetailMapper
    {
        public TourDetailResponse MapToResponse(Tour entity)
        {
            return new TourDetailResponse
            {
                Id = entity.Id,
                Name = entity.Name,
                Slug = entity.Slug,
                Images = entity.Images,
                Description = entity.Description,
                Schedule = entity.Schedule,
                ScheduleDetail = entity.ScheduleDetail,
                Price = entity.Price.HasValue ? entity.Price.ToString() : "Liên hệ",
                Location = entity.TourDetail.Location,
                Food = entity.TourDetail.Food,
                SuitablePerson = entity.TourDetail.SuitablePerson,
                IdealTime = entity.TourDetail.IdealTime,
                Transportation = entity.TourDetail.Transportation,
                Promotion = entity.TourDetail.Promotion,
                PriceIncluded = entity.NoticeInformation.PriceIncluded,
                PriceNotIncluded = entity.NoticeInformation.PriceNotIncluded,
                ChildrenNotice = entity.NoticeInformation.ChildrenNotice
            };
        }
    }
}
