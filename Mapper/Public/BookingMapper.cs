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
                IsFinished = false,
                IsOrdered = false,
                Customer = new Customer
                {
                    Name = request.CustomerName,
                    PhoneNumber = request.PhoneNumber
                }
            };
        }

        public BookingResponse MapToResponse(Booking entity)
        {
            return new BookingResponse
            {
                Id = entity.Id,
                CustomerId = entity.CustomerId,
                Note = entity.Note,
                NumberOfPerson = entity.NumberOfPerson,
                BookingDate = entity.BookingDate,
                CreatedAt = entity.CreatedAt,
                IsFinished = entity.IsFinished,
                IsOrdered = entity.IsOrdered,
                TourId = entity.TourId,
                TourName = entity.Tour?.Name,
                HotelId = entity.HotelId,
                HotelName = entity.Hotel?.Name,
                ComboId = entity.ComboId,
                ComboName = entity.Combo?.Name,
                CustomerName = entity.Customer?.Name,
                PhoneNumber = entity.Customer?.PhoneNumber
            };
        }
    }
}
