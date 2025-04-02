using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chef_assignment
{
    public partial class formchef_chefdashbaord_chd : Form
    {
        private int currentUserID;
        private string currentUserFullName;
        private string currentUserRole;

        public formchef_chefdashbaord_chd(int userID, string fullName, string role)
        {
            InitializeComponent();

            currentUserID = userID;
            currentUserFullName = fullName;
            currentUserRole = role;

            lblchef_chd_username.Text = $"User: {currentUserFullName}\nUser ID: {currentUserID}\nRole: {currentUserRole}";
        }

        private void btnchef_chd_manage_order_Click(object sender, EventArgs e)
        {
            formchef_ordermanagment_odmg formchef_Ordermanagment_Odmg = new formchef_ordermanagment_odmg(currentUserID, currentUserFullName, currentUserRole);
            formchef_Ordermanagment_Odmg.Show();
            this.Hide();
        }

        private void btnchef_chd_manage_inventory_Click(object sender, EventArgs e)
        {
            var formchef_Inventorymanagment_Inm = new formchef_inventorymanagment_inm(currentUserID, currentUserFullName, currentUserRole);
            formchef_Inventorymanagment_Inm.Show();
            this.Hide();
        }

        private void btnchef_chd_profile_setting_Click(object sender, EventArgs e)
        {
            var formchef_Profilemanagment_Pfm = new formchef_profilemanagment_pfm(currentUserID, currentUserFullName, currentUserRole); // ✅
            formchef_Profilemanagment_Pfm.Show();
            this.Hide();
        }

        private void btnchef_chd_logout_Click(object sender, EventArgs e)
        {
            Universal_Loginpage loginForm = new Universal_Loginpage();
            loginForm.Show();
            this.Close();
        }

        private void lblchef_chd_username_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User: {currentUserFullName}\nUser ID: {currentUserID}\nUser Role: {currentUserRole}", "Current User Info");
        }

        private void formchef_chefdashbaord_chd_Load(object sender, EventArgs e)
        {
        }

        private string GetCustomerName(int customerID, SqlConnection conn)
        {
            string query = "SELECT fullname FROM users WHERE userID = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", customerID);
            object result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : "Unknown";
        }

        private void formchef_chefdashbaord_chd_Load_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new chef_databasehelper().GetConnection())
            {
                conn.Open();
                string completedQuery = "SELECT TOP 7 orderID, customerID FROM orders WHERE LOWER(status) = 'completed' ORDER BY orderID ASC";

                SqlCommand cmdCompleted = new SqlCommand(completedQuery, conn);
                SqlDataReader readerCompleted = cmdCompleted.ExecuteReader();

                lsbxchef_chd_completed.Items.Clear();
                int completedCount = 0;

                while (readerCompleted.Read())
                {
                    int orderID = (int)readerCompleted["orderID"];
                    int customerID = (int)readerCompleted["customerID"];
                    string customerName = GetCustomerName(customerID, conn);
                    lsbxchef_chd_completed.Items.Add($"{orderID}: {customerName}");
                    completedCount++;
                }
                readerCompleted.Close();

                lblbxchef_chd_completedcount.Text = completedCount.ToString();

                string inProgressQuery = "SELECT orderID, customerID FROM orders WHERE LOWER(status) = 'in progress'";
                SqlCommand cmdInProgress = new SqlCommand(inProgressQuery, conn);
                SqlDataReader readerInProgress = cmdInProgress.ExecuteReader();

                lsbxchef_chd_inprogress.Items.Clear();
                int inProgressCount = 0;
                while (readerInProgress.Read())
                {
                    int orderID = (int)readerInProgress["orderID"];
                    int customerID = (int)readerInProgress["customerID"];
                    string customerName = GetCustomerName(customerID, conn);
                    lsbxchef_chd_inprogress.Items.Add($"{orderID}: {customerName}");
                    inProgressCount++;
                }
                readerInProgress.Close();
                lblbxchef_chd_inprogresscount.Text = inProgressCount.ToString();

                string lowInventoryQuery = "SELECT ingredientID, ingredientname, ingredientquantity FROM inventory WHERE ingredientquantity < 10";
                SqlCommand cmdInventory = new SqlCommand(lowInventoryQuery, conn);
                SqlDataReader readerInventory = cmdInventory.ExecuteReader();

                lsbxchef_chd_lowinventory.Items.Clear();
                int lowCount = 0;
                while (readerInventory.Read())
                {
                    int id = (int)readerInventory["ingredientID"];
                    string name = readerInventory["ingredientname"].ToString();
                    int qty = (int)readerInventory["ingredientquantity"];
                    lsbxchef_chd_lowinventory.Items.Add($"{id}: {name} - {qty}");
                    lowCount++;
                }
                readerInventory.Close();
                lblbxchef_chd_lowinventorycount.Text = lowCount.ToString();
            }
        }
    }
}
