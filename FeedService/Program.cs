using FeedService.DataLayer;
using FeedService.DataLayer.Interfaces;
using FeedService.Logic.interfaces;
using FeedService.Logic.Interfaces;
using FeedService.Logic.Services;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FinlahContext>(
	options => options.UseSqlServer(
		  "Server=localhost,1433;Database=Finlah;User=sa;Password=AnalKarnaval228$;TrustServerCertificate=True"));

builder.Services.AddScoped(typeof(ICrudService<,>), typeof(CrudService<,>));

builder.Services.AddScoped(typeof(IMonthTableService), typeof(MonthTableService));

builder.Services.AddScoped(typeof(ISearchService), typeof(SearchService));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => 
        options.AddPolicy("AllowSpecificOrigin", builder => 
            builder.WithOrigins("http://localhost:3000")
            .AllowAnyMethod()
            .AllowAnyHeader()));

/* CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture; */
/* CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture; */

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
/* using (var scope = app.Services.CreateScope()) */
/* { */
/*     var services = scope.ServiceProvider; */
/*     var context = services.GetRequiredService<FinlahContext>(); */
/*     context.Database.Migrate(); */
/* } */

app.Run();
