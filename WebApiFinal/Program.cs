using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiFinal.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebApiFinalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiFinalContext") ?? throw new InvalidOperationException("Connection string 'WebApiFinalContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
