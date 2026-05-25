using System.Linq;
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

        // Validates Visa or Mastercard number (Luhn + issuer prefix).
        public static bool IsValidCardNumber(string cardNumber, out string brand, out string error)
        {
            brand = string.Empty;
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                error = "Card number is required.";
                return false;
            }

            string digits = new string(cardNumber.Where(char.IsDigit).ToArray());
            if (digits.Length < 13 || digits.Length > 19)
            {
                error = "Card number must be 13–19 digits.";
                return false;
            }

            if (digits.StartsWith("4"))
            {
                if (digits.Length != 13 && digits.Length != 16 && digits.Length != 19)
                {
                    error = "Visa card numbers are usually 13, 16, or 19 digits.";
                    return false;
                }
                brand = "Visa";
            }
            else if (IsMastercardPrefix(digits))
            {
                if (digits.Length != 16)
                {
                    error = "Mastercard numbers must be 16 digits.";
                    return false;
                }
                brand = "Mastercard";
            }
            else
            {
                error = "Only Visa and Mastercard are accepted.";
                return false;
            }

            if (!PassesLuhn(digits))
            {
                error = "Card number failed validation.";
                return false;
            }

            return true;
        }

        // Validates MM/YY or MM/YYYY expiry.
        public static bool IsValidCardExpiry(string expiry, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(expiry))
            {
                error = "Expiry date is required.";
                return false;
            }

            string trimmed = expiry.Trim();
            Match match = Regex.Match(trimmed, @"^(0[1-9]|1[0-2])\s*/\s*(\d{2}|\d{4})$");
            if (!match.Success)
            {
                error = "Use MM/YY format (e.g. 09/28).";
                return false;
            }

            int month = int.Parse(match.Groups[1].Value);
            string yearPart = match.Groups[2].Value;
            int year = yearPart.Length == 2 ? 2000 + int.Parse(yearPart) : int.Parse(yearPart);
            var expiryDate = new System.DateTime(year, month, 1).AddMonths(1).AddDays(-1);
            if (expiryDate < System.DateTime.Today)
            {
                error = "Card has expired.";
                return false;
            }

            return true;
        }

        // Validates 3- or 4-digit CVV.
        public static bool IsValidCardCvv(string cvv, string brand, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(cvv))
            {
                error = "CVV is required.";
                return false;
            }

            if (!Regex.IsMatch(cvv.Trim(), @"^\d{3,4}$"))
            {
                error = "CVV must be 3 or 4 digits.";
                return false;
            }

            if (brand == "Mastercard" && cvv.Trim().Length != 3)
            {
                error = "Mastercard CVV must be 3 digits.";
                return false;
            }

            return true;
        }

        private static bool IsMastercardPrefix(string digits)
        {
            if (digits.Length < 2) return false;
            int prefix2 = int.Parse(digits.Substring(0, 2));
            if (prefix2 >= 51 && prefix2 <= 55) return true;
            if (digits.Length < 4) return false;
            int prefix4 = int.Parse(digits.Substring(0, 4));
            return prefix4 >= 2221 && prefix4 <= 2720;
        }

        private static bool PassesLuhn(string digits)
        {
            int sum = 0;
            bool alternate = false;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int n = digits[i] - '0';
                if (alternate)
                {
                    n *= 2;
                    if (n > 9) n -= 9;
                }
                sum += n;
                alternate = !alternate;
            }
            return sum % 10 == 0;
        }
    }
}
