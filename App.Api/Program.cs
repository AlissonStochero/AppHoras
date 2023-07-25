using App.Application.Commands.EmpresaCommands;
using App.Application.Services.Implementation;
using App.Application.Services.Interfaces;
using App.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Horas API", Version = "v1" });
});
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(CriarEmpresaCommand).Assembly);
});

builder.Services.AddDbContext<AppDbContext>(options =>
    //options.UseNpgsql(builder.Configuration.GetConnectionString("AppHoursDb"))
    options.UseInMemoryDatabase("AppHoursDb")
);

builder.Services.AddScoped<IEmpresaService, EmpresaService>();

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
