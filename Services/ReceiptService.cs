using System.IO;
using System.Text;
using DeskWise.Models;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

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

        // Writes the receipt as a PDF file and returns its full path.
        public static string SaveToFile(Order order)
        {
            FileService.EnsureDirectory(FileService.ReceiptsDirectory);
            string fullPath = Path.Combine(FileService.ReceiptsDirectory, order.OrderId + ".pdf");
            WritePdf(fullPath, Build(order));
            return fullPath;
        }

        // Returns the PDF path for a saved order receipt.
        public static string GetReceiptPath(string orderId)
        {
            return Path.Combine(FileService.ReceiptsDirectory, orderId + ".pdf");
        }

        // Writes arbitrary receipt text to a PDF file (preview or export).
        public static void SaveTextAsPdf(string fullPath, string receiptText)
        {
            FileService.EnsureDirectory(Path.GetDirectoryName(fullPath));
            WritePdf(fullPath, receiptText);
        }

        private static void WritePdf(string fullPath, string receiptText)
        {
            using (PdfDocument document = new PdfDocument())
            {
                document.Info.Title = "Receipt";
                PdfPage page = document.AddPage();
                using (XGraphics gfx = XGraphics.FromPdfPage(page))
                {
                    XFont font = new XFont("Courier New", 9);
                    double y = 40;
                    const double lineHeight = 12;
                    string[] lines = receiptText.Split(new[] { "\r\n", "\n" }, System.StringSplitOptions.None);
                    foreach (string line in lines)
                    {
                        if (y > page.Height.Point - 40) break;
                        gfx.DrawString(line ?? string.Empty, font, XBrushes.Black, 40, y);
                        y += lineHeight;
                    }
                }

                document.Save(fullPath);
            }
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
