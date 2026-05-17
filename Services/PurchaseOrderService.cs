using System;
using System.Collections.Generic;
using System.Linq;
using DeskWise.Models;

namespace DeskWise.Services
{
    // Supplier purchase orders: create, receive stock, and search.
    public static class PurchaseOrderService
    {
        private static List<PurchaseOrder> _purchaseOrders = new List<PurchaseOrder>();

        // Read-only view of all purchase orders in memory.
        public static IReadOnlyList<PurchaseOrder> All
        {
            get { return _purchaseOrders; }
        }

        // Points the in-memory list at the store's PurchaseOrders collection.
        public static void BindFromStore()
        {
            _purchaseOrders = DataStoreService.Store.PurchaseOrders ?? new List<PurchaseOrder>();
            DataStoreService.Store.PurchaseOrders = _purchaseOrders;
        }

        // Copies the in-memory list back into the store model before save.
        public static void SyncToStore()
        {
            DataStoreService.Store.PurchaseOrders = _purchaseOrders;
        }

        // Writes purchase orders to the store and flushes deskwise.json.
        public static void Save()
        {
            SyncToStore();
            DataStoreService.Save();
        }

        // Creates the next PO id with year and sequence (PO-2026-0001 style).
        public static string GeneratePoId()
        {
            int sequence = _purchaseOrders.Count + 1;
            return string.Format("PO-{0:yyyy}-{1:0000}", DateTime.Now, sequence);
        }

        // Finds a purchase order by its id string.
        public static PurchaseOrder GetById(string id)
        {
            return _purchaseOrders.FirstOrDefault(purchaseOrder => purchaseOrder.Id == id);
        }

        // Adds a PO, generating an id when missing.
        public static void Add(PurchaseOrder purchaseOrder)
        {
            if (string.IsNullOrEmpty(purchaseOrder.Id)) purchaseOrder.Id = GeneratePoId();
            _purchaseOrders.Add(purchaseOrder);
            Save();
        }

        // Replaces an existing purchase order by id.
        public static void Update(PurchaseOrder purchaseOrder)
        {
            int index = _purchaseOrders.FindIndex(item => item.Id == purchaseOrder.Id);
            if (index >= 0)
            {
                _purchaseOrders[index] = purchaseOrder;
                Save();
            }
        }

        // Removes a purchase order by id.
        public static void Delete(string id)
        {
            _purchaseOrders.RemoveAll(purchaseOrder => purchaseOrder.Id == id);
            Save();
        }

        // Marks all lines received, updates product stock, and sets status to Received.
        public static void MarkReceived(string id)
        {
            PurchaseOrder purchaseOrder = GetById(id);
            if (purchaseOrder == null) return;

            foreach (PurchaseOrderItem line in purchaseOrder.Items)
            {
                if (line.QuantityReceived == 0) line.QuantityReceived = line.QuantityOrdered;
            }

            ProductService.AddStock(purchaseOrder.Items);
            purchaseOrder.Status = "Received";
            Save();
        }

        // Filters by PO id, supplier name, and status.
        public static List<PurchaseOrder> Search(string query, string status)
        {
            IEnumerable<PurchaseOrder> filtered = _purchaseOrders;
            if (!string.IsNullOrWhiteSpace(query))
            {
                string needle = query.Trim().ToLowerInvariant();
                filtered = filtered.Where(purchaseOrder =>
                    (purchaseOrder.Id != null && purchaseOrder.Id.ToLowerInvariant().Contains(needle)) ||
                    (purchaseOrder.SupplierName != null && purchaseOrder.SupplierName.ToLowerInvariant().Contains(needle)));
            }
            if (!string.IsNullOrWhiteSpace(status) && status != "All")
            {
                filtered = filtered.Where(purchaseOrder => purchaseOrder.Status == status);
            }
            return filtered.OrderByDescending(purchaseOrder => purchaseOrder.DateCreated).ToList();
        }

        // How many POs match a given status string.
        public static int CountByStatus(string status)
        {
            return _purchaseOrders.Count(purchaseOrder => purchaseOrder.Status == status);
        }
    }
}
