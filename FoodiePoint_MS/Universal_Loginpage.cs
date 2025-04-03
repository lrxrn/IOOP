using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chef_assignment
{
    public partial class Universal_Loginpage : Form
    {
        private int loginAttempts = 0;
        private DateTime lockoutTime;
        public Universal_Loginpage()
        {
            InitializeComponent();
        }

        private void btnchef_loginpage_login_Click(object sender, EventArgs e)
        {
            if (DateTime.Now < lockoutTime)
            {
                MessageBox.Show("Too many failed attempts. Try again after 5 minutes.");
                return;
            }

            string userID = loginpage_userID.Text.Trim();
            string password = loginpage_password.Text.Trim();

            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fill all fields please.");
                return;
            }

            try
            {
                using (SqlConnection conn = new chef_databasehelper().GetConnection())
                {
                    string query = "SELECT * FROM users WHERE (username = @userID OR email = @userID) AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string fullname = reader["fullname"].ToString();
                        string role = reader["role"].ToString();
                        int userIDNum = Convert.ToInt32(reader["userID"]);

                        loginAttempts = 0;

                        if (role.Equals("Chef", StringComparison.OrdinalIgnoreCase))
                        {
                            var chefDashboard = new formchef_chefdashbaord_chd(userIDNum, fullname, role);
                            chefDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Dashboard for this role is not implemented.");
                        }
                    }
                    else
                    {
                        loginAttempts++;
                        if (loginAttempts >= 3)
                        {
                            lockoutTime = DateTime.Now.AddMinutes(5);
                            MessageBox.Show("Invalid Credentials. You can't login anymore for 5 minutes.");
                        }
                        else
                        {
                            MessageBox.Show("Invalid Credentials, Try again!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
            }
        }

        private void btnchef_loginpage_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
