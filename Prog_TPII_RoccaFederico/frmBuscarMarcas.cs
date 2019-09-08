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
    }
}
