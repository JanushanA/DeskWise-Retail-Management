using System;

namespace DeskWise.Models
{
    // Core inventory item. Status is computed on the fly so we never store stale data.
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Barcode { get; set; }
        public string Category { get; set; }
        public int SupplierId { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Quantity { get; set; }
        public int ReorderLevel { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        // Computed: a product is OutOfStock at 0, LowStock at-or-below reorder, else InStock.
        public StockStatus Status
        {
            get
            {
                if (Quantity <= 0) return StockStatus.OutOfStock;
                if (Quantity <= ReorderLevel) return StockStatus.LowStock;
                return StockStatus.InStock;
            }
        }

        // Human-readable label for grids and reports based on Status.
        public string StatusDisplay
        {
            get
            {
                switch (Status)
                {
                    case StockStatus.OutOfStock: return "Out of Stock";
                    case StockStatus.LowStock: return "Low Stock";
                    default: return "In Stock";
                }
            }
        }

        // Parameterless constructor for deserialization and designer use.
        public Product() { }

        // Builds a product with generated SKU, estimated cost, and default reorder level.
        public Product(int id, string name, string category, decimal salePrice, int quantity)
        {
            Id = id;
            Name = name;
            Category = category;
            SalePrice = salePrice;
            Quantity = quantity;
            SKU = "SKU-" + id;
            // Default cost is 60% of sale price when no supplier cost is known.
            CostPrice = Math.Round(salePrice * 0.6m, 2);
            ReorderLevel = 5;
            Description = string.Empty;
            ImagePath = string.Empty;
            Barcode = string.Empty;
        }
    }
}
