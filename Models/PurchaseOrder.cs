using System;
using System.Collections.Generic;
using System.Linq;

namespace DeskWise.Models
{
    // Supplier restock order with line items, delivery dates, and workflow status.
    public class PurchaseOrder
    {
        public string Id { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ExpectedDelivery { get; set; }
        public List<PurchaseOrderItem> Items { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public string Notes { get; set; }

        // Sum of line subtotals; returns zero when the item list is null.
        public decimal TotalCost
        {
            get { return Items != null ? Items.Sum(lineItem => lineItem.Subtotal) : 0m; }
        }

        // New PO defaults: draft status, empty lines, delivery one week out.
        public PurchaseOrder()
        {
            Items = new List<PurchaseOrderItem>();
            DateCreated = DateTime.Now;
            ExpectedDelivery = DateTime.Now.AddDays(7);
            Status = "Draft";
            CreatedBy = string.Empty;
            Notes = string.Empty;
            Id = string.Empty;
            SupplierName = string.Empty;
        }
    }
}
