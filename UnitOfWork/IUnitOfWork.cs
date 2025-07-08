using viet_trip_backend.Interfaces.Repositories.BookingRepo;
using viet_trip_backend.Interfaces.Repositories.HotelRepo;
using viet_trip_backend.Interfaces.Repositories.ImageRepository;
using viet_trip_backend.Interfaces.Repositories.PostRepo;
using viet_trip_backend.Interfaces.Repositories.TourRepo;

namespace viet_trip_backend.UnitOfWork
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        ITourRepository Tour {  get; }
        ITourDetailRepository TourDetail { get; }
        IHotelRepository Hotel { get; }
        IRoomDetailRepository RoomDetail {  get; }
        IPostRepository Post { get; }
        IImageRepository Image {  get; }
        ICustomerRepository Customer { get; }
        IBookingRepository Booking {  get; }

        Task Save();
    }
}
