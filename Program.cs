using viet_trip_backend.Interfaces.Mapper.Admin;
using viet_trip_backend.Interfaces.Mapper.Public;
using viet_trip_backend.Interfaces.Services.AdminService;
using viet_trip_backend.Interfaces.Services.PublicService;
using viet_trip_backend.Mapper.Admin;
using viet_trip_backend.Mapper.Public;
using viet_trip_backend.Services.AdminService;
using viet_trip_backend.Services.PublicService;
using viet_trip_backend.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the database context and unit of work
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
// Configure the services
//public services
builder.Services.AddScoped<ITourService, TourPublicService>();
builder.Services.AddScoped<IHotelService, HotelPublicService>();
builder.Services.AddScoped<IPostService, PostPublicService>();
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


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
