namespace Domain.Model
{
    public class Accesorio
    {
        public int idAccesorio { get; set; }
        public string descripcion { get; set; }
        public float importeCompra { get; set; }
        public float importeVenta { get; set; }
        public int stock { get; set; }

        public Maquinaria maquinaria { get; set; }
    }
}
