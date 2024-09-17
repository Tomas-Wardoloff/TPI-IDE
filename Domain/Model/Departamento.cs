namespace Domain.Model
{
    public class Departamento
    {
        public int idDepartamento { get; set; }
        public string nombre { get; set; }
        public ICollection<Empleado> Empleado { get; set; }
    }
}