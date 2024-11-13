using FoodOrderAPI.Repository;
using FoodOrderAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register repository and service with DI
// (For .NET 6 and Later)
builder.Services.AddScoped<IFoodRepository, FoodRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

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

