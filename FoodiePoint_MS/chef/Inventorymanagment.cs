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
    public partial class formchef_inventorymanagment_inm : Form
    {
        private int currentUserID;
        private string currentUserFullName;
        private string currentUserRole;

        private chef_inventorymanager inventoryManager;
        public formchef_inventorymanagment_inm(int userID, string fullname, string role)
        {
            InitializeComponent();
            inventoryManager = new chef_inventorymanager();
            LoadInventoryIntoListView();
            
            currentUserID = userID;
            currentUserFullName = fullname;
            currentUserRole = role;
            
            lblchef_inmg_username.Text = $"User: {currentUserFullName}\nUser ID: {currentUserID}\nRole: {currentUserRole}";
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblchef_inmg_username_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User: {currentUserFullName}\nUser ID: {currentUserID}\nUser Role: {currentUserRole}", "Current User Info");

        }

        private void LoadInventoryIntoListView()
        {
            lstvwchef_ingm_table.Items.Clear();
            lstvwchef_ingm_table.Columns.Clear();

            lstvwchef_ingm_table.Columns.Add("ID", 80);
            lstvwchef_ingm_table.Columns.Add("Ingredient Name", 150);
            lstvwchef_ingm_table.Columns.Add("Quantity", 100);
            lstvwchef_ingm_table.Columns.Add("Status", 100);

            var ingredients = inventoryManager.GetAllIngredients();

            if (ingredients.Count == 0)
            {
                MessageBox.Show("No ingredients found in inventory.");
                return;
            }

            foreach (var ingredient in ingredients)
            {
                var item = new ListViewItem(ingredient.IngredientID.ToString());
                item.SubItems.Add(ingredient.IngredientName);
                item.SubItems.Add(ingredient.IngredientQuantity.ToString());
                item.SubItems.Add(ingredient.IngredientSufficient);

                lstvwchef_ingm_table.Items.Add(item);
            }
        }

        private void btnchef_inmg_add_cancel_Click(object sender, EventArgs e)
        {
            txtbxchef_inmg_add_ID.Clear();
            txtbxchef_inmg_add_name.Clear();
            nudchef_inmg_add_quantity.Value = 0;
        }

        private void btnchef_inmg_edit_cancel_Click(object sender, EventArgs e)
        {
            txtbxchef_inmg_edit_ID.Clear();
            txtbxchef_inmg_edit_newname.Clear();
            nudchef_inmg_add_quantity.Value = 0;
        }

        private void btnchef_inmg_delete_cancel_Click(object sender, EventArgs e)
        {
            txtbxchef_inmg_delete_ID.Clear();
            txtbxchef_inmg_delete_name.Clear();
            nudchef_inmg_delete_quantity.Value = 0;
        }

        private void btnchef_inmg_displayfullinventory_Click(object sender, EventArgs e)
        {
            lsbxchef_ingm_details.Items.Clear();
        }

        private void btnchef_inmg_search_search_Click(object sender, EventArgs e)
        {

            lsbxchef_ingm_details.Items.Clear();

            if (int.TryParse(txtbxchef_inmg_search_ID.Text, out int id))
            {
                var ingredient = inventoryManager.FindIngredient(id);
                if (ingredient != null)
                {
                    lsbxchef_ingm_details.Items.Add($"Ingredient: {ingredient.IngredientName}");
                    lsbxchef_ingm_details.Items.Add($"Quantity available: {ingredient.IngredientQuantity}");
                    lsbxchef_ingm_details.Items.Add($"Quantity user wants: {nudchef_inmg_search_quantity.Value}");
                }
                else
                {
                    lsbxchef_ingm_details.Items.Add("Ingredient not in inventory.");
                }
            }
            else
            {
                lsbxchef_ingm_details.Items.Add("Invalid Ingredient ID! Please enter a valid number.");
            }
        }

        private void btnchef_inmg_add_add_Click(object sender, EventArgs e)
        {
            string name = txtbxchef_inmg_add_name.Text.Trim();
            int quantity = (int)nudchef_inmg_add_quantity.Value;

            if (string.IsNullOrEmpty(name) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid ingredient name and quantity.");
                return;
            }

            var existing = inventoryManager.FindIngredientByName(name);
            int ingredientID;

            if (existing == null)
            {
                inventoryManager.AddIngredient(name, quantity);
                ingredientID = inventoryManager.FindIngredientByName(name).IngredientID;
            }
            else
            {
                ingredientID = existing.IngredientID;
                int updatedQuantity = existing.IngredientQuantity + quantity;
                inventoryManager.UpdateIngredientQuantity(ingredientID, updatedQuantity);
            }

            LoadInventoryIntoListView();

            lsbxchef_ingm_details.Items.Clear();
            lsbxchef_ingm_details.Items.Add($"Ingredient being added: {name}");
            lsbxchef_ingm_details.Items.Add($"ID for the ingredient: {ingredientID}");
            lsbxchef_ingm_details.Items.Add($"Quantity added: {quantity}");
            lsbxchef_ingm_details.Items.Add("--- Ingredient added ---");

            MessageBox.Show("Ingredient added successfully!");
        }

        private void btnchef_inmg_edit_save_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtbxchef_inmg_edit_ID.Text, out int id))
            {
                MessageBox.Show("Invalid Ingredient ID!");
                return;
            }

            string newName = txtbxchef_inmg_edit_newname.Text.Trim();
            int newQuantity = (int)nudchef_inmg_edit_quantity.Value;

            var ingredient = inventoryManager.FindIngredient(id);
            if (ingredient == null)
            {
                MessageBox.Show("Ingredient not found in inventory.");
                return;
            }

            bool nameChanged = !string.IsNullOrEmpty(newName) && newName != ingredient.IngredientName;
            bool quantityChanged = newQuantity > 0 && newQuantity != ingredient.IngredientQuantity;

            if (!nameChanged && !quantityChanged)
            {
                MessageBox.Show("No changes made.");
                return;
            }

            if (nameChanged)
                inventoryManager.UpdateIngredientName(id, newName);
            else
                newName = ingredient.IngredientName;

            if (quantityChanged)
                inventoryManager.UpdateIngredientQuantity(id, newQuantity);
            else
                newQuantity = ingredient.IngredientQuantity;

            LoadInventoryIntoListView();

            lsbxchef_ingm_details.Items.Clear();
            lsbxchef_ingm_details.Items.Add($"Ingredient edited: {newName}");
            lsbxchef_ingm_details.Items.Add($"ID: {id}");
            lsbxchef_ingm_details.Items.Add($"New quantity: {newQuantity}");
            lsbxchef_ingm_details.Items.Add("--- Ingredient updated ---");

            MessageBox.Show("Ingredient updated successfully!");
        }

        private void btnchef_inmg_delete_delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtbxchef_inmg_delete_ID.Text, out int id))
            {
                MessageBox.Show("Invalid Ingredient ID.");
                return;
            }

            var ingredient = inventoryManager.FindIngredient(id);
            if (ingredient == null)
            {
                MessageBox.Show("Ingredient not found.");
                return;
            }

            int quantityToRemove = (int)nudchef_inmg_delete_quantity.Value;

            if (quantityToRemove == 0)
            {
                inventoryManager.DeleteIngredient(id);
                MessageBox.Show("Ingredient removed from inventory.");
            }
            else
            {
                int newQty = ingredient.IngredientQuantity - quantityToRemove;

                if (newQty <= 0)
                {
                    inventoryManager.DeleteIngredient(id);
                    MessageBox.Show("Quantity reduced to zero. Ingredient removed.");
                }
                else
                {
                    inventoryManager.UpdateIngredientQuantity(id, newQty);
                    MessageBox.Show($"Quantity updated: {newQty} remaining.");
                }
            }

            LoadInventoryIntoListView();

            lsbxchef_ingm_details.Items.Clear();
            lsbxchef_ingm_details.Items.Add($"Ingredient: {ingredient.IngredientName}");
            lsbxchef_ingm_details.Items.Add($"ID: {id}");
        }

        private void btnchef_inmg_chefdashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new formchef_chefdashbaord_chd(currentUserID, currentUserFullName, currentUserRole);
            dashboard.Show();
            this.Close();
        }

        private void formchef_inventorymanagment_inm_Load(object sender, EventArgs e)
        {

        }
    }
}
