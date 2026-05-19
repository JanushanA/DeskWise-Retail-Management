using System;

using System.IO;

using System.Linq;

using System.Windows.Forms;

using DeskWise.Models;

using DeskWise.Services;



namespace DeskWise.Forms

{

    // Modal dialog for adding or editing a product.

    // - In "add" mode, leave _existing null and the form will produce a brand new product on Save.

    // - In "edit" mode, pass the existing product and the form pre-fills its fields.

    // All validation runs through ValidationService so the same rules apply across the app.

    public partial class ProductEditForm : Form

    {

        private readonly Product _existing;

        public Product Result { get; private set; }

        public bool Deleted { get; private set; }



        // Default constructor opens the form in add mode.

        public ProductEditForm() : this(null) { }



        // Opens in add or edit mode; edit mode shows the delete button and pre-fills fields.

        public ProductEditForm(Product existing)

        {

            InitializeComponent();

            _existing = existing;

            PopulateDropdowns();

            if (_existing != null)

            {

                LoadProductIntoFields(_existing);

                this.Text = "Edit Product";

                btnDelete.Visible = true;

            }

            else

            {

                this.Text = "Add Product";

                btnDelete.Visible = false;

                numCostPrice.Value = 0;

                numSalePrice.Value = 0;

                numQuantity.Value = 0;

                numReorder.Value = 5;

            }

        }



        // Fill category and supplier dropdowns from live data plus common defaults.

        private void PopulateDropdowns()

        {

            // Category dropdown: existing categories + a few common defaults.

            cmbCategory.Items.Clear();

            string[] defaults = new[] { "Cables", "Widgets", "Lighting", "Accessories", "Stationery", "General" };

            foreach (string cat in ProductService.GetCategories())

            {

                if (!cmbCategory.Items.Contains(cat)) cmbCategory.Items.Add(cat);

            }

            foreach (string cat in defaults)

            {

                if (!cmbCategory.Items.Contains(cat)) cmbCategory.Items.Add(cat);

            }



            // Supplier dropdown - DisplayMember/ValueMember pair so we can pull the id easily.

            cmbSupplier.DataSource = SupplierService.All.ToList();

            cmbSupplier.DisplayMember = "Name";

            cmbSupplier.ValueMember = "Id";

        }



        // Copy an existing product's values into the form controls.

        private void LoadProductIntoFields(Product product)

        {

            txtName.Text = product.Name;

            txtSku.Text = product.SKU;

            txtBarcode.Text = product.Barcode;

            cmbCategory.Text = product.Category;

            if (product.SupplierId > 0) cmbSupplier.SelectedValue = product.SupplierId;

            numCostPrice.Value = ClampDecimal(product.CostPrice, numCostPrice.Minimum, numCostPrice.Maximum);

            numSalePrice.Value = ClampDecimal(product.SalePrice, numSalePrice.Minimum, numSalePrice.Maximum);

            numQuantity.Value  = ClampInt(product.Quantity, (int)numQuantity.Minimum, (int)numQuantity.Maximum);

            numReorder.Value   = ClampInt(product.ReorderLevel, (int)numReorder.Minimum, (int)numReorder.Maximum);

            txtDescription.Text = product.Description;

            txtImagePath.Text = product.ImagePath;

            TryLoadImage(product.ImagePath);

        }



        // Keep a decimal within the numeric up-down control's allowed range.

        private static decimal ClampDecimal(decimal value, decimal min, decimal max)

        {

            if (value < min) return min;

            if (value > max) return max;

            return value;

        }



        // Keep an integer within the numeric up-down control's allowed range.

        private static int ClampInt(int value, int min, int max)

        {

            if (value < min) return min;

            if (value > max) return max;

            return value;

        }



        // Open a file picker for the product image and refresh the preview.

        private void btnBrowse_Click(object sender, EventArgs e)

