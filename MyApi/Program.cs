using Common.Contracts.Repository.Post;
using Common.Contracts.Repository.User;
using Common.Contracts.Services.Post;
using Common.Contracts.Services.User;
using Data;
using Data.Repository.Post;
using Data.Repository.User;
using Microsoft.EntityFrameworkCore;
using Services.Post;
using Services.User;
using System.ComponentModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add the DI
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IPostServices, PostServices>();
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

//add the database config
var connectionString = builder.Configuration.GetConnectionString("SqlServer");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

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
