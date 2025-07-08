using viet_trip_backend.Data;
using viet_trip_backend.Interfaces.Repositories.BookingRepo;
using viet_trip_backend.Models;

namespace viet_trip_backend.Repositories.BookingRepo
{
    public class CustomerRepository:BaseRepository<Customer>,ICustomerRepository
    {
        public CustomerRepository(AppDbContext _context) : base(_context) { }
    }
}
