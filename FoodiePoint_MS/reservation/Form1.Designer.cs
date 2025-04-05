using System.Drawing;
using System.Windows.Forms;

namespace FoodiePoint.reservation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            cmbReservationStatus = new ComboBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            cmbHallID = new ComboBox();
            dtpReservationDate = new DateTimePicker();
            txtCustomerName = new TextBox();
            lblDateTime = new Label();
            lblName = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddٌReservation = new Button();
            dgvReservations = new DataGridView();
            pictureBox1 = new PictureBox();
            txtCustomerID = new TextBox();
            lblCustomerID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Gill Sans MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(375, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(314, 42);
            lblTitle.TabIndex = 45;
            lblTitle.Text = "Manage Reservations";
            // 
            // cmbReservationStatus
            // 
            cmbReservationStatus.FormattingEnabled = true;
            cmbReservationStatus.Items.AddRange(new object[] { "Confirmed", "Completed", "Cancelled" });
            cmbReservationStatus.Location = new Point(217, 492);
            cmbReservationStatus.Name = "cmbReservationStatus";
            cmbReservationStatus.Size = new Size(151, 28);
            cmbReservationStatus.TabIndex = 44;
            cmbReservationStatus.SelectedIndexChanged += cmbReservationStatus_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(274, 526);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 43;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(549, 291);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 42;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(428, 291);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 41;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbHallID
            // 
            cmbHallID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHallID.FormattingEnabled = true;
            cmbHallID.Location = new Point(568, 241);
            cmbHallID.Name = "cmbHallID";
            cmbHallID.Size = new Size(151, 28);
            cmbHallID.TabIndex = 40;
            cmbHallID.SelectedIndexChanged += cmbHalls_SelectedIndexChanged;
            // 
            // dtpReservationDate
            // 
            dtpReservationDate.Location = new Point(521, 194);
            dtpReservationDate.Name = "dtpReservationDate";
            dtpReservationDate.Size = new Size(250, 27);
            dtpReservationDate.TabIndex = 39;
            dtpReservationDate.ValueChanged += dtpReservationDate_ValueChanged_1;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(594, 79);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(125, 27);
            txtCustomerName.TabIndex = 36;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("FiraCode Nerd Font", 16.1999989F);
            lblDateTime.Location = new Point(270, 188);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(236, 33);
            lblDateTime.TabIndex = 33;
            lblDateTime.Text = "Date And Time";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("FiraCode Nerd Font", 16.1999989F);
            lblName.Location = new Point(301, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(219, 33);
            lblName.TabIndex = 31;
            lblName.Text = "CustomerName";
            lblName.Click += lblName_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(830, 476);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(709, 478);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(109, 27);
            txtSearch.TabIndex = 29;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(709, 424);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(215, 29);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete Reservation";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(709, 389);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(215, 29);
            btnEdit.TabIndex = 26;
            btnEdit.Text = "Edit Reservation";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAddٌReservation
            // 
            btnAddٌReservation.Location = new Point(709, 354);
            btnAddٌReservation.Name = "btnAddٌReservation";
            btnAddٌReservation.Size = new Size(215, 29);
            btnAddٌReservation.TabIndex = 25;
            btnAddٌReservation.Text = "Add Reservation";
            btnAddٌReservation.UseVisualStyleBackColor = true;
            btnAddٌReservation.Click += btnAddReservation_Click;
            // 
            // dgvReservations
            // 
            dgvReservations.BackgroundColor = SystemColors.ButtonFace;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(389, 354);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.Size = new Size(300, 188);
            dgvReservations.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 109);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(594, 134);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(125, 27);
            txtCustomerID.TabIndex = 36;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("FiraCode Nerd Font", 16.1999989F);
            lblCustomerID.Location = new Point(301, 128);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(185, 33);
            lblCustomerID.TabIndex = 31;
            lblCustomerID.Text = "CustomerID";
            lblCustomerID.Click += lblName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 582);
            Controls.Add(lblTitle);
            Controls.Add(cmbReservationStatus);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbHallID);
            Controls.Add(dtpReservationDate);
            Controls.Add(txtCustomerID);
            Controls.Add(txtCustomerName);
            Controls.Add(lblDateTime);
            Controls.Add(lblCustomerID);
            Controls.Add(lblName);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAddٌReservation);
            Controls.Add(dgvReservations);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox cmbReservationStatus;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cmbHallID;
        private DateTimePicker dtpReservationDate;
        private TextBox txtCustomerName;
        private Label lblDateTime;
        private Label lblName;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddٌReservation;
        private DataGridView dgvReservations;
        private PictureBox pictureBox1;
        private TextBox txtCustomerID;
        private Label lblCustomerID;
    }
}
