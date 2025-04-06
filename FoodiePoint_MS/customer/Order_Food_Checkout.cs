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
    public partial class Order_Food_Checkout : Form
    {
        private const string Role = "Customer";
        private int currentUserID;
        private string currentUserFullName;
        private List<ResMenuItem> SelectedMenuItems;
        private decimal TotalAmount;

        public List<ResMenuItem> selectedOrderItems;

        public Order_Food_Checkout(int UserID, string FullName, List<ResMenuItem> MenuItems)
        {
            InitializeComponent();
            currentUserID = UserID;
            currentUserFullName = FullName;
            SelectedMenuItems = MenuItems;

            lbl_user.Text = FullName.ToString();
            lbl_role.Text = Role;

            onLoad();
        }

        private void onLoad()
        {
            lv_MenuItems_Selected.Items.Clear();
            foreach (ResMenuItem item in SelectedMenuItems)
            {
                TotalAmount += item.Price;
                lv_MenuItems_Selected.Items.Add(item.ToString());
            }
            lbl_itemCntInCart.Text = SelectedMenuItems.Count.ToString();
            lbl_PayAmt.Text = TotalAmount.ToString("C2");
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Cancelled.");
            this.Close();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            // check if paymentmethod is selected
            if (string.IsNullOrEmpty(cmb_paymentMethod.Text)) // Add this line to check if payment method is selected
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            // Use messagebox to confirm payment
            DialogResult result = MessageBox.Show("Are you sure you want to proceed with the payment?", "Confirm Payment", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Proceed with payment logic
                MessageBox.Show("Payment Successful!");
                SaveOrderToDatabase();
            }
            else
            {
                MessageBox.Show("Payment Cancelled.");
                this.Close();
            }
        }

        private void SaveOrderToDatabase()
        {
            string orderQuery = "INSERT INTO Orders (customerID, TotalAmount, OrderDate) VALUES (@customerID, @TotalAmount, @OrderDate)";
            Dictionary<string, object> orderParameters = new Dictionary<string, object>
                {
                    { "@customerID", currentUserID },
                    { "@TotalAmount", TotalAmount },
                    { "@OrderDate", DateTime.Now }
                };
            ExecuteQuery(orderQuery, orderParameters);

            string getOrderIDQuery = "SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID DESC";
            DataTable orderIDTable = ExecuteQuery(getOrderIDQuery);
            int orderID = Convert.ToInt32(orderIDTable.Rows[0]["OrderID"]);

            string paymentQuery = "INSERT INTO payments (OrderID, amountpaid, paymentmethod, paymentdate) VALUES (@orderID, @amountpaid, @paymentmethod, @paymentdate)";
            Dictionary<string, object> paymentParameters = new Dictionary<string, object>
                {
                    { "@orderID", orderID },
                    { "@amountpaid", TotalAmount },
                    { "@paymentmethod", cmb_paymentMethod.Text },
                    { "@paymentdate", DateTime.Now }
                };
            ExecuteQuery(paymentQuery, paymentParameters);

            MessageBox.Show("Order and payment has been successfully submitted.");
            this.Close();
            Customer_Main MainCustomerForm = new Customer_Main(currentUserID, currentUserFullName, Role);
            MainCustomerForm.Show();
        }

        public int StringToInt(string input)
        {
            int result;
            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException("Input string is not a valid integer.");
            }
        }

        private void btn_backToDash_Click(object sender, EventArgs e)
        {
            Customer_Main MainCustomerForm = new Customer_Main(currentUserID, currentUserFullName, Role);
            MainCustomerForm.Show();
            this.Close();
        }
    }
}
