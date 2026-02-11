using ShopManagementSystem.Common;
using ShopManagementSystem.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.Customer.UI
{
    public partial class DeleteCustomer : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;

        private CustomerService service;
        public DeleteCustomer()
        {
            InitializeComponent();
            _originalFontSize = Font.Size;
            _originalHeight = Height;
            service = new CustomerService(new CustomerRepositoryDB());
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

        private void DeleteCustomer_Resize(object sender, EventArgs e)
        {
            if (Parent?.TopLevelControl is Form mainForm)
            {
                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    return;
                }
                float scaleFactor = (float)Height * 1.5f / _originalHeight;
                float newSize = _originalFontSize * scaleFactor;
                deleteCustomerTitleLabel.Font = new Font(deleteCustomerTitleLabel.Font.FontFamily, newSize, deleteCustomerTitleLabel.Font.Style);
                buttonsPanel.Font = new Font(buttonsPanel.Font.FontFamily, newSize * 0.75f, buttonsPanel.Font.Style);
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
                    statusLabel.Text = "Customer found.";
                    CustomerModel customer = service.GetCustomerById(int.Parse(idTextBox.Text));
                    nameTextBox.Text = customer.name;
                    numberTextBox.Text = customer.phoneNumber;
                    ageTextBox.Text = customer.age.ToString();
                    addressTextBox.Text = customer.address;
                    deleteButton.Visible = true;
                }
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Customer not found.";
                    deleteButton.Visible = false;
                    nameTextBox.Text = String.Empty;
                    numberTextBox.Text = String.Empty;
                    ageTextBox.Text = String.Empty;
                    addressTextBox.Text = String.Empty;
                }
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<CustomerUI>();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (service.Delete(int.Parse(idTextBox.Text)))
            {
                if (Parent is Panel panel)
                {
                    panel.ShowView<CustomerUI>();
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
