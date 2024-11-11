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
    public partial class VentaLista : Form
    {
        public VentaLista()
        {
            InitializeComponent();
        }
        private void VentaLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            VentaApiClient client = new VentaApiClient();

            this.ventasDataGridView.DataSource = null;
            this.ventasDataGridView.DataSource = await ClienteApiClient.GetAllAsync();
            this.ventasDataGridView.Columns["Venta"].Visible = false;
            this.ventasDataGridView.Columns["Servicio"].Visible = false;

            if (this.ventasDataGridView.Rows.Count > 0)
            {
                this.ventasDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Venta SelectedItem()
        {
            Venta venta;

            venta = (Venta)ventasDataGridView.SelectedRows[0].DataBoundItem;

            return venta;
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int idVenta;

            idVenta = this.SelectedItem().idVenta;
            await VentaApiClient.DeleteAsync(idVenta);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            VentaDetalle ventaDetalle = new VentaDetalle();

            int idVenta;

            idVenta = this.SelectedItem().idVenta;

            Venta venta = await VentaApiClient.GetAsync(idVenta);

            ventaDetalle.EditMode = true;
            ventaDetalle.Venta = venta;

            ventaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            VentaDetalle ventaDetalle = new VentaDetalle();

            Venta ventaNuevo = new Venta();

            ventaDetalle.Venta = ventaNuevo;

            ventaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }
    }
}
