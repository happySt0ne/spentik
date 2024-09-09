using FeedService.DataLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddDbContext<Context>(options =>
	options.UseSqlServer("Server=localhost;Database=Finalah;Trusted_Connection=True;TrustServerCertificate=True"));

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
