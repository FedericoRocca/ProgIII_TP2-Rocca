using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Prog_TPII_RoccaFederico
{
    public partial class frmBuscarArticulo : Form
    {
        public frmBuscarArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo registro = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                registro = (Articulo)dgvResultados.SelectedRows[0].DataBoundItem;

                DialogResult confirmation = MessageBox.Show("Seguro que querés eliminar el articulo " + registro.codigo + ", \""
                    + registro.nombre + ", \"" + registro.descripcion + "\"?",
                    "Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (confirmation == DialogResult.Yes)
                {
                    if (articuloNegocio.bajaArticulo(registro) == true)
                    {
                        MessageBox.Show("Se dio de baja el artículo.");
                        dgvResultados.DataSource = articuloNegocio.listarArticulos();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                bool isModificarArticuloOpen = false;
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].GetType() == typeof(frmAltaArticulos))
                    {
                        isModificarArticuloOpen = true;
                    }
                }

                if (!isModificarArticuloOpen && dgvResultados.RowCount > 0)
                {
                    frmAltaArticulos frmModificar = new frmAltaArticulos((Articulo)dgvResultados.CurrentRow.DataBoundItem);
                    for (int i = 0; i < Application.OpenForms.Count; i++)
                    {
                        if (Application.OpenForms[i].GetType() == typeof(frmMain))
                        {
                            frmModificar.MdiParent = Application.OpenForms[i];
                        }
                    }
                    frmModificar.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {

                List<Articulo> resultados = new List<Articulo>();
                resultados = articuloNegocio.BuscarArticulos(txbArticuloaBuscar.Text);

                if (resultados.Count <= 0)
                {
                    dgvResultados.DataSource = null;
                    MessageBox.Show("Sin resultados para la busqueda");
                }
                else
                {
                    dgvResultados.DataSource = resultados;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
