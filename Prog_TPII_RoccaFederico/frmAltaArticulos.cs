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
        DataGridView aux;

        public frmAltaArticulos()
        {
            InitializeComponent();
        }

        public frmAltaArticulos(Articulo _registro)
        {
            InitializeComponent();
            registro = _registro;
        }

        public frmAltaArticulos( Articulo _registro , DataGridView _aux)
        {
            InitializeComponent();
            registro = _registro;
            aux = _aux;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmAltaArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                cmbMarca.DataSource = marcaNegocio.listarMarcas();
                cmbMarca.ValueMember = "codigo";
                cmbMarca.DisplayMember = "descripcion";

                cmbCategoria.DataSource = categoriaNegocio.listarCategorias();
                cmbCategoria.ValueMember = "codigo";
                cmbCategoria.DisplayMember = "descripcion";

                if ( registro == null )
                {
                    cmbMarca.SelectedIndex = -1;
                    cmbCategoria.SelectedIndex = -1;
                }
                else
                {
                    txbCodigo.Text = registro.codigo.ToString();
                    txbNombre.Text = registro.nombre.ToString();
                    txbDescripcion.Text = registro.descripcion.ToString();
                    cmbMarca.SelectedValue = registro.marca.codigo;
                    cmbCategoria.SelectedValue = registro.categoria.codigo;
                    txbImagen.Text = registro.imagen.ToString();
                    txbPrecio.Text = registro.precio.ToString();
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
                if (registro == null)
                {
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

                    Validator.validate(registro);

                    if (articuloNegocio.altaArticulo(registro))
                    {
                        MessageBox.Show("Articulo dado de alta de manera correcta.");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error al dar de alta el artículo.");
                    } 
                }
                else
                {
                    registro.categoria = (Categoria)cmbCategoria.SelectedItem;
                    registro.marca = (Marca)cmbMarca.SelectedItem;
                    registro.codigo = txbCodigo.Text;
                    registro.descripcion = txbDescripcion.Text;
                    registro.imagen = txbImagen.Text;
                    registro.nombre = txbNombre.Text;
                    decimal _precio;
                    decimal.TryParse(txbPrecio.Text, out _precio);

                    Validator.validate(registro);

                    if (articuloNegocio.modificarArticulo(registro))
                    {
                        MessageBox.Show("Articulo modificado de manera correcta.");
                        aux.DataSource = articuloNegocio.listarArticulos();
                        aux.Refresh();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el artículo.");
                    }
                }

            }
            catch (Exception ex)
            {
                registro = null;
                MessageBox.Show(ex.Message);
            }


        }
    }
}
