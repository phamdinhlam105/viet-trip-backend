using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using viet_trip_backend.Dtos.Post.PostReq;
using viet_trip_backend.Interfaces.Services.AdminService;

namespace viet_trip_backend.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostAdminService _postAdminService;
        public PostController(IPostAdminService postAdminService)
        {
            _postAdminService = postAdminService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _postAdminService.GetAll();
            return Ok(posts);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var post = await _postAdminService.GetById(id);
            return Ok(post);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PostRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid post data.");
            }
            await _postAdminService.Add(request);
            return CreatedAtAction(nameof(GetById), new { id = request.Id }, request);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PostRequest request)
        {
            if (request == null || request.Id == null)
            {
                return BadRequest("Invalid post data or ID.");
            }
            var updatedPost = await _postAdminService.Update(request);
            return Ok(updatedPost);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _postAdminService.DeleteById(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound($"Post with ID {id} not found.");
            }
        }

    }
}
