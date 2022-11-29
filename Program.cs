using ApiTest.Data;
using ApiTest.Domain;
using ApiTest.Interfaces;
using ApiTest.Exceptions.Interfaces;
using ApiTest.Exceptions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICarro, CarroDomain>();
builder.Services.AddScoped<ICliente, ClienteDomain>();
builder.Services.AddScoped<IServPrestado, ServPrestadoDomain>();
builder.Services.AddScoped<IClienteException, ClienteException>();

//DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseLazyLoadingProxies().UseNpgsql(builder.Configuration.GetConnectionString("Default"),
    assembly => assembly.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName));
});

//AddAutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.

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
