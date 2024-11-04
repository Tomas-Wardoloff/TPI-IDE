using Domain.Model;

namespace Domain.Services
{
    public class ServicioService
    {
        public void Add(Servicio servicio)
        {
            using var context = new PaunyDBContext();

            context.Servicios.Add(servicio);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PaunyDBContext();

            Servicio? servicioToDelete = context.Servicios.Find(id);

            if (servicioToDelete != null)
            {
                context.Servicios.Remove(servicioToDelete);
                context.SaveChanges();
            }
        }

        public Servicio? Get(int id)
        {
            using var context = new PaunyDBContext();

            return context.Servicios.Find(id);
        }

        public IEnumerable<Servicio> GetAll()
        {
            using var context = new PaunyDBContext();

            return context.Servicios.ToList();
        }

        public void Update(Servicio servicio)
        {
            using var context = new PaunyDBContext();

            Servicio? servicioToUpdate = context.Servicios.Find(servicio.idServicio);

            if (servicioToUpdate != null)
            {
                servicioToUpdate.descripcion = servicio.descripcion;
                servicioToUpdate.costo = servicio.costo;
                servicioToUpdate.importeTotal = servicio.importeTotal;
                context.SaveChanges();
            }
        }
    }
}
