using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodiePoint.admin
{
    public partial class AdminHome : Form
    {
        public int currentUserID;
        public string currentUserFullName;
        public string currentUserRole;  
        public AdminHome(int userID, string userFullName, string userRole)
        {
            InitializeComponent();
            currentUserID = userID;
            currentUserFullName = userFullName;
            currentUserRole = userRole;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Manage_Users form = new Manage_Users(currentUserID);
            form.ShowDialog();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            ViewReports form = new ViewReports(currentUserID);
            form.ShowDialog();
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            Feedback form = new Feedback(currentUserID);
            form.ShowDialog();
        }

        private void btnProfileSettings_Click(object sender, EventArgs e)
        {
            Profile form = new Profile(currentUserID);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Universal_Loginpage loginForm = new Universal_Loginpage();
            loginForm.Show();
            this.Close();
        }

        private void btnReservaition_Click(object sender, EventArgs e)
        {
            Reservaition form = new Reservaition(currentUserID);
            form.ShowDialog();

        }
    }
}
