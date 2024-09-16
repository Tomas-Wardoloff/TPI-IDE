namespace Domain.Model
{
    public class Departamento
    {
        public int idDepartamento { get; set; }
        public string nombre { get; set; }
        public List<Empleado> empleados { get; set; }
        public Departamento()
        {
            empleados = new List<Empleado>();
        }
    }
}