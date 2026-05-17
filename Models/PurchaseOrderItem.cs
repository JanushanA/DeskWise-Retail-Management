namespace DeskWise.Models
{
    // A line on a Purchase Order (supplier-side). Quantity ordered vs received supports
    // partial deliveries and reconciliation when stock is updated.
    public class PurchaseOrderItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityOrdered { get; set; }
        public int QuantityReceived { get; set; }
        public decimal CostPerUnit { get; set; }

        // Extended cost for this line: unit cost multiplied by quantity ordered.
        public decimal Subtotal
        {
            get { return CostPerUnit * QuantityOrdered; }
        }

        // Ensures product name is non-null for grids and receiving screens.
        public PurchaseOrderItem()
        {
            ProductName = string.Empty;
        }
    }
}
