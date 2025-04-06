using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FoodiePoint.manager;

namespace FoodiePoint.manager
{
    internal class generatereports
    {
        private manager_databasehelper dbHelper;
        public generatereports()
        {
            dbHelper = new manager_databasehelper();
        }

        public DataTable GetReservationReport(string month, string reservationType)
        {
            int monthNumber = DateTime.ParseExact(month, "MMMM", null).Month;

            using (SqlConnection con = dbHelper.GetConnection())
            {
                string query = @"SELECT * FROM reservations WHERE MONTH(reservationdate) = @reservationdate AND status = @status";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@reservationdate", monthNumber);
                    cmd.Parameters.AddWithValue("@status", reservationType);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);

                    return table;
                }
            }
        }
    }
}
