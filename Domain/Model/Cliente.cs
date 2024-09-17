using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Domain.Model
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string cuitCuil { get; set; }
        public string razonSocial { get; set; }
        public string domicilio { get; set; }
        public string localidad { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public ICollection<Venta> Venta { get; set; }
        public ICollection<Servicio> Servicio { get; set; }
    }
}