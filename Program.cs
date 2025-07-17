using Microsoft.EntityFrameworkCore;
using viet_trip_backend.Data;
using viet_trip_backend.Interfaces.Mapper.Admin;
using viet_trip_backend.Interfaces.Mapper.Public;
using viet_trip_backend.Interfaces.Repositories.BookingRepo;
using viet_trip_backend.Interfaces.Repositories.ComboRepo;
using viet_trip_backend.Interfaces.Repositories.HotelRepo;
using viet_trip_backend.Interfaces.Repositories.ImageRepository;
using viet_trip_backend.Interfaces.Repositories.PostRepo;
using viet_trip_backend.Interfaces.Repositories.TourRepo;
using viet_trip_backend.Interfaces.Services.AdminService;
using viet_trip_backend.Interfaces.Services.PublicService;
using viet_trip_backend.Mapper.Admin;
using viet_trip_backend.Mapper.Public;
using viet_trip_backend.Repositories.AttachmentRepo;
using viet_trip_backend.Repositories.BookingRepo;
using viet_trip_backend.Repositories.ComboRepo;
using viet_trip_backend.Repositories.HotelRepo;
using viet_trip_backend.Repositories.PostRepo;
using viet_trip_backend.Repositories.TourRepo;
using viet_trip_backend.Services.AdminService;
using viet_trip_backend.Services.PublicService;
using viet_trip_backend.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//connection string
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//Repository
builder.Services.AddScoped<ITourRepository, TourRepository>();
builder.Services.AddScoped<ITourDetailRepository, TourDetailRepository>();
builder.Services.AddScoped<IHotelRepository, HotelRepository>();
builder.Services.AddScoped<IRoomDetailRepository, RoomDetailRepository>();
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IComboRepository, ComboRepository>();

// Configure the database context and unit of work
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
// Configure the services
//public services
builder.Services.AddScoped<ITourService, TourPublicService>();
builder.Services.AddScoped<ITourDetailService,TourPublicService>();
builder.Services.AddScoped<IHotelService, HotelPublicService>();
builder.Services.AddScoped<IHotelDetailService, HotelPublicService>();
builder.Services.AddScoped<IPostService, PostPublicService>();
builder.Services.AddScoped<IPostDetailService, PostPublicService>();
builder.Services.AddScoped<IBookingService, BookingPublicService>();
//admin services
builder.Services.AddScoped<IPostAdminService, PostAdminService>();
builder.Services.AddScoped<ITourAdminService, TourAdminService>();
builder.Services.AddScoped<IHotelAdminService, HotelAdminService>();
builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<IBookingAdminService, BookingAdminService>();
// Configure the mappers
//public mappers
builder.Services.AddScoped<ITourMapper, TourMapper>();
builder.Services.AddScoped<ITourDetailMapper, TourDetailMapper>();
builder.Services.AddScoped<IHotelMapper, HotelMapper>();
builder.Services.AddScoped<IHotelDetailMapper, HotelDetailMapper>();
builder.Services.AddScoped<IPostMapper, PostMapper>();
builder.Services.AddScoped<IPostDetailMapper, PostDetailMapper>();
builder.Services.AddScoped<IBookingMapper, BookingMapper>();
//admin mappers
builder.Services.AddScoped<IPostAdminMapper, PostAdminMapper>();
builder.Services.AddScoped<IPostDetailAdminMapper, PostDetailAdminMapper>();
builder.Services.AddScoped<ITourAdminMapper, TourAdminMapper>();
builder.Services.AddScoped<ITourDetailAdminMapper, TourDetailAdminMapper>();
builder.Services.AddScoped<IHotelAdminMapper, HotelAdminMapper>();
builder.Services.AddScoped<IHotelDetailAdminMapper, HotelDetailAdminMapper>();

// Configure the HTTP context accessor
builder.Services.AddHttpContextAccessor();
// Configure the web host environment
builder.Services.AddSingleton<IWebHostEnvironment>(builder.Environment);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowFrontend");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
