using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodiePoint.chef
{
    public partial class formchef_profilemanagment_pfm : Form
    {
        private int currentUserID;
        private string currentUserFullName;
        private string currentUserRole;

        private chef_usermanager chefManager;
        public formchef_profilemanagment_pfm(int userID, string fullName, string role)
        {
            InitializeComponent();
            chefManager = new chef_usermanager();

            currentUserID = userID;
            currentUserFullName = fullName;
            currentUserRole = role;
        }

        private void btnchef_pfm_update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtbxchef_pfm_userID.Text, out int userID))
            {
                MessageBox.Show("Invalid Chef ID.");
                return;
            }

            chef_user existingUser = chefManager.GetChefByID(userID);

            if (existingUser == null)
            {
                MessageBox.Show("Wrong ID, Try again.");
                ClearAllFields();
                return;
            }

            string newName = txtbxchef_pfm_name.Text.Trim();
            string newEmail = txtbxchef_pfm_email.Text.Trim();
            string newPassword = txtbxchef_pfm_newpassword.Text;
            string confirmPass = txtbxchef_pfm_confirmpass.Text;

            if (!string.IsNullOrEmpty(newName))
                existingUser.FullName = newName;

            if (!string.IsNullOrEmpty(newEmail))
                existingUser.Email = newEmail;

            if (!string.IsNullOrEmpty(newPassword))
            {
                if (newPassword != confirmPass)
                {
                    MessageBox.Show("New password does not match with confirm password.");
                    return;
                }

                existingUser.Password = newPassword;
            }

            if (chefManager.UpdateChefProfile(existingUser))
            {
                MessageBox.Show("Profile updated successfully.");
                DisplayChefInfo(existingUser);
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }

        private void DisplayChefInfo(chef_user user)
        {
            lsbxchef_pfm_details.Items.Clear();
            lsbxchef_pfm_details.Items.Add($"Full Name: {user.FullName}");
            lsbxchef_pfm_details.Items.Add($"Email: {user.Email}");
            lsbxchef_pfm_details.Items.Add($"User ID: {user.UserID}");
            lsbxchef_pfm_details.Items.Add($"Role: {user.Role}");
        }

        private void ClearAllFields()
        {
            txtbxchef_pfm_name.Clear();
            txtbxchef_pfm_currentpassword.Clear();
            txtbxchef_pfm_email.Clear();
            txtbxchef_pfm_newpassword.Clear();
            txtbxchef_pfm_confirmpass.Clear();
            txtbxchef_pfm_userID.Clear();
        }

        private void btnchef_pfm_chef_dashbaord_Click(object sender, EventArgs e)
        {
            var dashboard = new formchef_chefdashbaord_chd(currentUserID, currentUserFullName, currentUserRole);
            dashboard.Show();
            this.Close();
        }

        private void btnchef_pfm_cancel_Click(object sender, EventArgs e)
        {
            txtbxchef_pfm_name.Clear();
            txtbxchef_pfm_email.Clear();
            txtbxchef_pfm_newpassword.Clear();
            txtbxchef_pfm_confirmpass.Clear();

            txtbxchef_pfm_currentpassword.PasswordChar = '*';
        }

        private void formchef_profilemanagment_pfm_Load_1(object sender, EventArgs e)
        {
            chefManager = new chef_usermanager();

            int chefID = 25;

            chef_user user = chefManager.GetChefByID(chefID);

            if (user != null)
            {
                DisplayChefInfo(user);

                txtbxchef_pfm_userID.Text = user.UserID.ToString();
                txtbxchef_pfm_name.Text = user.FullName;
                txtbxchef_pfm_email.Text = user.Email;

                txtbxchef_pfm_currentpassword.Text = user.Password;
                txtbxchef_pfm_currentpassword.PasswordChar = '*';
            }
            else
            {
                MessageBox.Show("Chef profile not found.");
            }
        }

        private async void btnchef_pfm_revealpass_Click(object sender, EventArgs e)
        {
            txtbxchef_pfm_currentpassword.PasswordChar = '\0';
            await Task.Delay(3000);
            txtbxchef_pfm_currentpassword.PasswordChar = '*';
        }

        private void btnchef_pfm_showdetails_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbxchef_pfm_userID.Text, out int chefID))
            {
                chef_user user = chefManager.GetChefByID(chefID);
                if (user != null)
                {
                    DisplayChefInfo(user);
                }
            }
        }

        private void btnchef_pfm_clearbox_Click(object sender, EventArgs e)
        {
            lsbxchef_pfm_details.Items.Clear();
        }
    }
}
