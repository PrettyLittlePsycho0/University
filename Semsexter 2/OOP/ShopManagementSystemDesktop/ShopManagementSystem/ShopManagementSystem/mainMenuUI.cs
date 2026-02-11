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
using ShopManagementSystem.Order.OrderUI;

namespace ShopManagementSystem
{
    public partial class mainMenuUI : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalControlHeight;
        public mainMenuUI()
        {
            InitializeComponent();
            _originalFontSize = this.Font.Size;
            _originalControlHeight = Height;
            foreach (Control control in buttonsPanel.Controls)
            {
                if (control is Button btn)
                {
                    OtherUtils.ApplyHoverEffect(btn);
                    btn.Cursor = Cursors.Hand;
                }
            }
        }

        private void customerMenuButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<Customer.CustomerUI>();
            }
        }

        private void mainMenuUI_Resize(object sender, EventArgs e)
        {
            if (Parent?.TopLevelControl is Form mainForm)
            {
                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    return;
                }
                float scaleFactor = (float)Height * 1.5f / _originalControlHeight;
                float newSize = _originalFontSize * scaleFactor;
                titleLabel.Font = new Font(titleLabel.Font.FontFamily, newSize, titleLabel.Font.Style);
                buttonsPanel.Font = new Font(buttonsPanel.Font.FontFamily, newSize * 0.75f, buttonsPanel.Font.Style);
            }
        }

        private void productMenuButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<Product.ProductUI>();
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<OrderUI>();
            }
        }

        private void viewHistoryButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<Order.HistoryUI.HistoryUI>();

            }
        }
    }
}
