using viet_trip_backend.Dtos.Post.PostReq;
using viet_trip_backend.Dtos.Post.PostRes.Admin;
using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Mapper.Admin
{
    public interface IPostAdminMapper:IMapToEntity<Post,PostRequest>,
        IMapToResponse<Post,AdminPostListItemRes>,
        IUpdateToUpdate<Post, PostRequest>
    {
    }
}
