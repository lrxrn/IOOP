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
using FoodiePoint.Helpers;

namespace FoodiePoint.admin
{
    public partial class ViewReports : Form
    {
        string connectionString = new DatabaseHelper().GetConnectionString();
        private int currentUserID;

        public ViewReports(int userID)
        {
            InitializeComponent();

            currentUserID = userID;
        }

        private void lblRevenue_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"
            SELECT FORMAT(paymentdate, 'yyyy-MM') AS [Month], 
                   SUM(amountpaid) AS [Total Revenue]
            FROM payments
            GROUP BY FORMAT(paymentdate, 'yyyy-MM')
            ORDER BY [Month]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReports.DataSource = dt;
            }
        }

        private void ViewReports_Load(object sender, EventArgs e)
        {
            LoadMonthlyRevenue();
            LoadTotalOrders();
            LoadChefsPerformance();

        }
        private void LoadMonthlyRevenue()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(totalAmount) FROM orders", con);
                object result = cmd.ExecuteScalar();
                lblRevenue.Text = $"{result:C}";
            }
        }

        private void LoadTotalOrders()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM orders", con);
                object result = cmd.ExecuteScalar();
                lblOrders.Text = result.ToString();
            }
        }

        private void LoadChefsPerformance()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT chefName, COUNT(*) AS OrdersHandled FROM orders GROUP BY chefName", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReports.DataSource = dt;
            }
        }

        private void ViewReports_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvChefsPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblOrders_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"
            SELECT FORMAT(orderdate, 'yyyy-MM') AS [Month], 
                   COUNT(orderID) AS [Total Orders]
            FROM orders
            GROUP BY FORMAT(orderdate, 'yyyy-MM')
            ORDER BY [Month]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReports.DataSource = dt;
            }
        }

        private void lblChefs_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"
            SELECT createdBy AS Chef, COUNT(*) AS TotalDishes
            FROM menus
            GROUP BY createdBy
            ORDER BY TotalDishes DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReports.DataSource = dt;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
