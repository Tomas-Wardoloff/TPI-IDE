using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Domain.Model
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string razonSocial { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public Repuesto Repuesto { get; set; }
        public int RepuestoID { get; set; }
    }
}