using Domain.Model;

namespace Domain.Services
{
    public class AccesorioService
    {
        public void Add(Accesorio accesorio)
        {
            using var context = new PaunyDBContext();

            context.Accesorios.Add(accesorio);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PaunyDBContext();

            Accesorio? accesorioToDelete = context.Accesorios.Find(id);

            if (accesorioToDelete != null)
            {
                context.Accesorios.Remove(accesorioToDelete);
                context.SaveChanges();
            }
        }

        public Accesorio? Get(int id)
        {
            using var context = new PaunyDBContext();

            return context.Accesorios.Find(id);
        }

        public IEnumerable<Accesorio> GetAll()
        {
            using var context = new PaunyDBContext();

            return context.Accesorios.ToList();
        }

        public void Update(Accesorio accesorio)
        {
            using var context = new PaunyDBContext();

            Accesorio? accesorioToUpdate = context.Accesorios.Find(accesorio.idAccesorio);

            if (accesorioToUpdate != null)
            {
                accesorioToUpdate.descripcion = accesorio.descripcion;
                context.SaveChanges();
            }
        }
    }
}
