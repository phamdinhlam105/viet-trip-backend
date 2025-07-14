using viet_trip_backend.Dtos.Post.PostReq;
using viet_trip_backend.Dtos.Post.PostRes.Admin;
using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Services.AdminService
{
    public interface IPostAdminService:IAdd<PostRequest>,
        IGetById<AdminPostDetailRes>,
        IGetAll<AdminPostListItemRes>,
        IUpdate<PostRequest,AdminPostDetailRes>,
        IDeleteById
    {
    }
}
