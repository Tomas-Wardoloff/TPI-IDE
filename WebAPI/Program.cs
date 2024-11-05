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


//Accesorios
app.MapGet("/accesorios/{id}", (int id) =>
{
    AccesorioService accesorioService = new AccesorioService();

    return accesorioService.Get(id);
})
.WithName("GetAccesorio")
.WithOpenApi();

app.MapGet("/accesorios", () =>
{
    AccesorioService accesorioService = new AccesorioService();

    return accesorioService.GetAll();
})
.WithName("GetAllAccesorios")
.WithOpenApi();

app.MapPost("/accesorios", (Accesorio accesorio) =>
{
    AccesorioService accesorioService = new AccesorioService();

    accesorioService.Add(accesorio);
})
.WithName("AddAccesorio")
.WithOpenApi();

app.MapPut("/accesorios", (Accesorio accesorio) =>
{
    AccesorioService accesorioService = new AccesorioService();

    accesorioService.Update(accesorio);
})
.WithName("UpdateAccesorio")
.WithOpenApi();

app.MapDelete("/accesorios/{id}", (int id) =>
{
    AccesorioService accesorioService = new AccesorioService();

    accesorioService.Delete(id);
})
.WithName("DeleteAccesorio")
.WithOpenApi();


// Departamento
app.MapGet("/departamentos/{id}", (int id) =>
{
    DepartamentoService departamentoService = new DepartamentoService();

    return departamentoService.Get(id);
})
.WithName("GetDepartamento")
.WithOpenApi();

app.MapGet("/departamentos", () =>
{
    DepartamentoService departamentoService = new DepartamentoService();

    return departamentoService.GetAll();
})
.WithName("GetAllDepartamentos")
.WithOpenApi();

app.MapPost("/departamentos", (Departamento departamento) =>
{
    DepartamentoService departamentoService = new DepartamentoService();

    departamentoService.Add(departamento);
})
.WithName("AddDepartamento")
.WithOpenApi();

app.MapPut("/departamentos", (Departamento departamento) =>
{
    DepartamentoService departamentoService = new DepartamentoService();

    departamentoService.Update(departamento);
})
.WithName("UpdateDepartamento")
.WithOpenApi();

app.MapDelete("/departamentos/{id}", (int id) =>
{
    DepartamentoService departamentoService = new DepartamentoService();

    departamentoService.Delete(id);
})
.WithName("DeleteDepartamento")
.WithOpenApi();

app.Run();
