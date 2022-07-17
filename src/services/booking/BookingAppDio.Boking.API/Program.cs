using BookingAppDio.Boking.API;
using BookingAppDio.Booking.Infra.Context;
using Microsoft.EntityFrameworkCore;
using MediatR;
using BookingAppDio.Booking.Domain.Interfaces;
using BookingAppDio.Booking.Infra.Repository;
using BookingAppDio.Core.Mapster;
using BookingAppDio.Bus;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddDbContext<BookingDbContext>(options =>
                    options.UseNpgsql(
                          configuration.GetConnectionString("DefaultConnection"),
                         x => x.MigrationsAssembly(typeof(BookingDbContext).Assembly.GetName().Name)));

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(BookingRoot).Assembly);
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddCustomMapster(typeof(BookingRoot).Assembly);
builder.Services.AddCustomMassTransit(configuration, typeof(BookingRoot).Assembly);


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
