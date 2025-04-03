namespace chef_assignment
{
    partial class Universal_Loginpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlchef_loginpage_info = new System.Windows.Forms.Panel();
            this.pbchef_loginpage_picture = new System.Windows.Forms.PictureBox();
            this.loginpage_exit = new System.Windows.Forms.Button();
            this.loginpage_login = new System.Windows.Forms.Button();
            this.lblchef_loginpage_password = new System.Windows.Forms.Label();
            this.lblchef_loginpage_userID = new System.Windows.Forms.Label();
            this.lblchef_loginpage_title = new System.Windows.Forms.Label();
            this.loginpage_password = new System.Windows.Forms.TextBox();
            this.loginpage_userID = new System.Windows.Forms.TextBox();
            this.pbchef_loginpage_picture2 = new System.Windows.Forms.PictureBox();
            this.pnlchef_loginpage_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbchef_loginpage_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbchef_loginpage_picture2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlchef_loginpage_info
            // 
            this.pnlchef_loginpage_info.BackColor = System.Drawing.Color.Orange;
            this.pnlchef_loginpage_info.Controls.Add(this.pbchef_loginpage_picture);
            this.pnlchef_loginpage_info.Controls.Add(this.loginpage_exit);
            this.pnlchef_loginpage_info.Controls.Add(this.loginpage_login);
            this.pnlchef_loginpage_info.Controls.Add(this.lblchef_loginpage_password);
            this.pnlchef_loginpage_info.Controls.Add(this.lblchef_loginpage_userID);
            this.pnlchef_loginpage_info.Controls.Add(this.lblchef_loginpage_title);
            this.pnlchef_loginpage_info.Controls.Add(this.loginpage_password);
            this.pnlchef_loginpage_info.Controls.Add(this.loginpage_userID);
            this.pnlchef_loginpage_info.Location = new System.Drawing.Point(385, 0);
            this.pnlchef_loginpage_info.Name = "pnlchef_loginpage_info";
            this.pnlchef_loginpage_info.Size = new System.Drawing.Size(379, 455);
            this.pnlchef_loginpage_info.TabIndex = 29;
            // 
            // pbchef_loginpage_picture
            // 
            this.pbchef_loginpage_picture.Image = global::chef_assignment.Properties.Resources.LOGO;
            this.pbchef_loginpage_picture.InitialImage = global::chef_assignment.Properties.Resources.LOGO;
            this.pbchef_loginpage_picture.Location = new System.Drawing.Point(128, 22);
            this.pbchef_loginpage_picture.Name = "pbchef_loginpage_picture";
            this.pbchef_loginpage_picture.Size = new System.Drawing.Size(124, 109);
            this.pbchef_loginpage_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbchef_loginpage_picture.TabIndex = 39;
            this.pbchef_loginpage_picture.TabStop = false;
            // 
            // loginpage_exit
            // 
            this.loginpage_exit.BackColor = System.Drawing.Color.SandyBrown;
            this.loginpage_exit.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpage_exit.Location = new System.Drawing.Point(62, 364);
            this.loginpage_exit.Name = "loginpage_exit";
            this.loginpage_exit.Size = new System.Drawing.Size(107, 30);
            this.loginpage_exit.TabIndex = 38;
            this.loginpage_exit.Text = "Exit";
            this.loginpage_exit.UseVisualStyleBackColor = false;
            this.loginpage_exit.Click += new System.EventHandler(this.btnchef_loginpage_exit_Click);
            // 
            // loginpage_login
            // 
            this.loginpage_login.BackColor = System.Drawing.Color.DarkOrange;
            this.loginpage_login.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpage_login.Location = new System.Drawing.Point(217, 364);
            this.loginpage_login.Name = "loginpage_login";
            this.loginpage_login.Size = new System.Drawing.Size(107, 30);
            this.loginpage_login.TabIndex = 36;
            this.loginpage_login.Text = "Log In";
            this.loginpage_login.UseVisualStyleBackColor = false;
            this.loginpage_login.Click += new System.EventHandler(this.btnchef_loginpage_login_Click);
            // 
            // lblchef_loginpage_password
            // 
            this.lblchef_loginpage_password.AutoSize = true;
            this.lblchef_loginpage_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchef_loginpage_password.Location = new System.Drawing.Point(24, 279);
            this.lblchef_loginpage_password.Name = "lblchef_loginpage_password";
            this.lblchef_loginpage_password.Size = new System.Drawing.Size(91, 20);
            this.lblchef_loginpage_password.TabIndex = 34;
            this.lblchef_loginpage_password.Text = "Password:";
            // 
            // lblchef_loginpage_userID
            // 
            this.lblchef_loginpage_userID.AutoSize = true;
            this.lblchef_loginpage_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchef_loginpage_userID.Location = new System.Drawing.Point(24, 243);
            this.lblchef_loginpage_userID.Name = "lblchef_loginpage_userID";
            this.lblchef_loginpage_userID.Size = new System.Drawing.Size(150, 20);
            this.lblchef_loginpage_userID.TabIndex = 33;
            this.lblchef_loginpage_userID.Text = "Email/ Username:";
            // 
            // lblchef_loginpage_title
            // 
            this.lblchef_loginpage_title.AutoSize = true;
            this.lblchef_loginpage_title.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchef_loginpage_title.Location = new System.Drawing.Point(132, 161);
            this.lblchef_loginpage_title.Name = "lblchef_loginpage_title";
            this.lblchef_loginpage_title.Size = new System.Drawing.Size(131, 42);
            this.lblchef_loginpage_title.TabIndex = 32;
            this.lblchef_loginpage_title.Text = "Log In";
            // 
            // loginpage_password
            // 
            this.loginpage_password.Location = new System.Drawing.Point(175, 279);
            this.loginpage_password.Name = "loginpage_password";
            this.loginpage_password.Size = new System.Drawing.Size(191, 20);
            this.loginpage_password.TabIndex = 30;
            // 
            // loginpage_userID
            // 
            this.loginpage_userID.Location = new System.Drawing.Point(175, 243);
            this.loginpage_userID.Name = "loginpage_userID";
            this.loginpage_userID.Size = new System.Drawing.Size(191, 20);
            this.loginpage_userID.TabIndex = 29;
            // 
            // pbchef_loginpage_picture2
            // 
            this.pbchef_loginpage_picture2.ErrorImage = null;
            this.pbchef_loginpage_picture2.Image = global::chef_assignment.Properties.Resources.BEACH_TREE;
            this.pbchef_loginpage_picture2.ImageLocation = "";
            this.pbchef_loginpage_picture2.InitialImage = null;
            this.pbchef_loginpage_picture2.Location = new System.Drawing.Point(-111, 0);
            this.pbchef_loginpage_picture2.Name = "pbchef_loginpage_picture2";
            this.pbchef_loginpage_picture2.Size = new System.Drawing.Size(499, 455);
            this.pbchef_loginpage_picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbchef_loginpage_picture2.TabIndex = 39;
            this.pbchef_loginpage_picture2.TabStop = false;
            this.pbchef_loginpage_picture2.WaitOnLoad = true;
            // 
            // Universal_Loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.pbchef_loginpage_picture2);
            this.Controls.Add(this.pnlchef_loginpage_info);
            this.Name = "Universal_Loginpage";
            this.Text = "Login - FoodiePoint";
            this.pnlchef_loginpage_info.ResumeLayout(false);
            this.pnlchef_loginpage_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbchef_loginpage_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbchef_loginpage_picture2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlchef_loginpage_info;
        private System.Windows.Forms.Button loginpage_login;
        private System.Windows.Forms.Label lblchef_loginpage_password;
        private System.Windows.Forms.Label lblchef_loginpage_userID;
        private System.Windows.Forms.Label lblchef_loginpage_title;
        private System.Windows.Forms.TextBox loginpage_password;
        private System.Windows.Forms.TextBox loginpage_userID;
        private System.Windows.Forms.Button loginpage_exit;
        private System.Windows.Forms.PictureBox pbchef_loginpage_picture2;
        private System.Windows.Forms.PictureBox pbchef_loginpage_picture;
    }
}