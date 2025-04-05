using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodiePoint.reservation
{
    internal class ReservationManager
    {
        // Connection string 
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moham\source\repos\Reservation\Reservation\restaurant.mdf\Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

        // Add Reservation Method
        public bool AddReservation(Reservation reservation)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Reservations 
                        (CustomerName, ContactDetails, PartySize, ReservationDate, HallTime, Status) 
                        VALUES 
                        (@CustomerName, @ContactDetails, @PartySize, @ReservationDate, @HallTime, @Status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", reservation.CustomerName);
                        command.Parameters.AddWithValue("@ReservationDate", reservation.ReservationDate);
                        command.Parameters.AddWithValue("@HallTime", reservation.HallTime);
                        command.Parameters.AddWithValue("@Status", reservation.Status);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error adding reservation: " + ex.Message);
                return false;
            }
        }

        // Edit Reservation Method
        public bool EditReservation(Reservation reservation)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Reservations 
                        SET CustomerName = @CustomerName,  
                            ReservationDate = @ReservationDate, 
                            HallTime = @HallTime, 
                            Status = @Status 
                        WHERE ReservationId = @ReservationId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationId", reservation.ReservationId);
                        command.Parameters.AddWithValue("@CustomerName", reservation.CustomerName);;
                        command.Parameters.AddWithValue("@CustomerID", reservation.CustomerID); ;
                        command.Parameters.AddWithValue("@ReservationDate", reservation.ReservationDate);
                        command.Parameters.AddWithValue("@HallTime", reservation.HallTime);
                        command.Parameters.AddWithValue("@Status", reservation.Status);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error editing reservation: " + ex.Message);
                return false;
            }
        }

        // Delete Reservation Method
        public bool DeleteReservation(int reservationID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Reservations WHERE ReservationID = @ReservationID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ReservationID", reservationID);
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    // Log the exception
                    Console.WriteLine("Error deleting reservation: " + ex.Message);
                    MessageBox.Show("Error deleting reservation: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } 
        }

        // Search Reservations Method
        public List<Reservation> SearchReservations(string customerName)
        {
            List<Reservation> reservations = new List<Reservation>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Reservations WHERE CustomerName LIKE @CustomerName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", "%" + customerName + "%");

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                reservations.Add(new Reservation
                                {
                                    ReservationId = Convert.ToInt32(reader["ReservationId"]),
                                    CustomerName = reader["CustomerName"].ToString() ?? string.Empty,
                                    ReservationDate = Convert.ToDateTime(reader["ReservationDate"]),
                                    HallTime = reader["HallTime"].ToString()?? string.Empty,
                                    Status = reader["Status"].ToString() ?? string.Empty,
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error searching reservations: " + ex.Message);
            }

            return reservations;
        }
    }
}
