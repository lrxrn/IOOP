namespace FoodiePoint.customer
{
    partial class View_Status
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
            this.lbl_order = new System.Windows.Forms.Label();
            this.lv_ReservationItems = new System.Windows.Forms.ListBox();
            this.btn_backToDash = new System.Windows.Forms.Button();
            this.lv_OrderStatusItems = new System.Windows.Forms.ListBox();
            this.lbl_reservations = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbl_role);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Location = new System.Drawing.Point(720, 15);
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
            this.lbl_msg.Size = new System.Drawing.Size(173, 36);
            this.lbl_msg.TabIndex = 8;
            this.lbl_msg.Text = "View Status";
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
            this.panel2.Controls.Add(this.lbl_reservations);
            this.panel2.Controls.Add(this.lbl_order);
            this.panel2.Controls.Add(this.lv_ReservationItems);
            this.panel2.Controls.Add(this.btn_backToDash);
            this.panel2.Controls.Add(this.lv_OrderStatusItems);
            this.panel2.Location = new System.Drawing.Point(29, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 416);
            this.panel2.TabIndex = 10;
            // 
            // lbl_order
            // 
            this.lbl_order.AutoSize = true;
            this.lbl_order.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_order.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_order.Location = new System.Drawing.Point(25, 15);
            this.lbl_order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(86, 23);
            this.lbl_order.TabIndex = 6;
            this.lbl_order.Text = "Orders:";
            // 
            // lv_ReservationItems
            // 
            this.lv_ReservationItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ReservationItems.FormattingEnabled = true;
            this.lv_ReservationItems.ItemHeight = 29;
            this.lv_ReservationItems.Location = new System.Drawing.Point(498, 42);
            this.lv_ReservationItems.Margin = new System.Windows.Forms.Padding(4);
            this.lv_ReservationItems.Name = "lv_ReservationItems";
            this.lv_ReservationItems.Size = new System.Drawing.Size(454, 294);
            this.lv_ReservationItems.TabIndex = 10;
            // 
            // btn_backToDash
            // 
            this.btn_backToDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backToDash.Location = new System.Drawing.Point(29, 348);
            this.btn_backToDash.Margin = new System.Windows.Forms.Padding(4);
            this.btn_backToDash.Name = "btn_backToDash";
            this.btn_backToDash.Size = new System.Drawing.Size(923, 53);
            this.btn_backToDash.TabIndex = 9;
            this.btn_backToDash.Text = "Go Back to Dashboard";
            this.btn_backToDash.UseVisualStyleBackColor = true;
            this.btn_backToDash.Click += new System.EventHandler(this.btn_backToDash_Click);
            // 
            // lv_OrderStatusItems
            // 
            this.lv_OrderStatusItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_OrderStatusItems.FormattingEnabled = true;
            this.lv_OrderStatusItems.ItemHeight = 29;
            this.lv_OrderStatusItems.Location = new System.Drawing.Point(29, 42);
            this.lv_OrderStatusItems.Margin = new System.Windows.Forms.Padding(4);
            this.lv_OrderStatusItems.Name = "lv_OrderStatusItems";
            this.lv_OrderStatusItems.Size = new System.Drawing.Size(461, 294);
            this.lv_OrderStatusItems.TabIndex = 3;
            // 
            // lbl_reservations
            // 
            this.lbl_reservations.AutoSize = true;
            this.lbl_reservations.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_reservations.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_reservations.Location = new System.Drawing.Point(494, 15);
            this.lbl_reservations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reservations.Name = "lbl_reservations";
            this.lbl_reservations.Size = new System.Drawing.Size(144, 23);
            this.lbl_reservations.TabIndex = 11;
            this.lbl_reservations.Text = "Reservations:";
            // 
            // View_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.Restaurant_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View_Status";
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
        private System.Windows.Forms.ListBox lv_OrderStatusItems;
        private System.Windows.Forms.Button btn_backToDash;
        private System.Windows.Forms.ListBox lv_ReservationItems;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.Label lbl_reservations;
    }
}