using Domain.Model;

namespace Domain.Services
{
    public class RepuestoService
    {
        public void Add(Repuesto repuesto)
        {
            using var context = new PaunyDBContext();

            context.Repuestos.Add(repuesto);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PaunyDBContext();

            Repuesto? repuestoToDelete = context.Repuestos.Find(id);

            if (repuestoToDelete != null)
            {
                context.Repuestos.Remove(repuestoToDelete);
                context.SaveChanges();
            }
        }

        public Repuesto? Get(int id)
        {
            using var context = new PaunyDBContext();

            return context.Repuestos.Find(id);
        }

        public IEnumerable<Repuesto> GetAll()
        {
            using var context = new PaunyDBContext();

            return context.Repuestos.ToList();
        }

        public void Update(Repuesto repuesto)
        {
            using var context = new PaunyDBContext();

            Repuesto? repuestoToUpdate = context.Repuestos.Find(repuesto.idRepuesto);

            if (repuestoToUpdate != null)
            {
                repuestoToUpdate.descripcion = repuesto.descripcion;
                repuestoToUpdate.stock = repuesto.stock;
                repuestoToUpdate.importeVenta = repuesto.importeVenta;
                repuestoToUpdate.importeCompra = repuesto.importeCompra;

                context.SaveChanges();
            }
        }
    }
}
