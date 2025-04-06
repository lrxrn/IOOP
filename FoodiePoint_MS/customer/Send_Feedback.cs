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
    public partial class Send_Feedback : Form
    {
        private const string Role = "Customer";
        private int currentUserID;
        private string currentUserFullName;

        public Send_Feedback(int UserID, string FullName)
        {
            InitializeComponent();
            currentUserID = UserID;
            currentUserFullName = FullName;

            lbl_user.Text = FullName.ToString();
            lbl_role.Text = Role;
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

        private void btn_backToDash_Click(object sender, EventArgs e)
        {
            Customer_Main MainCustomerForm = new Customer_Main(currentUserID, currentUserFullName, Role);
            MainCustomerForm.Show();
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string feedbackType = "";
            // check if feedback is empty
            if (string.IsNullOrEmpty(txt_feedback.Text))
            {
                MessageBox.Show("Please enter your feedback.");
                return;
            }
            // check if feedback is too long
            if (txt_feedback.Text.Length > 500)
            {
                MessageBox.Show("Feedback is too long. Please limit it to 500 characters.");
                return;
            }
            // check type
            if (rbtn_food.Checked)
            {
                feedbackType = "food";
            }
            else if (rbtn_reservation.Checked)
            {
                feedbackType = "reservation";
            }
            else
            {
                MessageBox.Show("Please select a feedback type.");
                return;
            }

            //add to db
            ExecuteQuery("INSERT INTO feedback (customerID, feedbacktype, comments) VALUES (@customerID, @feedbacktype, @comments)",
                new Dictionary<string, object>
                {
                    { "@customerID", currentUserID },
                    { "@feedbacktype", feedbackType },
                    { "@comments", txt_feedback.Text }
                });

            // show success message
            MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // clear the text box
            txt_feedback.Clear();
            // uncheck the radio buttons
            rbtn_food.Checked = false;
            rbtn_reservation.Checked = false;
        }
    }
}
