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
    public partial class ManageHallDetails : Form
    {
        public ManageHallDetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hallName = textBox1.Text;
            int capacity = int.Parse(textBox4.Text);
            string partyType = textBox3.Text;

            new managehalls().AddHall(hallName, capacity, partyType);
            MessageBox.Show("Hall added successfully.");
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string hallID = textBox12.Text;

            new managehalls().DeleteHall(hallID);
            MessageBox.Show("Hall deleted successfully.");
            textBox12.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string hallIDedit = textBox2.Text;
            string hallName = textBox5.Text;
            int capacity = int.Parse(textBox7.Text);
            string partyType = textBox6.Text;

            new managehalls().EditHall(hallIDedit, hallName, capacity, partyType);

            MessageBox.Show("Hall details updated successfully.");
            textBox2.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox6.Clear();
        }
    }
}
