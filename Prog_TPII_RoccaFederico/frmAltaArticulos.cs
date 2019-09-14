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

namespace Prog_TPII_RoccaFederico
{
    public partial class frmAltaArticulos : Form
    {
        public frmAltaArticulos()
        {
            InitializeComponent();
        }

        public frmAltaArticulos( Articulo registro )
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
