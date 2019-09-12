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
    public partial class frmListarMarcas : Form
    {
        public frmListarMarcas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmListarMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                dgvListaMarcas.DataSource = marcaNegocio.listarMarcas();
                dgvListaMarcas.Columns[0].HeaderText = "Código";
                dgvListaMarcas.Columns[1].HeaderText = "Descripción";
                dgvListaMarcas.Refresh();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Marca aux = new Marca();
            try
            {
                if(dgvListaMarcas.Rows.Count > 0)
                {
                    aux.codigo = (Int32)dgvListaMarcas.SelectedRows[0].Cells[0].Value;
                    aux.descripcion = dgvListaMarcas.SelectedRows[0].Cells[1].Value.ToString();

                    DialogResult confirmation = MessageBox.Show("Seguro que querés eliminar la marca " + aux.codigo + ", \"" + aux.descripcion + "\"?", "Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (confirmation == DialogResult.Yes)
                    {
                        MarcaNegocio marcaNegocio = new MarcaNegocio();
                        if (marcaNegocio.bajaMarca(aux) == false)
                        {
                            MessageBox.Show("Hubo problemas al eliminar la marca.");
                        }
                        else
                        {
                            dgvListaMarcas.DataSource = marcaNegocio.listarMarcas();
                            MessageBox.Show("Se eliminó la marca " + aux.codigo + ", \"" + aux.descripcion + "\"");
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
            Marca aux = new Marca();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                if(dgvListaMarcas.Rows.Count > 0)
                {
                    aux.codigo = (Int32)dgvListaMarcas.SelectedRows[0].Cells[0].Value;
                    aux.descripcion = dgvListaMarcas.SelectedRows[0].Cells[1].Value.ToString();

                    frmModificacionMarca modificar = new frmModificacionMarca();

                    for (int i = 0; i < Application.OpenForms.Count; i++)
                    {
                        if (Application.OpenForms[i].GetType() == typeof(frmMain))
                        {
                            modificar.MdiParent = Application.OpenForms[i];
                        }
                    }
                    modificar.putInfo(aux, dgvListaMarcas);
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
