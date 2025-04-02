using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace chef_assignment
{
    internal class restaurantdatabaseconnection_chef
    {
        private string connectionString;

        public restaurantdatabaseconnection_chef()
        {
            connectionString = ConfigurationManager.ConnectionStrings["restaurant"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public string TestConnection()
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    return "Connected to the database successfully";
                }
                catch (Exception ex)
                {
                    return "Connection failed: " + ex.Message;
                }
            }
        }
    }
}
