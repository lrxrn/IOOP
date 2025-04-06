namespace FoodiePoint.customer
{
    partial class Send_Feedback
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.Restaurant_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_backToDash = new System.Windows.Forms.Button();
            this.txt_feedback = new System.Windows.Forms.RichTextBox();
            this.rbtn_food = new System.Windows.Forms.RadioButton();
            this.rbtn_reservation = new System.Windows.Forms.RadioButton();
            this.lbl_type = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbl_role);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Location = new System.Drawing.Point(544, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 78);
            this.panel1.TabIndex = 9;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_role.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_role.Location = new System.Drawing.Point(20, 44);
            this.lbl_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(41, 19);
            this.lbl_role.TabIndex = 5;
            this.lbl_role.Text = "Role";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_user.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_user.Location = new System.Drawing.Point(17, 11);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(78, 35);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "User";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.lbl_msg.Location = new System.Drawing.Point(23, 79);
            this.lbl_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(223, 36);
            this.lbl_msg.TabIndex = 8;
            this.lbl_msg.Text = "Send Feedback";
            // 
            // Restaurant_name
            // 
            this.Restaurant_name.AutoSize = true;
            this.Restaurant_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restaurant_name.Location = new System.Drawing.Point(16, 11);
            this.Restaurant_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Restaurant_name.Name = "Restaurant_name";
            this.Restaurant_name.Size = new System.Drawing.Size(359, 69);
            this.Restaurant_name.TabIndex = 7;
            this.Restaurant_name.Text = "FoodiePoint";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_submit);
            this.panel2.Controls.Add(this.lbl_type);
            this.panel2.Controls.Add(this.rbtn_reservation);
            this.panel2.Controls.Add(this.rbtn_food);
            this.panel2.Controls.Add(this.txt_feedback);
            this.panel2.Controls.Add(this.btn_backToDash);
            this.panel2.Location = new System.Drawing.Point(29, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 358);
            this.panel2.TabIndex = 10;
            // 
            // btn_backToDash
            // 
            this.btn_backToDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backToDash.Location = new System.Drawing.Point(29, 284);
            this.btn_backToDash.Margin = new System.Windows.Forms.Padding(4);
            this.btn_backToDash.Name = "btn_backToDash";
            this.btn_backToDash.Size = new System.Drawing.Size(750, 53);
            this.btn_backToDash.TabIndex = 9;
            this.btn_backToDash.Text = "Go Back to Dashboard";
            this.btn_backToDash.UseVisualStyleBackColor = true;
            this.btn_backToDash.Click += new System.EventHandler(this.btn_backToDash_Click);
            // 
            // txt_feedback
            // 
            this.txt_feedback.Location = new System.Drawing.Point(29, 61);
            this.txt_feedback.Name = "txt_feedback";
            this.txt_feedback.Size = new System.Drawing.Size(750, 115);
            this.txt_feedback.TabIndex = 10;
            this.txt_feedback.Text = "";
            // 
            // rbtn_food
            // 
            this.rbtn_food.AutoSize = true;
            this.rbtn_food.Location = new System.Drawing.Point(38, 219);
            this.rbtn_food.Name = "rbtn_food";
            this.rbtn_food.Size = new System.Drawing.Size(60, 20);
            this.rbtn_food.TabIndex = 11;
            this.rbtn_food.TabStop = true;
            this.rbtn_food.Text = "Food";
            this.rbtn_food.UseVisualStyleBackColor = true;
            // 
            // rbtn_reservation
            // 
            this.rbtn_reservation.AutoSize = true;
            this.rbtn_reservation.Location = new System.Drawing.Point(38, 246);
            this.rbtn_reservation.Name = "rbtn_reservation";
            this.rbtn_reservation.Size = new System.Drawing.Size(101, 20);
            this.rbtn_reservation.TabIndex = 12;
            this.rbtn_reservation.TabStop = true;
            this.rbtn_reservation.Text = "Reservation";
            this.rbtn_reservation.UseVisualStyleBackColor = true;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(26, 198);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(194, 18);
            this.lbl_type.TabIndex = 13;
            this.lbl_type.Text = "Select Type of Feedback";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(498, 202);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(281, 55);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit Feedback";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Type your feedback to send to the Administrator or the Reservation Coordinator";
            // 
            // Send_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 495);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.Restaurant_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Send_Feedback";
            this.Text = "Order_Food";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label Restaurant_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_backToDash;
        private System.Windows.Forms.RichTextBox txt_feedback;
        private System.Windows.Forms.RadioButton rbtn_reservation;
        private System.Windows.Forms.RadioButton rbtn_food;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label label1;
    }
}