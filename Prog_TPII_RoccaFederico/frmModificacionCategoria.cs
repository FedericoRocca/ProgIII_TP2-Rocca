using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Prog_TPII_RoccaFederico
{
    public partial class frmModificacionCategoria : Form
    {

        Categoria aux = new Categoria();
        DataGridView dgvAux = new DataGridView();

        public frmModificacionCategoria()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                if (categoriaNegocio.modificarCategoria(aux, txbDescripcion.Text) == false)
                {
                    MessageBox.Show("Hubo un error al modificar la categoría.");
                }
                else
                {
                    dgvAux.DataSource = categoriaNegocio.listarCategorias();
                    dgvAux.Refresh();
                    MessageBox.Show("Se modificó la categoría correctamente.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void putInfo(Categoria _aux, DataGridView _dgv)
        {
            aux = _aux;
            dgvAux = _dgv;
        }
    }
}
