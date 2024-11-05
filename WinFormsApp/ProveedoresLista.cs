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
    public partial class ProveedoresLista : Form
    {
        public ProveedoresLista()
        {
            InitializeComponent();
        }
        private void Proveedors_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int idProveedor;

            idProveedor = this.SelectedItem().idProveedor;
            await ProveedorApiClient.DeleteAsync(idProveedor);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            ProveedorDetalle proveedorDetalle = new ProveedorDetalle();

            int idProveedor;

            idProveedor = this.SelectedItem().idProveedor;

            Proveedor proveedor = await ProveedorApiClient.GetAsync(idProveedor);

            proveedorDetalle.EditMode = true;
            proveedorDetalle.Proveedor = proveedor;

            proveedorDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            ProveedorDetalle proveedorDetalle = new ProveedorDetalle();

            Proveedor proveedorNuevo = new Proveedor();

            proveedorDetalle.Proveedor = proveedorNuevo;

            proveedorDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            ProveedorApiClient client = new ProveedorApiClient();

            this.proveedoresDataGridView.DataSource = null;
            this.proveedoresDataGridView.DataSource = await ProveedorApiClient.GetAllAsync();

            if (this.proveedoresDataGridView.Rows.Count > 0)
            {
                this.proveedoresDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Proveedor SelectedItem()
        {
            Proveedor proveedor;

            proveedor = (Proveedor)proveedoresDataGridView.SelectedRows[0].DataBoundItem;

            return proveedor;
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
