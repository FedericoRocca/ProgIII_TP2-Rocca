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
    public partial class frmAltaMarca : Form
    {
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Marca marca = new Marca();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                marca.descripcion = txbDescripcion.Text;
                if(marcaNegocio.altaMarcaDB(marca) == true)
                {
                    MessageBox.Show("Marca dada de alta de manera correcta.");
                    this.Dispose();
                }
                else MessageBox.Show("No se dió de alta la marca.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
