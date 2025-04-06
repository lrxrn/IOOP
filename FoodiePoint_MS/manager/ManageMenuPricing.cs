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
    public partial class ManageMenuPricing : Form
    {
        public ManageMenuPricing()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string foodIDedit = textBox2.Text;
            string foodName = textBox6.Text;
            int price = int.Parse(textBox5.Text);

            new managemenu().EditMenuItem(foodIDedit, foodName, price);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string foodName = textBox4.Text;
            string foodcategory = textBox1.Text;
            decimal price = decimal.Parse(textBox3.Text);

            new managemenu().AddMenuItem(foodName, foodcategory, price);

            MessageBox.Show("Menu item added successfully.");
            textBox4.Clear();
            textBox1.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int foodID = int.Parse(textBox12.Text);

            new managemenu().DeleteMenuItem(foodID);

            MessageBox.Show("Menu item deleted successfully.");
            textBox12.Clear();
        }
    }
}