        {

            using (OpenFileDialog fileDialog = new OpenFileDialog())

            {

                fileDialog.Filter = "Image files|*.png;*.jpg;*.jpeg;*.bmp;*.gif|All files|*.*";

                if (fileDialog.ShowDialog() == DialogResult.OK)

                {

                    txtImagePath.Text = fileDialog.FileName;

                    TryLoadImage(fileDialog.FileName);

                }

            }

        }



        // Load the preview image when the path is valid; clear preview on failure.

        private void TryLoadImage(string path)

        {

            try

            {

                if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))

                {

                    picPreview.Image = System.Drawing.Image.FromFile(path);

                }

                else

                {

                    picPreview.Image = null;

                }

            }

            catch

            {

                picPreview.Image = null;

            }

        }



        // Validate inputs, persist the product, and return it via Result.

        private void btnSave_Click(object sender, EventArgs e)

        {

            if (!ValidateInputs()) return;



            // ---- Save ----

            bool isNew = (_existing == null);

            Product target = isNew ? new Product() : _existing;



            target.Name = txtName.Text.Trim();

            target.SKU = string.IsNullOrWhiteSpace(txtSku.Text) ? "SKU-" + (isNew ? ProductService.NextId() : target.Id) : txtSku.Text.Trim();

            target.Barcode = txtBarcode.Text.Trim();

            target.Category = string.IsNullOrWhiteSpace(cmbCategory.Text) ? "General" : cmbCategory.Text.Trim();

            target.SupplierId = cmbSupplier.SelectedValue is int sid ? sid : 0;

            target.CostPrice = numCostPrice.Value;

            target.SalePrice = numSalePrice.Value;

            target.Quantity = (int)numQuantity.Value;

            target.ReorderLevel = (int)numReorder.Value;

            target.Description = txtDescription.Text.Trim();

            target.ImagePath = txtImagePath.Text.Trim();



            if (isNew)

            {

                target.Id = ProductService.NextId();

                ProductService.Add(target);

            }

            else

            {

                ProductService.Update(target);

            }



            Result = target;

            this.DialogResult = DialogResult.OK;

            this.Close();

        }



        // Run all field-level validation rules before save.

        private bool ValidateInputs()

        {

            if (!ValidationService.IsValidName(txtName.Text))

            {

                MessageBox.Show("Product name must contain at least one letter or number.", "Invalid Name",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtName.Focus();

                return false;

            }

            if (numSalePrice.Value <= 0)

            {

                MessageBox.Show("Sale price must be greater than zero.", "Invalid Price",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                numSalePrice.Focus();

                return false;

            }

            if (numCostPrice.Value < 0)

            {

                MessageBox.Show("Cost price cannot be negative.", "Invalid Cost",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                numCostPrice.Focus();

                return false;

            }

            if (numQuantity.Value < 0)

            {

                MessageBox.Show("Quantity cannot be negative.", "Invalid Quantity",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                numQuantity.Focus();

                return false;

            }

            int ignoreId = _existing != null ? _existing.Id : -1;

            if (!string.IsNullOrWhiteSpace(txtSku.Text) && ProductService.IsSkuTaken(txtSku.Text.Trim(), ignoreId))

            {

                MessageBox.Show("That SKU is already used by another product.", "Duplicate SKU",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtSku.Focus();

                return false;

            }

            return true;

        }



        // Confirm and delete the product being edited (edit mode only).

        private void btnDelete_Click(object sender, EventArgs e)

        {

            if (_existing == null) return;

            DialogResult confirm = MessageBox.Show("Delete " + _existing.Name + "?", "Confirm Delete",

                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;



            ProductService.Delete(_existing.Id);

            Deleted = true;

            this.DialogResult = DialogResult.OK;

            this.Close();

        }



        // Close without saving changes.

        private void btnCancel_Click(object sender, EventArgs e)

        {

            this.DialogResult = DialogResult.Cancel;

            this.Close();

        }

    }

}


