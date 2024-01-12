using EightToTenCopy.Controllers;
using EightToTenCopy.Service.Minich10;
using EightToTenCopy.Service.Minich8;
using EightToTenCopy.Service.Minich9;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMinich8Service, Minich8Service>();
builder.Services.AddScoped<IMinich9Service, Minich9Service>();
builder.Services.AddScoped<IMinich10Service, Minich10Service>();
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
