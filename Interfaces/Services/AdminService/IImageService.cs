using viet_trip_backend.Models;

namespace viet_trip_backend.Interfaces.Services.AdminService
{
    public interface IImageService:IGetAll<Image>, IGetById<Image>, IDelete<Image>
    {
        Task<Image> Update(Image image);
        Task Add(IFormFile file, string name);
    }
}
