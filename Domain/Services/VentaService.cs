using Domain.Model;

namespace Domain.Services
{
    public class VentaService
    {
        public void Add(Venta venta)
        {
            using var context = new PaunyDBContext();

            context.Ventas.Add(venta);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PaunyDBContext();

            Venta? ventaToDelete = context.Ventas.Find(id);

            if (ventaToDelete != null)
            {
                context.Ventas.Remove(ventaToDelete);
                context.SaveChanges();
            }
        }

        public Venta? Get(int id)
        {
            using var context = new PaunyDBContext();

            return context.Ventas.Find(id);
        }

        public IEnumerable<Venta> GetAll()
        {
            using var context = new PaunyDBContext();

            return context.Ventas.ToList();
        }

        public void Update(Venta venta)
        {
            using var context = new PaunyDBContext();

            Venta? ventaToUpdate = context.Ventas.Find(venta.idVenta);

            if (ventaToUpdate != null)
            {
                ventaToUpdate.fecha = venta.fecha;
                ventaToUpdate.importeTotal = venta.importeTotal;
                ventaToUpdate.estado = venta.estado;

                context.SaveChanges();
            }
        }
    }
}
