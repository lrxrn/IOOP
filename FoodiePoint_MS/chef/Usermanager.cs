using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chef_assignment
{
    public class chef_usermanager
    {
        private chef_databasehelper dbHelper;

        public chef_usermanager()
        {
            dbHelper = new chef_databasehelper();
        }

        public bool UpdateChefProfile(chef_user user)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "UPDATE users SET fullname=@FullName, email=@Email, password=@Password WHERE userID=@UserID AND role='Chef'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public chef_user GetChefByID(int userID)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT * FROM users WHERE userID=@UserID AND role='Chef'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new chef_user
                    {
                        UserID = Convert.ToInt32(reader["userID"]),
                        FullName = reader["fullname"].ToString(),
                        Email = reader["email"].ToString(),
                        Password = reader["password"].ToString(),
                        Role = reader["role"].ToString()
                    };
                }
            }

            return null;
        }
    }
}
