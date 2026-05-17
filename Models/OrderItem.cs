namespace DeskWise.Models
{
    // One line on a sales order. Subtotal is a computed property so the cart can never
    // get out of sync with quantity * unit price - discount.
    public class OrderItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }

        // Line total before tax: (unit price × quantity) minus line discount.
        public decimal Subtotal
        {
            get { return (UnitPrice * Quantity) - Discount; }
        }

        // Ensures product name is non-null for grid binding and receipts.
        public OrderItem()
        {
            ProductName = string.Empty;
        }
    }
}
