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
    }
}
