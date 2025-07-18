using MediTrack.Application;
using MediTrack.Infrastructure;
using MediTrack.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Register Services
builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices()
    .AddPersistenceServices(builder.Configuration);

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
