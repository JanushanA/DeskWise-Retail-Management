namespace DeskWise.Controls
{
    partial class CheckoutControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblCustomerCaption = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblPaymentCaption = new System.Windows.Forms.Label();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbSplit = new System.Windows.Forms.RadioButton();
            this.rbStoreCredit = new System.Windows.Forms.RadioButton();
            this.pnlCardDetails = new System.Windows.Forms.Panel();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardExpiry = new System.Windows.Forms.Label();
            this.txtCardExpiry = new System.Windows.Forms.TextBox();
            this.lblCardCvv = new System.Windows.Forms.Label();
            this.txtCardCvv = new System.Windows.Forms.TextBox();
            this.lblCardName = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.lblCardExample = new System.Windows.Forms.Label();
            this.pnlTotals = new System.Windows.Forms.Panel();
            this.lblSubtotalCaption = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountCaption = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTaxCaption = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblReceiptCaption = new System.Windows.Forms.Label();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlTotals.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlHeader.Size = new System.Drawing.Size(1100, 60);
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Text = "Checkout";
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(22, 40);
            this.lblSubtitle.Text = "Review the order, choose a payment method, then confirm the sale.";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlBody.Controls.Add(this.pnlRight);
            this.pnlBody.Controls.Add(this.pnlLeft);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            // 
            // pnlLeft - order summary
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.dgvSummary);
            this.pnlLeft.Controls.Add(this.lblSummary);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(20, 12);
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(12);
            this.pnlLeft.Size = new System.Drawing.Size(560, 616);
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblSummary.Location = new System.Drawing.Point(15, 14);
            this.lblSummary.Text = "Order Summary";
            // 
            this.dgvSummary.BackgroundColor = System.Drawing.Color.White;
            this.dgvSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Location = new System.Drawing.Point(15, 42);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.RowHeadersVisible = false;
            this.dgvSummary.Size = new System.Drawing.Size(525, 555);
            this.dgvSummary.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // pnlRight - customer / payment / totals / receipt / actions
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.pnlActions);
            this.pnlRight.Controls.Add(this.txtReceipt);
            this.pnlRight.Controls.Add(this.lblReceiptCaption);
            this.pnlRight.Controls.Add(this.pnlTotals);
            this.pnlRight.Controls.Add(this.pnlCardDetails);
            this.pnlRight.Controls.Add(this.rbStoreCredit);
            this.pnlRight.Controls.Add(this.rbSplit);
            this.pnlRight.Controls.Add(this.rbCard);
            this.pnlRight.Controls.Add(this.rbCash);
            this.pnlRight.Controls.Add(this.lblPaymentCaption);
            this.pnlRight.Controls.Add(this.cmbCustomer);
            this.pnlRight.Controls.Add(this.lblCustomerCaption);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(590, 12);
            this.pnlRight.Padding = new System.Windows.Forms.Padding(12);
            this.pnlRight.Size = new System.Drawing.Size(490, 616);
            // 
            this.lblCustomerCaption.AutoSize = true;
            this.lblCustomerCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCustomerCaption.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCustomerCaption.Location = new System.Drawing.Point(15, 14);
            this.lblCustomerCaption.Text = "Customer";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCustomer.Location = new System.Drawing.Point(15, 36);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(455, 25);
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            this.lblPaymentCaption.AutoSize = true;
            this.lblPaymentCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPaymentCaption.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPaymentCaption.Location = new System.Drawing.Point(15, 72);
            this.lblPaymentCaption.Text = "Payment Method";
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCash.Location = new System.Drawing.Point(20, 96);
            this.rbCash.Text = "Cash";
            this.rbCash.CheckedChanged += new System.EventHandler(this.PaymentMethodChanged);
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCard.Location = new System.Drawing.Point(110, 96);
            this.rbCard.Text = "Card";
            this.rbCard.CheckedChanged += new System.EventHandler(this.PaymentMethodChanged);
            // 
            this.rbSplit.AutoSize = true;
            this.rbSplit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbSplit.Location = new System.Drawing.Point(200, 96);
            this.rbSplit.Text = "Split Pay";
            this.rbSplit.CheckedChanged += new System.EventHandler(this.PaymentMethodChanged);
            // 
            this.rbStoreCredit.AutoSize = true;
            this.rbStoreCredit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbStoreCredit.Location = new System.Drawing.Point(300, 96);
            this.rbStoreCredit.Text = "Store Credit";
            this.rbStoreCredit.CheckedChanged += new System.EventHandler(this.PaymentMethodChanged);
            // 
            // pnlCardDetails
            // 
            this.pnlCardDetails.Controls.Add(this.lblCardExample);
            this.pnlCardDetails.Controls.Add(this.txtCardName);
            this.pnlCardDetails.Controls.Add(this.lblCardName);
            this.pnlCardDetails.Controls.Add(this.txtCardCvv);
            this.pnlCardDetails.Controls.Add(this.lblCardCvv);
            this.pnlCardDetails.Controls.Add(this.txtCardExpiry);
            this.pnlCardDetails.Controls.Add(this.lblCardExpiry);
            this.pnlCardDetails.Controls.Add(this.txtCardNumber);
            this.pnlCardDetails.Controls.Add(this.lblCardNumber);
            this.pnlCardDetails.Location = new System.Drawing.Point(15, 124);
            this.pnlCardDetails.Name = "pnlCardDetails";
            this.pnlCardDetails.Size = new System.Drawing.Size(455, 136);
            this.pnlCardDetails.Visible = false;
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCardNumber.Location = new System.Drawing.Point(0, 4);
            this.lblCardNumber.Text = "Card Number";
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCardNumber.Location = new System.Drawing.Point(0, 22);
            this.txtCardNumber.MaxLength = 19;
            this.txtCardNumber.Size = new System.Drawing.Size(280, 25);
            // 
            this.lblCardExpiry.AutoSize = true;
            this.lblCardExpiry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCardExpiry.Location = new System.Drawing.Point(290, 4);
            this.lblCardExpiry.Text = "Expiry (MM/YY)";
            // 
            this.txtCardExpiry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCardExpiry.Location = new System.Drawing.Point(290, 22);
            this.txtCardExpiry.MaxLength = 7;
            this.txtCardExpiry.Size = new System.Drawing.Size(80, 25);
            // 
            this.lblCardCvv.AutoSize = true;
            this.lblCardCvv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCardCvv.Location = new System.Drawing.Point(378, 4);
            this.lblCardCvv.Text = "CVV";
            // 
            this.txtCardCvv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCardCvv.Location = new System.Drawing.Point(378, 22);
            this.txtCardCvv.MaxLength = 4;
            this.txtCardCvv.Size = new System.Drawing.Size(70, 25);
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCardName.Location = new System.Drawing.Point(0, 54);
            this.lblCardName.Text = "Name on Card";
            // 
            this.txtCardName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCardName.Location = new System.Drawing.Point(0, 72);
            this.txtCardName.Size = new System.Drawing.Size(448, 25);
            // 
            this.lblCardExample.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCardExample.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblCardExample.Location = new System.Drawing.Point(0, 100);
            this.lblCardExample.Size = new System.Drawing.Size(448, 32);
            this.lblCardExample.Text = "Example (Visa): 4111 1111 1111 1111 · 12/28 · CVV 123 · Jane Doe";
            // 
            // pnlTotals
            // 
            this.pnlTotals.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlTotals.Controls.Add(this.lblTotalCaption);
            this.pnlTotals.Controls.Add(this.lblTotal);
            this.pnlTotals.Controls.Add(this.lblTaxCaption);
            this.pnlTotals.Controls.Add(this.lblTax);
            this.pnlTotals.Controls.Add(this.lblDiscountCaption);
            this.pnlTotals.Controls.Add(this.lblDiscount);
            this.pnlTotals.Controls.Add(this.lblSubtotalCaption);
            this.pnlTotals.Controls.Add(this.lblSubtotal);
            this.pnlTotals.Location = new System.Drawing.Point(15, 266);
            this.pnlTotals.Size = new System.Drawing.Size(455, 130);
            // 
            this.lblSubtotalCaption.AutoSize = true;
            this.lblSubtotalCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtotalCaption.Location = new System.Drawing.Point(15, 10);
            this.lblSubtotalCaption.Text = "Subtotal";
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtotal.Location = new System.Drawing.Point(345, 10);
            this.lblSubtotal.Size = new System.Drawing.Size(95, 18);
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSubtotal.Text = "$0.00";
            // 
            this.lblDiscountCaption.AutoSize = true;
            this.lblDiscountCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiscountCaption.Location = new System.Drawing.Point(15, 35);
            this.lblDiscountCaption.Text = "Discount";
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiscount.Location = new System.Drawing.Point(345, 35);
            this.lblDiscount.Size = new System.Drawing.Size(95, 18);
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiscount.Text = "$0.00";
            // 
            this.lblTaxCaption.AutoSize = true;
            this.lblTaxCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTaxCaption.Location = new System.Drawing.Point(15, 60);
            this.lblTaxCaption.Text = "Tax";
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTax.Location = new System.Drawing.Point(345, 60);
            this.lblTax.Size = new System.Drawing.Size(95, 18);
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTax.Text = "$0.00";
            // 
            this.lblTotalCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCaption.Location = new System.Drawing.Point(13, 95);
            this.lblTotalCaption.Size = new System.Drawing.Size(120, 24);
            this.lblTotalCaption.Text = "GRAND TOTAL";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblTotal.Location = new System.Drawing.Point(310, 90);
            this.lblTotal.Size = new System.Drawing.Size(130, 28);
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Text = "$0.00";
            // 
            this.lblReceiptCaption.AutoSize = true;
            this.lblReceiptCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReceiptCaption.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblReceiptCaption.Location = new System.Drawing.Point(15, 404);
            this.lblReceiptCaption.Text = "Receipt Preview";
            // 
            this.txtReceipt.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceipt.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtReceipt.Location = new System.Drawing.Point(15, 428);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.ReadOnly = true;
            this.txtReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceipt.Size = new System.Drawing.Size(455, 118);
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnConfirm);
            this.pnlActions.Controls.Add(this.btnPrint);
            this.pnlActions.Controls.Add(this.btnCancel);
            this.pnlActions.Location = new System.Drawing.Point(15, 554);
            this.pnlActions.Size = new System.Drawing.Size(455, 100);
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(254, 226, 226);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27);
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Size = new System.Drawing.Size(145, 40);
            this.btnCancel.Text = "Cancel Transaction";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.Location = new System.Drawing.Point(155, 0);
            this.btnPrint.Size = new System.Drawing.Size(145, 40);
            this.btnPrint.Text = "Save / Print Receipt";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(0, 50);
            this.btnConfirm.Size = new System.Drawing.Size(455, 45);
            this.btnConfirm.Text = "Confirm Sale";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // CheckoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "CheckoutControl";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.CheckoutControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlTotals.ResumeLayout(false);
            this.pnlTotals.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblCustomerCaption;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblPaymentCaption;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbSplit;
        private System.Windows.Forms.RadioButton rbStoreCredit;
        private System.Windows.Forms.Panel pnlCardDetails;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardExpiry;
        private System.Windows.Forms.TextBox txtCardExpiry;
        private System.Windows.Forms.Label lblCardCvv;
        private System.Windows.Forms.TextBox txtCardCvv;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.Label lblCardExample;
        private System.Windows.Forms.Panel pnlTotals;
        private System.Windows.Forms.Label lblSubtotalCaption;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscountCaption;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTaxCaption;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblReceiptCaption;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnConfirm;
    }
}
