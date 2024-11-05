using Domain.Model;

namespace Domain.Services
{
    public class MaquinariaService
    {
        public void Add(Maquinaria maquinaria)
        {
            using var context = new PaunyDBContext();

            context.Maquinarias.Add(maquinaria);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PaunyDBContext();

            Maquinaria? maquinariaToDelete = context.Maquinarias.Find(id);

            if (maquinariaToDelete != null)
            {
                context.Maquinarias.Remove(maquinariaToDelete);
                context.SaveChanges();
            }
        }

        public Maquinaria? Get(int id)
        {
            using var context = new PaunyDBContext();

            return context.Maquinarias.Find(id);
        }

        public IEnumerable<Maquinaria> GetAll()
        {
            using var context = new PaunyDBContext();

            return context.Maquinarias.ToList();
        }

        public void Update(Maquinaria maquinaria)
        {
            using var context = new PaunyDBContext();

            Maquinaria? maquinariaToUpdate = context.Maquinarias.Find(maquinaria.idMaquinaria);

            if (maquinariaToUpdate != null)
            {
                maquinariaToUpdate.modelo = maquinaria.modelo;
                maquinariaToUpdate.importeCompra = maquinaria.importeCompra;
                maquinariaToUpdate.importeVenta = maquinaria.importeVenta;
                maquinariaToUpdate.VentaID = maquinaria.VentaID;

                context.SaveChanges();
            }
        }
    }
}
