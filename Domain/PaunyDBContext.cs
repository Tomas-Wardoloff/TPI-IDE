using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    internal class PaunyDBContext : DbContext
    {
        internal DbSet<Cliente> Clientes { get; set; }

        internal PaunyDBContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=PaunyDB");
    }
}