namespace chef_assignment
{
    partial class chef_databasepart_tester
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
            this.lbldatabaseconnectiontesterheader = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldatabaseconnectiontesterheader
            // 
            this.lbldatabaseconnectiontesterheader.AutoSize = true;
            this.lbldatabaseconnectiontesterheader.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatabaseconnectiontesterheader.Location = new System.Drawing.Point(63, 28);
            this.lbldatabaseconnectiontesterheader.Name = "lbldatabaseconnectiontesterheader";
            this.lbldatabaseconnectiontesterheader.Size = new System.Drawing.Size(273, 26);
            this.lbldatabaseconnectiontesterheader.TabIndex = 5;
            this.lbldatabaseconnectiontesterheader.Text = "Database connection tester";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblConnectionStatus.Location = new System.Drawing.Point(132, 119);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(115, 13);
            this.lblConnectionStatus.TabIndex = 4;
            this.lblConnectionStatus.Text = "                                    ";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(135, 81);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(107, 23);
            this.btnTestConnection.TabIndex = 3;
            this.btnTestConnection.Text = "Test connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // chef_databasepart_tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 161);
            this.Controls.Add(this.lbldatabaseconnectiontesterheader);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.btnTestConnection);
            this.Name = "chef_databasepart_tester";
            this.Text = "Chef Table Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldatabaseconnectiontesterheader;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnTestConnection;
    }
}