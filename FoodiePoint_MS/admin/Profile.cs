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
using FoodiePoint.Helpers;

namespace FoodiePoint.admin
{
    public partial class Profile : Form
    {
        string connectionString = new DatabaseHelper().GetConnectionString();
        private int adminID;
        public Profile(int userID)
        {
            InitializeComponent();
            adminID = userID;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadProfile();

        }
        private void LoadProfile()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT fullname, email, password FROM users WHERE userID = @id", con);
                cmd.Parameters.AddWithValue("@id", adminID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFullName.Text = reader["fullname"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtPassword.Text = reader["password"].ToString();
                }
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE users SET fullname=@fullname, email=@email, password=@password WHERE userID=@id", con);
                cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@id", adminID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile updated successfully!");
                con.Close();
            }
        }
    }
}
