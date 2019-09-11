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

        private string connectionString = "data source=DESKTOP-BA6HNP1\\SQLEXPRESS01; integrated security=sspi; initial catalog=CATALOGO_DB;";

        public List<Categoria> listarCategorias()
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            SqlDataReader reader;
            Categoria aux;
            List<Categoria> resultados = new List<Categoria>();

            try
            {
                conn.ConnectionString = connectionString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "select id, Descripcion from CATEGORIAS;";
                conn.Open();
                reader = comm.ExecuteReader();

                while (reader.Read() )
                {
                    aux = new Categoria( (Int32)reader["id"], reader["Descripcion"].ToString());
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
                conn.Close();
            }
        }

    }


}
