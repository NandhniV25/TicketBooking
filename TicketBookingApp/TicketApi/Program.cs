using Microsoft.EntityFrameworkCore;
using TicketApi.AutoMapper;
using TicketApi.Service.City;
using TicketApi.Service.Court;
using TicketApi.Service.Ground;
using TicketRepository.Data;
using TicketRepository.Repository.City;
using TicketRepository.Repository.Court;
using TicketRepository.Repository.Ground;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAutoMapper(typeof(MapperProfile));
 
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<ICityRepository, CityRepository>();

builder.Services.AddTransient<IGroundRepository, GroundRepository>();
builder.Services.AddTransient<IGroundService, GroundService>();

builder.Services.AddTransient<ICourtRepository, CourtRepository>();
builder.Services.AddTransient<ICourtService, CourtService>();

#region Configure Database

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
