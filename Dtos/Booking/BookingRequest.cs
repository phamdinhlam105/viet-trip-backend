namespace viet_trip_backend.Dtos.Booking
{
    public class BookingRequest
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Note { get; set; }
        public int NumberOfPerson {  get; set; }
        public DateOnly BookingDate { get; set; }
        public Guid? TourId { get; set; }
        public Guid? HotelId { get; set; }
        public Guid? ComboId { get; set; }

    }
}
