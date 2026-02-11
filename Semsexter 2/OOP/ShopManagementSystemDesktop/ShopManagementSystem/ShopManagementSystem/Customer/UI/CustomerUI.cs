using ShopManagementSystem.Common;
using ShopManagementSystem.Customer.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.Customer
{
    public partial class CustomerUI : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;
        private CustomerService service;
        public CustomerUI()
        {
            InitializeComponent();
            service = new CustomerService(new CustomerRepositoryDB());
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
                panel.ShowView<mainMenuUI>();
            }
        }

        private void CustomerUI_Resize(object sender, EventArgs e)
        {
            if (Parent?.TopLevelControl is Form mainForm)
            {
                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    return;
                }
                float scaleFactor = (float)Height * 1.5f / _originalHeight;
                float newSize = _originalFontSize * scaleFactor;
                customerTitleLabel.Font = new Font(customerTitleLabel.Font.FontFamily, newSize, customerTitleLabel.Font.Style);
                buttonsPanel.Font = new Font(buttonsPanel.Font.FontFamily, newSize * 0.75f, buttonsPanel.Font.Style);
            }
        }

        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<CreateCustomer>();
            }
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<UpdateCustomer>();
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<DeleteCustomer>();
            }
        }

        private void viewAllCustomersButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<ViewAllCustomers>();
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
