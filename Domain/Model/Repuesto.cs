namespace Domain.Model
{
    public class Repuesto
    {
        public int idRepuesto { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public float importeCompra { get; set; }
        public float importeVenta { get; set; }
        public int VentaID { get; set; }
        public Venta Venta { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}