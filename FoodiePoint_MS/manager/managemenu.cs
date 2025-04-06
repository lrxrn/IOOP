using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodiePoint.manager;

namespace FoodiePoint.manager
{
    internal class managemenu
    {
            private manager_databasehelper dbHelper;

            public managemenu()
            {
                dbHelper = new manager_databasehelper();
            }

            public void AddMenuItem(string name, string category, decimal price)
            {
                try
                {
                    using (SqlConnection conn = dbHelper.GetConnection())
                    {
                        string query = "INSERT INTO menus (foodname, category, price) VALUES (@foodname, @category, @price)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@foodname", name);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@price", price);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"Menu item '{name}' added with price '{price}'.");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                    throw;
                }
            }

            public void EditMenuItem(string foodID, string newName, decimal newPrice)
            {
                try
                {
                    using (SqlConnection conn = dbHelper.GetConnection())
                    {
                        if (newName != null)
                        {
                            string query = "UPDATE menus SET foodname = @foodname WHERE foodID = @foodID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@foodID", foodID);
                            cmd.Parameters.AddWithValue("@foodname", newName);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            Console.WriteLine($"Menu item '{foodID}' updated with new name '{newName}'.");
                        }

                        if (newPrice != 0)
                        {
                            string query = "UPDATE menus SET price = @price WHERE foodID = @foodID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@foodID", foodID);
                            cmd.Parameters.AddWithValue("@price", newPrice);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            Console.WriteLine($"Menu item '{foodID}' updated with new price '{newPrice}'.");
                        }

                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                    throw;
                }
            }

            public void DeleteMenuItem(int foodID)
            {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "DELETE FROM menus WHERE foodID = @foodID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@foodID", foodID);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    Console.WriteLine($"Menu item '{foodID}' deleted.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }
        public class MenuItem
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }

            public MenuItem(string name, string category, decimal price)
            {
                Name = name;
                Category = category;
                Price = price;
            }
        }
    }
}
