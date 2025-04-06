using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePoint.manager
{
    internal class manager_databasehelper
    {
        private string connectionString;

        public manager_databasehelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["restaurant"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}