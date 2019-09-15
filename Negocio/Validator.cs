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

        const int minlen_articuloCodigo = 1;
        const int maxlen_articuloCodigo = 50;

        const int minlen_articuloNombre = 1;
        const int maxlen_articuloNombre = 50;

        const int minlen_articuloDescripcion = 1;
        const int maxlen_articuloDescripcion = 150;

        const int minlen_articuloImagen = 1;
        const int maxlen_articuloImagen = 150;

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
            if( reg.codigo.Length < minlen_articuloCodigo )
            {
                throw new System.ArgumentException("El largo mínimo del código del artículo es de " + minlen_articuloCodigo + " caracter/es.");
            }

            if( reg.codigo.Length > maxlen_articuloCodigo )
            {
                throw new System.ArgumentException("El largo maximo del código  del artículo es de " + maxlen_articuloCodigo + " caracter/es.");
            }

            if( reg.nombre.Length < minlen_articuloNombre )
            {
                throw new System.ArgumentException("El largo mínimo del nombre del artículo es de " + minlen_articuloNombre + " caracter/es.");
            }

            if( reg.nombre.Length > maxlen_articuloNombre )
            {
                throw new System.ArgumentException("El largo maximo del nombre del artículo es de " + maxlen_articuloNombre + " caracter/es.");
            }

            if( reg.descripcion.Length < minlen_articuloDescripcion)
            {
                throw new System.ArgumentException("El largo mínimo de la descripción del artículo es de " + minlen_articuloDescripcion + " caracter/es.");
            }

            if (reg.descripcion.Length > maxlen_articuloDescripcion)
            {
                throw new System.ArgumentException("El largo maximo de la descripción del artículo es de " + maxlen_articuloDescripcion + " caracter/es.");
            }

            if (reg.imagen.Length < minlen_articuloImagen)
            {
                throw new System.ArgumentException("El largo mínimo de la imagen del artículo es de " + minlen_articuloImagen + " caracter/es.");
            }

            if (reg.imagen.Length > maxlen_articuloImagen)
            {
                throw new System.ArgumentException("El largo maximo de la imagen del artículo es de " + maxlen_articuloImagen + " caracter/es.");
            }

            if (reg.precio <= 0)
            {
                throw new System.ArgumentException("El monto ingresado es inválido");
            }

            if( reg.marca == null )
            {
                throw new System.ArgumentException("Debe seleccionar una marca de la lista");
            }

            if (reg.categoria == null)
            {
                throw new System.ArgumentException("Debe seleccionar una categoría de la lista");
            }

        }

    }
}
