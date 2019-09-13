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

        public List<Categoria> BuscarCategorias(string ToSearch)
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            SqlDataReader reader;
            Categoria aux;
            List<Categoria> Resultados = new List<Categoria>();
            ToSearch = ToSearch.ToLower();

            try
            {

                conn.ConnectionString = connectionString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "select Id, Descripcion from CATEGORIAS where Descripcion like lower('%" + ToSearch + "%');";
                conn.Open();
                reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    aux = new Categoria( (Int32)reader["Id"], reader["Descripcion"].ToString() );
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
                conn.Close();
            }
        }

        public bool altaCategoria( Categoria reg )
        {

            SqlCommand comm = new SqlCommand();
            SqlConnection conn = new SqlConnection();

            try
            {

                conn.ConnectionString = connectionString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "insert into CATEGORIAS values ('" + reg.descripcion + "');";
                conn.Open();
                int result = comm.ExecuteNonQuery();
                if( result >= 0 )
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
                conn.Close();
            }
        }

        public bool bajaCategoría( Categoria reg )
        {

            SqlCommand comm = new SqlCommand();
            SqlConnection conn = new SqlConnection();

            try
            {

                conn.ConnectionString = connectionString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "delete from CATEGORIAS where Id = '" + reg.codigo + "' and Descripcion = '" + reg.descripcion + "';";
                conn.Open();
                int result = comm.ExecuteNonQuery();
                if (result <= 0)
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
                conn.Close();
            }
        }

        public bool modificarCategoria( Categoria reg , string newDesc)
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            try
            {
                conn.ConnectionString = connectionString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "update CATEGORIAS set Descripcion = '" + newDesc + "' where Id = '" + reg.codigo + "' and Descripcion = '" + reg.descripcion + "';";
                conn.Open();
                int result = comm.ExecuteNonQuery();
                if (result <= 0)
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
                conn.Close();
            }
        }

    }


}
