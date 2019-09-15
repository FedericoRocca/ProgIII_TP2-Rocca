using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public static class Validator
    {

        const int minlen_marcaDescripcion = 1;
        const int maxlen_marcaDescripcion = 50;
        
        const int minlen_categoriaDescripcion = 1;
        const int maxlen_categoriaDescripcion = 50;

        public static void validate( Marca reg )
        {
            if (reg.descripcion.Length > maxlen_marcaDescripcion)
            {
                throw new System.ArgumentException("El largo máximo de la descripción de la marca es de " + maxlen_marcaDescripcion + " caracteres.");
            }

            if (reg.descripcion.Length < minlen_marcaDescripcion)
            {
                throw new System.ArgumentException("El largo mínimo de la descripción de la marca es de " + minlen_marcaDescripcion + " caracter/es.");
            }
        }

        public static void validate(Marca reg, string text)
        {
            if (text.Length > maxlen_marcaDescripcion)
            {
                throw new System.ArgumentException("El largo máximo de la descripción de la marca es de " + maxlen_marcaDescripcion + " caracteres.");
            }

            if (text.Length < minlen_marcaDescripcion)
            {
                throw new System.ArgumentException("El largo mínimo de la descripción de la marca es de " + minlen_marcaDescripcion + " caracter/es.");
            }
        }

        public static void validate( Categoria reg )
        {
            if (reg.descripcion.Length > maxlen_categoriaDescripcion)
            {
                throw new System.ArgumentException("El largo máximo de la descripción de la categorìa es de " + maxlen_categoriaDescripcion + " caracteres.");
            }

            if (reg.descripcion.Length < minlen_categoriaDescripcion)
            {
                throw new System.ArgumentException("El largo mínimo de la descripción de la categorìa es de " + minlen_categoriaDescripcion + " caracter/es.");
            }
        }

        public static void validate(Categoria reg, string text)
        {
            if (text.Length > maxlen_categoriaDescripcion)
            {
                throw new System.ArgumentException("El largo máximo de la descripción de la categorìa es de " + maxlen_categoriaDescripcion + " caracteres.");
            }

            if (text.Length < minlen_categoriaDescripcion)
            {
                throw new System.ArgumentException("El largo mínimo de la descripción de la categorìa es de " + minlen_categoriaDescripcion + " caracter/es.");
            }
        }

        public static void validate( Articulo reg )
        {

        }

    }
}
