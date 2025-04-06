using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodiePoint.Helpers;

namespace FoodiePoint.customer
{
    public partial class Customer_Main : Form
    {
        private int currentUserID;
        private string currentUserFullName;
        private string currentUserRole;

        public Customer_Main(int userID, string fullName, string role)
        {
            InitializeComponent();

            currentUserID = userID;
            currentUserFullName = fullName;
            currentUserRole = role;

            lbl_user.Text = fullName.ToString();
            lbl_role.Text = role.ToString();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            var Order_Food_Form = new Order_Food(currentUserID, currentUserFullName);
            Order_Food_Form.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Universal_Loginpage loginForm = new Universal_Loginpage();
            loginForm.Show();
            this.Close();
        }

        private void btn_updateProfile_Click(object sender, EventArgs e)
        {
            ManageProfile_SH manageProfile_SH = new ManageProfile_SH(currentUserID, currentUserFullName, currentUserRole);
            manageProfile_SH.Show();
            this.Close();
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            View_Status view_Status = new View_Status(currentUserID, currentUserFullName);
            view_Status.Show();
            this.Hide();
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {
            Send_Feedback send_Feedback = new Send_Feedback(currentUserID, currentUserFullName);
            send_Feedback.Show();
            this.Hide();
        }
    }
}
