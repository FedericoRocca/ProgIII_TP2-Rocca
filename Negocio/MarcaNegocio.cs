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

        private string connectionString = "data source=DESKTOP-BA6HNP1\\SQLEXPRESS01; integrated security=sspi; initial catalog=CATALOGO_DB;";

        public bool altaMarcaDB(Marca reg)
        {

            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();

            try
            {

                connection.ConnectionString = connectionString;
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = "insert into MARCAS values (@Descripcion)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Descripcion", reg.descripcion);
                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result <= 0)
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
                connection.Close();
            }
        }

        public List<Marca> listarMarcas()
        {

            Marca aux;
            List<Marca> listaMarcas = new List<Marca>();
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            SqlDataReader read;

            try
            {
                conn.ConnectionString = connectionString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "select Id, Descripcion from MARCAS";
                conn.Open();
                read = comm.ExecuteReader();

                while( read.Read() )
                {
                    aux = new Marca((Int32)read["Id"], read["Descripcion"].ToString());
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
                conn.Close();
            }
        }

        public List<Marca> buscarMarca(string toSearch)
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            SqlDataReader read;
            Marca reg;
            List<Marca> results = new List<Marca>();

            try
            {

                conn.ConnectionString = connectionString;
                comm.CommandType = System.Data.CommandType.Text;
                comm.Connection = conn;
                comm.CommandText = "select Id ,Descripcion from MARCAS where LOWER(Descripcion) like '%" + toSearch.ToLower() + "%';";
//                TODO
//                Ver por qué chota no funcionó con parámetros...
//                comm.Parameters.Clear();
//                comm.Parameters.AddWithValue("@Search", toSearch);
                conn.Open();
                read = comm.ExecuteReader();

                while(read.Read())
                {
                    reg = new Marca((Int32)read["Id"], read["Descripcion"].ToString());
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
                conn.Close();
            }
        }

        public bool bajaMarca(Marca reg)
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            try
            {

                conn.ConnectionString = connectionString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "delete from MARCAS where Id = '" + reg.codigo + "' and Descripcion = '" + reg.descripcion + "';";
                conn.Open();
                int result = comm.ExecuteNonQuery();
                if (result <= 0)
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
                conn.Close();
            }
        }

        public bool modificarMarca(Marca reg, string newDesc)
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            try
            {

                conn.ConnectionString = connectionString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "update MARCAS set Descripcion = '" + newDesc + "' where Id = '" + reg.codigo + "';";
                conn.Open();
                int result = comm.ExecuteNonQuery();
                if (result <= 0)
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
                conn.Close();
            }
        }
    }
}
