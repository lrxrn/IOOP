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

namespace FoodiePoint.customer
{
    public partial class View_Status : Form
    {
        private const string Role = "Customer";
        private int currentUserID;
        private string currentUserFullName;

        public View_Status(int UserID, string FullName)
        {
            InitializeComponent();
            currentUserID = UserID;
            currentUserFullName = FullName;

            lbl_user.Text = FullName.ToString();
            lbl_role.Text = Role;

            onLoad();
        }

        private void onLoad()
        {
            lv_OrderStatusItems.Items.Clear();
            lv_ReservationItems.Items.Clear();
            getOrderStatus();
            getReservationStatus();
        }

        public void getOrderStatus()
        {
            DataTable orderStatus = ExecuteQuery("SELECT * FROM orders WHERE customerID = @id", new Dictionary<string, object> { { "@id", currentUserID } });
            foreach (DataRow row in orderStatus.Rows)
            {
                lv_OrderStatusItems.Items.Add($"ID: {row["orderID"]}, Status: {row["status"]}");
            }
        }

        public void getReservationStatus()
        {
            DataTable reservationStatus = ExecuteQuery("SELECT * FROM reservations WHERE customerID = @id", new Dictionary<string, object> { { "@id", currentUserID } });
            foreach (DataRow row in reservationStatus.Rows)
            {
                lv_ReservationItems.Items.Add($"ID: {row["reservationID"]}, Status: {row["status"]}");
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

        private void btn_backToDash_Click(object sender, EventArgs e)
        {
            Customer_Main MainCustomerForm = new Customer_Main(currentUserID, currentUserFullName, Role);
            MainCustomerForm.Show();
            this.Close();
        }
    }
}
