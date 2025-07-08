using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using viet_trip_backend.Interfaces.Services.PublicService;

namespace viet_trip_backend.Controllers.Public
{
    [Route("api/public/[controller]")]
    [ApiController]
    public class TourController : ControllerBase
    {
        private readonly ITourService _tourService;
        private readonly ITourDetailService _tourDetailService;
        public TourController(ITourService tourService, ITourDetailService tourDetailService)
        {
            _tourService = tourService;
            _tourDetailService = tourDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTour()
        {
            return Ok(await _tourService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTourById(Guid id)
        {
            return Ok(await _tourDetailService.GetById(id));
        }

        [HttpGet("slug/{slug}")]
        public async Task<IActionResult> GetTourBySlug(string slug)
        {
            return Ok(await _tourDetailService.GetBySlug(slug));
        }
    }
}
