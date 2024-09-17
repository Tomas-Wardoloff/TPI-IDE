namespace Domain.Model
{
    public class Venta
    {
        public int idVenta { get; set; }
        public DateTime fecha { get; set; }
        public float importeTotal { get; set; }
        public string estado { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Maquinaria> Maquinaria { get; set; }
        public ICollection<Repuesto> Repuesto { get; set; }
    }
}