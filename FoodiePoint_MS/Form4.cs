using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chef_assignment
{
    public partial class formchef_chefdashbaord_chd : Form
    {
        public formchef_chefdashbaord_chd()
        {
            InitializeComponent();
        }

        private void btnchef_chd_manage_order_Click(object sender, EventArgs e)
        {
            formchef_ordermanagment_odmg formchef_Ordermanagment_Odmg = new formchef_ordermanagment_odmg();
            formchef_Ordermanagment_Odmg.Show();
            this.Hide();
        }

        private void btnchef_chd_manage_inventory_Click(object sender, EventArgs e)
        {
            formchef_inventorymanagment_inm formchef_Inventorymanagment_Inm = new formchef_inventorymanagment_inm();
            formchef_Inventorymanagment_Inm.Show();
            this.Hide();
        }

        private void btnchef_chd_profile_setting_Click(object sender, EventArgs e)
        {
            formchef_profilemanagment_pfm formchef_Profilemanagment_Pfm = new formchef_profilemanagment_pfm();
            formchef_Profilemanagment_Pfm.Show();
            this.Hide();
        }

        private void btnchef_chd_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
