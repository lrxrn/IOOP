using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chef_assignment
{
    internal class chef_ingredient
    {
        public int IngredientID { get; set; }
        public string IngredientName { get; set; }
        public int IngredientQuantity { get; set; }
        public string IngredientSufficient { get; set; }

        public chef_ingredient(int ingredientID, string ingredientname, int ingredientquantity, string ingredientsufficient)
        {
            IngredientID = ingredientID;
            IngredientName = ingredientname;
            IngredientQuantity = ingredientquantity;
            IngredientSufficient = ingredientsufficient;
        }
    }
}
