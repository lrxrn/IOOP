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
    public partial class Feedback : Form
    {
        string connectionString = new DatabaseHelper().GetConnectionString();
        private int currentUserID;
        public Feedback(int userID)
        {
            InitializeComponent();


            currentUserID = userID;
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            LoadFeedback();
            CustomizeGridView();

        }
        private void LoadFeedback()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = @"
                SELECT 
                    users.fullname AS CustomerName,
                    feedback.feedbacktype AS FeedbackType,
                    feedback.comments AS Comments,
                    feedback.timestamp AS SubmittedAt
                FROM feedback
                INNER JOIN users ON feedback.customerID = users.userID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvFeedback.DataSource = dt;

            con.Close();
        }

        private void CustomizeGridView()
        {
            dgvFeedback.DefaultCellStyle.ForeColor = Color.White;
            dgvFeedback.DefaultCellStyle.BackColor = Color.Navy;
            dgvFeedback.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dgvFeedback.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvFeedback.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvFeedback.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvFeedback.EnableHeadersVisualStyles = false;

            dgvFeedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeedback.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFeedback.ReadOnly = true;
        }
    }
}
