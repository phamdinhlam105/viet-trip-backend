using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using viet_trip_backend.Dtos.Hotel.HotelReq;
using viet_trip_backend.Interfaces.Services.AdminService;

namespace viet_trip_backend.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelAdminService _hotelAdminService;
        public HotelController(IHotelAdminService hotelAdminService)
        {
            _hotelAdminService = hotelAdminService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var hotels = await _hotelAdminService.GetAll();
            return Ok(hotels);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var hotel = await _hotelAdminService.GetById(id);
            if (hotel == null)
            {
                return NotFound($"Hotel with ID {id} not found");
            }
            return Ok(hotel);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] HotelRequest request)
        {
            if (request == null)
            {
                return BadRequest("Hotel data is required");
            }
            await _hotelAdminService.Add(request);
            return CreatedAtAction(nameof(GetById), new { id = request.Id }, request);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] HotelRequest request)
        {
            if (request == null)
            {
                return BadRequest("Hotel data is required");
            }
            
            var updatedHotel = await _hotelAdminService.Update(request);
            if (updatedHotel == null)
            {
                return NotFound($"Hotel with ID {request.Id} not found");
            }
            return Ok(updatedHotel);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _hotelAdminService.DeleteById(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound($"Hotel with ID {id} not found");
            }
        }
        [HttpGet("room-details/{hotelId}")]
        public async Task<IActionResult> GetRoomDetailsByHotelId(Guid hotelId)
        {
            var roomDetails = await _hotelAdminService.GetRoomDetailByHotelId(hotelId);
            if (roomDetails == null || !roomDetails.Any())
            {
                return NotFound($"No room details found for hotel with ID {hotelId}");
            }
            return Ok(roomDetails);
        }
    }
}
