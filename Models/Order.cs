using System;
using System.Collections.Generic;
using System.Linq;

namespace DeskWise.Models
{
    // A completed or in-progress sales order. The grand-total math lives in RecalculateTotals
    // so we have a single source of truth - the Order Builder and Checkout screens both call it.
    public class Order
    {
        public string OrderId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
        public List<OrderItem> Items { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal TaxRate { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public string EmployeeUsername { get; set; }

        // Default cart: pending status, walk-in customer, cash payment, empty line list.
        public Order()
        {
            Items = new List<OrderItem>();
            Date = DateTime.Now;
            Status = "Pending";
            PaymentMethod = "Cash";
            CustomerName = "Walk-in Customer";
            OrderId = string.Empty;
            EmployeeUsername = string.Empty;
        }

        // Centralised totals calculation. taxRate is a fraction (e.g. 0.13 for 13%).
        public void RecalculateTotals(decimal taxRate)
        {
            TaxRate = taxRate;
            Subtotal = Items.Sum(lineItem => lineItem.Subtotal);
            decimal taxable = Subtotal - Discount;
            // Never tax a negative base after a large order-level discount.
            if (taxable < 0) taxable = 0;
            Tax = decimal.Round(taxable * taxRate, 2);
            Total = decimal.Round(taxable + Tax, 2);
        }
    }
}
