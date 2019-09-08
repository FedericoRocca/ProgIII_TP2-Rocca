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
    public partial class frmBuscarMarcas : Form
    {
        public frmBuscarMarcas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Marca> marca = new List<Marca>();
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                marca = marcaNegocio.buscarMarca(txbMarcaaBuscar.Text.ToString());
                
                if( marca.Count <= 0 )
                {
                    dgvResultados.DataSource = null;
                    MessageBox.Show("Sin resultados para la busqueda");
                }
                else
                {
                    dgvResultados.DataSource = marca;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Marca aux = new Marca();
            try
            {
                aux.codigo = (int)dgvResultados.SelectedRows[0].Cells[0].Value;
                aux.descripcion = dgvResultados.SelectedRows[0].Cells[1].Value.ToString();

                DialogResult confirmation = MessageBox.Show("Seguro que querés eliminar el registro " + aux.codigo + ", " + aux.descripcion + "?", "Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (confirmation == DialogResult.Yes)
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    if (marcaNegocio.bajaMarca(aux) == false)
                    {
                        MessageBox.Show("Hubo problemas al eliminar el registro.");
                    }
                    else
                    {
                        dgvResultados.DataSource = marcaNegocio.listarMarcas();
                        MessageBox.Show("Se eliminó el registro.");
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
            Marca aux = new Marca();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                if(dgvResultados.DisplayedColumnCount(true) > 0)
                {
                    aux.codigo = (int)dgvResultados.SelectedRows[0].Cells[0].Value;
                    aux.descripcion = dgvResultados.SelectedRows[0].Cells[1].Value.ToString();

                    frmModificacionMarca modificar = new frmModificacionMarca();

                    for (int i = 0; i < Application.OpenForms.Count; i++)
                    {
                        if (Application.OpenForms[i].GetType() == typeof(frmMain))
                        {
                            modificar.MdiParent = Application.OpenForms[i];
                        }
                    }
                    modificar.putInfo(aux, dgvResultados);
                    modificar.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
