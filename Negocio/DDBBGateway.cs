using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class DDBBGateway
    {

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        int affectedRows;

        private string connectionString;

        public DDBBGateway()
        {
            /// Desktop-PC
            connectionString = "data source=DESKTOP-BA6HNP1\\SQLEXPRESS01; integrated security=sspi; initial catalog=CATALOGO_DB;";
            /// Notebook-PC
           // connectionString = "data source=DESKTOP-SI2UFE1\\SQLEXPRESS; integrated security=sspi; initial catalog=CATALOGO_DB;";

            connection.ConnectionString = connectionString;
            command.Connection = connection;
            command.Parameters.Clear();
            affectedRows = 0;
        }

        public void prepareQuery(string query)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }

        public void prepareStatement(string statement)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = statement;
        }

        public void addParameter(object name, object value)
        {
            command.Parameters.AddWithValue(name.ToString(), value.ToString());
        }

        public void sendQuery()
        {
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void sendStatement()
        {
            try
            {
                connection.Open();
                affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        ~DDBBGateway()
        {
            reader.Close();
            connection.Close();
        }

    }
}
