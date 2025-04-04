using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodiePoint.chef
{
    public partial class chef_databasepart_tester : Form
    {
        public chef_databasepart_tester()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            restaurantdatabaseconnection_chef db = new restaurantdatabaseconnection_chef();
            string result = db.TestConnection();
            lblConnectionStatus.Text = result;
        }
    }
}
