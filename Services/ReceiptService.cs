using System.IO;

using System.Text;

using DeskWise.Models;



namespace DeskWise.Services

{

    // Formats completed orders as plain-text receipts and saves them under Receipts.

    public static class ReceiptService

    {

        // Builds a fixed-width text receipt from order lines and app settings.

        public static string Build(Order order)

        {

            AppSettings settings = SettingsService.Current;

            StringBuilder receiptText = new StringBuilder();



            receiptText.AppendLine("================================================");

            receiptText.AppendLine(Center(settings.ReceiptHeader));

            receiptText.AppendLine(Center(settings.CompanyName));

            receiptText.AppendLine("================================================");

            receiptText.AppendLine("Order:    " + order.OrderId);

            receiptText.AppendLine("Date:     " + order.Date.ToString("yyyy-MM-dd HH:mm"));

            receiptText.AppendLine("Customer: " + order.CustomerName);

            receiptText.AppendLine("Staff:    " + order.EmployeeUsername);

            receiptText.AppendLine("Payment:  " + order.PaymentMethod);

            receiptText.AppendLine("------------------------------------------------");

            receiptText.AppendLine(string.Format("{0,-24}{1,5}{2,8}{3,11}", "Item", "Qty", "Price", "Subtotal"));



            foreach (OrderItem item in order.Items)

            {

                string name = item.ProductName ?? string.Empty;

                if (name.Length > 24) name = name.Substring(0, 24);

                receiptText.AppendLine(string.Format("{0,-24}{1,5}{2,8:0.00}{3,11:0.00}", name, item.Quantity, item.UnitPrice, item.Subtotal));

            }



            receiptText.AppendLine("------------------------------------------------");

            receiptText.AppendLine(string.Format("{0,-37}{1,11:0.00}", "Subtotal:", order.Subtotal));

            receiptText.AppendLine(string.Format("{0,-37}{1,11:0.00}", "Discount:", order.Discount));

            receiptText.AppendLine(string.Format("{0,-37}{1,11:0.00}", string.Format("Tax ({0:0.##}%):", order.TaxRate * 100m), order.Tax));

            receiptText.AppendLine(string.Format("{0,-37}{1,11:0.00}", "TOTAL:", order.Total));

            receiptText.AppendLine("================================================");

            receiptText.AppendLine(Center(settings.ReceiptFooter));

            receiptText.AppendLine("================================================");



            return receiptText.ToString();

        }



        // Writes the receipt text file and returns its full path.

        public static string SaveToFile(Order order)

        {

            FileService.EnsureDirectory(FileService.ReceiptsDirectory);

            string fullPath = Path.Combine(FileService.ReceiptsDirectory, order.OrderId + ".txt");

            FileService.WriteText(fullPath, Build(order));

            return fullPath;

        }



        // Pads text to center within a 48-character receipt width.

        private static string Center(string text)

        {

            if (string.IsNullOrEmpty(text)) return string.Empty;

            const int Width = 48;

            if (text.Length >= Width) return text;

            int padTotal = Width - text.Length;

            int padLeft = padTotal / 2;

            return new string(' ', padLeft) + text;

        }

    }

}


