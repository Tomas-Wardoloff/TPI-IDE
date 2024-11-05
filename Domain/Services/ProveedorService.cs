using Domain.Model;

namespace Domain.Services
{
    public class ProveedorService
    {
        public void Add(Proveedor proveedor)
        {
            using var context = new PaunyDBContext();

            context.Proveedores.Add(proveedor);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PaunyDBContext();

            Proveedor? proveedorToDelete = context.Proveedores.Find(id);

            if (proveedorToDelete != null)
            {
                context.Proveedores.Remove(proveedorToDelete);
                context.SaveChanges();
            }
        }

        public Proveedor? Get(int id)
        {
            using var context = new PaunyDBContext();

            return context.Proveedores.Find(id);
        }

        public IEnumerable<Proveedor> GetAll()
        {
            using var context = new PaunyDBContext();

            return context.Proveedores.ToList();
        }

        public void Update(Proveedor proveedor)
        {
            using var context = new PaunyDBContext();

            Proveedor? proveedorToUpdate = context.Proveedores.Find(proveedor.idProveedor);

            if (proveedorToUpdate != null)
            {
                proveedorToUpdate.razonSocial = proveedor.razonSocial;
                proveedorToUpdate.mail = proveedor.mail;
                proveedorToUpdate.telefono = proveedor.telefono;
                proveedorToUpdate.RepuestoID = proveedor.RepuestoID;

                context.SaveChanges();
            }
        }
    }
}
