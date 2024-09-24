using System.Net.Mail;

namespace Domain.Model
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }
        public string mail { get; set; }
        public DateTime fechaIngreso { get; set; }
        public ICollection<Servicio> Servicio { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
    }
}