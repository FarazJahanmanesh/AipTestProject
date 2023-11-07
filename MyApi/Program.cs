using Microsoft.EntityFrameworkCore;
using IOC.Dependencies;
using Data;
using Services.Helper;
using ElmahCore.Mvc;
using ElmahCore.Sql;
using Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add config for automappe
builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration).Assembly);

//add the DI
builder.Services.RegisterServices();

//add the database config
var connectionString = builder.Configuration.GetConnectionString("SqlServer");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

//builder.Services.AddElmah<SqlErrorLog>(options =>
//{
//    options.Path = "/ErrorLog";
//    options.ConnectionString = builder.Configuration.GetConnectionString("Elmah");
//});
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
//app.UseElmah();

app.Run();
