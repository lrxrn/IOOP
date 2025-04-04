using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePoint.Models
{
    public class ResMenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public bool IsAvailable { get; set; }
        public string ImagePath { get; set; }

        public ResMenuItem(int ItemID, string ItemName, string ItemCategory, decimal ItemPrice, bool ItemIsAvailable, string ItemImagePath)
        {
            Id = ItemID;
            Name = ItemName;
            Price = ItemPrice;
            Category = ItemCategory;
            IsAvailable = ItemIsAvailable;
            ImagePath = ItemImagePath;
        }

        public ResMenuItem() { }

        public override string ToString()
        {
            return $"{Name} - ${Price:0.00}";
        }
    }
}
