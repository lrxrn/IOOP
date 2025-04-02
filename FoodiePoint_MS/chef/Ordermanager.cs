using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chef_assignment
{
    internal class chef_ordermanager
    {
        private chef_databasehelper dbHelper;

        public chef_ordermanager()
        {
            dbHelper = new chef_databasehelper();
        }

        public void AddOrder(int orderId, string customerName, DateTime orderDate)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string getCustomerIDQuery = "SELECT userID FROM users WHERE fullname = @customerName";
                    SqlCommand getCustomerCmd = new SqlCommand(getCustomerIDQuery, conn);
                    getCustomerCmd.Parameters.AddWithValue("@customerName", customerName);

                    conn.Open();
                    object customerIDObj = getCustomerCmd.ExecuteScalar();
                    conn.Close();

                    if (customerIDObj == null)
                    {
                        MessageBox.Show("Customer not found! Please enter a valid customer name.");
                        return;
                    }

                    int actualCustomerID = Convert.ToInt32(customerIDObj);

                    string query = "INSERT INTO orders (orderID, customerID, orderdate, status) " +
                                   "VALUES (@orderID, @customerID, @orderdate, 'In Progress')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orderID", orderId);
                    cmd.Parameters.AddWithValue("@customerID", actualCustomerID);
                    cmd.Parameters.AddWithValue("@orderdate", orderDate);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public int GenerateNewOrderID()
        {
            int newOrderId = 1;

            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "SELECT MAX(orderID) FROM orders";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        newOrderId = Convert.ToInt32(result) + 1;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }

            return newOrderId;
        }

        public chef_order FindOrder(int orderID)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string orderQuery = "SELECT o.orderID, u.fullname, o.orderdate, o.status " +
                                        "FROM orders o " +
                                        "INNER JOIN users u ON o.customerID = u.userID " +
                                        "WHERE o.orderID = @orderID";

                    SqlCommand orderCmd = new SqlCommand(orderQuery, conn);
                    orderCmd.Parameters.AddWithValue("@orderID", orderID);

                    conn.Open();
                    SqlDataReader orderReader = orderCmd.ExecuteReader();

                    if (!orderReader.Read())
                    {
                        conn.Close();
                        return null;
                    }

                    int orderId = Convert.ToInt32(orderReader["orderID"]);
                    string customerName = orderReader["fullname"].ToString();
                    DateTime orderDate = Convert.ToDateTime(orderReader["orderdate"]);
                    string status = orderReader["status"].ToString();
                    orderReader.Close();

                    string foodQuery = "SELECT m.foodname, m.category " +
                                       "FROM orderitems oi " +
                                       "INNER JOIN menus m ON oi.fooditemID = m.foodID " +
                                       "WHERE oi.orderID = @orderID";

                    SqlCommand foodCmd = new SqlCommand(foodQuery, conn);
                    foodCmd.Parameters.AddWithValue("@orderID", orderID);

                    SqlDataReader foodReader = foodCmd.ExecuteReader();
                    List<string> foodList = new List<string>();
                    while (foodReader.Read())
                    {
                        string foodName = foodReader["foodname"].ToString();
                        string category = foodReader["category"].ToString();
                        foodList.Add($"{foodName} ({category})");
                    }

                    conn.Close();

                    return new chef_order(orderId, customerName, foodList, orderDate, status);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public void UpdateOrderStatus(int orderID, string newStatus)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "UPDATE orders SET status = @status WHERE orderID = @orderID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@orderID", orderID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public List<chef_order> GetAllOrders()
        {
            List<chef_order> orders = new List<chef_order>();
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "SELECT o.orderID, u.fullname, o.orderdate, o.status " +
                                   "FROM orders o INNER JOIN users u ON o.customerID = u.userID";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        orders.Add(new chef_order(
                            Convert.ToInt32(reader["orderID"]),
                            reader["fullname"].ToString(),
                            null,
                            Convert.ToDateTime(reader["orderdate"]),
                            reader["status"].ToString()
                        ));
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
            return orders;
        }

        public int GetFoodID(string foodName)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "SELECT foodID FROM menus WHERE foodname = @foodName";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@foodName", foodName);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
            }

            return -1;
        }

        public void AddOrderItem(int orderId, int foodID, int quantity)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "INSERT INTO orderitems (orderID, fooditemID, quantity) " +
                                   "VALUES (@orderID, @foodID, @quantity)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orderID", orderId);
                    cmd.Parameters.AddWithValue("@foodID", foodID);
                    cmd.Parameters.AddWithValue("@quantity", quantity);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public void UpdateCustomerName(int orderId, string newName)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string getUserIdQuery = "SELECT customerID FROM orders WHERE orderID = @orderId";
                SqlCommand getCmd = new SqlCommand(getUserIdQuery, conn);
                getCmd.Parameters.AddWithValue("@orderId", orderId);

                conn.Open();
                object result = getCmd.ExecuteScalar();
                conn.Close();

                if (result != null)
                {
                    int customerId = Convert.ToInt32(result);

                    string updateQuery = "UPDATE users SET fullname = @newName WHERE userID = @customerId";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@newName", newName);
                    cmd.Parameters.AddWithValue("@customerId", customerId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateOrderFood(int orderId, List<string> newFoods)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string deleteQuery = "DELETE FROM orderitems WHERE orderID = @orderId";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@orderId", orderId);
                deleteCmd.ExecuteNonQuery();

                foreach (string food in newFoods)
                {
                    string getFoodIdQuery = "SELECT foodID FROM menus WHERE foodname = @food";
                    SqlCommand getFoodIdCmd = new SqlCommand(getFoodIdQuery, conn);
                    getFoodIdCmd.Parameters.AddWithValue("@food", food);

                    object result = getFoodIdCmd.ExecuteScalar();
                    if (result != null)
                    {
                        int foodId = Convert.ToInt32(result);
                        string insertQuery = "INSERT INTO orderitems (orderID, fooditemID, quantity) VALUES (@orderID, @foodID, 1)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@orderID", orderId);
                        insertCmd.Parameters.AddWithValue("@foodID", foodId);
                        insertCmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }
    }
}
