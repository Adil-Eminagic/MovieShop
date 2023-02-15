using MovieShop.Api;
using MovieShop.Api.Config;
using MovieShop.Application;
using MovieShop.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.BindConfig<ConnectionStringConfig>("ConnectionStrings");

builder.Services.AddControllers();
builder.Services.AddValidators();
builder.Services.AddInfrastructure();
builder.Services.AddApplication();
builder.Services.AddDataBase(connectionString);
builder.Services.AddMapper();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}


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
