using Domain.Model;

namespace Domain.Services
{
    public class ClienteService
    {
        public void Add(Cliente cliente)
        {
            using var context = new PaunyDBContext();

            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PaunyDBContext();

            Cliente? clienteToDelete = context.Clientes.Find(id);

            if (clienteToDelete != null)
            {
                context.Clientes.Remove(clienteToDelete);
                context.SaveChanges();
            }
        }

        public Cliente? Get(int id)
        {
            using var context = new PaunyDBContext();

            return context.Clientes.Find(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            using var context = new PaunyDBContext();

            return context.Clientes.ToList();
        }

        public void Update(Cliente cliente)
        {
            using var context = new PaunyDBContext();

            Cliente? clienteToUpdate = context.Clientes.Find(cliente.idCliente);

            if (clienteToUpdate != null)
            {
                clienteToUpdate.cuitCuil = cliente.cuitCuil;
                clienteToUpdate.razonSocial = cliente.razonSocial;
                clienteToUpdate.domicilio = cliente.domicilio;
                clienteToUpdate.localidad = cliente.localidad;
                clienteToUpdate.mail = cliente.mail;

                clienteToUpdate.telefono = cliente.telefono;
                context.SaveChanges();
            }
        }
    }
}