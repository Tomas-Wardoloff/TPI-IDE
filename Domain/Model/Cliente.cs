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
        public MailAddress mail { get; set; }
        public PhoneAttribute telefono { get; set; }
        public List<Venta> ventas { get; set; }
        public Cliente()
        {
            ventas = new List<Venta>();
        }
    }
}