namespace FoodiePoint.manager
{
    partial class ManagerMain
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
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnhall = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.btnupdateprofile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(42, 118);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(133, 60);
            this.btnmenu.TabIndex = 0;
            this.btnmenu.Text = "Manage menu and Pricing";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btnhall
            // 
            this.btnhall.Location = new System.Drawing.Point(200, 118);
            this.btnhall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhall.Name = "btnhall";
            this.btnhall.Size = new System.Drawing.Size(133, 60);
            this.btnhall.TabIndex = 1;
            this.btnhall.Text = "Manage Hall Details";
            this.btnhall.UseVisualStyleBackColor = true;
            this.btnhall.Click += new System.EventHandler(this.btnhall_Click);
            // 
            // btnreports
            // 
            this.btnreports.Location = new System.Drawing.Point(364, 118);
            this.btnreports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(133, 60);
            this.btnreports.TabIndex = 2;
            this.btnreports.Text = "View Hall Reservation Report";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnupdateprofile
            // 
            this.btnupdateprofile.Location = new System.Drawing.Point(524, 118);
            this.btnupdateprofile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdateprofile.Name = "btnupdateprofile";
            this.btnupdateprofile.Size = new System.Drawing.Size(133, 60);
            this.btnupdateprofile.TabIndex = 3;
            this.btnupdateprofile.Text = "Update Profile";
            this.btnupdateprofile.UseVisualStyleBackColor = true;
            this.btnupdateprofile.Click += new System.EventHandler(this.btnupdateprofile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manager Dashboard";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(42, 319);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(77, 30);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdateprofile);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.btnhall);
            this.Controls.Add(this.btnmenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerMain";
            this.Text = "Manager Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnhall;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnupdateprofile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogout;
    }
}