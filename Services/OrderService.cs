using System;
using System.Collections.Generic;
using System.Linq;
using DeskWise.Models;

namespace DeskWise.Services
{
    // Sales orders: checkout completion, search, refunds, and dashboard totals.
    public static class OrderService
    {
        private static List<Order> _orders = new List<Order>();

        // Read-only view of all orders in memory.
        public static IReadOnlyList<Order> All
        {
            get { return _orders; }
        }

        // Points the in-memory list at the store's Orders collection.
        public static void BindFromStore()
        {
            _orders = DataStoreService.Store.Orders ?? new List<Order>();
            DataStoreService.Store.Orders = _orders;
        }

        // Copies the in-memory list back into the store model before save.
        public static void SyncToStore()
        {
            DataStoreService.Store.Orders = _orders;
        }

        // Writes orders to the store and flushes deskwise.json.
        public static void Save()
        {
            SyncToStore();
            DataStoreService.Save();
        }

        // Creates the next order id in ORD-0001 style based on list size.
        public static string GenerateOrderId()
        {
            int sequence = _orders.Count + 1;
            return string.Format("ORD-{0:0000}", sequence);
        }

        // Finds an order by its business key.
        public static Order GetById(string orderId)
        {
            return _orders.FirstOrDefault(order => order.OrderId == orderId);
        }

        // Finalizes a pending cart: stock check, totals, stock reduction, and save.
        public static Order Complete(Order pendingOrder, string employeeUsername, decimal taxRate)
        {
            if (pendingOrder == null) throw new ArgumentNullException(nameof(pendingOrder));
            if (pendingOrder.Items == null || pendingOrder.Items.Count == 0)
            {
                throw new InvalidOperationException("Cannot complete an empty order.");
            }

            // Ensure every line has enough stock before committing.
            foreach (OrderItem line in pendingOrder.Items)
            {
                Product product = ProductService.GetById(line.ProductId);
                if (product == null)
                {
                    throw new InvalidOperationException("Product no longer exists: " + line.ProductName);
                }
                if (product.Quantity < line.Quantity)
                {
                    throw new InvalidOperationException(
                        string.Format("Not enough stock for {0}. Available: {1}, requested: {2}.",
                            product.Name, product.Quantity, line.Quantity));
                }
            }

            pendingOrder.OrderId = GenerateOrderId();
            pendingOrder.Date = DateTime.Now;
            pendingOrder.EmployeeUsername = employeeUsername;
            pendingOrder.Status = "Completed";
            pendingOrder.RecalculateTotals(taxRate);

            ProductService.ReduceStock(pendingOrder.Items);
            if (pendingOrder.CustomerId > 0)
            {
                CustomerService.RegisterPurchase(pendingOrder.CustomerId, pendingOrder.Total);
            }

            _orders.Add(pendingOrder);
            Save();
            return pendingOrder;
        }

        // Marks an order as refunded without reversing stock (manual adjustment elsewhere).
        public static void Refund(string orderId)
        {
            Order order = GetById(orderId);
            if (order == null) return;
            order.Status = "Refunded";
            Save();
        }

        // Filters orders by text, date range, status, and payment method.
        public static List<Order> Search(string query, DateTime? start, DateTime? end, string status, string paymentMethod)
        {
            IEnumerable<Order> filtered = _orders;

            if (!string.IsNullOrWhiteSpace(query))
            {
                string needle = query.Trim().ToLowerInvariant();
                filtered = filtered.Where(order =>
                    (order.OrderId != null && order.OrderId.ToLowerInvariant().Contains(needle)) ||
                    (order.CustomerName != null && order.CustomerName.ToLowerInvariant().Contains(needle)));
            }

            if (start.HasValue) filtered = filtered.Where(order => order.Date.Date >= start.Value.Date);
            if (end.HasValue) filtered = filtered.Where(order => order.Date.Date <= end.Value.Date);

            if (!string.IsNullOrWhiteSpace(status) && status != "All")
            {
                filtered = filtered.Where(order => order.Status == status);
            }

            if (!string.IsNullOrWhiteSpace(paymentMethod) && paymentMethod != "All")
            {
                filtered = filtered.Where(order => order.PaymentMethod == paymentMethod);
            }

            return filtered.OrderByDescending(order => order.Date).ToList();
        }

        // Sum of completed order totals for today.
        public static decimal TotalSalesToday()
        {
            DateTime today = DateTime.Today;
            return _orders.Where(order => order.Date.Date == today && order.Status == "Completed")
                .Sum(order => order.Total);
        }

        // Sum of completed order totals from the first day of this month.
        public static decimal TotalRevenueThisMonth()
        {
            DateTime firstOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            return _orders.Where(order => order.Date >= firstOfMonth && order.Status == "Completed")
                .Sum(order => order.Total);
        }

        // Count of orders still in Pending status.
        public static int CountPending()
        {
            return _orders.Count(order => order.Status == "Pending");
        }

        // Most recent orders for dashboard or quick lists.
        public static IEnumerable<Order> Recent(int count)
        {
            return _orders.OrderByDescending(order => order.Date).Take(count);
        }

        // Rolling 7-day window for the dashboard chart. Anchors to the latest completed
        // order when the calendar window has no sales (e.g. mock data ends before today).
        public static void GetSalesChartWindow(out DateTime start, out DateTime end)
        {
            end = DateTime.Today;
            start = end.AddDays(-6);

            decimal windowTotal = SumCompletedBetween(start, end);
            if (windowTotal > 0)
            {
                return;
            }

            Order latestCompleted = _orders
                .Where(order => IsCompleted(order))
                .OrderByDescending(order => order.Date)
                .FirstOrDefault();

            if (latestCompleted == null)
            {
                return;
            }

            end = latestCompleted.Date.Date;
            start = end.AddDays(-6);
        }

        // Sum of completed order totals for each day in an inclusive date range.
        public static decimal SumCompletedBetween(DateTime start, DateTime end)
        {
            DateTime from = start.Date;
            DateTime to = end.Date;
            return _orders
                .Where(order => IsCompleted(order) && order.Date.Date >= from && order.Date.Date <= to)
                .Sum(order => order.Total);
        }

        private static bool IsCompleted(Order order)
        {
            return order != null
                && string.Equals(order.Status, "Completed", StringComparison.OrdinalIgnoreCase);
        }
    }
}
