using System;
using System.Collections.Generic;
using System.Linq;
using DeskWise.Models;

namespace DeskWise.Services
{
    // Product catalog: inventory levels, search, and stock changes from sales or POs.
    public static class ProductService
    {
        private static List<Product> _products = new List<Product>();

        // Read-only view of all products in memory.
        public static IReadOnlyList<Product> All
        {
            get { return _products; }
        }

        // Points the in-memory list at the store's Products collection.
        public static void BindFromStore()
        {
            _products = DataStoreService.Store.Products ?? new List<Product>();
            DataStoreService.Store.Products = _products;
        }

        // Copies the in-memory list back into the store model before save.
        public static void SyncToStore()
        {
            DataStoreService.Store.Products = _products;
        }

        // Writes products to the store and flushes deskwise.json.
        public static void Save()
        {
            SyncToStore();
            DataStoreService.Save();
        }

        // Next product id (starts at 1000 when the catalog is empty).
        public static int NextId()
        {
            return _products.Count == 0 ? 1000 : _products.Max(product => product.Id) + 1;
        }

        // Finds a product by primary key.
        public static Product GetById(int id)
        {
            return _products.FirstOrDefault(product => product.Id == id);
        }

        // Appends a new product and persists.
        public static void Add(Product product)
        {
            _products.Add(product);
            Save();
        }

        // Replaces an existing product by id.
        public static void Update(Product product)
        {
            int index = _products.FindIndex(item => item.Id == product.Id);
            if (index >= 0)
            {
                _products[index] = product;
                Save();
            }
        }

        // Removes a product by id.
        public static void Delete(int id)
        {
            _products.RemoveAll(product => product.Id == id);
            Save();
        }

        // True when another product already uses this SKU (optionally excluding one id).
        public static bool IsSkuTaken(string sku, int ignoreId = -1)
        {
            if (string.IsNullOrWhiteSpace(sku)) return false;
            return _products.Any(product =>
                product.Id != ignoreId &&
                string.Equals(product.SKU, sku, StringComparison.OrdinalIgnoreCase));
        }

        // Distinct non-empty category names sorted alphabetically.
        public static List<string> GetCategories()
        {
            return _products
                .Select(product => product.Category)
                .Where(category => !string.IsNullOrWhiteSpace(category))
                .Distinct()
                .OrderBy(category => category)
                .ToList();
        }

        // Filters by name, SKU, barcode, category, and stock status label.
        public static List<Product> Search(string query, string category, string status)
        {
            IEnumerable<Product> filtered = _products;

            if (!string.IsNullOrWhiteSpace(query))
            {
                string needle = query.Trim().ToLowerInvariant();
                filtered = filtered.Where(product =>
                    (product.Name != null && product.Name.ToLowerInvariant().Contains(needle)) ||
                    (product.SKU != null && product.SKU.ToLowerInvariant().Contains(needle)) ||
                    (product.Barcode != null && product.Barcode.ToLowerInvariant().Contains(needle)));
            }

            if (!string.IsNullOrWhiteSpace(category) && category != "All Categories")
            {
                filtered = filtered.Where(product =>
                    string.Equals(product.Category, category, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(status) && status != "All Statuses")
            {
                filtered = filtered.Where(product => product.StatusDisplay == status);
            }

            return filtered.ToList();
        }

        // Products at or below reorder level (includes out of stock).
        public static List<Product> GetLowStock()
        {
            return _products.Where(product =>
                product.Status == StockStatus.LowStock ||
                product.Status == StockStatus.OutOfStock).ToList();
        }

        // Rough quantity to order to reach roughly double the reorder level.
        public static int SuggestReorderQuantity(Product product)
        {
            int suggested = (product.ReorderLevel * 2) - product.Quantity;
            return suggested < 1 ? 1 : suggested;
        }

        // Deducts sold quantities after checkout (never below zero).
        public static void ReduceStock(IEnumerable<OrderItem> items)
        {
            foreach (OrderItem line in items)
            {
                Product product = GetById(line.ProductId);
                if (product == null) continue;
                product.Quantity = Math.Max(0, product.Quantity - line.Quantity);
            }
            Save();
        }

        // Adds received PO line quantities back into inventory.
        public static void AddStock(IEnumerable<PurchaseOrderItem> items)
        {
            foreach (PurchaseOrderItem line in items)
            {
                Product product = GetById(line.ProductId);
                if (product == null) continue;
                int received = line.QuantityReceived > 0 ? line.QuantityReceived : line.QuantityOrdered;
                product.Quantity += received;
            }
            Save();
        }
    }
}
