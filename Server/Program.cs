using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

//builder.Services.AddSwaggerGen(c =>
//{
//  c.SwaggerDoc("v1", new OpenApiInfo { Title = "BEYOU", Version = "v1" });
//});

builder.Services.AddDbContext<ApplicationDbContext>(_ =>
{
  _.UseSqlServer(builder
      .Configuration
      .GetConnectionString("DefaultConnection"));
});

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
