using System.Collections.Generic;
using System.Linq;
using DeskWise.Models;

namespace DeskWise.Services
{
    // Supplier directory: CRUD and search backed by deskwise.json.
    public static class SupplierService
    {
        private static List<Supplier> _suppliers = new List<Supplier>();

        // Read-only view of all suppliers in memory.
        public static IReadOnlyList<Supplier> All
        {
            get { return _suppliers; }
        }

        // Points the in-memory list at the store's Suppliers collection.
        public static void BindFromStore()
        {
            _suppliers = DataStoreService.Store.Suppliers ?? new List<Supplier>();
            DataStoreService.Store.Suppliers = _suppliers;
        }

        // Copies the in-memory list back into the store model before save.
        public static void SyncToStore()
        {
            DataStoreService.Store.Suppliers = _suppliers;
        }

        // Writes suppliers to the store and flushes deskwise.json.
        public static void Save()
        {
            SyncToStore();
            DataStoreService.Save();
        }

        // Next available supplier id (max existing + 1).
        public static int NextId()
        {
            return _suppliers.Count == 0 ? 1 : _suppliers.Max(supplier => supplier.Id) + 1;
        }

        // Finds a supplier by primary key.
        public static Supplier GetById(int id)
        {
            return _suppliers.FirstOrDefault(supplier => supplier.Id == id);
        }

        // Appends a new supplier and persists.
        public static void Add(Supplier supplier)
        {
            _suppliers.Add(supplier);
            Save();
        }

        // Replaces an existing supplier by id.
        public static void Update(Supplier supplier)
        {
            int index = _suppliers.FindIndex(item => item.Id == supplier.Id);
            if (index >= 0)
            {
                _suppliers[index] = supplier;
                Save();
            }
        }

        // Removes a supplier by id.
        public static void Delete(int id)
        {
            _suppliers.RemoveAll(supplier => supplier.Id == id);
            Save();
        }

        // Filters by name, contact, or email; returns all when query is empty.
        public static List<Supplier> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query)) return _suppliers.ToList();
            string needle = query.Trim().ToLowerInvariant();
            return _suppliers.Where(supplier =>
                (supplier.Name != null && supplier.Name.ToLowerInvariant().Contains(needle)) ||
                (supplier.ContactName != null && supplier.ContactName.ToLowerInvariant().Contains(needle)) ||
                (supplier.Email != null && supplier.Email.ToLowerInvariant().Contains(needle))).ToList();
        }
    }
}
