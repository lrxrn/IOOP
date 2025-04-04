namespace FoodiePoint
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
            this.pb_loginpage_picture = new System.Windows.Forms.PictureBox();
            this.loginpage_exit = new System.Windows.Forms.Button();
            this.loginpage_login = new System.Windows.Forms.Button();
            this.lbl_loginpage_password = new System.Windows.Forms.Label();
            this.lbl_loginpage_userID = new System.Windows.Forms.Label();
            this.loginpage_title = new System.Windows.Forms.Label();
            this.loginpage_password = new System.Windows.Forms.TextBox();
            this.loginpage_userID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlchef_loginpage_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loginpage_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlchef_loginpage_info
            // 
            this.pnlchef_loginpage_info.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlchef_loginpage_info.Controls.Add(this.label1);
            this.pnlchef_loginpage_info.Controls.Add(this.pb_loginpage_picture);
            this.pnlchef_loginpage_info.Controls.Add(this.loginpage_exit);
            this.pnlchef_loginpage_info.Controls.Add(this.loginpage_login);
            this.pnlchef_loginpage_info.Controls.Add(this.lbl_loginpage_password);
            this.pnlchef_loginpage_info.Controls.Add(this.lbl_loginpage_userID);
            this.pnlchef_loginpage_info.Controls.Add(this.loginpage_title);
            this.pnlchef_loginpage_info.Controls.Add(this.loginpage_password);
            this.pnlchef_loginpage_info.Controls.Add(this.loginpage_userID);
            this.pnlchef_loginpage_info.Location = new System.Drawing.Point(-2, -3);
            this.pnlchef_loginpage_info.Name = "pnlchef_loginpage_info";
            this.pnlchef_loginpage_info.Size = new System.Drawing.Size(387, 385);
            this.pnlchef_loginpage_info.TabIndex = 29;
            // 
            // pb_loginpage_picture
            // 
            this.pb_loginpage_picture.Image = global::FoodiePoint.Properties.Resources.LOGO;
            this.pb_loginpage_picture.InitialImage = global::FoodiePoint.Properties.Resources.LOGO;
            this.pb_loginpage_picture.Location = new System.Drawing.Point(28, 15);
            this.pb_loginpage_picture.Name = "pb_loginpage_picture";
            this.pb_loginpage_picture.Size = new System.Drawing.Size(338, 122);
            this.pb_loginpage_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_loginpage_picture.TabIndex = 39;
            this.pb_loginpage_picture.TabStop = false;
            // 
            // loginpage_exit
            // 
            this.loginpage_exit.BackColor = System.Drawing.Color.SandyBrown;
            this.loginpage_exit.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpage_exit.Location = new System.Drawing.Point(61, 323);
            this.loginpage_exit.Name = "loginpage_exit";
            this.loginpage_exit.Size = new System.Drawing.Size(107, 30);
            this.loginpage_exit.TabIndex = 38;
            this.loginpage_exit.Text = "Exit";
            this.loginpage_exit.UseVisualStyleBackColor = false;
            this.loginpage_exit.Click += new System.EventHandler(this.btn_loginpage_exit_Click);
            // 
            // loginpage_login
            // 
            this.loginpage_login.BackColor = System.Drawing.Color.DarkOrange;
            this.loginpage_login.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpage_login.Location = new System.Drawing.Point(219, 323);
            this.loginpage_login.Name = "loginpage_login";
            this.loginpage_login.Size = new System.Drawing.Size(107, 30);
            this.loginpage_login.TabIndex = 36;
            this.loginpage_login.Text = "Log In";
            this.loginpage_login.UseVisualStyleBackColor = false;
            this.loginpage_login.Click += new System.EventHandler(this.btn_loginpage_login_Click);
            // 
            // lbl_loginpage_password
            // 
            this.lbl_loginpage_password.AutoSize = true;
            this.lbl_loginpage_password.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_loginpage_password.Location = new System.Drawing.Point(25, 264);
            this.lbl_loginpage_password.Name = "lbl_loginpage_password";
            this.lbl_loginpage_password.Size = new System.Drawing.Size(82, 19);
            this.lbl_loginpage_password.TabIndex = 34;
            this.lbl_loginpage_password.Text = "Password:";
            // 
            // lbl_loginpage_userID
            // 
            this.lbl_loginpage_userID.AutoSize = true;
            this.lbl_loginpage_userID.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginpage_userID.Location = new System.Drawing.Point(25, 231);
            this.lbl_loginpage_userID.Name = "lbl_loginpage_userID";
            this.lbl_loginpage_userID.Size = new System.Drawing.Size(135, 19);
            this.lbl_loginpage_userID.TabIndex = 33;
            this.lbl_loginpage_userID.Text = "Email/ Username:";
            // 
            // loginpage_title
            // 
            this.loginpage_title.AutoSize = true;
            this.loginpage_title.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpage_title.Location = new System.Drawing.Point(138, 140);
            this.loginpage_title.Name = "loginpage_title";
            this.loginpage_title.Size = new System.Drawing.Size(122, 45);
            this.loginpage_title.TabIndex = 32;
            this.loginpage_title.Text = "Log In";
            this.loginpage_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginpage_password
            // 
            this.loginpage_password.Location = new System.Drawing.Point(166, 263);
            this.loginpage_password.Name = "loginpage_password";
            this.loginpage_password.PasswordChar = '*';
            this.loginpage_password.Size = new System.Drawing.Size(191, 20);
            this.loginpage_password.TabIndex = 30;
            // 
            // loginpage_userID
            // 
            this.loginpage_userID.Location = new System.Drawing.Point(166, 230);
            this.loginpage_userID.Name = "loginpage_userID";
            this.loginpage_userID.Size = new System.Drawing.Size(191, 20);
            this.loginpage_userID.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "FoodiePoint";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Universal_Loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(380, 377);
            this.Controls.Add(this.pnlchef_loginpage_info);
            this.Name = "Universal_Loginpage";
            this.Text = "Login - FoodiePoint";
            this.pnlchef_loginpage_info.ResumeLayout(false);
            this.pnlchef_loginpage_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loginpage_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlchef_loginpage_info;
        private System.Windows.Forms.Button loginpage_login;
        private System.Windows.Forms.Label lbl_loginpage_password;
        private System.Windows.Forms.Label lbl_loginpage_userID;
        private System.Windows.Forms.Label loginpage_title;
        private System.Windows.Forms.TextBox loginpage_password;
        private System.Windows.Forms.TextBox loginpage_userID;
        private System.Windows.Forms.Button loginpage_exit;
        private System.Windows.Forms.PictureBox pb_loginpage_picture;
        private System.Windows.Forms.Label label1;
    }
}