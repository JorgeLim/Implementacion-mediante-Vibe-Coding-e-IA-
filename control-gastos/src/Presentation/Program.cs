using Microsoft.OpenApi.Models;
using Application.Interfaces;
using Application.Services;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddNewtonsoftJson();



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Control Gastos API",
        Version = "v1",
        Description = "API REST para Sistema de Control de Gastos Empresariales"
    });
});

// CORS para desarrollo
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// === Servicios de Usuarios y Áreas ===
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

builder.Services.AddScoped<IAreaRepository, AreaRepository>();
builder.Services.AddScoped<IAreaService, AreaService>();

builder.Services.AddScoped<IRolRepository, RolRepository>();
builder.Services.AddScoped<IRolService, RolService>();

builder.Services.AddScoped<ICentroCostoRepository, CentroCostoRepository>();
builder.Services.AddScoped<ICentroCostoService, CentroCostoService>();

builder.Services.AddScoped<IPresupuestoRepository, PresupuestoRepository>();
builder.Services.AddScoped<IPresupuestoService, PresupuestoService>();

var app = builder.Build();

app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.InjectStylesheet("/swagger-ui/custom.css");
        c.InjectJavascript("/swagger-ui/custom.js");
        c.DocumentTitle = "Control Gastos API - Documentación Técnica";
    });
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseAuthorization();

app.MapControllers();

app.Run();