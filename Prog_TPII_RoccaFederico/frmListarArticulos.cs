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
    public partial class frmListarArticulos : Form
    {
        public frmListarArticulos()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmListarArticulos_Load(object sender, EventArgs e)
        {
            try
            {

                ArticuloNegocio artNegocio = new ArticuloNegocio();
                dgvListaArticulos.DataSource = artNegocio.listarArticulos();
                dgvListaArticulos.Columns[0].Visible = false;
                dgvListaArticulos.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Articulo registro = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                if (dgvListaArticulos.RowCount > 0)
                {
                    registro = (Articulo)dgvListaArticulos.SelectedRows[0].DataBoundItem;

                    DialogResult confirmation = MessageBox.Show("Seguro que querés eliminar el articulo " + registro.codigo + ", \""
                        + registro.nombre + ", \"" + registro.descripcion + "\"?",
                        "Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.Yes)
                    {
                        if (articuloNegocio.bajaArticulo(registro) == true)
                        {
                            MessageBox.Show("Se dio de baja el artículo.");
                            dgvListaArticulos.DataSource = articuloNegocio.listarArticulos();
                        }
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

                ArticuloNegocio articuloNegocio = new ArticuloNegocio();

                if (dgvListaArticulos.RowCount > 0)
                {
                    bool isModificarArticuloOpen = false;
                    for (int i = 0; i < Application.OpenForms.Count; i++)
                    {
                        if (Application.OpenForms[i].GetType() == typeof(frmAltaArticulos))
                        {
                            isModificarArticuloOpen = true;
                        }
                    }

                    if (!isModificarArticuloOpen)
                    {
                        frmAltaArticulos frmModificar = new frmAltaArticulos((Articulo)dgvListaArticulos.CurrentRow.DataBoundItem, dgvListaArticulos);
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
