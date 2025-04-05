using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;



namespace FoodiePoint.reservation
{
    internal class Databaseconnection
    {
        private string connectionString;

        public Databaseconnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["restaurant"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
    }

