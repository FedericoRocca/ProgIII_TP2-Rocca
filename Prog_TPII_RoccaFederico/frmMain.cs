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

        private void smiCategoriaListar_Click(object sender, EventArgs e)
        {
            bool isListarCategoriasOpen = false;

            try
            {

                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if( Application.OpenForms[i].GetType() == typeof(frmListarCategorias) )
                    {
                        isListarCategoriasOpen = true;
                    }
                }

                if( !isListarCategoriasOpen )
                {
                    frmListarCategorias listarCategorias = new frmListarCategorias();
                    listarCategorias.MdiParent = this;
                    listarCategorias.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void smiCategoriaBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                bool isBuscarCategoriaOpen = false;
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if( Application.OpenForms[i].GetType() == typeof(frmBuscarCategoria) )
                    {
                        isBuscarCategoriaOpen = true;
                    }
                }

                if( !isBuscarCategoriaOpen )
                {
                    frmBuscarCategoria frmBuscar = new frmBuscarCategoria();
                    frmBuscar.MdiParent = this;
                    frmBuscar.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void smiCategoriaAlta_Click(object sender, EventArgs e)
        {
            try
            {
                bool isAltaCategoriaOpen = false;
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].GetType() == typeof(frmAltaCategoria) )
                    {
                        isAltaCategoriaOpen = true;
                    }
                }

                if( !isAltaCategoriaOpen )
                {
                    frmAltaCategoria altaCategoria = new frmAltaCategoria();
                    altaCategoria.MdiParent = this;
                    altaCategoria.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
