using System;

namespace DeskWise.Models
{
    // Vendor record linked to products and purchase orders for restocking.
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DeliveryInfo { get; set; }
        public string Status { get; set; }
        public DateTime? LastOrderDate { get; set; }

        // Initializes empty contact fields and Active status for new suppliers.
        public Supplier()
        {
            Name = string.Empty;
            ContactName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            DeliveryInfo = string.Empty;
            Status = "Active";
        }
    }
}
