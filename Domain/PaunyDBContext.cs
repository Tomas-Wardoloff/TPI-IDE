using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class PaunyDBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Maquinaria> Maquinarias { get; set; }
        public DbSet<Repuesto> Repuestos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Accesorio> Accesorios { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Tabla clientes
            modelBuilder.Entity<Cliente>().HasKey(c => c.idCliente);
            modelBuilder.Entity<Cliente>().Property(c => c.idCliente).ValueGeneratedOnAdd();

            //Tabla Ventas
            modelBuilder.Entity<Venta>().HasKey(v => v.idVenta);
            modelBuilder.Entity<Venta>().Property(v => v.idVenta).ValueGeneratedOnAdd();
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.Venta)
                .HasForeignKey(v => v.ClienteId);

            //Tabla Maquinarias
            modelBuilder.Entity<Maquinaria>().HasKey(m => m.idMaquinaria);
            modelBuilder.Entity<Maquinaria>().Property(m => m.idMaquinaria).ValueGeneratedOnAdd();
            modelBuilder.Entity<Maquinaria>()
                .HasOne(m => m.Venta)
                .WithMany(v => v.Maquinaria)
                .HasForeignKey(v => v.VentaID);

            //Tabla Accesorios
            modelBuilder.Entity<Accesorio>().HasKey(a => a.idAccesorio);
            modelBuilder.Entity<Accesorio>().Property(a => a.idAccesorio).ValueGeneratedOnAdd();
            modelBuilder.Entity<Accesorio>()
                .HasOne(a => a.Maquinaria)
                .WithMany(m => m.Accesorio)
                .HasForeignKey(a => a.MaquinariaId);

            //Tabla Repuestos
            modelBuilder.Entity<Repuesto>().HasKey(r => r.idRepuesto);
            modelBuilder.Entity<Repuesto>().Property(r => r.idRepuesto).ValueGeneratedOnAdd();
            modelBuilder.Entity<Repuesto>()
                .HasOne(r => r.Venta)
                .WithMany(v => v.Repuesto)
                .HasForeignKey(r => r.VentaID);

            //Tabla Proveedor
            modelBuilder.Entity<Proveedor>().HasKey(p => p.idProveedor);
            modelBuilder.Entity<Proveedor>().Property(p => p.idProveedor).ValueGeneratedOnAdd();
            modelBuilder.Entity<Proveedor>()
                .HasOne(p => p.Repuesto)
                .WithOne(r => r.Proveedor)
                .HasForeignKey<Repuesto>(r => r.ProveedorId);

            //Tabla servicios
            modelBuilder.Entity<Servicio>().HasKey(s => s.idServicio);
            modelBuilder.Entity<Servicio>().Property(s => s.idServicio).ValueGeneratedOnAdd();
            modelBuilder.Entity<Servicio>()
                .HasMany(s => s.Cliente)
                .WithMany(c => c.Servicio);
            modelBuilder.Entity<Servicio>()
                .HasMany(s => s.Empleado)
                .WithMany(e => e.Servicio);

            //Tabla Empleados
            modelBuilder.Entity<Empleado>().HasKey(e => e.idEmpleado);
            modelBuilder.Entity<Empleado>().Property(e => e.idEmpleado).ValueGeneratedOnAdd();
            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Servicio)
                .WithMany(s => s.Empleado);
            modelBuilder.Entity<Empleado>()
                .HasOne(e => e.Departamento)
                .WithMany(d => d.Empleado)
                .HasForeignKey(e => e.DepartamentoId);

            //Tabla Departamentos
            modelBuilder.Entity<Departamento>().HasKey(d => d.idDepartamento);
            modelBuilder.Entity<Departamento>().Property(d => d.idDepartamento).ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }


        public PaunyDBContext()
        {
            this.Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=PaunyDB");
    }
}