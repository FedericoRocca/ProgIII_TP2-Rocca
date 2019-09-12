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
    public partial class frmAltaCategoria : Form
    {
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                Categoria reg = new Categoria();
                reg.descripcion = txbDescripcion.Text;
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                if( categoriaNegocio.altaCategoria(reg) == true )
                {
                    MessageBox.Show("Categoría dada de alta de manera correcta.");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se dió de alta la categoría.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
