using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public Int32 codigo { get; set; }
        public string descripcion { get; set; }

        public Marca(){}
        public Marca(int _codigo, string _descripcion)
        {
            descripcion = _descripcion;
            codigo = _codigo;
        }

        public Marca(int _codigo)
        {
            codigo = _codigo;
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}