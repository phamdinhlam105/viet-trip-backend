using viet_trip_backend.Data;
using viet_trip_backend.Interfaces.Repositories.BookingRepo;
using viet_trip_backend.Interfaces.Repositories.HotelRepo;
using viet_trip_backend.Interfaces.Repositories.ImageRepository;
using viet_trip_backend.Interfaces.Repositories.PostRepo;
using viet_trip_backend.Interfaces.Repositories.TourRepo;

namespace viet_trip_backend.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(AppDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }

        public ITourRepository Tour => _serviceProvider.GetRequiredService<ITourRepository>();
        public ITourDetailRepository TourDetail => _serviceProvider.GetRequiredService<ITourDetailRepository>();
        public IHotelRepository Hotel => _serviceProvider.GetRequiredService<IHotelRepository>();
        public IRoomDetailRepository RoomDetail => _serviceProvider.GetRequiredService<IRoomDetailRepository>();
        public IPostRepository Post => _serviceProvider.GetRequiredService<IPostRepository>();
        public IImageRepository Image => _serviceProvider.GetRequiredService<IImageRepository>();
        public ICustomerRepository Customer => _serviceProvider.GetRequiredService<ICustomerRepository>();
        public IBookingRepository Booking => _serviceProvider.GetRequiredService<IBookingRepository>();

        public async ValueTask DisposeAsync()
        {

            if (_context != null)
            {
                await _context.DisposeAsync();
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }


    }
}
