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
    public partial class frmBuscarCategoria : Form
    {
        public frmBuscarCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {

                List<Categoria> resultados = new List<Categoria>();
                resultados = categoriaNegocio.BuscarCategorias(txbCategoriaaBuscar.Text);

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
