using System;

namespace DeskWise.Models
{
    // Three-role auth model (Admin, Manager, Employee). Passwords are stored as plain text
    // in the local data file; use a proper credential store in production deployments.
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastLogin { get; set; }

        // Default new user: Employee role, active, empty credentials until saved.
        public User()
        {
            Username = string.Empty;
            Password = string.Empty;
            DisplayName = string.Empty;
            Role = "Employee";
            Email = string.Empty;
            IsActive = true;
        }
    }
}
