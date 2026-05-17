namespace DeskWise.Models
{
    // Tri-state stock status used everywhere we display or filter inventory.
    public enum StockStatus
    {
        // Quantity above reorder level.
        InStock,
        // Quantity positive but at or below reorder level.
        LowStock,
        // Quantity is zero or negative.
        OutOfStock
    }
}
