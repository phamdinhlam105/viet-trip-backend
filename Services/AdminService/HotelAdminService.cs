using viet_trip_backend.Dtos.Hotel.HotelReq;
using viet_trip_backend.Dtos.Hotel.HotelRes.Admin;
using viet_trip_backend.Dtos.Hotel.HotelRes.Public;
using viet_trip_backend.Interfaces.Mapper.Admin;
using viet_trip_backend.Interfaces.Services;
using viet_trip_backend.Interfaces.Services.AdminService;
using viet_trip_backend.UnitOfWork;

namespace viet_trip_backend.Services.AdminService
{
    public class HotelAdminService : IHotelAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHotelAdminMapper _hotelAdminMapper;
        private readonly IHotelDetailAdminMapper _hotelDetailAdminMapper;
        public HotelAdminService(IUnitOfWork unitOfWork, IHotelAdminMapper hotelAdminMapper, IHotelDetailAdminMapper hotelDetailAdminMapper)
        {
            _unitOfWork = unitOfWork;
            _hotelAdminMapper = hotelAdminMapper;
            _hotelDetailAdminMapper = hotelDetailAdminMapper;
        }
        public async Task Add(HotelRequest request)
        {
            var hotel = _hotelAdminMapper.MapToEntity(request);
            var newId = Guid.NewGuid();
            hotel.Id = newId;
            hotel.CreatedAt = DateTime.UtcNow;
            hotel.UpdatedAt = DateTime.UtcNow;
            foreach(var room in hotel.RoomDetails)
            {
                room.Id = Guid.NewGuid();
                room.HotelId = newId;
            }
            await _unitOfWork.Hotel.Add(hotel);
        }

        public async Task DeleteById(Guid id)
        {
            var hotel = await _unitOfWork.Hotel.GetById(id);
            if (hotel == null)
            {
                throw new KeyNotFoundException("Hotel not found");
            }
            await _unitOfWork.Hotel.Delete(hotel);
        }

        public async Task<IEnumerable<AdminHotelListItemRes>> GetAll()
        {
            return (await _unitOfWork.Hotel.GetAll())
                .Select(h => _hotelAdminMapper.MapToResponse(h));
        }

        public async Task<AdminHotelDetailRes> GetById(Guid id)
        {
            var hotel = await _unitOfWork.Hotel.GetById(id);
            if (hotel == null)
            {
                throw new KeyNotFoundException("Hotel not found");
            }
            return _hotelDetailAdminMapper.MapToResponse(hotel);
        }

        public async Task<IEnumerable<RoomDetailResponse>> GetRoomDetailByHotelId(Guid hotelId)
        {
            var hotel = await _unitOfWork.Hotel.GetById(hotelId);
            if (hotel == null)
            {
                throw new KeyNotFoundException("Hotel not found");
            }
            return hotel.RoomDetails.Select(rd => new RoomDetailResponse
            {
                Id = rd.Id,
                Name = rd.Name,
                Price = rd.Price,
                Included = rd.Included,
                Capacity = rd.Capacity,
                HotelId = hotelId
            }).ToList();
        }

        public async Task<AdminHotelDetailRes> Update(HotelRequest request)
        {
            if( request.Id == null)
            {
                throw new ArgumentNullException(nameof(request.Id), "Hotel ID cannot be null");
            }
            var id = request.Id ?? Guid.Empty;
            var existingHotel = await _unitOfWork.Hotel.GetById(id);
            if (existingHotel == null)
            {
                throw new KeyNotFoundException("Hotel not found");
            }
            existingHotel.UpdatedAt = DateTime.UtcNow;
            _hotelAdminMapper.UpdateToEntity(existingHotel, request);
            if (request.ShouldUpdateRoom == true)
                foreach (var room in existingHotel.RoomDetails)
                {
                    room.Id = Guid.NewGuid();
                }
            await _unitOfWork.Hotel.Update(existingHotel);
            return _hotelDetailAdminMapper.MapToResponse(existingHotel);
        }
    }
}
