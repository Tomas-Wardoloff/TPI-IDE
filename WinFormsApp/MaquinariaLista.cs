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
    public partial class MaquinariaLista : Form
    {
        public MaquinariaLista()
        {
            InitializeComponent();
        }

        private void MaquinariaLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            MaquinariaApiClient client = new MaquinariaApiClient();

            this.maquinariaDataGridView.DataSource = null;
            this.maquinariaDataGridView.DataSource = await MaquinariaApiClient.GetAllAsync();

            if (this.maquinariaDataGridView.Rows.Count > 0)
            {
                this.maquinariaDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }
        private Maquinaria SelectedItem()
        {
            Maquinaria maquinaria;

            maquinaria = (Maquinaria)maquinariaDataGridView.SelectedRows[0].DataBoundItem;

            return maquinaria;
        }
        private void agregarButton_Click(object sender, EventArgs e)
        {
            MaquinariaDetalle maquinariaDetalle = new MaquinariaDetalle();

            Maquinaria maquinariaNuevo = new Maquinaria();

            maquinariaDetalle.Maquinaria = maquinariaNuevo;

            maquinariaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int idMaquinaria;

            idMaquinaria = this.SelectedItem().idMaquinaria;
            await MaquinariaApiClient.DeleteAsync(idMaquinaria);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            MaquinariaDetalle maquinariaDetalle = new MaquinariaDetalle();

            int idMaquinaria;

            idMaquinaria = this.SelectedItem().idMaquinaria;

            Maquinaria maquinaria = await MaquinariaApiClient.GetAsync(idMaquinaria);

            maquinariaDetalle.EditMode = true;
            maquinariaDetalle.Maquinaria = maquinaria;

            maquinariaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }
    }
}
