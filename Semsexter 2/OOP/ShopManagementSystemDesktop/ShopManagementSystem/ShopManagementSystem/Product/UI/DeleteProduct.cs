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
    public partial class DeleteProduct : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;

        private ProductService service;
        public DeleteProduct()
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
            deleteButton.Visible = false;
        }

        private void DeleteProduct_Resize(object sender, EventArgs e)
        {
            if (Parent?.TopLevelControl is Form mainForm)
            {
                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    return;
                }
                float scaleFactor = (float)Height * 1.5f / _originalHeight;
                float newSize = _originalFontSize * scaleFactor;
                deleteProductTitleLabel.Font = new Font(deleteProductTitleLabel.Font.FontFamily, newSize, deleteProductTitleLabel.Font.Style);
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
                    deleteButton.Visible = true;
                }
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Product not found.";
                    deleteButton.Visible = false;
                    nameTextBox.Text = String.Empty;
                    priceTextBox.Text = String.Empty;
                    discountTextBox.Text = String.Empty;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (service.Delete(int.Parse(idTextBox.Text)))
            {
                if (Parent is Panel panel)
                {
                    panel.ShowView<ProductUI>();
                }
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Deletion failed.";
            }
        }
    }
}
