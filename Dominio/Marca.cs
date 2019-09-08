using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }

        public Marca(){}
        public Marca(int _codigo, string _descripcion)
        {
            descripcion = _descripcion;
            codigo = _codigo;
        }
    }
}