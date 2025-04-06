using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FoodiePoint.manager;

namespace FoodiePoint.manager
{
    internal class managehalls
    {
        private manager_databasehelper dbHelper;
        public managehalls()
        {
            dbHelper = new manager_databasehelper();
        }

            public void AddHall(string hallName, int capacity, string partyType)
            {
                try
                {
                    using (SqlConnection conn = dbHelper.GetConnection())
                    {
                    string query = "INSERT INTO halls (hallname, capacity, description) VALUES (@hallname, @capacity, @description)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@hallname", hallName);
                    cmd.Parameters.AddWithValue("@capacity", capacity);
                    cmd.Parameters.AddWithValue("@description", partyType);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine($"Hall '{hallName}' added with capacity '{capacity}', and party type '{partyType}'.");
                }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                    throw;
                }
            }

        public void EditHall(string hallID, string newName, int newCapacity, string newPartyType)
        {
            try
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    if (newName != null)
                    {
                        string query = "UPDATE halls SET hallname = @hallname WHERE hallID = @hallID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@hallname", newName);
                        cmd.Parameters.AddWithValue("@hallID", hallID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"Hall '{hallID}' updated with new name '{newName}'.");
                    }
                    if (newCapacity != 0)
                    {
                        string query = "UPDATE halls SET capacity = @capacity WHERE hallID = @hallID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@capacity", newCapacity);
                        cmd.Parameters.AddWithValue("@hallID", hallID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"Hall '{hallID}' updated with new capacity '{newCapacity}'.");
                    }
                    if (newPartyType != null)
                    {
                        string query = "UPDATE halls SET description = @description WHERE hallID = @hallID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@description", newPartyType);
                        cmd.Parameters.AddWithValue("@hallID", hallID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"Hall '{hallID}' updated with new party type '{newPartyType}'.");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
        }

            public void DeleteHall(string hallID)
            {
                try
                {
                    using (SqlConnection conn = dbHelper.GetConnection())
                    {
                        string query = "DELETE FROM halls WHERE hallID = @hallID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@hallID", hallID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"Hall '{hallID}' deleted.");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                    throw;
                }
            }

        // Hall Class
        public class Hall
        {
            public string HallName { get; set; }
            public int Capacity { get; set; }
            public string PartyType { get; set; }

            public Hall(string hallName, int capacity, string partyType)
            {
                HallName = hallName;
                Capacity = capacity;
                PartyType = partyType;
            }
        }
    }
}
