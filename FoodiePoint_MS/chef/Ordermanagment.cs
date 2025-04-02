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
    public partial class formchef_ordermanagment_odmg : Form
    {
        private int currentUserID;
        private string currentUserFullName;
        private string currentUserRole;

        private chef_ordermanager orderManager;
        public formchef_ordermanagment_odmg(int userID, string fullName, string role)
        {
            InitializeComponent();
            orderManager = new chef_ordermanager();

            currentUserID = userID;
            currentUserFullName = fullName;
            currentUserRole = role;

            lblchef_odmg_username.Text = $"User: {currentUserFullName}\nUser ID: {currentUserID}\nRole: {currentUserRole}";

            LoadOrders();
        }

        private void Order_managment_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(txtbxchef_odmg_view_ID.Text);
            chef_order order = orderManager.FindOrder(orderId);
            if (order != null)
            {
                txtbxchef_odmg_view_name.Text = order.CustomerName;
                dtpchef_odmg_viewdate.Text = order.OrderDate.ToString();
                cobxchef_odmg_viewstatus.Text = order.Status;
            }
            else
            {
                MessageBox.Show("Order Not Found!");
            }
        }

        private void LoadOrders()
        {
            lsbxchef_odmg_details.Items.Clear();
            lstvwchef_odmg_table.Items.Clear();
            lstvwchef_odmg_table.Columns.Clear();

            lstvwchef_odmg_table.Columns.Add("Order ID", 80);
            lstvwchef_odmg_table.Columns.Add("Customer Name", 150);
            lstvwchef_odmg_table.Columns.Add("Order Date", 150);
            lstvwchef_odmg_table.Columns.Add("Status", 120);

            List<chef_order> orders = orderManager.GetAllOrders();
            if (orders.Count == 0)
            {
                MessageBox.Show("No orders found.");
                return;
            }

            foreach (var order in orders)
            {
                var item = new ListViewItem(order.OrderID.ToString());
                item.SubItems.Add(order.CustomerName);
                item.SubItems.Add(order.OrderDate.ToString("yyyy-MM-dd HH:mm"));
                item.SubItems.Add(order.Status);
                lstvwchef_odmg_table.Items.Add(item);
            }
        }

        private void btnchef_odmg_chefdashbaord_Click(object sender, EventArgs e)
        {
            var dashboard = new formchef_chefdashbaord_chd(currentUserID, currentUserFullName, currentUserRole);
            dashboard.Show();
            this.Close();
        }

        private void btnchef_odmg_update_cancel_Click(object sender, EventArgs e)
        {
            txtbxchef_odmg_view_ID.Clear();
            txtbxchef_odmg_view_name.Clear();
            dtpchef_odmg_viewdate.Value = DateTime.Now;
            cobxchef_odmg_viewstatus.SelectedIndex = -1;

            lsbxchef_odmg_details.Items.Clear();
        }

        private void btnchef_odmg_view_find_Click(object sender, EventArgs e)
        {
            lsbxchef_odmg_details.Items.Clear();

            if (!int.TryParse(txtbxchef_odmg_view_ID.Text.Trim(), out int orderId))
            {
                MessageBox.Show("Invalid Order ID! Please enter a valid number.");
                return;
            }

            var order = orderManager.FindOrder(orderId);

            if (order != null)
            {
                txtbxchef_odmg_view_name.Text = order.CustomerName;
                dtpchef_odmg_viewdate.Value = order.OrderDate;
                cobxchef_odmg_viewstatus.Text = order.Status;

                lsbxchef_odmg_details.Items.Add($"Order ID: {order.OrderID}");
                lsbxchef_odmg_details.Items.Add($"Customer Name: {order.CustomerName}");
                lsbxchef_odmg_details.Items.Add($"Order Date: {order.OrderDate:yyyy-MM-dd HH:mm}");
                lsbxchef_odmg_details.Items.Add($"Status: {order.Status}");

                if (order.FoodItems != null && order.FoodItems.Count > 0)
                {
                    lsbxchef_odmg_details.Items.Add("Foods Ordered:");
                    foreach (var food in order.FoodItems)
                        lsbxchef_odmg_details.Items.Add($"- {food}");
                }
                else
                {
                    lsbxchef_odmg_details.Items.Add("No food items found for this order.");
                }
            }
            else
            {
                MessageBox.Show("Order not found.");
            }
        }

        private void btnchef_odmg_order_order_Click(object sender, EventArgs e)
        {
         
        }

        private void btnchef_odmg_update_update_Click(object sender, EventArgs e)
        {
            lsbxchef_odmg_details.Items.Clear();

            if (!int.TryParse(txtbxchef_odmg_update_ID.Text.Trim(), out int orderId))
            {
                MessageBox.Show("Invalid Order ID.");
                return;
            }

            chef_order existingOrder = orderManager.FindOrder(orderId);
            if (existingOrder == null)
            {
                MessageBox.Show("Order does not exist. Try again.");

                txtbxchef_odmg_update_ID.Clear();
                txtbxchef_odmg_update_customername.Clear();
                cobxchef_odmg_updatestatus.SelectedIndex = -1;
            }

            string newName = txtbxchef_odmg_update_customername.Text.Trim();
            string newStatus = cobxchef_odmg_updatestatus.Text.Trim();

            List<string> selectedFoods = new List<string>();

            bool updated = false;

            if (!string.IsNullOrWhiteSpace(newName))
            {
                orderManager.UpdateCustomerName(orderId, newName);
                updated = true;
            }

            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                orderManager.UpdateOrderStatus(orderId, newStatus);
                updated = true;
            }

            if (selectedFoods.Count > 0)
            {
                orderManager.UpdateOrderFood(orderId, selectedFoods);
                updated = true;
            }

            if (updated)
            {
                MessageBox.Show("Update successful!");

                chef_order updatedOrder = orderManager.FindOrder(orderId);

                lsbxchef_odmg_details.Items.Add($"Order ID: {updatedOrder.OrderID}");
                lsbxchef_odmg_details.Items.Add($"Customer Name: {updatedOrder.CustomerName}");
                lsbxchef_odmg_details.Items.Add($"Status: {updatedOrder.Status}");

                if (updatedOrder.FoodItems != null && updatedOrder.FoodItems.Count > 0)
                {
                    lsbxchef_odmg_details.Items.Add("Foods Ordered:");
                    foreach (var food in updatedOrder.FoodItems)
                    {
                        lsbxchef_odmg_details.Items.Add($"- {food}");
                    }
                }

                lsbxchef_odmg_details.Items.Add("-- Order updated successfully --");
            }

            LoadOrders();
        }

        private void lstvwchef_odmg_table_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnchef_inmg_cleardisplay_Click(object sender, EventArgs e)
        {
            lsbxchef_odmg_details.Items.Clear();
        }

        private void btnchef_odmg_update_cancel_Click_1(object sender, EventArgs e)
        {
            txtbxchef_odmg_view_ID.Clear();
            txtbxchef_odmg_view_name.Clear();
            dtpchef_odmg_viewdate.Value = DateTime.Now;
            cobxchef_odmg_viewstatus.SelectedIndex = -1;
            lsbxchef_odmg_details.Items.Clear();
        }

        private void lblchef_odmg_username_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User: {currentUserFullName}\nUser ID: {currentUserID}\nUser Role: {currentUserRole}", "Current User Info");
        }

        private void btnchef_odmg_view_findbyname_Click(object sender, EventArgs e)
        {
            string customerName = txtbxchef_odmg_view_name.Text.Trim();
            lsbxchef_odmg_details.Items.Clear();

            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Please enter a customer name.");
                return;
            }

            using (SqlConnection conn = new chef_databasehelper().GetConnection())
            {
                conn.Open();

                string getUserQuery = "SELECT userID FROM users WHERE fullname = @name";
                SqlCommand cmdUser = new SqlCommand(getUserQuery, conn);
                cmdUser.Parameters.AddWithValue("@name", customerName);

                object result = cmdUser.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Customer doesn't exist.");
                    return;
                }

                int customerID = Convert.ToInt32(result);
                lsbxchef_odmg_details.Items.Add($"Customer Name: {customerName} (ID: {customerID})");
                lsbxchef_odmg_details.Items.Add("Foods Ordered:");

                string orderQuery = "SELECT orderID FROM orders WHERE customerID = @custID";
                SqlCommand cmdOrders = new SqlCommand(orderQuery, conn);
                cmdOrders.Parameters.AddWithValue("@custID", customerID);

                List<int> orderIDs = new List<int>();
                SqlDataReader readerOrders = cmdOrders.ExecuteReader();
                while (readerOrders.Read())
                {
                    orderIDs.Add((int)readerOrders["orderID"]);
                }
                readerOrders.Close();

                if (orderIDs.Count == 0)
                {
                    lsbxchef_odmg_details.Items.Add("- No orders found.");
                    return;
                }

                foreach (int orderID in orderIDs)
                {
                    string foodQuery = @"
                SELECT oi.fooditemID, m.foodname
                FROM orderitems oi
                JOIN menus m ON oi.fooditemID = m.foodID
                WHERE oi.orderID = @oid";
                    SqlCommand cmdFoods = new SqlCommand(foodQuery, conn);
                    cmdFoods.Parameters.AddWithValue("@oid", orderID);

                    SqlDataReader readerFoods = cmdFoods.ExecuteReader();
                    while (readerFoods.Read())
                    {
                        int foodID = (int)readerFoods["fooditemID"];
                        string foodName = readerFoods["foodname"].ToString();
                        lsbxchef_odmg_details.Items.Add($"- {orderID} : : {foodName}");
                    }
                    readerFoods.Close();
                }
            }
        }
    }
}
