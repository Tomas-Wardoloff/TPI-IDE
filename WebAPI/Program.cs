using Domain.Services;
using Domain.Model; 

var builder = WebApplication.CreateBuilder(args);

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


// Clientes
app.MapGet("/clientes/{id}", (int id) =>
{
    ClienteService clienteService = new ClienteService();

    return clienteService.Get(id);
})
.WithName("GetCliente")
.WithOpenApi();

app.MapGet("/clientes", () =>
{
    ClienteService clienteService = new ClienteService();

    return clienteService.GetAll();
})
.WithName("GetAllClientes")
.WithOpenApi();

app.MapPost("/clientes", (Cliente cliente) =>
{
    ClienteService clienteService = new ClienteService();

    clienteService.Add(cliente);
})
.WithName("AddCliente")
.WithOpenApi();

app.MapPut("/clientes", (Cliente cliente) =>
{
    ClienteService clienteService = new ClienteService();

    clienteService.Update(cliente);
})
.WithName("UpdateCliente")
.WithOpenApi();

app.MapDelete("/clientes/{id}", (int id) =>
{
    ClienteService clienteService = new ClienteService();

    clienteService.Delete(id);
})
.WithName("DeleteCliente")
.WithOpenApi();


// Venta
app.MapGet("/ventas", () =>
{
    VentaService ventaService = new VentaService();

    return ventaService.GetAll();
})
.WithName("GetAllVentas")
.WithOpenApi();

app.Run();
