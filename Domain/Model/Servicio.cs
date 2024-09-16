namespace Domain.Model
{
    public class Servicio
    {
        public int idServicio { get; set; }
        public string nroChasis { get; set; }
        public string descripcion { get; set; }
        public float costo { get; set; }
        public float importeTotal { get; set; }
        public List<Empleado> empleados { get; set; }
        public List<Cliente> cliente { get; set; }
        public Servicio()
        {
            empleados = new List<Empleado>();
            cliente = new List<Cliente>();
        }
    }
}