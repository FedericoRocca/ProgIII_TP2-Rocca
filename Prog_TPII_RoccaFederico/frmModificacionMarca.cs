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
    public partial class frmModificacionMarca : Form
    {

        Marca aux = new Marca();
        DataGridView dgvaux = new DataGridView();

        public frmModificacionMarca()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void putInfo(Marca _aux, DataGridView _dgv)
        {
            aux = _aux;
            dgvaux = _dgv;
        }

        private void frmModificacionMarca_Load(object sender, EventArgs e)
        {
            txbDescripcion.Text = aux.descripcion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                Validator.validate(aux, txbDescripcion.Text);
                if (marcaNegocio.modificarMarca(aux, txbDescripcion.Text) == false)
                {
                    MessageBox.Show("Hubo un error al modificar la marca.");
                }
                else
                {
                    dgvaux.DataSource = marcaNegocio.listarMarcas();
                    dgvaux.Refresh();
                    MessageBox.Show("Se modificó la marca correctamente.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
