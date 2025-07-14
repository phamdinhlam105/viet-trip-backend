﻿using viet_trip_backend.Dtos.Post.PostRes.Public;

namespace viet_trip_backend.Interfaces.Services.PublicService
{
    public interface IPostDetailService:IGetById<PostDetailResponse>,IGetBySlug<PostDetailResponse>
    {
    }
}
