using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    internal class PaunyDBContext : DbContext
    {
        internal DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(c => c.idCliente);
            modelBuilder.Entity<Cliente>().Property(c => c.idCliente).ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }

        internal PaunyDBContext()
        {
            this.Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=PaunyDB");
    }
}