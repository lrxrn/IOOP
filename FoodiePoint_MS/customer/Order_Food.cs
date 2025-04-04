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
    public partial class Order_Food : Form
    {
        private const string Role = "Customer";
        private int currentUserID;
        private string currentUserFullName;
        public Order_Food(int UserID, string FullName)
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
            lv_MenuItems.Items.Clear();
            List<ResMenuItem> RestaurantMenuItemList = getMenuItems();
            foreach (ResMenuItem item in RestaurantMenuItemList)
            {
                lv_MenuItems.Items.Add(item.ToString());
            }
        }

        private List<ResMenuItem> getMenuItems()
        {
            List<ResMenuItem> items = new List<ResMenuItem>();
            DataTable menusItem = ExecuteQuery("SELECT * FROM menus");

            foreach (DataRow row in menusItem.Rows)
            {
                ResMenuItem item = new ResMenuItem
                {
                    Id = Convert.ToInt32(row["foodID"]),
                    Name = row["foodname"].ToString(),
                    Price = Convert.ToDecimal(row["price"]),
                    Category = row["category"].ToString(),
                    IsAvailable = Convert.ToBoolean(row["isAvailable"]),
                    ImagePath = row["image"].ToString(),
            };

                items.Add(item);
            }

            return items;
        }

        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new DatabaseHelper().GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters if provided
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    conn.Open();

                    // Use SqlDataAdapter to fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }
    }
}
