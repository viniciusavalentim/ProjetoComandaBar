using BackComandaBar.Database;
using BackComandaBar.Models;
using BackComandaBar.Services.CardService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<ComandaBarDatabaseSettings>(
    builder.Configuration.GetSection("ComandaBarDatabase"));

builder.Services.AddSingleton<CardService>();
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
