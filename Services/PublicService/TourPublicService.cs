using viet_trip_backend.Dtos.Tour.TourRes.Public;
using viet_trip_backend.Interfaces.Mapper.Public;
using viet_trip_backend.Interfaces.Services.PublicService;
using viet_trip_backend.UnitOfWork;

namespace viet_trip_backend.Services.PublicService
{
    public class TourPublicService : ITourService,ITourDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITourMapper _tourMapper;
        private readonly ITourDetailMapper _tourDetailMapper;
        public TourPublicService(IUnitOfWork unitOfWork, ITourMapper tourMapper, ITourDetailMapper tourDetailMapper)
        {
            _unitOfWork = unitOfWork;
            _tourMapper = tourMapper;
            _tourDetailMapper = tourDetailMapper;
        }

        public async Task<IEnumerable<TourListResponse>> GetAll()
        {
            return (await _unitOfWork.Tour.GetAll()).Select(t => _tourMapper.MapToResponse(t));
        }

        public async Task<TourDetailResponse> GetById(Guid id)
        {
            return _tourDetailMapper.MapToResponse(await _unitOfWork.Tour.GetById(id));
        }

        public async Task<TourDetailResponse> GetBySlug(string slug)
        {
            return _tourDetailMapper.MapToResponse(await _unitOfWork.Tour.GetBySlug(slug));
        }
    }
}
