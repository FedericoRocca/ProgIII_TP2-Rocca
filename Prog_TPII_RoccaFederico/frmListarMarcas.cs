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
    }
}
