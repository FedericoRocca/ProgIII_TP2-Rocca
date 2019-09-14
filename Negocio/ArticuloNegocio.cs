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
        /// private string connectionString = "data source=DESKTOP-BA6HNP1\\SQLEXPRESS01; integrated security=sspi; initial catalog=CATALOGO_DB;";
        private string connectionString = "data source=DESKTOP-BA6HNP1\\SQLEXPRESS01; integrated security=sspi; initial catalog=CATALOGO_DB;";

        public List<Articulo> listarArticulos()
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            SqlDataReader reader;
            List<Articulo> aux = new List<Articulo>();

            try
            {

                conn.ConnectionString = connectionString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id as 'IdMarca', M.Descripcion as 'Marca', C.Id as 'IdDescripcion', C.Descripcion as 'Categoria', A.Imagen, A.Precio from ARTICULOS as A inner join MARCAS as M on (A.IdMarca = M.Id) inner join CATEGORIAS as C on ( A.IdCategoria = C.Id );";
                conn.Open();
                reader = comm.ExecuteReader();
                while( reader.Read() )
                {
                    aux.Add(new Articulo(
                        (Int32)reader["Id"],
                        reader["Codigo"].ToString(),
                        reader["Nombre"].ToString(),
                        reader["Descripcion"].ToString(),
                        (Int32)reader["IdMarca"],
                        reader["Marca"].ToString(),
                        (Int32)reader["IdDescripcion"],
                        reader["Categoria"].ToString(),
                        reader["Imagen"].ToString(),
                        (Decimal)reader["Precio"]
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
                conn.Close();
            }
        }
    }
}
