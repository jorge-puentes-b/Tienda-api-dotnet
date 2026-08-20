using TiendaApi.Interfaces;
using TiendaApi.Services;
var builder = WebApplication.CreateBuilder(args);

//Servicios

builder.Services.AddSingleton<IProductoService, ProductoService>();
builder.Services.AddSingleton<IClienteService, ClienteService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

//Middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Configuracion HTTPs
app.UseHttpsRedirection();

//Configuracion Autorizacion
app.UseAuthorization();

//Configuracion Controllers
app.MapControllers();

app.Run();
