﻿using viet_trip_backend.Dtos.Booking;
using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Mapper.Public
{
    public interface IBookingMapper:IMapToEntity<Booking,BookingRequest>,
        IMapToResponse<Booking, BookingResponse>
    {
    }
}
