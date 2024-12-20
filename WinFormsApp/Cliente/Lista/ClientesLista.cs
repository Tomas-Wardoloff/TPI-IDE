using Domain.Model;

namespace WinFormsApp
{
    public partial class ClientesLista : Form
    {
        public ClientesLista()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int idCliente;

            idCliente = this.SelectedItem().idCliente;
            await ClienteApiClient.DeleteAsync(idCliente);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            ClienteDetalle clienteDetalle = new ClienteDetalle();

            int idCliente;

            idCliente = this.SelectedItem().idCliente;

            Cliente cliente = await ClienteApiClient.GetAsync(idCliente);

            clienteDetalle.EditMode = true;
            clienteDetalle.Cliente = cliente;

            clienteDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            ClienteDetalle clienteDetalle = new ClienteDetalle();

            Cliente clienteNuevo = new Cliente();

            clienteDetalle.Cliente = clienteNuevo;

            clienteDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            ClienteApiClient client = new ClienteApiClient();

            this.clientesDataGridView.DataSource = null;
            this.clientesDataGridView.DataSource = await ClienteApiClient.GetAllAsync();
            this.clientesDataGridView.Columns["Venta"].Visible = false;
            this.clientesDataGridView.Columns["Servicio"].Visible = false;

            if (this.clientesDataGridView.Rows.Count > 0)
            {
                this.clientesDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Cliente SelectedItem()
        {
            Cliente cliente;

            cliente = (Cliente)clientesDataGridView.SelectedRows[0].DataBoundItem;

            return cliente;
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
