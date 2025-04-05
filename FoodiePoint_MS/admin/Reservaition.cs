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
    public partial class Reservaition : Form
    {
        string connectionString = new DatabaseHelper().GetConnectionString();
        int selectedReservationID = -1;
        private int currentUserID;

        public Reservaition(int userID)
        {
            InitializeComponent();

            currentUserID = userID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reservaition_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }
        private void LoadReservations()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT reservationID, customerID, reservationdate, hallID, status FROM reservations",
                    con
                );
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReservations.DataSource = dt;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (selectedReservationID == -1)
            {
                MessageBox.Show("Please select a reservation first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE reservations SET status='Confirmed' WHERE reservationID=@id", con);
                cmd.Parameters.AddWithValue("@id", selectedReservationID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Reservation confirmed.");
            LoadReservations();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (selectedReservationID == -1)
            {
                MessageBox.Show("Please select a reservation first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE reservations SET status='Cancelled' WHERE reservationID=@id", con);
                cmd.Parameters.AddWithValue("@id", selectedReservationID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Reservation cancelled.");
            LoadReservations();
        }

        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedReservationID = Convert.ToInt32(dgvReservations.Rows[e.RowIndex].Cells["reservationID"].Value);
            }
        }
    }
}
