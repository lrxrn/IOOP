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

namespace FoodiePoint.manager
{
    public partial class ManagerMain : Form
    {
        int currentUserID;
        string currentUserFullName;
        string currentUserRole;
        public ManagerMain(int userID, string userFullName, string userRole)
        {
            InitializeComponent();

            currentUserID = userID;
            currentUserFullName = userFullName;
            currentUserRole = userRole;
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            ManageMenuPricing f1 = new ManageMenuPricing();
            f1.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            HallReservationReport f2 = new HallReservationReport();
            f2.Show();
        }

        private void btnhall_Click(object sender, EventArgs e)
        {
            ManageHallDetails f3 = new ManageHallDetails();
            f3.Show();
        }

        private void btnupdateprofile_Click(object sender, EventArgs e)
        {
            ManageProfile_SH manageProfile_SH = new ManageProfile_SH(currentUserID, currentUserFullName, currentUserRole);
            manageProfile_SH.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Universal_Loginpage loginForm = new Universal_Loginpage();
            loginForm.Show();
            this.Close();
        }
    }
}
