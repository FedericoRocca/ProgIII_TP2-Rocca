using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        public Int32 codigo { get; set; }
        public string descripcion { get; set; }

        public Categoria() { }
        public Categoria(Int32 _codigo, string _descripcion)
        {
            codigo = _codigo;
            descripcion = _descripcion;
        }

        public Categoria(Int32 _codigo)
        {
            codigo = _codigo;
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
