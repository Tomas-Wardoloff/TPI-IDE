namespace Domain.Model
{
    public class Servicio
    {
        public int idServicio { get; set; }
        public string nroChasis { get; set; }
        public string descripcion { get; set; }
        public float costo { get; set; }
        public float importeTotal { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Empleado> Empleado { get; set; }
    }
}