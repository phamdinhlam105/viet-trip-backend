using viet_trip_backend.Dtos.Post.PostReq;
using viet_trip_backend.Dtos.Post.PostRes.Admin;
using viet_trip_backend.Interfaces.Mapper.Admin;
using viet_trip_backend.Interfaces.Services.AdminService;
using viet_trip_backend.UnitOfWork;

namespace viet_trip_backend.Services.AdminService
{
    public class PostAdminService:IPostAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPostAdminMapper _postAdminMapper;
        private readonly IPostDetailAdminMapper _postDetailAdminMapper;
        public PostAdminService(IUnitOfWork unitOfWork, IPostAdminMapper postAdminMapper, IPostDetailAdminMapper postDetailAdminMapper)
        {
            _unitOfWork = unitOfWork;
            _postAdminMapper = postAdminMapper;
            _postDetailAdminMapper = postDetailAdminMapper;
        }

        public async Task Add(PostRequest request)
        {
            var post = _postAdminMapper.MapToEntity(request);
            post.Id = Guid.NewGuid();
            post.CreatedAt = DateTime.UtcNow;
            post.UpdatedAt = DateTime.UtcNow;
            await _unitOfWork.Post.Add(post);
        }

        public async Task DeleteById(Guid id)
        {
            var post = await _unitOfWork.Post.GetById(id);
            if (post == null)
            {
                throw new KeyNotFoundException("Post not found");
            }
            await _unitOfWork.Post.Delete(post);
        }

        public async Task<IEnumerable<AdminPostListItemRes>> GetAll()
        {
            return (await _unitOfWork.Post.GetAll())
                .Select(post => _postAdminMapper.MapToResponse(post));
        }

        public async Task<AdminPostDetailRes> GetById(Guid id)
        {
            var post = await _unitOfWork.Post.GetById(id);
            if (post == null)
            {
                throw new KeyNotFoundException("Post not found");
            }
            return _postDetailAdminMapper.MapToResponse(post);
        }

        public async Task<AdminPostDetailRes> Update(PostRequest request)
        {
            if (request.Id == null)
            {
                throw new ArgumentNullException(nameof(request.Id), "Post ID cannot be null");
            }
            var id = request.Id?? Guid.Empty;
            var post = await _unitOfWork.Post.GetById(id);
            if (post == null)
            {
                throw new KeyNotFoundException("Post not found");
            }
            _postAdminMapper.UpdateToEntity(post, request);
            post.UpdatedAt = DateTime.UtcNow;
            await _unitOfWork.Post.Update(post);
            return _postDetailAdminMapper.MapToResponse(post);
        }
    }
}
