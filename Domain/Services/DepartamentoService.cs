using Domain.Model;

namespace Domain.Services
{
    public class DepartamentoService
    {
        public void Add(Departamento departamento)
        {
            using var context = new PaunyDBContext();

            context.Departamentos.Add(departamento);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PaunyDBContext();

            Departamento? departamentoToDelete = context.Departamentos.Find(id);

            if (departamentoToDelete != null)
            {
                context.Departamentos.Remove(departamentoToDelete);
                context.SaveChanges();
            }
        }

        public Departamento? Get(int id)
        {
            using var context = new PaunyDBContext();

            return context.Departamentos.Find(id);
        }

        public IEnumerable<Departamento> GetAll()
        {
            using var context = new PaunyDBContext();

            return context.Departamentos.ToList();
        }

        public void Update(Departamento departamento)
        {
            using var context = new PaunyDBContext();

            Departamento? departamentoToUpdate = context.Departamentos.Find(departamento.idDepartamento);

            if (departamentoToUpdate != null)
            {
                departamentoToUpdate.nombre = departamento.nombre;
                context.SaveChanges();
            }
        }
    }
}
