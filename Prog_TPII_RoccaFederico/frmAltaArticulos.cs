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
    public partial class frmAltaArticulos : Form
    {

        Articulo registro;

        public frmAltaArticulos()
        {
            InitializeComponent();
        }

        public frmAltaArticulos( Articulo _registro )
        {
            InitializeComponent();
            registro = _registro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmAltaArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                if( registro == null )
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                    cmbMarca.DataSource = marcaNegocio.listarMarcas();
                    cmbCategoria.DataSource = categoriaNegocio.listarCategorias();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                registro = new Articulo();
                registro.categoria = (Categoria)cmbCategoria.SelectedItem;
                registro.marca = (Marca)cmbMarca.SelectedItem;
                registro.codigo = txbCodigo.Text;
                registro.descripcion = txbDescripcion.Text;
                registro.imagen = txbImagen.Text;
                registro.nombre = txbNombre.Text;
                decimal _precio;
                if (decimal.TryParse(txbPrecio.Text, out _precio))
                {
                    registro.precio = _precio;
                }

                if( articuloNegocio.altaArticulo( registro ) )
                {
                    MessageBox.Show("Articulo dado de alta de manera correcta.");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al dar de alta el artículo.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
