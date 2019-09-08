using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_TPII_RoccaFederico
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void smiMarcaAlta_Click(object sender, EventArgs e)
        {
            try
            {
                bool isAltaMarcaOpen = false;
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if( Application.OpenForms[i].GetType() == typeof(frmAltaMarca) )
                    {
                        isAltaMarcaOpen = true;
                    }
                }

                if(!isAltaMarcaOpen)
                {
                    frmAltaMarca altaMarca = new frmAltaMarca();
                    altaMarca.MdiParent = this;
                    altaMarca.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void smiMarcaListar_Click(object sender, EventArgs e)
        {
            try
            {

                bool isListadoMarcasOpen = false;
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if( Application.OpenForms[i].GetType() == typeof( frmListarMarcas ) )
                    {
                        isListadoMarcasOpen = true;
                    }
                }

                if(!isListadoMarcasOpen)
                {
                    frmListarMarcas listadoMarcas = new frmListarMarcas();
                    listadoMarcas.MdiParent = this;
                    listadoMarcas.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void smiMarcaBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                bool isBuscarOpen = false;
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if( Application.OpenForms[i].GetType() == typeof( frmBuscarMarcas ) )
                    {
                        isBuscarOpen = true;
                    }
                }

                if(!isBuscarOpen)
                {
                    frmBuscarMarcas buscarMarcas = new frmBuscarMarcas();
                    buscarMarcas.MdiParent = this;
                    buscarMarcas.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
