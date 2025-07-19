using Microsoft.EntityFrameworkCore;
using viet_trip_backend.Interfaces.Services.AdminService;
using viet_trip_backend.Models;
using viet_trip_backend.UnitOfWork;

namespace viet_trip_backend.Services.AdminService
{
    public class ImageService:IImageService
    {
        private readonly IWebHostEnvironment _env;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUnitOfWork _unitOfWork;
        private readonly string _uploadFolder = "uploads";
        public ImageService(IWebHostEnvironment env, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _env = env;
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task Add(IFormFile file, string name)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("File không hợp lệ");

            var uploadsPath = Path.Combine(_env.WebRootPath, _uploadFolder);
            if (!Directory.Exists(uploadsPath))
                Directory.CreateDirectory(uploadsPath);
            var id = Guid.NewGuid(); // Tạo trước Id
            var ext = Path.GetExtension(file.FileName);
            var fileName = $"{id}{ext}";
            var filePath = Path.Combine(uploadsPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            var request = _httpContextAccessor.HttpContext.Request;
            var baseUrl = $"{request.Scheme}://{request.Host}";

            var image = new Image
            {
                Id = id,
                Name = $"Ảnh {name}",
                Url = $"{baseUrl}/{_uploadFolder}/{fileName}",
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.Image.Add(image);

        }

        public async Task Delete(Image image)
        {
            var uploadsPath = Path.Combine(_env.WebRootPath, _uploadFolder);
            var ext = Path.GetExtension(image.Url);
            var fileName = image.Id + ext;

            var filePath = Path.Combine(uploadsPath, fileName);

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

           await _unitOfWork.Image.Delete(image);
        }

        public async Task<IEnumerable<Image>> GetAll()
        {
            return await _unitOfWork.Image.GetAll();
        }

        public async Task<Image> GetById(Guid id)
        {
            return await _unitOfWork.Image.GetById(id);
        }

        public async Task<Image> Update(Image request)
        {
            if(await _unitOfWork.Image.GetById(request.Id) == null)
                throw new ArgumentException("Image not found");
            await _unitOfWork.Image.Update(request);
            return request;
        }
    }
}
