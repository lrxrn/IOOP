using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chef_assignment
{
    internal class chef_databasehelper
    {
        private string connectionString;

        public chef_databasehelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["restaurant"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
