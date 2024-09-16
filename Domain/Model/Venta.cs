namespace Domain.Model
{
    public class Venta
    {
        public int idVenta { get; set; }
        public DateTime fecha { get; set; }
        public float importeTotal { get; set; }
        public string estado { get; set; }
        public List<Maquinaria> maquinarias { get; set; }
        public List<Repuesto> repuestos { get; set; }
        public Cliente cliente { get; set; }
        public Venta()
        {
            maquinarias = new List<Maquinaria>();
            repuestos = new List<Repuesto>();
        }
    }
}