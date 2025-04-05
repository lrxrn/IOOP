using FoodiePoint.customer;
using FoodiePoint.chef;
using FoodiePoint.admin;
using FoodiePoint.reservation;
using FoodiePoint.Helpers;
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

namespace FoodiePoint
{
    public partial class Universal_Loginpage : Form
    {
        private int loginAttempts = 0;
        private DateTime lockoutTime;
        public Universal_Loginpage()
        {
            InitializeComponent();
            this.AcceptButton = loginpage_login;
        }

        private void btn_loginpage_login_Click(object sender, EventArgs e)
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
                using (SqlConnection conn = new DatabaseHelper().GetConnection())
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
                        else if (role.Equals("Customer", StringComparison.OrdinalIgnoreCase))
                        {
                            var customerDashboard = new Customer_Main(userIDNum, fullname, role);
                            customerDashboard.Show();
                            this.Hide();
                        }
                        else if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            var adminDashboard = new AdminHome(userIDNum, fullname, role);
                            adminDashboard.Show();
                            this.Hide();
                        }
                        else if (role.Equals("Reservationcoordinator", StringComparison.OrdinalIgnoreCase))
                        {
                            var reservationCoordinatorDashboard = new ReservationManager_Dashboard(userIDNum, fullname, role);
                            reservationCoordinatorDashboard.Show();
                            this.Hide();
                        }
                        //else if (role.Equals("Manager", StringComparison.OrdinalIgnoreCase))
                        //{
                        //    var managerDashboard = new Manager_Dashboard(userIDNum, fullname, role);
                        //    managerDashboard.Show();
                        //    this.Hide();
                        //}
                        else
                        {
                            MessageBox.Show(
                                $"Your account has role '{role}' which is not currently supported in the system.\n\n" +
                                "Please contact the system administrator for assistance.",
                                "Access Restricted - Unsupported Role",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
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

        private void btn_loginpage_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
