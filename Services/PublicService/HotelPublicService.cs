using viet_trip_backend.Dtos.Hotel.HotelRes.Public;
using viet_trip_backend.Interfaces.Mapper.Public;
using viet_trip_backend.Interfaces.Services.PublicService;
using viet_trip_backend.UnitOfWork;

namespace viet_trip_backend.Services.PublicService
{
    public class HotelPublicService : IHotelService,IHotelDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHotelMapper _hotelMapper;
        private readonly IHotelDetailMapper _hotelDetailMapper;
        public HotelPublicService(IUnitOfWork unitOfWork, IHotelMapper hotelMapper, IHotelDetailMapper hotelDetailMapper)
        {
            _unitOfWork = unitOfWork;
            _hotelMapper = hotelMapper;
            _hotelDetailMapper = hotelDetailMapper;
        }

        public async Task<IEnumerable<HotelListResponse>> GetAll()
        {
            return (await _unitOfWork.Hotel.GetAll()).Select(h=>_hotelMapper.MapToResponse(h));
        }

        public async Task<HotelDetailResponse> GetById(Guid id)
        {
            return _hotelDetailMapper.MapToResponse(await _unitOfWork.Hotel.GetById(id));
        }

        public async Task<HotelDetailResponse> GetBySlug(string slug)
        {
            return _hotelDetailMapper.MapToResponse(await _unitOfWork.Hotel.GetBySlug(slug));
        }
    }
}
