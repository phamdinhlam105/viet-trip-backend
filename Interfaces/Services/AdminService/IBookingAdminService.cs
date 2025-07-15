using viet_trip_backend.Dtos.Booking;

namespace viet_trip_backend.Interfaces.Services.AdminService
{
    public interface IBookingAdminService:IGetAll<BookingResponse>,
        IGetById<BookingResponse>,
        IDeleteById
    {
        Task Finish(Guid id);
        Task Ordered(Guid id);
    }
}
