using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chef_assignment
{
    internal class chef_inventorymanager
    {
        private chef_databasehelper dbHelper;

        public chef_inventorymanager()
        {
            dbHelper = new chef_databasehelper();
        }

        public void AddIngredient(string name, int quantity)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string status = quantity > 10 ? "Sufficient" : "Low";

                    string query = "INSERT INTO inventory (ingredientname, ingredientquantity, ingredientsufficient) VALUES (@ingredientname, @ingredientquantity, @ingredientsufficient)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ingredientname", name);
                    cmd.Parameters.AddWithValue("@ingredientquantity", quantity);
                    cmd.Parameters.AddWithValue("@ingredientsufficient", status);

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

        public chef_ingredient FindIngredient(int id)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "SELECT * FROM inventory WHERE ingredientID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new chef_ingredient(
                            Convert.ToInt32(reader["ingredientID"]),
                            reader["ingredientname"].ToString(),
                            Convert.ToInt32(reader["ingredientquantity"]),
                            reader["ingredientsufficient"].ToString()
                        );
                    }
                    return null;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public void UpdateIngredientName(int id, string newName)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "UPDATE inventory SET ingredientname = @newingredientName WHERE ingredientID = @ingredientID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@newingredientName", newName);
                    cmd.Parameters.AddWithValue("@ingredientID", id);

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

        public void DeleteIngredient(int id)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "DELETE FROM inventory WHERE ingredientID = @ingredientID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ingredientID", id);

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

        public List<chef_ingredient> GetAllIngredients()
        {
            List<chef_ingredient> ingredients = new List<chef_ingredient>();
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "SELECT * FROM inventory ORDER BY ingredientID ASC";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ingredients.Add(new chef_ingredient(
                            Convert.ToInt32(reader["ingredientID"]),
                            reader["ingredientname"].ToString(),
                            Convert.ToInt32(reader["ingredientquantity"]),
                            reader["ingredientsufficient"].ToString()
                        ));
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
            return ingredients;
        }

        public chef_ingredient FindIngredientByName(string name)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "SELECT * FROM inventory WHERE ingredientname = @name";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new chef_ingredient(
                            Convert.ToInt32(reader["ingredientID"]),
                            reader["ingredientname"].ToString(),
                            Convert.ToInt32(reader["ingredientquantity"]),
                            reader["ingredientsufficient"].ToString()
                        );
                    }
                    return null;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

        public void UpdateIngredientQuantity(int id, int newQuantity)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string status = newQuantity > 10 ? "Sufficient" : "Low";

                    string query = "UPDATE inventory SET ingredientquantity = @quantity, ingredientsufficient = @status WHERE ingredientID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@quantity", newQuantity);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", id);

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
    }
}
