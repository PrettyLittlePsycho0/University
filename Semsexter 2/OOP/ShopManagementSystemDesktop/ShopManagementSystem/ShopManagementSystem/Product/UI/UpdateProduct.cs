using System;
using ShopManagementSystem.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.Product.UI
{
    public partial class UpdateProduct : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;

        private ProductService service;
        public UpdateProduct()
        {
            InitializeComponent();
            _originalFontSize = Font.Size;
            _originalHeight = Height;
            service = new ProductService(new ProductRepositoryDB());
            foreach (Control control in buttonsPanel.Controls)
            {
                if (control is Button btn)
                {
                    OtherUtils.ApplyHoverEffect(btn);
                    btn.Cursor = Cursors.Hand;
                }
            }
        }

        private void UpdateProduct_Resize(object sender, EventArgs e)
        {
            if (Parent?.TopLevelControl is Form mainForm)
            {
                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    return;
                }
                float scaleFactor = (float)Height * 1.5f / _originalHeight;
                float newSize = _originalFontSize * scaleFactor;
                updateProductTitleLabel.Font = new Font(updateProductTitleLabel.Font.FontFamily, newSize, updateProductTitleLabel.Font.Style);
                buttonsPanel.Font = new Font(buttonsPanel.Font.FontFamily, newSize * 0.75f, buttonsPanel.Font.Style);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<ProductUI>();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string price = priceTextBox.Text;
            string discount = discountTextBox.Text;
            bool nameValid = !char.IsDigit(name[0]) && name.Length < 50 && name != String.Empty;
            bool priceValid = float.TryParse(price, out float p) && p >= 0;
            bool discountValid = float.TryParse(discount, out float d) && d >= 0 && d <= 100;
            if (nameValid && priceValid && discountValid)
            {
                if (service.Update(new ProductModel(int.Parse(idTextBox.Text), nameTextBox.Text, double.Parse(priceTextBox.Text), double.Parse(discountTextBox.Text))))
                {
                    if (Parent is Panel panel)
                    {
                        panel.ShowView<ProductUI>();
                    }
                }
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Database Error.";
                }
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Invalid input data.";
            }
            
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (idErrorLabel.Text == String.Empty)
            {
                statusLabel.ForeColor = Color.Black;
                statusLabel.Text = "Searching...";
                statusLabel.Update();
                bool found = service.Exists(int.Parse(idTextBox.Text));
                if (found)
                {
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = "Product found.";
                    ProductModel product = service.GetProductById(int.Parse(idTextBox.Text));
                    nameTextBox.Text = product.name;
                    priceTextBox.Text = product.purchasePrice.ToString();
                    discountTextBox.Text = product.discount.ToString();
                    updateButton.Visible = true;
                }
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Product not found.";
                    updateButton.Visible = false;
                    nameTextBox.Text = String.Empty;
                    priceTextBox.Text = String.Empty;
                    discountTextBox.Text = String.Empty;
                }
            }
        }

        private void idTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(idTextBox.Text, out int id) && id > 0)
            {
                idErrorLabel.Text = String.Empty;
            }
            else
            {
                idErrorLabel.Text = "Invalid ID.";
            }
        }
    }
}
