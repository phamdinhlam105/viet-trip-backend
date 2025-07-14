using viet_trip_backend.Dtos.Booking;
using viet_trip_backend.Interfaces.Mapper.Public;
using viet_trip_backend.Interfaces.Services.PublicService;
using viet_trip_backend.UnitOfWork;

namespace viet_trip_backend.Services.PublicService
{
    public class BookingPublicService : IBookingService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookingMapper _bookingMapper;
        public BookingPublicService(IUnitOfWork unitOfWork, IBookingMapper bookingMapper)
        {
            _unitOfWork = unitOfWork;
            _bookingMapper = bookingMapper;
        }

        public async Task Add(BookingRequest request)
        {
            var newBooking = _bookingMapper.MapToEntity(request);
            var newId = Guid.NewGuid();
            newBooking.CustomerId = newId;
            newBooking.Customer.Id = newId;
            newBooking.Id = Guid.NewGuid();
            await _unitOfWork.Booking.Add(newBooking);
        }
    }
}
