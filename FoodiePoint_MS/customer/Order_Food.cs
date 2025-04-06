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
        private List<ResMenuItem> resMenuItems;

        public List<ResMenuItem> selectedOrderItems;
        public Order_Food(int UserID, string FullName)
        {
            InitializeComponent();
            currentUserID = UserID;
            currentUserFullName = FullName;

            lbl_user.Text = FullName.ToString();
            lbl_role.Text = Role;

            selectedOrderItems = new List<ResMenuItem>();

            onLoad();
        }

        private void onLoad()
        {
            lv_MenuItems.Items.Clear();
            resMenuItems = getMenuItems();
            foreach (ResMenuItem item in resMenuItems)
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
                    ImagePath = row["imagePath"].ToString(),
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

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            Order_Food_Checkout order_Food_Checkout = new Order_Food_Checkout(currentUserID, currentUserFullName, selectedOrderItems);
            order_Food_Checkout.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (lbl_SelectedItemIndex.Text == "-")
            {
                MessageBox.Show("Select an item to add to your order.");
            } else
            {
                int SelectedItemIndexInt = StringToInt(lbl_SelectedItemIndex.Text);
                ResMenuItem SelectedItem = resMenuItems[SelectedItemIndexInt];
                ItemSelected(SelectedItem);
            }
        }

        private void ItemSelected(ResMenuItem SelectedItem)
        {
            selectedOrderItems.Add(SelectedItem);
            lbl_itemCntInCart.Text = selectedOrderItems.Count.ToString();
            MessageBox.Show($"Item added to cart: {SelectedItem.ToString()}");
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

        private void lv_MenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_MenuItems.SelectedItems.Count > 0)
            {
                lbl_selectedItem.Text = lv_MenuItems.SelectedItem.ToString();
                lbl_SelectedItemIndex.Text = lv_MenuItems.SelectedIndex.ToString();
            } else
            {
                lbl_selectedItem.Text = "No Item Selected.";
                lbl_SelectedItemIndex.Text = "-";
            }
        }
    }
}
