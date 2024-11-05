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
app.MapGet("/clientes", () =>
{
    ClienteService clienteService = new ClienteService();

    return clienteService.GetAll();
})
.WithName("GetAllClientes")
.WithOpenApi();

app.MapGet("/clientes/{id}", (int id) =>
{
    ClienteService clienteService = new ClienteService();

    return clienteService.Get(id);
})
.WithName("GetCliente")
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

app.MapGet("/ventas/{id}", (int id) =>
{
    VentaService ventaService = new VentaService();

    return ventaService.Get(id);
})
.WithName("GetVenta")
.WithOpenApi();

app.MapPost("/ventas", (Venta venta) =>
{
    VentaService ventaService = new VentaService();

    ventaService.Add(venta);
})
.WithName("AddVenta")
.WithOpenApi();

app.MapPut("/ventas", (Venta venta) =>
{
    VentaService ventaService = new VentaService();

    ventaService.Update(venta);
})
.WithName("UpdateVenta")
.WithOpenApi();

app.MapDelete("/ventas/{id}", (int id) =>
{
    VentaService ventaService = new VentaService();

    ventaService.Delete(id);
})
.WithName("DeleteVenta")
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

//Empleado
app.MapGet("/empleados/{id}", (int id) =>
{
    EmpleadoService empleadoService = new EmpleadoService();

    return empleadoService.Get(id);
})
.WithName("GetEmpleado")
.WithOpenApi();

app.MapGet("/empleados", () =>
{
    EmpleadoService empleadoService = new EmpleadoService();

    return empleadoService.GetAll();
})
.WithName("GetAllEmpleados")
.WithOpenApi();

app.MapPost("/empleados", (Empleado empleado) =>
{
    EmpleadoService empleadoService = new EmpleadoService();

    empleadoService.Add(empleado);
})
.WithName("AddEmpleado")
.WithOpenApi();

app.MapPut("/empleados", (Empleado empleado) =>
{
    EmpleadoService empleadoService = new EmpleadoService();

    empleadoService.Update(empleado);
})
.WithName("UpdateEmpleado")
.WithOpenApi();

app.MapDelete("/empleados/{id}", (int id) =>
{
    EmpleadoService empleadoService = new EmpleadoService();

    empleadoService.Delete(id);
})
.WithName("DeleteEmpleado")
.WithOpenApi();


//Maquinaria
app.MapGet("/maquinarias/{id}", (int id) =>
{
    MaquinariaService maquinariaService = new MaquinariaService();

    return maquinariaService.Get(id);
})
.WithName("GetMaquinaria")
.WithOpenApi();

app.MapGet("/maquinarias", () =>
{
    MaquinariaService maquinariaService = new MaquinariaService();

    return maquinariaService.GetAll();
})
.WithName("GetAllMaquinarias")
.WithOpenApi();

app.MapPost("/maquinarias", (Maquinaria maquinaria) =>
{
    MaquinariaService maquinariaService = new MaquinariaService();

    maquinariaService.Add(maquinaria);
})
.WithName("AddMaquinaria")
.WithOpenApi();

app.MapPut("/maquinarias", (Maquinaria maquinaria) =>
{
    MaquinariaService maquinariaService = new MaquinariaService();

    maquinariaService.Update(maquinaria);
})
.WithName("UpdateMaquinaria")
.WithOpenApi();

app.MapDelete("/maquinarias/{id}", (int id) =>
{
    MaquinariaService maquinariaService = new MaquinariaService();

    maquinariaService.Delete(id);
})
.WithName("DeleteMaquinaria")
.WithOpenApi();


//Proveedor
app.MapGet("/proveedores/{id}", (int id) =>
{
    ProveedorService proveedorService = new ProveedorService();

    return proveedorService.Get(id);
})
.WithName("GetProveedor")
.WithOpenApi();

app.MapGet("/proveedores", () =>
{
    ProveedorService proveedorService = new ProveedorService();

    return proveedorService.GetAll();
})
.WithName("GetAllProveedores")
.WithOpenApi();

app.MapPost("/proveedores", (Proveedor proveedor) =>
{
    ProveedorService proveedorService = new ProveedorService();

    proveedorService.Add(proveedor);
})
.WithName("AddProveedor")
.WithOpenApi();

app.MapPut("/proveedores", (Proveedor proveedor) =>
{
    ProveedorService proveedorService = new ProveedorService();

    proveedorService.Update(proveedor);
})
.WithName("UpdateProveedor")
.WithOpenApi();

app.MapDelete("/proveedores/{id}", (int id) =>
{
    ProveedorService proveedorService = new ProveedorService();

    proveedorService.Delete(id);
})
.WithName("DeleteProveedor")
.WithOpenApi();

//Repuesto

app.MapGet("/repuestos/{id}", (int id) =>
{
    RepuestoService repuestoService = new RepuestoService();

    return repuestoService.Get(id);
})
.WithName("GetRepuesto")
.WithOpenApi();

app.MapGet("/repuestos", () =>
{
    RepuestoService repuestoService = new RepuestoService();

    return repuestoService.GetAll();
})
.WithName("GetAllRepuestos")
.WithOpenApi();

app.MapPost("/repuestos", (Repuesto repuesto) =>
{
    RepuestoService repuestoService = new RepuestoService();

    repuestoService.Add(repuesto);
})
.WithName("AddRepuesto")
.WithOpenApi();

app.MapPut("/repuestos", (Repuesto repuesto) =>
{
    RepuestoService repuestoService = new RepuestoService();

    repuestoService.Update(repuesto);
})
.WithName("UpdateRepuesto")
.WithOpenApi();

app.MapDelete("/repuestos/{id}", (int id) =>
{
    RepuestoService repuestoService = new RepuestoService();

    repuestoService.Delete(id);
})
.WithName("DeleteRepuesto")
.WithOpenApi();

//Servicio

app.MapGet("/servicios/{id}", (int id) =>
{
    ServicioService servicioService = new ServicioService();

    return servicioService.Get(id);
})
.WithName("GetServicio")
.WithOpenApi();

app.MapGet("/servicios", () =>
{
    ServicioService servicioService = new ServicioService();

    return servicioService.GetAll();
})
.WithName("GetAllServicios")
.WithOpenApi();

app.MapPost("/servicios", (Servicio servicio) =>
{
    ServicioService servicioService = new ServicioService();

    servicioService.Add(servicio);
})
.WithName("AddServicio")
.WithOpenApi();

app.MapPut("/servicios", (Servicio servicio) =>
{
    ServicioService servicioService = new ServicioService();

    servicioService.Update(servicio);
})
.WithName("UpdateServicio")
.WithOpenApi();

app.MapDelete("/servicios/{id}", (int id) =>
{
    ServicioService servicioService = new ServicioService();

    servicioService.Delete(id);
})
.WithName("DeleteServicio")
.WithOpenApi();

app.Run();
