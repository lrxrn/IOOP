using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chef_assignment
{
    internal class chef_order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public List<string> FoodItems { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public chef_order(int orderId, string customerName, List<string> foodItems, DateTime orderDate, string status)
        {
            OrderID = orderId;
            CustomerName = customerName;
            FoodItems = foodItems;
            OrderDate = orderDate;
            Status = status;
        }
    }
}
