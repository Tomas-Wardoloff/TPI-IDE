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
    public partial class MaquinariaDetalle : Form
    {
        private Maquinaria maquinaria;
        public bool EditMode { get; set; }
        public Maquinaria Maquinaria
        {
            get { return maquinaria; }
            set
            {
                maquinaria = value;
                this.SetMaquinaria();
            }
        }
        public MaquinariaDetalle()
        {
            InitializeComponent();
        }

        private async void MaquinariaDetalle_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }
        private async Task CargarDatos()
        {
            using (var context = new PaunyDBContext())
            {
                var ventas = await context.Ventas.ToListAsync();
                ventaComboBox.DataSource = ventas;
                ventaComboBox.DisplayMember = "fecha"; //revisar esto, como muestro una venta relacionada? malisimo
                ventaComboBox.ValueMember = "idVenta";

                var accesorios = await context.Accesorios
                                             .Select(a => new { a.idAccesorio, a.descripcion })
                                             .ToListAsync();
                accesorioCheckedListBox.DataSource = accesorios;
                accesorioCheckedListBox.DisplayMember = "descripcion";
                accesorioCheckedListBox.ValueMember = "idAccesorio";
            }
        }
        private void SetMaquinaria()
        {
            this.modeloTextBox.Text = maquinaria.modelo;
            this.nroChasisTextBox.Text = maquinaria.nroChasis;
            this.importeCompraTextBox.Text = maquinaria.importeCompra.ToString();
            this.importeVentaTextBox.Text = maquinaria.importeVenta.ToString();
            this.tipoTextBox.Text = maquinaria.tipo;
            this.ventaComboBox.SelectedValue = maquinaria.Venta;
            foreach (var idAccesorio in maquinaria.Accesorio)
            {
                for (int i = 0; i < accesorioCheckedListBox.Items.Count; i++)
                {
                    var item = accesorioCheckedListBox.Items[i];
                    if (((dynamic)item).IdAccesorio == idAccesorio)
                    {
                        accesorioCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            MaquinariaApiClient client = new MaquinariaApiClient();

            if (this.ValidateMaquinaria())
            {
                this.Maquinaria.modelo = this.modeloTextBox.Text;
                this.Maquinaria.nroChasis = this.nroChasisTextBox.Text;
                this.Maquinaria.importeCompra = Convert.ToSingle(this.importeCompraTextBox.Text);
                this.Maquinaria.importeVenta = Convert.ToSingle(this.importeVentaTextBox.Text);
                this.Maquinaria.tipo = this.tipoTextBox.Text;
                var ventaSeleccionado = (int)ventaComboBox.SelectedValue;
                var accesoriosSeleccionados = accesorioCheckedListBox.CheckedItems.Cast<dynamic>()
                    .Select(item => item.idAccesorio)
                    .ToList();

                if (this.EditMode)
                {
                    await MaquinariaApiClient.UpdateAsync(this.Maquinaria);
                }
                else
                {
                    await MaquinariaApiClient.AddAsync(this.Maquinaria);
                }

                this.Close();
            }
        }
        private bool ValidateMaquinaria()
        {
            bool isValid = true;

            errorProvider.SetError(modeloTextBox, string.Empty);
            errorProvider.SetError(nroChasisTextBox, string.Empty);
            errorProvider.SetError(importeCompraTextBox, string.Empty);
            errorProvider.SetError(importeVentaTextBox, string.Empty);
            errorProvider.SetError(tipoTextBox, string.Empty);
            errorProvider.SetError(ventaComboBox, string.Empty);
            errorProvider.SetError(accesorioCheckedListBox, string.Empty);

            if (this.modeloTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(modeloTextBox, "El campo Modelo es obligatorio");
            }

            else if (this.nroChasisTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nroChasisTextBox, "El campo Numero de Chasis es obligatorio");
            }
            else if (this.importeCompraTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(importeCompraTextBox, "El campo Importe de Compra es obligatorio");
            }
            else if (!IsValidAmount(this.importeCompraTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(importeCompraTextBox, "El importe ingresado no es válido");
            }
            else if (this.importeVentaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(importeVentaTextBox, "El campo Importe de Venta es obligatorio");
            }
            else if (!IsValidAmount(this.importeVentaTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(importeVentaTextBox, "El importe ingresado no es válido");
            }
            else if (this.tipoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tipoTextBox, "El campo Tipo es obligatorio");
            }
            if (this.ventaComboBox.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(ventaComboBox, "Debe seleccionar una Venta");
            }
            if (accesorioCheckedListBox.CheckedItems.Count == 0)
            {
                isValid = false;
                errorProvider.SetError(accesorioCheckedListBox, "Debe seleccionar al menos un Accesorio");
            }

            return isValid;
        }
        private bool IsValidAmount(string amountText)
        {
            return float.TryParse(amountText, out _);
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
