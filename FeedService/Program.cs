using FeedService.DataLayer;
using FeedService.DataLayer.Interfaces;
using FeedService.Logic;
using FeedService.Logic.interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FinlahContext>(
	options => options.UseSqlServer(
		"Server=localhost;Database=Finlah;Trusted_Connection=True;TrustServerCertificate=True"));

builder.Services.AddScoped(typeof(ICrudService<,>), typeof(CrudService<,>));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
