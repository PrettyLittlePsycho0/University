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
    public partial class ViewAllProducts : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;
        private ProductService service;
        public ViewAllProducts()
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
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<ProductUI>();
            }
        }

        private void ViewAllProducts_Resize(object sender, EventArgs e)
        {
            if (Parent?.TopLevelControl is Form mainForm)
            {
                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    return;
                }
                float scaleFactor = (float)Height * 1.5f / _originalHeight;
                float newSize = _originalFontSize * scaleFactor;
                viewTitleLabel.Font = new Font(viewTitleLabel.Font.FontFamily, newSize, viewTitleLabel.Font.Style);
                buttonsPanel.Font = new Font(buttonsPanel.Font.FontFamily, newSize * 0.75f, buttonsPanel.Font.Style);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            statusLabel.ForeColor = Color.Black;
            statusLabel.Text = "Loading products...";
            statusLabel.Update();
            productsGrid.DataSource = service.GetAll();
            productsGrid.Columns["name"].HeaderText = "Product Name";
            productsGrid.Columns["purchasePrice"].HeaderText = "Purchase Price";
            productsGrid.Columns["discount"].HeaderText = "Discount (%)";
            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = "Products loaded successfully.";
        }
    }
}
