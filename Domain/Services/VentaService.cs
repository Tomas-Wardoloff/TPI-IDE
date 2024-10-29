using Domain.Model;

namespace Domain.Services
{
    public class VentaService
    {
        public IEnumerable<Venta> GetAll()
        {
            using var context = new PaunyDBContext();

            return context.Ventas.ToList();
        }
    }
}