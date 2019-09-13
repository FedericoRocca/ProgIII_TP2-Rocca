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
    public partial class frmListarCategorias : Form
    {
        public frmListarCategorias()
        {
            InitializeComponent();
        }

        private void frmListarCategorias_Load(object sender, EventArgs e)
        {

            CategoriaNegocio categorioNegocio = new CategoriaNegocio();

            try
            {
                dgvListaCategorias.DataSource = categorioNegocio.listarCategorias();
                dgvListaCategorias.Columns[0].HeaderText = "Código";
                dgvListaCategorias.Columns[1].HeaderText = "Descripción";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria aux = new Categoria();
            try
            {
                if(dgvListaCategorias.Rows.Count > 0)
                {
                    aux.codigo = (Int32)dgvListaCategorias.SelectedRows[0].Cells[0].Value;
                    aux.descripcion = dgvListaCategorias.SelectedRows[0].Cells[1].Value.ToString();
                    DialogResult confirmation = MessageBox.Show("Seguro que querés eliminar la categoría " + aux.codigo + ", \"" + aux.descripcion + "\"?", "Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (confirmation == DialogResult.Yes)
                    {
                        CategoriaNegocio catNegocio = new CategoriaNegocio();
                        if (catNegocio.bajaCategoría(aux) == false)
                        {
                            MessageBox.Show("Hubo problemas al eliminar la categoría");
                        }
                        else
                        {
                            dgvListaCategorias.DataSource = catNegocio.listarCategorias();
                            MessageBox.Show("Se eliminó la categoría " + aux.codigo + ", \"" + aux.descripcion + "\"");
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
            Categoria aux = new Categoria();
            CategoriaNegocio marcaNegocio = new CategoriaNegocio();
            try
            {
                if (dgvListaCategorias.Rows.Count > 0)
                {
                    bool isModifCategorioOpen = false;
                    for (int i = 0; i < Application.OpenForms.Count; i++)
                    {
                        if( Application.OpenForms[i].GetType() == typeof(frmModificacionCategoria) )
                        {
                            isModifCategorioOpen = true;
                        }
                    }

                    if( !isModifCategorioOpen )
                    {
                        aux.codigo = (Int32)dgvListaCategorias.SelectedRows[0].Cells[0].Value;
                        aux.descripcion = dgvListaCategorias.SelectedRows[0].Cells[1].Value.ToString();

                        frmModificacionCategoria modificar = new frmModificacionCategoria();

                        for (int i = 0; i < Application.OpenForms.Count; i++)
                        {
                            if (Application.OpenForms[i].GetType() == typeof(frmMain))
                            {
                                modificar.MdiParent = Application.OpenForms[i];
                            }
                        }
                        modificar.putInfo(aux, dgvListaCategorias);
                        modificar.Show();
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
