namespace viet_trip_backend.Dtos.Booking
{
    public class BookingResponse
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string? Note { get; set; }
        public int NumberOfPerson { get; set; }
        public DateOnly BookingDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsFinished { get; set; }
        public bool IsOrdered { get; set; }
        public Guid? TourId { get; set; }
        public string? TourName { get; set; }
        public Guid? HotelId { get; set; }
        public string? HotelName { get; set; }
        public Guid? ComboId { get; set; }
        public string? ComboName { get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
