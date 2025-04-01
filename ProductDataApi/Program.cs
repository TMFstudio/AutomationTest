using Microsoft.EntityFrameworkCore;
using ProductDataApi.Data;
using ProductDataApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductDbContext>(option =>
option.UseSqlServer(
    builder.Configuration.GetConnectionString("ProductConnectionString")));
builder.Services.AddTransient<IProductRepository, ProductRepository>();
var app = builder.Build();
app.UseDeveloperExceptionPage();

// Configure the HTTP request pipeline..
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProductApi v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
public partial class Program { }
