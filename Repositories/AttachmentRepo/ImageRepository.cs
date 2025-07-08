using viet_trip_backend.Data;
using viet_trip_backend.Interfaces.Repositories.ImageRepository;
using viet_trip_backend.Models;

namespace viet_trip_backend.Repositories.AttachmentRepo
{
    public class ImageRepository:BaseRepository<Image>,IImageRepository
    {
        public ImageRepository(AppDbContext _context) : base(_context) { }
    }
}
