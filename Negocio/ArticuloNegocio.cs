using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulos()
        {
            DDBBGateway ddbbData = new DDBBGateway();
            List<Articulo> aux = new List<Articulo>();

            try
            {

                ddbbData.prepareQuery("select A.Id, A.Codigo, A.Nombre, A.Descripcion, " +
                                    "M.Id as 'IdMarca', M.Descripcion as 'Marca', " +
                                    "C.Id as 'IdDescripcion', C.Descripcion as 'Categoria', " +
                                    "A.Imagen, A.Precio from ARTICULOS as A inner join MARCAS" +
                                    " as M on (A.IdMarca = M.Id) inner join CATEGORIAS as C on " +
                                    "( A.IdCategoria = C.Id );");
                ddbbData.sendQuery();
                while (ddbbData.getReader().Read() )
                {
                    aux.Add(new Articulo(
                        (Int32)ddbbData.getReader()["Id"],
                        ddbbData.getReader()["Codigo"].ToString(),
                        ddbbData.getReader()["Nombre"].ToString(),
                        ddbbData.getReader()["Descripcion"].ToString(),
                        (Int32)ddbbData.getReader()["IdMarca"],
                        ddbbData.getReader()["Marca"].ToString(),
                        (Int32)ddbbData.getReader()["IdDescripcion"],
                        ddbbData.getReader()["Categoria"].ToString(),
                        ddbbData.getReader()["Imagen"].ToString(),
                        (Decimal)ddbbData.getReader()["Precio"]
                        ));
                }

                return aux;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ddbbData.closeConnection();
            }
        }

        public bool bajaArticulo( Articulo reg )
        {

            DDBBGateway ddbbData = new DDBBGateway();

            try
            {
                ddbbData.prepareStatement("delete from ARTICULOS where Id = '" + reg.id + 
                                          "' and Codigo = '" + reg.codigo + "' and Nombre = '" + reg.nombre + "';");
                ddbbData.sendStatement();
                if (ddbbData.getAffectedRows() <= 0)
                {
                    return false;
                }
                else return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                ddbbData.closeConnection();
            }
        }

        public List<Articulo> BuscarArticulos(string ToSearch)
        {
            DDBBGateway ddbbData = new DDBBGateway();
            List<Articulo> aux = new List<Articulo>();

            try
            {

                ddbbData.prepareQuery("select A.Id, A.Codigo, A.Nombre, A.Descripcion, " +
                                    "M.Id as 'IdMarca', M.Descripcion as 'Marca', " +
                                    "C.Id as 'IdDescripcion', C.Descripcion as 'Categoria', " +
                                    "A.Imagen, A.Precio from ARTICULOS as A inner join MARCAS" +
                                    " as M on (A.IdMarca = M.Id) inner join CATEGORIAS as C on " +
                                    "( A.IdCategoria = C.Id )" +
                                    "where A.Descripcion like lower('%" + ToSearch + "%') or Nombre like lower('%" + ToSearch + "%'); ");
                ddbbData.sendQuery();
                while (ddbbData.getReader().Read())
                {
                    aux.Add(new Articulo(
                        (Int32)ddbbData.getReader()["Id"],
                        ddbbData.getReader()["Codigo"].ToString(),
                        ddbbData.getReader()["Nombre"].ToString(),
                        ddbbData.getReader()["Descripcion"].ToString(),
                        (Int32)ddbbData.getReader()["IdMarca"],
                        ddbbData.getReader()["Marca"].ToString(),
                        (Int32)ddbbData.getReader()["IdDescripcion"],
                        ddbbData.getReader()["Categoria"].ToString(),
                        ddbbData.getReader()["Imagen"].ToString(),
                        (Decimal)ddbbData.getReader()["Precio"]
                        ));
                }

                return aux;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ddbbData.closeConnection();
            }
        }

        public bool altaArticulo( Articulo reg )
        {
            DDBBGateway ddbbData = new DDBBGateway();
            try
            {
                ddbbData.prepareStatement("insert into ARTICULOS VALUES ( @cod, @nom, @desc, @idMar, @idCat, @ima, @pre);");
                ddbbData.addParameter("@cod", reg.codigo);
                ddbbData.addParameter("@nom", reg.nombre);
                ddbbData.addParameter("@desc", reg.descripcion);
                ddbbData.addParameter("@idMar", reg.marca.codigo);
                ddbbData.addParameter("@idCat", reg.categoria.codigo);
                ddbbData.addParameter("@ima", reg.imagen);
                ddbbData.addParameter("@pre", reg.precio);
                ddbbData.sendStatement();

                if (ddbbData.getAffectedRows() <= 0)
                {
                    return false;
                }
                else return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                ddbbData.closeConnection();
            }
        }

        public bool modificarArticulo( Articulo reg )
        {
            DDBBGateway ddbbData = new DDBBGateway();
            try
            {

                ddbbData.prepareStatement("update ARTICULOS set " +
                                          "Codigo = @Cod, " +
                                          "Nombre = @Nom, " +
                                          "Descripcion = @Desc, " +
                                          "IdMarca = @IdMar, " +
                                          "IdCategoria = @IdCat, " +
                                          "Imagen = @Img, " +
                                          "Precio = @Pre " +
                                          "where Id = @IdArt;");

                ddbbData.addParameter("@Cod", reg.codigo);
                ddbbData.addParameter("@Nom", reg.nombre);
                ddbbData.addParameter("@Desc", reg.descripcion);
                ddbbData.addParameter("@IdMar", reg.marca.codigo.ToString());
                ddbbData.addParameter("@IdCat", reg.categoria.codigo.ToString());
                ddbbData.addParameter("@Img", reg.imagen);
                ddbbData.addParameter("@Pre", reg.precio.ToString());
                ddbbData.addParameter("@IdArt", reg.id.ToString());
                ddbbData.sendStatement();
                if (ddbbData.getAffectedRows() <= 0)
                {
                    return false;
                }
                else return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ddbbData.closeConnection();
            }
        }
    }
}
