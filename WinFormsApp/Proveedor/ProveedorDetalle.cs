using Domain;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
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
    public partial class ProveedorDetalle : Form
    {
        private Proveedor proveedor;
        public bool EditMode { get; set; }
        public Proveedor Proveedor
        {
            get { return proveedor; }
            set
            {
                proveedor = value;
                this.SetProveedor();
            }
        }
        public ProveedorDetalle()
        {
            InitializeComponent();
        }
        private async void ProveedorDetalle_Load(object sender, EventArgs e)
        {
            await CargarRepuestos();
        }
        private async Task CargarRepuestos()
        {
            using (var context = new PaunyDBContext())
            {
                var repuestos = await context.Repuestos.ToListAsync();
                repuestoComboBox.DataSource = repuestos;
                repuestoComboBox.DisplayMember = "Descripcion";  
                repuestoComboBox.ValueMember = "IdRepuesto";    
            }
        }


        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            ProveedorApiClient client = new ProveedorApiClient();

            if (this.ValidateProveedor())
            {
                this.Proveedor.razonSocial = this.razonSocialTextBox.Text;
                this.Proveedor.mail = this.mailTextBox.Text;
                this.Proveedor.telefono = this.telefonoTextBox.Text;
                var repuestoSeleccionado = (int)repuestoComboBox.SelectedValue;

                if (this.EditMode)
                {
                    await ProveedorApiClient.UpdateAsync(this.Proveedor);
                }
                else
                {
                    await ProveedorApiClient.AddAsync(this.Proveedor);
                }

                this.Close();
            }
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetProveedor()
        {
            this.razonSocialTextBox.Text = proveedor.razonSocial;
            this.mailTextBox.Text = proveedor.mail;
            this.telefonoTextBox.Text = proveedor.telefono;
            this.repuestoComboBox.SelectedValue = proveedor.Repuesto;
        }
        private bool ValidateProveedor()
        {
            bool isValid = true;

            errorProvider.SetError(razonSocialTextBox, string.Empty);
            errorProvider.SetError(mailTextBox, string.Empty); // chequear que tenga formato de mail
            errorProvider.SetError(telefonoTextBox, string.Empty); // chequear que tenga formato de telefono
            errorProvider.SetError(repuestoComboBox, string.Empty);

            if (this.razonSocialTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(razonSocialTextBox, "El campo Razón Social es obligatorio");
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
            if (this.repuestoComboBox.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(repuestoComboBox, "Debe seleccionar un Repuesto");
            }

            return isValid;
        }

        
    }
}
