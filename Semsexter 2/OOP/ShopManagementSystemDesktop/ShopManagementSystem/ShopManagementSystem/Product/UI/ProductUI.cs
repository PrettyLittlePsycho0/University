using ShopManagementSystem.Common;
using ShopManagementSystem.Product.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.Product
{

    public partial class ProductUI : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;
        public ProductUI()
        {
            InitializeComponent();
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


        private void ProductUI_Resize(object sender, EventArgs e)
        {
            if (Parent?.TopLevelControl is Form mainForm)
            {
                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    return;
                }
                float scaleFactor = (float)Height * 1.5f / _originalHeight;
                float newSize = _originalFontSize * scaleFactor;
                productTitleLabel.Font = new Font(productTitleLabel.Font.FontFamily, newSize, productTitleLabel.Font.Style);
                buttonsPanel.Font = new Font(buttonsPanel.Font.FontFamily, newSize * 0.75f, buttonsPanel.Font.Style);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<mainMenuUI>();
            }
        }

        private void createProductButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<CreateProduct>();
            }
        }

        private void viewAllProductsButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<ViewAllProducts>();
            }
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<UpdateProduct>();
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<DeleteProduct>();
            }
        }

        private void advanceSearchButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<AdvanceSearch>();
            }
        }
    }
}
