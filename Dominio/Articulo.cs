using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public Int32 id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }
        public string imagen { get; set; }
        public decimal precio { get; set; }

        public Articulo() { }

        public Articulo( 
            Int32 _id, 
            string _codigo, 
            string _nombre, 
            string _descripcion, 
            Int32 _Idmarca, 
            string _DescMarca,
            Int32 _IdCategoria,
            string _DescCategoria,
            string _imagen, 
            decimal _precio )
        {
            id = _id;
            codigo = _codigo;
            nombre = _nombre;
            descripcion = _descripcion;
            marca = new Marca(_Idmarca, _DescMarca);
            categoria = new Categoria( _IdCategoria, _DescCategoria );
            imagen = _imagen;
            precio = _precio;
        }
    }
}
