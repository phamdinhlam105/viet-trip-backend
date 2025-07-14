using viet_trip_backend.Dtos.Post.PostRes.Public;
using viet_trip_backend.Interfaces.Mapper.Public;
using viet_trip_backend.Interfaces.Services.PublicService;
using viet_trip_backend.UnitOfWork;

namespace viet_trip_backend.Services.PublicService
{
    public class PostPublicService : IPostService, IPostDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPostMapper _postMapper;
        private readonly IPostDetailMapper _postDetailMapper;

        public PostPublicService(IUnitOfWork unitOfWork, IPostMapper postMapper, IPostDetailMapper postDetailMapper)
        {
            _unitOfWork = unitOfWork;
            _postMapper = postMapper;
            _postDetailMapper = postDetailMapper;
        }

        public async Task<IEnumerable<PostListResponse>> GetAll()
        {
            return (await _unitOfWork.Post.GetAll()).Select(p=>_postMapper.MapToResponse(p)).ToList();
        }

        public async Task<PostDetailResponse> GetById(Guid id)
        {
            return _postDetailMapper.MapToResponse(await _unitOfWork.Post.GetById(id));
        }

        public async Task<PostDetailResponse> GetBySlug(string slug)
        {
            return _postDetailMapper.MapToResponse(await _unitOfWork.Post.GetBySlug(slug));
        }
    }
}
