using Api.Models.Facade;
using Api.Models.Login;
using Api.Models.Operaciones.Divisas;
using Api.Models.Operaciones.Sumadora;
using Api.Models.Operaciones.Temperatura;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddControllers();
builder.Services.AddSingleton<Autenticacion>();
builder.Services.AddSingleton<GuardarRegistro>();
builder.Services.AddSingleton<CalcDivisas>();
builder.Services.AddSingleton<CalcTemperaturas>();
builder.Services.AddSingleton<Calculadora>();
builder.Services.AddSingleton<ICalculadora, Calculadora>();
builder.Services.AddSingleton<IDivisas, CalcDivisas>();
builder.Services.AddSingleton<ITemperatura, CalcTemperaturas>();
builder.Services.AddSingleton<OperacionesFachada>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("NuevaPolitica", app =>
    {
        app.AllowAnyHeader()
           .AllowAnyOrigin()
           .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Usar CORS
app.UseCors("NuevaPolitica");

app.UseAuthorization();

app.MapControllers();

app.Run();
