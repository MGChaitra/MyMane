using Microsoft.EntityFrameworkCore;
using My_Mane;
using My_Mane.Contracts;
using My_Mane.Services;
using System.Configuration;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(setUp =>
{
    setUp.AddPolicy("cors", setUp =>
    {
        setUp.WithOrigins("http://localhost:5173")
                        .AllowAnyMethod()
                        .AllowAnyHeader();
    });
});

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<EmailService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("cors");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
