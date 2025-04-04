namespace FoodiePoint.customer
{
    partial class Order_Food
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
            this.lv_MenuItems = new System.Windows.Forms.ListView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbl_role);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Location = new System.Drawing.Point(540, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 63);
            this.panel1.TabIndex = 9;
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
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Open Sans Light", 18F, System.Drawing.FontStyle.Italic);
            this.lbl_msg.Location = new System.Drawing.Point(17, 64);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(170, 33);
            this.lbl_msg.TabIndex = 8;
            this.lbl_msg.Text = "Ordering Food";
            // 
            // Restaurant_name
            // 
            this.Restaurant_name.AutoSize = true;
            this.Restaurant_name.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restaurant_name.Location = new System.Drawing.Point(12, 9);
            this.Restaurant_name.Name = "Restaurant_name";
            this.Restaurant_name.Size = new System.Drawing.Size(315, 65);
            this.Restaurant_name.TabIndex = 7;
            this.Restaurant_name.Text = "FoodiePoint";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lv_MenuItems);
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Controls.Add(this.txtBox_Search);
            this.panel2.Location = new System.Drawing.Point(22, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 325);
            this.panel2.TabIndex = 10;
            // 
            // lv_MenuItems
            // 
            this.lv_MenuItems.HideSelection = false;
            this.lv_MenuItems.Location = new System.Drawing.Point(24, 38);
            this.lv_MenuItems.Name = "lv_MenuItems";
            this.lv_MenuItems.Size = new System.Drawing.Size(693, 246);
            this.lv_MenuItems.TabIndex = 3;
            this.lv_MenuItems.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(617, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 20);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(24, 12);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(586, 20);
            this.txtBox_Search.TabIndex = 1;
            this.txtBox_Search.Text = "Search a Food";
            // 
            // Order_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.Restaurant_name);
            this.Name = "Order_Food";
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
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.ListView lv_MenuItems;
    }
}