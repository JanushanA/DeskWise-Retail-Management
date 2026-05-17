using System.Collections.Generic;

namespace DeskWise.Models
{
    // Root object persisted as a single JSON file (Data/deskwise.json).
    public class DeskWiseDataStore
    {
        // All catalog products loaded into memory at startup.
        public List<Product> Products { get; set; }
        // Registered customers for sales and loyalty.
        public List<Customer> Customers { get; set; }
        // Vendors linked to products and purchase orders.
        public List<Supplier> Suppliers { get; set; }
        // Completed and in-progress sales orders.
        public List<Order> Orders { get; set; }
        // Supplier purchase orders for restocking.
        public List<PurchaseOrder> PurchaseOrders { get; set; }
        // Application users for login and role checks.
        public List<User> Users { get; set; }
        // Global store preferences (tax, theme, receipts).
        public AppSettings Settings { get; set; }

        // Creates empty collections and default settings for a new data file.
        public DeskWiseDataStore()
        {
            Products = new List<Product>();
            Customers = new List<Customer>();
            Suppliers = new List<Supplier>();
            Orders = new List<Order>();
            PurchaseOrders = new List<PurchaseOrder>();
            Users = new List<User>();
            Settings = new AppSettings();
        }
    }
}
