using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodiePoint.Models;

namespace FoodiePoint.Helpers
{
    public partial class ManageProfile_SH : Form
    {
        private int currentUserID;
        private string currentUserFullName;
        private string currentUserRole;

        private User CurrentUser;
        public ManageProfile_SH(int userID, string fullName, string role)
        {
            InitializeComponent();

            currentUserID = userID;
            currentUserFullName = fullName;
            currentUserRole = role;

            CurrentUser = new User(currentUserID);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            User existingUser = CurrentUser.UserID == currentUserID ? CurrentUser : null;

            if (existingUser == null)
            {
                MessageBox.Show("Something went wrong, Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAllFields();
                return;
            }

            string newName = txt_name.Text.Trim();
            string newEmail = txt_email.Text.Trim();
            string newPassword = txt_pwd.Text;
            string confirmPass = txt_pwdcnf.Text;

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

            if (CurrentUser.UpdateUser(existingUser))
            {
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAllFields()
        {
            txt_name.Clear();
            txt_curpwd.Clear();
            txt_email.Clear();
            txt_pwd.Clear();
            txt_pwdcnf.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            var loginPage = new Universal_Loginpage();
            loginPage.Show();
            this.Close();
        }

        private void form_Load_1(object sender, EventArgs e)
        {

            lbl_userid.Text = CurrentUser.UserID.ToString();
            lbl_username.Text = CurrentUser.Username;
            txt_name.Text = CurrentUser.FullName;
            txt_email.Text = CurrentUser.Email;

            txt_curpwd.PasswordChar = '*';
            txt_curpwd.Text = CurrentUser.Password;
        }
    }
}
