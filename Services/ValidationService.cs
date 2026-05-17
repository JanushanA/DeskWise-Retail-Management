using System.Text.RegularExpressions;

namespace DeskWise.Services
{
    // Reusable validation helpers. UI code calls these and shows a MessageBox if false,
    // so all rules live in one place and are easy to point to during a code review.
    public static class ValidationService
    {
        // Product / customer / supplier names: must contain at least one letter or digit,
        // and must not be only symbols or whitespace.
        public static bool IsValidName(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;
            return Regex.IsMatch(value, @"[A-Za-z0-9]");
        }

        // Email format check; empty is allowed for optional fields.
        public static bool IsValidEmail(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return true; // optional field
            return Regex.IsMatch(value.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Phone format check; empty is allowed for optional fields.
        public static bool IsValidPhone(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return true; // optional field
            return Regex.IsMatch(value.Trim(), @"^[\+\d\s\-\(\)]{6,20}$");
        }

        // Parses text as a decimal strictly greater than zero.
        public static bool IsPositiveDecimal(string text, out decimal value)
        {
            return decimal.TryParse(text, out value) && value > 0;
        }

        // Parses text as a decimal zero or greater.
        public static bool IsNonNegativeDecimal(string text, out decimal value)
        {
            return decimal.TryParse(text, out value) && value >= 0;
        }

        // Parses text as an integer zero or greater.
        public static bool IsNonNegativeInt(string text, out int value)
        {
            return int.TryParse(text, out value) && value >= 0;
        }

        // Parses text as an integer strictly greater than zero.
        public static bool IsPositiveInt(string text, out int value)
        {
            return int.TryParse(text, out value) && value > 0;
        }
    }
}
