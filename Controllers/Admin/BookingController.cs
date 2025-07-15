using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using viet_trip_backend.Interfaces.Services.AdminService;

namespace viet_trip_backend.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingAdminService _bookingAdminService;
        public BookingController(IBookingAdminService bookingAdminService)
        {
            _bookingAdminService = bookingAdminService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bookings = await _bookingAdminService.GetAll();
            return Ok(bookings);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var booking = await _bookingAdminService.GetById(id);
            if (booking == null)
            {
                return NotFound();
            }
            return Ok(booking);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(Guid id)
        {
            try
            {
                await _bookingAdminService.DeleteById(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        [HttpPost("finish/{id}")]
        public async Task<IActionResult> Finish(Guid id)
        {
            try
            {
                await _bookingAdminService.Finish(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        [HttpPost("ordered/{id}")]
        public async Task<IActionResult> Ordered(Guid id)
        {
            try
            {
                await _bookingAdminService.Ordered(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
