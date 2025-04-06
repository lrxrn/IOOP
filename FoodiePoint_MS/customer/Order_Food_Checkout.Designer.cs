namespace FoodiePoint.customer
{
    partial class Order_Food_Checkout
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
            this.lbl_itemCntInCartLbl = new System.Windows.Forms.Label();
            this.lbl_itemCntInCart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PayLbl = new System.Windows.Forms.Label();
            this.lbl_PayAmt = new System.Windows.Forms.Label();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lv_MenuItems_Selected = new System.Windows.Forms.ListBox();
            this.btn_backToDash = new System.Windows.Forms.Button();
            this.cmb_paymentMethod = new System.Windows.Forms.ComboBox();
            this.lbl_payTypelbl = new System.Windows.Forms.Label();
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
            this.lbl_msg.Size = new System.Drawing.Size(360, 36);
            this.lbl_msg.TabIndex = 8;
            this.lbl_msg.Text = "Ordering Food - Checkout";
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
            this.panel2.Controls.Add(this.lbl_payTypelbl);
            this.panel2.Controls.Add(this.cmb_paymentMethod);
            this.panel2.Controls.Add(this.lbl_itemCntInCartLbl);
            this.panel2.Controls.Add(this.lbl_itemCntInCart);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_PayLbl);
            this.panel2.Controls.Add(this.lbl_PayAmt);
            this.panel2.Controls.Add(this.btn_Pay);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.lv_MenuItems_Selected);
            this.panel2.Location = new System.Drawing.Point(29, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 416);
            this.panel2.TabIndex = 10;
            // 
            // lbl_itemCntInCartLbl
            // 
            this.lbl_itemCntInCartLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_itemCntInCartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemCntInCartLbl.Location = new System.Drawing.Point(28, 305);
            this.lbl_itemCntInCartLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemCntInCartLbl.Name = "lbl_itemCntInCartLbl";
            this.lbl_itemCntInCartLbl.Size = new System.Drawing.Size(160, 25);
            this.lbl_itemCntInCartLbl.TabIndex = 13;
            this.lbl_itemCntInCartLbl.Text = "Items in Cart:";
            // 
            // lbl_itemCntInCart
            // 
            this.lbl_itemCntInCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_itemCntInCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemCntInCart.Location = new System.Drawing.Point(187, 305);
            this.lbl_itemCntInCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemCntInCart.Name = "lbl_itemCntInCart";
            this.lbl_itemCntInCart.Size = new System.Drawing.Size(360, 25);
            this.lbl_itemCntInCart.TabIndex = 12;
            this.lbl_itemCntInCart.Text = "No Items in cart.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 321);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 10;
            // 
            // lbl_PayLbl
            // 
            this.lbl_PayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PayLbl.Location = new System.Drawing.Point(555, 316);
            this.lbl_PayLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PayLbl.Name = "lbl_PayLbl";
            this.lbl_PayLbl.Size = new System.Drawing.Size(214, 25);
            this.lbl_PayLbl.TabIndex = 9;
            this.lbl_PayLbl.Text = "Total Amount to Pay:";
            // 
            // lbl_PayAmt
            // 
            this.lbl_PayAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PayAmt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PayAmt.Location = new System.Drawing.Point(777, 316);
            this.lbl_PayAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PayAmt.Name = "lbl_PayAmt";
            this.lbl_PayAmt.Size = new System.Drawing.Size(175, 25);
            this.lbl_PayAmt.TabIndex = 8;
            this.lbl_PayAmt.Text = "0$";
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(236, 345);
            this.btn_Pay.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(720, 49);
            this.btn_Pay.TabIndex = 6;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(32, 345);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(196, 49);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lv_MenuItems_Selected
            // 
            this.lv_MenuItems_Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_MenuItems_Selected.FormattingEnabled = true;
            this.lv_MenuItems_Selected.ItemHeight = 29;
            this.lv_MenuItems_Selected.Location = new System.Drawing.Point(32, 19);
            this.lv_MenuItems_Selected.Margin = new System.Windows.Forms.Padding(4);
            this.lv_MenuItems_Selected.Name = "lv_MenuItems_Selected";
            this.lv_MenuItems_Selected.Size = new System.Drawing.Size(923, 265);
            this.lv_MenuItems_Selected.TabIndex = 3;
            // 
            // btn_backToDash
            // 
            this.btn_backToDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backToDash.Location = new System.Drawing.Point(721, 92);
            this.btn_backToDash.Margin = new System.Windows.Forms.Padding(4);
            this.btn_backToDash.Name = "btn_backToDash";
            this.btn_backToDash.Size = new System.Drawing.Size(292, 27);
            this.btn_backToDash.TabIndex = 9;
            this.btn_backToDash.Text = "Go Back to Dashboard";
            this.btn_backToDash.UseVisualStyleBackColor = true;
            this.btn_backToDash.Click += new System.EventHandler(this.btn_backToDash_Click);
            // 
            // cmb_paymentMethod
            // 
            this.cmb_paymentMethod.FormattingEnabled = true;
            this.cmb_paymentMethod.Items.AddRange(new object[] {
            "card",
            "cash",
            "online"});
            this.cmb_paymentMethod.Location = new System.Drawing.Point(781, 291);
            this.cmb_paymentMethod.Name = "cmb_paymentMethod";
            this.cmb_paymentMethod.Size = new System.Drawing.Size(171, 24);
            this.cmb_paymentMethod.TabIndex = 14;
            // 
            // lbl_payTypelbl
            // 
            this.lbl_payTypelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_payTypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payTypelbl.Location = new System.Drawing.Point(555, 291);
            this.lbl_payTypelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_payTypelbl.Name = "lbl_payTypelbl";
            this.lbl_payTypelbl.Size = new System.Drawing.Size(214, 25);
            this.lbl_payTypelbl.TabIndex = 15;
            this.lbl_payTypelbl.Text = "Payment Type";
            // 
            // Order_Food_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 554);
            this.Controls.Add(this.btn_backToDash);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.Restaurant_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Order_Food_Checkout";
            this.Text = "Order_Food";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lv_MenuItems_Selected;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_backToDash;
        private System.Windows.Forms.Label lbl_PayLbl;
        private System.Windows.Forms.Label lbl_PayAmt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_itemCntInCartLbl;
        private System.Windows.Forms.Label lbl_itemCntInCart;
        private System.Windows.Forms.Label lbl_payTypelbl;
        private System.Windows.Forms.ComboBox cmb_paymentMethod;
    }
}