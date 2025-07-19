using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using viet_trip_backend.Interfaces.Services.AdminService;
using viet_trip_backend.Models;

namespace viet_trip_backend.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost]
        public async Task<IActionResult> Upload([FromForm] IFormFile file, [FromForm] string name)
        {
            try
            {
                await _imageService.Add(file, name);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var images = await _imageService.GetAll();
                return Ok(images);
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
                var image = await _imageService.GetById(id);
                if (image == null)
                {
                    return NotFound();
                }
                return Ok(image);
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
                var image = await _imageService.GetById(id);
                if (image == null)
                {
                    return NotFound();
                }
                await _imageService.Delete(image);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] Image image)
        {
            try
            {
                await _imageService.Update(image);
                return Ok(image);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
