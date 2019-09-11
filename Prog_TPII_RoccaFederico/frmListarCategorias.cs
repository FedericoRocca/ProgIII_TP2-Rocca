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
    }
}
