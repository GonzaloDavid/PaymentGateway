using Microsoft.AspNetCore;
using Microsoft.Extensions.Configuration;
using PaymentGateway;
using PaymentGateway.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BDDContext>();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();
//app.UseMiddleware<Startup>();



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




//builder.Services.AddDbContext<BDDContext>( options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

