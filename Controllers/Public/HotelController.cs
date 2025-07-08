using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using viet_trip_backend.Interfaces.Services.PublicService;

namespace viet_trip_backend.Controllers.Public
{
    [Route("api/public/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;
        private readonly IHotelDetailService _hotelDetailService;
        public HotelController(IHotelService hotelService, IHotelDetailService hotelDetailService)
        {
            _hotelService = hotelService;
            _hotelDetailService = hotelDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHotel()
        {
            return Ok(await _hotelService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHotelById(Guid id)
        {
            return Ok(await _hotelDetailService.GetById(id));
        }

        [HttpGet("slug/{slug}")]
        public async Task<IActionResult> GetHotelBySlug(string slug)
        {
            return Ok(await _hotelDetailService.GetBySlug(slug));
        }
    }
}
