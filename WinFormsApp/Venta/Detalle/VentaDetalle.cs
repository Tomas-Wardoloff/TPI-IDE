using Domain.Model;
using Domain;
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
    public partial class VentaDetalle : Form
    {
        private Venta venta;
        public bool EditMode { get; set; }
        public Venta Venta
        {
            get { return venta; }
            set
            {
                venta = value;
                this.SetVenta();
            }
        }
        public VentaDetalle()
        {
            InitializeComponent();
        }
        private async Task CargarDatos()
        {
            using (var context = new PaunyDBContext())
            {
                // Obtener lista de clientes (para el ComboBox)
                var clientes = await context.Clientes
                                            .Select(c => new { c.idCliente, c.razonSocial })
                                            .ToListAsync();

                // Obtener lista de maquinaria (para el CheckedListBox)
                var maquinaria = await context.Maquinarias
                                              .Select(m => new { m.idMaquinaria, m.modelo })
                                              .ToListAsync();

                // Obtener lista de repuestos (para el CheckedListBox)
                var repuestos = await context.Repuestos
                                             .Select(r => new { r.idRepuesto, r.descripcion })
                                             .ToListAsync();

                // Llenar ComboBox de clientes
                clienteComboBox.DataSource = clientes;
                clienteComboBox.DisplayMember = "Nombre"; // Lo que se va a mostrar en el ComboBox
                clienteComboBox.ValueMember = "IdCliente"; // El valor que se va a guardar

                // Llenar CheckedListBox de maquinaria
                maquinariaCheckedListBox.DataSource = maquinaria;
                maquinariaCheckedListBox.DisplayMember = "Modelo";
                maquinariaCheckedListBox.ValueMember = "IdMaquinaria";

                // Llenar CheckedListBox de repuestos
                repuestoCheckedListBox.DataSource = repuestos;
                repuestoCheckedListBox.DisplayMember = "Descripcion";
                repuestoCheckedListBox.ValueMember = "IdRepuesto";
            }
        }
        private async void VentaDetalle_Load(object sender, EventArgs e) 
        {
            await CargarDatos();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            VentaApiClient client = new VentaApiClient();

            if (this.ValidateVenta())
            {
                this.Venta.fecha = Convert.ToDateTime(this.fechaTextBox.Text);
                this.Venta.importeTotal = Convert.ToSingle(this.importeTotalTextBox.Text);
                this.Venta.estado = this.estadoTextBox.Text;

                var clienteSeleccionado = (int)clienteComboBox.SelectedValue;

                // Maquinarias seleccionadas
                var maquinariaSeleccionada = maquinariaCheckedListBox.CheckedItems.Cast<dynamic>()
                    .Select(item => item.IdMaquinaria)
                    .ToList();

                // Repuestos seleccionados
                var repuestosSeleccionados = repuestoCheckedListBox.CheckedItems.Cast<dynamic>()
                    .Select(item => item.IdRepuesto)
                    .ToList();

                if (this.EditMode)
                {
                    await VentaApiClient.UpdateAsync(this.Venta);
                }
                else
                {
                    await VentaApiClient.AddAsync(this.Venta);
                }

                this.Close();
            }
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetVenta()
        {
            this.fechaTextBox.Text = venta.fecha.ToString("yyyy-MM-dd");
            this.importeTotalTextBox.Text = venta.importeTotal.ToString();
            this.estadoTextBox.Text = venta.estado;
            this.clienteComboBox.SelectedValue = venta.ClienteId;
            foreach (var idMaquinaria in venta.Maquinaria)
            {
                for (int i = 0; i < maquinariaCheckedListBox.Items.Count; i++)
                {
                    var item = maquinariaCheckedListBox.Items[i];
                    if (((dynamic)item).IdMaquinaria == idMaquinaria)
                    {
                        maquinariaCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            foreach (var idRepuesto in venta.Repuesto)
            {
                for (int i = 0; i < repuestoCheckedListBox.Items.Count; i++)
                {
                    var item = repuestoCheckedListBox.Items[i];
                    if (((dynamic)item).IdRepuesto == idRepuesto)
                    {
                        repuestoCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
        }
        private bool ValidateVenta()
        {
            bool isValid = true;

            errorProvider.SetError(fechaTextBox, string.Empty);
            errorProvider.SetError(importeTotalTextBox, string.Empty);
            errorProvider.SetError(estadoTextBox, string.Empty);
            errorProvider.SetError(clienteComboBox, string.Empty);
            errorProvider.SetError(maquinariaCheckedListBox, string.Empty);  
            errorProvider.SetError(repuestoCheckedListBox, string.Empty);

            if (this.fechaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(fechaTextBox, "El campo Fecha es obligatorio");
            }
            else if (!IsValidDate(this.fechaTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(fechaTextBox, "La fecha ingresada no es válida");
            }

            else if (this.importeTotalTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(importeTotalTextBox, "El campo Importe Total es obligatorio");
            }
            else if (!IsValidAmount(this.importeTotalTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(importeTotalTextBox, "El importe ingresado no es válido");
            }
            else if (this.estadoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(estadoTextBox, "El campo Estado es obligatorio");
            }
            if (this.clienteComboBox.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(clienteComboBox, "Debe seleccionar un Cliente");
            }
            if (maquinariaCheckedListBox.CheckedItems.Count == 0)
            {
                isValid = false;
                errorProvider.SetError(maquinariaCheckedListBox, "Debe seleccionar al menos una Maquinaria");
            }
            if (maquinariaCheckedListBox.CheckedItems.Count == 0)
            {
                isValid = false;
                errorProvider.SetError(maquinariaCheckedListBox, "Debe seleccionar al menos una Maquinaria");
            }

            return isValid;
        }
        // Método para validar el formato de fecha
        private bool IsValidDate(string dateText)
        {
            return DateTime.TryParse(dateText, out _);
        }
        // Método para validar el formato de importe
        private bool IsValidAmount(string amountText)
        {
            return float.TryParse(amountText, out _);
        }

    }
}
