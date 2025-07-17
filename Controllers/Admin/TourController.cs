using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using viet_trip_backend.Dtos.Tour.TourReq;
using viet_trip_backend.Interfaces.Services.AdminService;

namespace viet_trip_backend.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    public class TourController : ControllerBase
    {
        private readonly ITourAdminService _tourAdminService;
        public TourController(ITourAdminService tourAdminService)
        {
            _tourAdminService = tourAdminService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var tours = await _tourAdminService.GetAll();
                return Ok(tours);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var tour = await _tourAdminService.GetById(id);
                if (tour == null)
                {
                    return NotFound();
                }
                return Ok(tour);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] NewTourRequest request)
        {
            try
            {
                await _tourAdminService.Add(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] NewTourRequest request)
        {
            try
            {
                var updatedTour = await _tourAdminService.Update(request);
                return Ok(updatedTour);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _tourAdminService.DeleteById(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
