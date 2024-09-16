namespace Domain.Model
{
    public class Repuesto
    {
        public int idRepuesto { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public float importeCompra { get; set; }
        public float importeVenta { get; set; }
        public Venta venta { get; set; }
        public Proveedor proveedor { get; set; }
    }
}