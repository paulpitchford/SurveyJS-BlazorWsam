using Microsoft.EntityFrameworkCore;
using SurveyBlazor.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add DbContext with SQL Server provider
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Enable CORS to allow requests from Blazor app
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorApp",
        policy => policy.WithOrigins("http://localhost:5018") // Blazor app URL
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.

// Use CORS policy
app.UseCors("AllowBlazorApp");

app.UseAuthorization();

app.MapControllers();

app.Run();