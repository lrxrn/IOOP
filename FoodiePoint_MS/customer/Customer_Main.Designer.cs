namespace FoodiePoint.customer
{
    partial class Customer_Main
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Restaurant_name = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_status = new System.Windows.Forms.Button();
            this.btn_feedback = new System.Windows.Forms.Button();
            this.btn_updateProfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Restaurant_name
            // 
            this.Restaurant_name.AutoSize = true;
            this.Restaurant_name.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restaurant_name.Location = new System.Drawing.Point(12, 9);
            this.Restaurant_name.Name = "Restaurant_name";
            this.Restaurant_name.Size = new System.Drawing.Size(315, 65);
            this.Restaurant_name.TabIndex = 2;
            this.Restaurant_name.Text = "FoodiePoint";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Open Sans Light", 18F, System.Drawing.FontStyle.Italic);
            this.lbl_msg.Location = new System.Drawing.Point(17, 64);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(176, 33);
            this.lbl_msg.TabIndex = 3;
            this.lbl_msg.Text = "Welcome Back!";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_user.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_user.Location = new System.Drawing.Point(13, 9);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(62, 27);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "User";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_role.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_role.Location = new System.Drawing.Point(15, 36);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(33, 16);
            this.lbl_role.TabIndex = 5;
            this.lbl_role.Text = "Role";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbl_role);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Location = new System.Drawing.Point(540, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 63);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(22, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 325);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::chef_assignment.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(418, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_order);
            this.flowLayoutPanel1.Controls.Add(this.btn_status);
            this.flowLayoutPanel1.Controls.Add(this.btn_feedback);
            this.flowLayoutPanel1.Controls.Add(this.btn_updateProfile);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(277, 297);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_order
            // 
            this.btn_order.Font = new System.Drawing.Font("Lato Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.Location = new System.Drawing.Point(3, 3);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(263, 68);
            this.btn_order.TabIndex = 0;
            this.btn_order.Text = "Order Food";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_status
            // 
            this.btn_status.Font = new System.Drawing.Font("Lato Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_status.Location = new System.Drawing.Point(3, 77);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(263, 68);
            this.btn_status.TabIndex = 1;
            this.btn_status.Text = "View Order Status";
            this.btn_status.UseVisualStyleBackColor = true;
            // 
            // btn_feedback
            // 
            this.btn_feedback.Font = new System.Drawing.Font("Lato Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_feedback.Location = new System.Drawing.Point(3, 151);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(263, 68);
            this.btn_feedback.TabIndex = 2;
            this.btn_feedback.Text = "Send Feedback";
            this.btn_feedback.UseVisualStyleBackColor = true;
            // 
            // btn_updateProfile
            // 
            this.btn_updateProfile.Font = new System.Drawing.Font("Lato Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateProfile.Location = new System.Drawing.Point(3, 225);
            this.btn_updateProfile.Name = "btn_updateProfile";
            this.btn_updateProfile.Size = new System.Drawing.Size(263, 68);
            this.btn_updateProfile.TabIndex = 3;
            this.btn_updateProfile.Text = "Update Profile";
            this.btn_updateProfile.UseVisualStyleBackColor = true;
            // 
            // Customer_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.Restaurant_name);
            this.Name = "Customer_Main";
            this.Text = "Customer_Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Restaurant_name;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Button btn_feedback;
        private System.Windows.Forms.Button btn_updateProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}