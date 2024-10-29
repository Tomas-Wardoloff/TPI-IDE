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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesLista menuClientes = new ClientesLista();
            menuClientes.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaLista menuVentas = new VentaLista();
            menuVentas.Show();
        }
    }
}
