using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listarCategorias()
        {
            DDBBGateway ddbbData = new DDBBGateway();
            Categoria aux;
            List<Categoria> resultados = new List<Categoria>();

            try
            {
                ddbbData.prepareQuery("select id, Descripcion from CATEGORIAS;");
                ddbbData.sendQuery();

                while ( ddbbData.getReader().Read() )
                {
                    aux = new Categoria( (Int32)ddbbData.getReader()["id"], ddbbData.getReader()["Descripcion"].ToString());
                    resultados.Add(aux);
                }

                return resultados;

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

        public List<Categoria> BuscarCategorias(string ToSearch)
        {
            DDBBGateway ddbbData = new DDBBGateway();
            Categoria aux;
            List<Categoria> Resultados = new List<Categoria>();
            ToSearch = ToSearch.ToLower();

            try
            {
                ddbbData.prepareQuery("select Id, Descripcion from CATEGORIAS where Descripcion like lower('%" + ToSearch + "%');");
                ddbbData.sendQuery();

                while( ddbbData.getReader().Read() )
                {
                    aux = new Categoria( (Int32)ddbbData.getReader()["Id"], ddbbData.getReader()["Descripcion"].ToString() );
                    Resultados.Add(aux);
                }

                return Resultados;

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

        public bool altaCategoria( Categoria reg )
        {

            DDBBGateway ddbbData = new DDBBGateway();

            try
            {
                ddbbData.prepareStatement("insert into CATEGORIAS values ('" + reg.descripcion + "');");
                ddbbData.sendStatement();
                if( ddbbData.getAffectedRows() >= 0 )
                {
                    return true;
                } else return false;
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

        public bool bajaCategoría( Categoria reg )
        {

            DDBBGateway ddbbData = new DDBBGateway();

            try
            {

                ddbbData.prepareStatement("delete from CATEGORIAS where Id = '" + reg.codigo + "' and Descripcion = '" + reg.descripcion + "';");
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

        public bool modificarCategoria( Categoria reg , string newDesc)
        {

            DDBBGateway ddbbData = new DDBBGateway();

            try
            {
                ddbbData.prepareStatement("update CATEGORIAS set Descripcion = '" + newDesc + "' where Id = '" + reg.codigo + "' and Descripcion = '" + reg.descripcion + "';");
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
