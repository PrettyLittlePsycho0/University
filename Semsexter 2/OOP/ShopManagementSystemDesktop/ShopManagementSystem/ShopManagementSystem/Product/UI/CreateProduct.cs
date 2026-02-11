using ShopManagementSystem.Common;
using System;
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
    public partial class CreateProduct : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;
        private ProductService service;


        public CreateProduct()
        {
            InitializeComponent();
            service = new ProductService(new ProductRepositoryDB());
            _originalFontSize = Font.Size;
            _originalHeight = Height;
            foreach (Control control in buttonsPanel.Controls)
            {
                if (control is Button btn)
                {
                    OtherUtils.ApplyHoverEffect(btn);
                    btn.Cursor = Cursors.Hand;
                }
            }
            createButton.Visible = false;
        }

        private void CreateProduct_Resize(object sender, EventArgs e)
        {
            if (Parent?.TopLevelControl is Form mainForm)
            {
                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    return;
                }
                float scaleFactor = (float)Height * 1.5f / _originalHeight;
                float newSize = _originalFontSize * scaleFactor;
                createProductTitleLabel.Font = new Font(createProductTitleLabel.Font.FontFamily, newSize, createProductTitleLabel.Font.Style);
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

        private void productNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string s = productNameTextBox.Text;
            if (!string.IsNullOrEmpty(s) && char.IsDigit(s[0]))
            {
                productNameErrorLabel.Text = "Can't start with a number.";
            }
            else if (s.Length > 50)
            {
                productNameErrorLabel.Text = "Name is too long.";
            }
            else
            {
                productNameErrorLabel.Text = "";
            }
            createButtonVisibilityStatus();
        }

        private void createButtonVisibilityStatus()
        {
            if (string.IsNullOrEmpty(productNameErrorLabel.Text) && string.IsNullOrEmpty(purchasePriceErrorLabel.Text) && string.IsNullOrEmpty(discountErrorLabel.Text)
                && !string.IsNullOrEmpty(productNameTextBox.Text) && !string.IsNullOrEmpty(purchasePriceTextBox.Text) && !string.IsNullOrEmpty(discountTextBox.Text))
            {
                createButton.Visible = true;
            }
            else
            {
                createButton.Visible = false;
            }
        }

        private void purchasePriceTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string s = purchasePriceTextBox.Text;
            if (float.TryParse(s, out float price))
            {
                if (price < 0)
                {
                    purchasePriceErrorLabel.Text = "Price can't be negative.";
                }
                else
                {
                    purchasePriceErrorLabel.Text = "";
                }
            }
            else
            {
                purchasePriceErrorLabel.Text = "Invalid price format.";
            }
            createButtonVisibilityStatus();
        }

        private void discountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string s = discountTextBox.Text;
            if (float.TryParse(s, out float discount))
            {
                if (discount < 0 || discount > 100)
                {
                    discountErrorLabel.Text = "Discount must be between 0 and 100.";
                }
                else
                {
                    discountErrorLabel.Text = "";
                }
            }
            else
            {
                discountErrorLabel.Text = "Invalid discount format.";
            }
            createButtonVisibilityStatus();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (service.Create(new ProductModel(productNameTextBox.Text, double.Parse(purchasePriceTextBox.Text), double.Parse(discountTextBox.Text))))
            {


                if (Parent is Panel panel)
                {
                    panel.ShowView<ProductUI>();
                }
            }
            else
            {
                statusLabel.Text = "Database Error.";
            }
        }
    }
}
