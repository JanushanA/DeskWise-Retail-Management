using System;
using System.Collections.Generic;
using System.Linq;
using DeskWise.Models;

namespace DeskWise.Services
{
    // Customer records: CRUD, search, and loyalty updates backed by deskwise.json.
    public static class CustomerService
    {
        private static List<Customer> _customers = new List<Customer>();

        // Read-only view of all customers in memory.
        public static IReadOnlyList<Customer> All
        {
            get { return _customers; }
        }

        // Points the in-memory list at the store's Customers collection.
        public static void BindFromStore()
        {
            _customers = DataStoreService.Store.Customers ?? new List<Customer>();
            DataStoreService.Store.Customers = _customers;
        }

        // Copies the in-memory list back into the store model before save.
        public static void SyncToStore()
        {
            DataStoreService.Store.Customers = _customers;
        }

        // Writes customers to the store and flushes deskwise.json.
        public static void Save()
        {
            SyncToStore();
            DataStoreService.Save();
        }

        // Next available customer id (max existing + 1).
        public static int NextId()
        {
            return _customers.Count == 0 ? 1 : _customers.Max(customer => customer.Id) + 1;
        }

        // Finds a customer by primary key.
        public static Customer GetById(int id)
        {
            return _customers.FirstOrDefault(customer => customer.Id == id);
        }

        // Appends a new customer and persists.
        public static void Add(Customer customer)
        {
            _customers.Add(customer);
            Save();
        }

        // Replaces an existing customer by id.
        public static void Update(Customer customer)
        {
            int index = _customers.FindIndex(item => item.Id == customer.Id);
            if (index >= 0)
            {
                _customers[index] = customer;
                Save();
            }
        }

        // Removes a customer by id.
        public static void Delete(int id)
        {
            _customers.RemoveAll(customer => customer.Id == id);
            Save();
        }

        // Filters by name, phone, or email; returns all when query is empty.
        public static List<Customer> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query)) return _customers.ToList();
            string needle = query.Trim().ToLowerInvariant();
            return _customers.Where(customer =>
                (customer.Name != null && customer.Name.ToLowerInvariant().Contains(needle)) ||
                (customer.Phone != null && customer.Phone.ToLowerInvariant().Contains(needle)) ||
                (customer.Email != null && customer.Email.ToLowerInvariant().Contains(needle))).ToList();
        }

        // Updates last purchase date and loyalty points after a completed order.
        public static void RegisterPurchase(int customerId, decimal orderTotal)
        {
            Customer customer = GetById(customerId);
            if (customer == null) return;
            customer.LastPurchase = DateTime.Now;
            customer.LoyaltyPoints += (int)Math.Floor(orderTotal);
            Save();
        }
    }
}
