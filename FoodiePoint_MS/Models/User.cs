using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodiePoint.Helpers;
using System.Windows.Forms;

namespace FoodiePoint.Models
{
    internal class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }

        public User(int UserIDP)
        {
            UserID = UserIDP;
            FindandSetUser();
        }

        public User() { }

        public bool UpdateUser(User updatedUser)
        {
            FullName = updatedUser.FullName;
            Email = updatedUser.Email;
            Password = updatedUser.Password;
            Role = updatedUser.Role;
            string query = "UPDATE users SET fullname = @fullname, email = @email, password = @password, role = @role WHERE userID = @userID";
            ExecuteQuery(query, new Dictionary<string, object>
            {
                { "@fullname", FullName },
                { "@email", Email },
                { "@password", Password },
                { "@role", Role },
                { "@userID", UserID }
            });
            return true;
        }

        private void FindandSetUser()
        {
            string query = "SELECT * FROM users WHERE userID = @userID";
            DataTable dt = ExecuteQuery(query, new Dictionary<string, object> { { "@userID", UserID } });
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                UserID = Convert.ToInt32(row["userID"]);
                FullName = row["fullname"].ToString();
                Email = row["email"].ToString();
                Password = row["password"].ToString();
                Role = row["role"].ToString();
                Username = row["username"].ToString();
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new DatabaseHelper().GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    conn.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }
    }
}
