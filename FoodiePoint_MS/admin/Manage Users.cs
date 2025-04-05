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
using FoodiePoint.Models;
using FoodiePoint.Helpers;

namespace FoodiePoint.admin
{
    public partial class Manage_Users : Form

    {
        string connectionString = new DatabaseHelper().GetConnectionString();
        private int selectedUserID;
        private void ClearFields()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
        }


        public Manage_Users(int userID)
        {
            InitializeComponent();
            selectedUserID = userID;
        }
        private void Manage_Users_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Customer");
            cmbRole.Items.Add("Reservationcoordinator");
            cmbRole.Items.Add("Chef");
            cmbRole.Items.Add("Manager");
            cmbRole.Items.Add("Admin");

            LoadUsers();

        }

        private void LoadUsers()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT userID, fullname, email, role FROM users", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvUsers.DataSource = dt;

            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid role from the list.");
                return;
            }
            if (txtFullName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || cmbRole.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            User user = new User()
            {
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Role = cmbRole.Text
            };

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO users (fullname, email, password, role) VALUES (@fullname, @email, @password, @role)", con);
            cmd.Parameters.AddWithValue("@fullname", user.FullName);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("User added successfully!");
            LoadUsers();
            ClearFields();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserID == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            User user = new User()
            {
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text, 
                Role = cmbRole.Text
            };

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE users SET fullname=@fullname, email=@email, password=@password, role=@role WHERE userID=@userID", con);
            cmd.Parameters.AddWithValue("@fullname", user.FullName);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@userID", selectedUserID);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("User updated successfully!");
            LoadUsers();
            ClearFields();
            selectedUserID = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserID == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE userID=@userID", con);
                cmd.Parameters.AddWithValue("@userID", selectedUserID);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("User deleted successfully!");
                LoadUsers();
                ClearFields();
                selectedUserID = -1;
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                txtFullName.Text = row.Cells["fullname"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPassword.Text = "";
                cmbRole.Text = row.Cells["role"].Value.ToString();
                selectedUserID = Convert.ToInt32(row.Cells["userID"].Value);
            }
        }
    }
}
