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
        public MailAddress mail { get; set; }
        public DateTime fechaIngreso { get; set; }
        public List<Servicio> servicios { get; set; }
        public Departamento departamento { get; set; }
        public Empleado()
        {
            servicios = new List<Servicio>();
        }
    }
}