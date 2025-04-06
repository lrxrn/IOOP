using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodiePoint.manager
{
    public partial class HallReservationReport : Form
    {
        public HallReservationReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string month = comboBox2.Text;
            string reservationType = comboBox1.Text;

            if (string.IsNullOrEmpty(month) || string.IsNullOrEmpty(reservationType))
            {
                MessageBox.Show("Please select both month and reservation type.");
                return;
            }

            DataTable table = new generatereports().GetReservationReport(month, reservationType);

            if (table.Rows.Count > 0)
            {
                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("No reservations found for the selected month and type.");
            }
        }
    }
}
