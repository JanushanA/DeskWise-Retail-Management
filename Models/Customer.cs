using System;

namespace DeskWise.Models
{
    // Retail customer record used for checkout, loyalty, and order history.
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int LoyaltyPoints { get; set; }
        public DateTime? LastPurchase { get; set; }
        public string Notes { get; set; }

        // Initializes empty strings so bound forms never see null text fields.
        public Customer()
        {
            Name = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Notes = string.Empty;
        }
    }
}
