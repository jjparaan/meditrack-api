using MediTrack.Application.Common.Mapping;
using MediTrack.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register EF Core
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register Mapping Profile
builder.Services.AddAutoMapper(typeof(MappingProfiles).Assembly);


// Register Controllers + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Use Swagger in Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware Pipeline
app.UseHttpsRedirection(); // Redirect HTTP to HTTPS

app.UseAuthorization();    // uthorization middleware (needs to come after authentication if you have it)

app.MapControllers();      // Route requests to controllers

app.Run();
