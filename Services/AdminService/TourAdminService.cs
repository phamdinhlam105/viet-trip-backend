using viet_trip_backend.Dtos.Tour.TourReq;
using viet_trip_backend.Dtos.Tour.TourRes.Admin;
using viet_trip_backend.Interfaces.Mapper.Admin;
using viet_trip_backend.Interfaces.Services.AdminService;
using viet_trip_backend.UnitOfWork;

namespace viet_trip_backend.Services.AdminService
{
    public class TourAdminService : ITourAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITourAdminMapper _tourAdminMapper;
        private readonly ITourDetailAdminMapper _tourDetailAdminMapper;
        public TourAdminService(IUnitOfWork unitOfWork,ITourAdminMapper tourAdminMapper, ITourDetailAdminMapper tourDetailAdminMapper)
        {
            _unitOfWork = unitOfWork;
            _tourAdminMapper = tourAdminMapper;
            _tourDetailAdminMapper = tourDetailAdminMapper;
        }
        public async Task Add(NewTourRequest request)
        {
            var newId = Guid.NewGuid();
            var tour = _tourAdminMapper.MapToEntity(request);
            tour.TourDetail.Id= newId;
            tour.Id = Guid.NewGuid();
            tour.CreatedAt = DateTime.UtcNow;
            tour.UpdatedAt = DateTime.UtcNow;
            await _unitOfWork.Tour.Add(tour);
        }

        public async Task DeleteById(Guid id)
        {
            var request = await _unitOfWork.Tour.GetById(id);
            if (request == null)
            {
                throw new KeyNotFoundException($"Tour with ID {id} not found");
            }
            await _unitOfWork.Tour.Delete(request);
        }

        public async Task<IEnumerable<AdminTourListItemRes>> GetAll()
        {
            return (await _unitOfWork.Tour.GetAll())
                .Select(tour => _tourAdminMapper.MapToResponse(tour));
        }

        public async Task<AdminTourDetailRes> GetById(Guid id)
        {
            return _tourDetailAdminMapper.MapToResponse(await _unitOfWork.Tour.GetById(id));
        }

        public async Task<AdminTourDetailRes> Update(NewTourRequest request)
        {
            if( request.Id == null)
            {
                throw new ArgumentNullException(nameof(request.Id), "Tour ID cannot be null");
            }
            var id = request.Id ?? Guid.Empty;
            var existingTour = await _unitOfWork.Tour.GetById(id);
            if ((await _unitOfWork.Tour.GetById(id)) == null)
            {
                throw new KeyNotFoundException($"Tour with ID {request.Id} not found");
            }
            _tourAdminMapper.UpdateToEntity(existingTour, request);
            existingTour.UpdatedAt = DateTime.UtcNow;
            await _unitOfWork.Tour.Update(existingTour);
            return _tourDetailAdminMapper.MapToResponse(existingTour);
        }
    }
}
