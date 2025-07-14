using viet_trip_backend.Dtos.Booking;
using viet_trip_backend.Interfaces.Mapper.Public;
using viet_trip_backend.Models;

namespace viet_trip_backend.Mapper.Public
{
    public class BookingMapper : IBookingMapper
    {
        public Booking MapToEntity(BookingRequest request)
        {
            return new Booking
            {
                NumberOfPerson = request.NumberOfPerson,
                BookingDate = request.BookingDate,
                TourId = request.TourId,
                HotelId = request.HotelId,
                ComboId = request.ComboId,
                Note= request.Note,
                Customer = new Customer
                {
                    Name = request.CustomerName,
                    PhoneNumber = request.PhoneNumber
                }
            };
        }
    }
}
