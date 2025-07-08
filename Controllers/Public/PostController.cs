using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using viet_trip_backend.Interfaces.Services.PublicService;

namespace viet_trip_backend.Controllers.Public
{
    [Route("api/public/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IPostDetailService _postDetailService;
        public PostController(IPostService postService, IPostDetailService postDetailService)
        {
            _postService = postService;
            _postDetailService = postDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPost()
        {
            return Ok(await _postService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostById(Guid id)
        {
            return Ok(await _postDetailService.GetById(id));
        }

        [HttpGet("slug/{slug}")]
        public async Task<IActionResult> GetPostBySlug(string slug)
        {
            return Ok(await _postDetailService.GetBySlug(slug));
        }
    }
}
