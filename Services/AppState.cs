using DeskWise.Models;

namespace DeskWise.Services
{
    // Central app state: signed-in user and the order being built before checkout.
    public static class AppState
    {
        public static User CurrentUser { get; set; }

        public static Order PendingOrder { get; set; }

        // True when the signed-in user has the Admin role.
        public static bool IsAdmin
        {
            get { return CurrentUser != null && CurrentUser.Role == "Admin"; }
        }

        // True when the signed-in user is a Manager or Admin.
        public static bool IsManager
        {
            get { return CurrentUser != null && (CurrentUser.Role == "Manager" || CurrentUser.Role == "Admin"); }
        }

        // True when any user is signed in (any active role).
        public static bool IsEmployee
        {
            get { return CurrentUser != null; }
        }

        // Loads deskwise.json and wires every service list from the single store.
        public static void Initialize()
        {
            DataStoreService.Load();
            SettingsService.BindFromStore();
            AuthService.BindFromStore();
            SupplierService.BindFromStore();
            ProductService.BindFromStore();
            CustomerService.BindFromStore();
            OrderService.BindFromStore();
            PurchaseOrderService.BindFromStore();
        }

        // Persists the full store to deskwise.json.
        public static void SaveAll()
        {
            ProductService.SyncToStore();
            CustomerService.SyncToStore();
            SupplierService.SyncToStore();
            OrderService.SyncToStore();
            PurchaseOrderService.SyncToStore();
            AuthService.SyncToStore();
            SettingsService.SyncToStore();
            DataStoreService.Save();
        }

        // Clears session state after sign-out.
        public static void Logout()
        {
            CurrentUser = null;
            PendingOrder = null;
        }
    }
}
