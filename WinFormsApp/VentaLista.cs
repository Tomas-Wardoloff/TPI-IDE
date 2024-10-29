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
        private void Ventas_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            VentaApiClient client = new VentaApiClient();

            this.ventasDataGridView.DataSource = null;
            this.ventasDataGridView.DataSource = await ClienteApiClient.GetAllAsync();
            //this.ventasDataGridView.Columns["Venta"].Visible = false;
            //this.ventasDataGridView.Columns["Servicio"].Visible = false;

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
    }
}
