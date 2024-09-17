namespace Domain.Model
{
    public class Maquinaria
    {
        public int idMaquinaria { get; set; }
        public string modelo { get; set; }
        public string nroChasis { get; set; }
        public float importeCompra { get; set; }
        public float importeVenta { get; set; }
        public string tipo { get; set; }
        public int VentaID { get; set; }
        public Venta Venta { get; set; }
        public ICollection<Accesorio> Accesorio { get; set; }
    }
}