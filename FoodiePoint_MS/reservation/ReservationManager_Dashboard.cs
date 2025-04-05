using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
//using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FoodiePoint.Helpers;

namespace FoodiePoint.reservation

{
    public partial class ReservationManager_Dashboard : Form
    {
        private ReservationManager reservationManager;
        private string connectionString = new DatabaseHelper().GetConnectionString();

        public int currentUserID;
        public string currentUserFullName;
        public string currentUserRole;
        public ReservationManager_Dashboard(int userID, string userFullName, string userRole)
        {
            InitializeComponent();

            currentUserID = userID;
            currentUserFullName = userFullName;
            currentUserRole = userRole;

            reservationManager = new ReservationManager();
        }
        // Function to load reservations 
        private void LoadReservations()
        {
            string connectionString = new DatabaseHelper().GetConnectionString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM reservations";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvReservations.DataSource = dt; 
                }
            }
        }

        private int GetCustomerID(string customerName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT customerID FROM customers WHERE customerName = @customerName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@customerName", customerName);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1; 
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadHalls();
            LoadReservations();

            cmbReservationStatus.Items.Clear();
            cmbReservationStatus.Items.Add("Pending");
            cmbReservationStatus.Items.Add("Confirmed");
            cmbReservationStatus.Items.Add("Cancelled");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dtpReservationDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (!ValidateInputFields())
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Reservations (CustomerName, ContactDetails, PartySize, ReservationDate, HallTime, Status) " +
                               "VALUES (@name, @contact, @size, @date, @hallTime, @status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@date", dtpReservationDate.Value);
                    cmd.Parameters.AddWithValue("@hallTime", cmbHallID.SelectedItem?.ToString() ?? string.Empty);
                    cmd.Parameters.AddWithValue("@status", "Pending");

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Reservation Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        // Validation Method
        private bool ValidateInputFields()
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }





            if (cmbHallID.SelectedItem == null)
            {
                MessageBox.Show("Please select a hall time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Clear Input Fields Method
        private void ClearInputFields()
        {
            txtCustomerName.Clear();
            dtpReservationDate.Value = DateTime.Now;
            cmbHallID.SelectedIndex = -1;
            cmbReservationStatus.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                int reservationID = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["reservationID"].Value);
                int customerID = GetCustomerID(txtCustomerName.Text);

                if (customerID == -1)
                {
                    MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                string status = cmbReservationStatus.SelectedItem?.ToString()?.Trim() ?? "";

                if (string.IsNullOrEmpty(status))
                {
                    status = "Pending"; 
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE reservations 
                         SET customerID = @customerID, 
                             reservationdate = @reservationDate, 
                             hallID = @hallID, 
                             status = @status 
                         WHERE reservationID = @reservationID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@reservationDate", dtpReservationDate.Value);
                        cmd.Parameters.AddWithValue("@hallID", Convert.ToInt32(cmbHallID.SelectedValue));
                        cmd.Parameters.AddWithValue("@status", status); 
                        cmd.Parameters.AddWithValue("@reservationID", reservationID);

                        // Check what value is being sent
                        MessageBox.Show("Updating status: " + status);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadReservations(); 
                        }
                        else
                        {
                            MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0) 
            {
                int reservationID = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["reservationID"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moham\source\repos\Reservation\Reservation\restaurant.mdf;Integrated Security=True";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM reservations WHERE reservationID = @reservationID";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@reservationID", reservationID);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Reservation Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                          
                                LoadReservations();
                            }
                            else
                            {
                                MessageBox.Show("Deletion Failed. Reservation not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadHalls()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT hallID, hallName FROM halls";  
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<int, string> halls = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        halls.Add(reader.GetInt32(0), reader.GetString(1));
                    }

                    cmbHallID.DataSource = new BindingSource(halls, null);
                    cmbHallID.DisplayMember = "Value";  
                    cmbHallID.ValueMember = "Key";      
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading halls: " + ex.Message);
                }
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text)) 
            {
                int reservationID;
                if (int.TryParse(txtSearch.Text, out reservationID)) 
                {
                    string query = "SELECT * FROM reservations WHERE reservationID = @reservationID";
                    using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\moham\\source\\repos\\Reservation\\Reservation\\restaurant.mdf;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@reservationID", reservationID);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dgvReservations.DataSource = dt; 
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Reservation ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a Reservation ID to search.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int customerID = GetCustomerID(txtCustomerName.Text.Trim());
            DateTime reservationDate = dtpReservationDate.Value;
            int hallID = Convert.ToInt32(cmbHallID.SelectedValue);
            string status = "Pending"; 

            if (customerID == -1)
            {
                MessageBox.Show("Customer not found. Please enter a valid customer.");
                return;
            }



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                INSERT INTO reservations (customerID, reservationdate, hallID, status) 
                VALUES (@customerID, @reservationDate, @hallID, @status)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@reservationDate", reservationDate);
                    cmd.Parameters.AddWithValue("@hallID", hallID);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation added successfully.");

                    LoadReservations(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                int reservationID = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["reservationID"].Value);
                int customerID = GetCustomerID(txtCustomerName.Text);

                if (customerID == -1)
                {
                    MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get and validate status
                string status = cmbReservationStatus.SelectedItem?.ToString()?.Trim() ?? "";
                List<string> allowedStatuses = new List<string> { "Pending", "Confirmed", "Cancelled" };
                if (!allowedStatuses.Contains(status))
                {
                    MessageBox.Show("Invalid status selected! Please choose from Pending, Confirmed, or Cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE reservations 
                         SET customerID = @customerID, 
                             reservationdate = @reservationDate, 
                             hallID = @hallID, 
                             status = @status 
                         WHERE reservationID = @reservationID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@reservationDate", dtpReservationDate.Value);
                        cmd.Parameters.AddWithValue("@hallID", Convert.ToInt32(cmbHallID.SelectedValue));
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@reservationID", reservationID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadReservations(); 
                        }
                        else
                        {
                            MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbHalls_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            ManageReservationsForm reservationsForm = new ManageReservationsForm();
            reservationsForm.Show();
        }

        private void txtSearchCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAssignHall_Click(object sender, EventArgs e)
        {

        }

        private void cmbReservationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
