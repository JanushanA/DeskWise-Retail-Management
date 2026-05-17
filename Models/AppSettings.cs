namespace DeskWise.Models
{
    // Persisted user preferences for the store. Tax rate is stored as a fraction (0.13 = 13%).
    public class AppSettings
    {
        // Sales tax applied at checkout, as a decimal fraction of the taxable amount.
        public decimal TaxRate { get; set; }
        // Text printed at the top of customer receipts.
        public string ReceiptHeader { get; set; }
        // Text printed at the bottom of customer receipts.
        public string ReceiptFooter { get; set; }
        // Backup schedule label: Daily, Weekly, or Off.
        public string AutoBackup { get; set; }
        // Quantity at or below which inventory alerts flag low stock.
        public int LowStockThreshold { get; set; }
        // UI theme name (e.g. Light or Dark).
        public string Theme { get; set; }
        // Store name shown in the shell and on receipts.
        public string CompanyName { get; set; }

        // Sets sensible defaults when settings are first created or reset.
        public AppSettings()
        {
            TaxRate = 0.13m;
            ReceiptHeader = "DeskWise Retail Management";
            ReceiptFooter = "Thank you for shopping with us!";
            AutoBackup = "Off";
            LowStockThreshold = 5;
            Theme = "Light";
            CompanyName = "DeskWise";
        }
    }
}
