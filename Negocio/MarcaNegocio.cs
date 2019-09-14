using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class MarcaNegocio
    {

        public bool altaMarcaDB(Marca reg)
        {
            DDBBGateway ddbbData = new DDBBGateway();
            try
            {
                ddbbData.prepareStatement("insert into MARCAS values(@Descripcion)");
                ddbbData.addParameter("@Descripcion", reg.descripcion);
                ddbbData.sendStatement();

                if (ddbbData.getAffectedRows() <= 0)
                {
                    return false;
                }
                else return true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ddbbData = null;
            }
        }

        public List<Marca> listarMarcas()
        {

            Marca aux;
            List<Marca> listaMarcas = new List<Marca>();
            DDBBGateway ddbbData = new DDBBGateway();

            try
            {

                ddbbData.prepareQuery("select Id, Descripcion from MARCAS");
                ddbbData.sendQuery();

                while (ddbbData.getReader().Read() )
                {
                    aux = new Marca((Int32)ddbbData.getReader()["Id"], ddbbData.getReader()["Descripcion"].ToString());
                    listaMarcas.Add(aux);
                }
                return listaMarcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                ddbbData = null;
            }
        }

        public List<Marca> buscarMarca(string toSearch)
        {

            Marca reg;
            List<Marca> results = new List<Marca>();
            DDBBGateway ddbbData = new DDBBGateway();

            try
            {
                
                ddbbData.prepareQuery("select Id ,Descripcion from MARCAS where LOWER(Descripcion) like '%" + toSearch.ToLower() + "%';");
                ddbbData.sendQuery();

                while(ddbbData.getReader().Read())
                {
                    reg = new Marca((Int32)ddbbData.getReader()["Id"], ddbbData.getReader()["Descripcion"].ToString());
                    results.Add(reg);
                }

                return results;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                ddbbData = null;
            }
        }

        public bool bajaMarca(Marca reg)
        {

            DDBBGateway ddbbData = new DDBBGateway();

            try
            {

                ddbbData.prepareStatement("delete from MARCAS where Id = '" + reg.codigo + "' and Descripcion = '" + reg.descripcion + "';");
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
                ddbbData = null;
            }
        }

        public bool modificarMarca(Marca reg, string newDesc)
        {

            DDBBGateway ddbbData = new DDBBGateway();

            try
            {
                ddbbData.prepareStatement("update MARCAS set Descripcion = '" + newDesc + "' where Id = '" + reg.codigo + "';");
                ddbbData.sendStatement();
                if (ddbbData.getAffectedRows() <= 0)
                {
                    return false;
                }
                else return true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ddbbData = null;
            }
        }
    }
}
