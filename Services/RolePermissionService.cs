using System.Collections.Generic;

namespace DeskWise.Services
{
    public sealed class RolePermissionRow
    {
        public string Feature { get; set; }
        public string Admin { get; set; }
        public string Manager { get; set; }
        public string Employee { get; set; }
    }

    // Static role-permission matrix shown on the User Management screen.
    public static class RolePermissionService
    {
        public const string Allowed = "\u2713";
        public const string Denied = "\u2717";

        public static IList<RolePermissionRow> All { get; } = new List<RolePermissionRow>
        {
            new RolePermissionRow { Feature = "Dashboard",           Admin = Allowed, Manager = Allowed, Employee = Allowed },
            new RolePermissionRow { Feature = "Inventory (view)",    Admin = Allowed, Manager = Allowed, Employee = Allowed },
            new RolePermissionRow { Feature = "Inventory (edit)",      Admin = Allowed, Manager = Allowed, Employee = Denied },
            new RolePermissionRow { Feature = "Build Orders",          Admin = Allowed, Manager = Allowed, Employee = Allowed },
            new RolePermissionRow { Feature = "Checkout",              Admin = Allowed, Manager = Allowed, Employee = Allowed },
            new RolePermissionRow { Feature = "Order History",         Admin = Allowed, Manager = Allowed, Employee = Allowed },
            new RolePermissionRow { Feature = "Refunds",               Admin = Allowed, Manager = Allowed, Employee = Denied },
            new RolePermissionRow { Feature = "Customers (edit)",      Admin = Allowed, Manager = Allowed, Employee = Denied },
            new RolePermissionRow { Feature = "Suppliers",             Admin = Allowed, Manager = Allowed, Employee = Denied },
            new RolePermissionRow { Feature = "Purchase Orders",       Admin = Allowed, Manager = Allowed, Employee = Denied },
            new RolePermissionRow { Feature = "Reports",               Admin = Allowed, Manager = Allowed, Employee = Denied },
            new RolePermissionRow { Feature = "Alerts",                Admin = Allowed, Manager = Allowed, Employee = Allowed },
            new RolePermissionRow { Feature = "User Management",       Admin = Allowed, Manager = Denied,  Employee = Denied },
            new RolePermissionRow { Feature = "Settings (edit)",       Admin = Allowed, Manager = Allowed, Employee = Denied },
            new RolePermissionRow { Feature = "Settings (view)",       Admin = Allowed, Manager = Allowed, Employee = Allowed }
        };
    }
}
