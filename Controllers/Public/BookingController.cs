using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using viet_trip_backend.Dtos.Booking;
using viet_trip_backend.Interfaces.Services.PublicService;

namespace viet_trip_backend.Controllers.Public
{
    [Route("api/public/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpPost]
        public async Task<IActionResult> NewBooking([FromBody] BookingRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest("Request Body Incorrect");
            try
            {
                await _bookingService.Add(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
