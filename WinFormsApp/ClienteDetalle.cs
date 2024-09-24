using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ClienteDetalle : Form
    {
        private Cliente cliente;
        public bool EditMode { get; set; }
        public Cliente Cliente
        {
            get { return cliente; }
            set
            {
                cliente = value;
                this.SetCliente();
            }
        }
        public ClienteDetalle()
        {
            InitializeComponent();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            ClienteApiClient client = new ClienteApiClient();

            if (this.ValidateCliente()) 
            {
                this.Cliente.cuitCuil = this.cuitCuilTextBox.Text;
                this.Cliente.razonSocial = this.razonSocialTextBox.Text;
                this.Cliente.domicilio = this.domicilioTextBox.Text;
                this.Cliente.localidad = this.localidadTextBox.Text;
                this.Cliente.mail = this.mailTextBox.Text;
                this.Cliente.telefono = this.telefonoTextBox.Text;

                if (this.EditMode)
                {
                    await ClienteApiClient.UpdateAsync(this.Cliente);
                }
                else
                {
                    await ClienteApiClient.AddAsync(this.Cliente);
                }
                
                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetCliente()
        {
            this.cuitCuilTextBox.Text = cliente.cuitCuil;
            this.razonSocialTextBox.Text = cliente.razonSocial;
            this.domicilioTextBox.Text = cliente.domicilio;
            this.localidadTextBox.Text = cliente.localidad;
            this.mailTextBox.Text = cliente.mail;
            this.telefonoTextBox.Text = cliente.telefono;
        }

        private bool ValidateCliente()
        {
            bool isValid = true;

            errorProvider.SetError(cuitCuilTextBox, string.Empty);
            errorProvider.SetError(razonSocialTextBox, string.Empty);
            errorProvider.SetError(domicilioTextBox, string.Empty);
            errorProvider.SetError(localidadTextBox, string.Empty);
            errorProvider.SetError(mailTextBox, string.Empty); // chequear que tenga formato de mail
            errorProvider.SetError(telefonoTextBox, string.Empty); // chequear que tenga formato de telefono

            if (this.cuitCuilTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(cuitCuilTextBox, "El campo CUIT/CUIL es obligatorio");
            }
            else if (this.razonSocialTextBox.Text == string.Empty) {
                isValid = false;    
                errorProvider.SetError(razonSocialTextBox, "El campo Razón Social es obligatorio");
            }
            else if (this.domicilioTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(domicilioTextBox, "El campo Domicilio es obligatorio");
            }
            else if (this.localidadTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(localidadTextBox, "El campo Localidad es obligatorio");
            }
            else if (this.mailTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(mailTextBox, "El campo Mail es obligatorio");
            }
            else if (this.telefonoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(telefonoTextBox, "El campo Telefono es obligatorio");
            }


            return isValid;
        }
    }
}
