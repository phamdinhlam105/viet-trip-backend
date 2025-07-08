﻿namespace viet_trip_backend.Models
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string? Note {  get; set; }
        public int NumberOfPerson {  get; set; }
        public DateOnly BookingDate {  get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? TourId {  get; set; }
        public Guid? HotelId {  get; set; }
        public Guid? ComboId {  get; set; }

    }
}
