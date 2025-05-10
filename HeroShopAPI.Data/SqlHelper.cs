using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroShopAPI.Data
{
    public class SqlHelper
    {
        public object[] Get(string connectionString, string commandName, string[] param)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(commandName, connection);
                    connection.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    //add logging
                    throw ex;
                }
                finally
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }


                
            }
            return new object[] { "Item1", "Item2", "Item3" };
        }
    }
}
