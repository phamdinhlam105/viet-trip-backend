using viet_trip_backend.Dtos.Booking;
using viet_trip_backend.Interfaces.Mapper.Public;
using viet_trip_backend.Interfaces.Services.AdminService;
using viet_trip_backend.UnitOfWork;

namespace viet_trip_backend.Services.AdminService
{
    public class BookingAdminService : IBookingAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookingMapper _bookingMapper;

        public BookingAdminService(IUnitOfWork unitOfWork, IBookingMapper bookingMapper)
        {
            _unitOfWork = unitOfWork;
            _bookingMapper = bookingMapper;
        }
        public async Task DeleteById(Guid id)
        {
            var booking = await _unitOfWork.Booking.GetById(id);
            if (booking == null)
            {
                throw new KeyNotFoundException("Booking not found");
            }
            await _unitOfWork.Booking.Delete(booking);
        }

        public async Task Finish(Guid id)
        {
            var booking = await _unitOfWork.Booking.GetById(id);
            if (booking == null)
            {
                throw new KeyNotFoundException("Booking not found");
            }
            booking.IsFinished = true;
            await _unitOfWork.Booking.Update(booking);
        }

        public async Task<IEnumerable<BookingResponse>> GetAll()
        {
            return (await _unitOfWork.Booking.GetAll())
                .Select(_bookingMapper.MapToResponse);
        }

        public async Task<BookingResponse> GetById(Guid id)
        {
            return _bookingMapper.MapToResponse(
                await _unitOfWork.Booking.GetById(id));
        }

        public async Task Ordered(Guid id)
        {
            var booking = await _unitOfWork.Booking.GetById(id);
            if (booking == null)
            {
                throw new KeyNotFoundException("Booking not found");
            }
            booking.IsOrdered = true;
            await _unitOfWork.Booking.Update(booking);
        }
    }
}
