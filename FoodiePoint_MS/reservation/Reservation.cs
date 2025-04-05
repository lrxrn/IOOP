using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePoint.reservation
{
    internal class Reservation
    {
        // Properties for Reservation
        public int ReservationId { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public DateTime ReservationDate { get; set; }
        public string HallTime { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string HallName { get; set; }
        public int CustomerId { get; set; }
        public int HallId { get; set; }

        // Enum for Reservation Status
        public enum ReservationStatusType
        {
            Pending,
            Confirmed,
            Completed,
            Cancelled
        }
    }
}
