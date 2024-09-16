using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Domain.Model
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string razonSocial { get; set; }
        public PhoneAttribute telefono { get; set; }
        public MailAddress mail { get; set; }
        public Repuesto repusto { get; set; }
    }
}