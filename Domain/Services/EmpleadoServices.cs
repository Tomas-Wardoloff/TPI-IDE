using Domain.Model;

namespace Domain.Services
{
    public class EmpleadoService
    {
        public void Add(Empleado empleado)
        {
            using var context = new PaunyDBContext();

            context.Empleados.Add(empleado);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PaunyDBContext();

            Empleado? empleadoToDelete = context.Empleados.Find(id);

            if (empleadoToDelete != null)
            {
                context.Empleados.Remove(empleadoToDelete);
                context.SaveChanges();
            }
        }

        public Empleado? Get(int id)
        {
            using var context = new PaunyDBContext();

            return context.Empleados.Find(id);
        }

        public IEnumerable<Empleado> GetAll()
        {
            using var context = new PaunyDBContext();

            return context.Empleados.ToList();
        }

        public void Update(Empleado empleado)
        {
            using var context = new PaunyDBContext();

            Empleado? empleadoToUpdate = context.Empleados.Find(empleado.idEmpleado);

            if (empleadoToUpdate != null)
            {
                empleadoToUpdate.dni = empleado.dni;
                empleadoToUpdate.nombre = empleado.nombre;
                empleadoToUpdate.apellido  = empleado.apellido;
                empleadoToUpdate.domicilio = empleado.domicilio;
                empleadoToUpdate.mail= empleado.mail;
                empleadoToUpdate.departamentoId = empleado.departamentoId;

                context.SaveChanges();
            }
        }
    }
}
