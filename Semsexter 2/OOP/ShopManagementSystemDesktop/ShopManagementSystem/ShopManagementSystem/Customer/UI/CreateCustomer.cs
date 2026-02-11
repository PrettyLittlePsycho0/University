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
    public partial class CreateCustomer : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;
        private CustomerService service;
        public CreateCustomer()
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
            createButton.Visible = false;
        }

        private void CreateCustomer_Resize(object sender, EventArgs e)
        {
            if (Parent?.TopLevelControl is Form mainForm)
            {
                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    return;
                }
                float scaleFactor = (float)Height * 1.5f / _originalHeight;
                float newSize = _originalFontSize * scaleFactor;
                createCustomerTitleLabel.Font = new Font(createCustomerTitleLabel.Font.FontFamily, newSize, createCustomerTitleLabel.Font.Style);
                buttonsPanel.Font = new Font(buttonsPanel.Font.FontFamily, newSize * 0.75f, buttonsPanel.Font.Style);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<CustomerUI>();
            }
        }
        private void createButtonVisibilityStatus()
        {
            if (string.IsNullOrEmpty(customerNameErrorLabel.Text) && string.IsNullOrEmpty(numberErrorLabel.Text) && string.IsNullOrEmpty(ageErrorLabel.Text) && string.IsNullOrEmpty(addressErrorLabel.Text)
                && !string.IsNullOrEmpty(customerNameTextBox.Text) && !string.IsNullOrEmpty(numberTextBox.Text) && !string.IsNullOrEmpty(ageTextBox.Text) && !string.IsNullOrEmpty(addressTextBox.Text))
            {
                createButton.Visible = true;
            }
            else
            {
                createButton.Visible = false;
            }
        }

        private void customerNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string s = customerNameTextBox.Text;
            if (!string.IsNullOrEmpty(s) && char.IsDigit(s[0]))
            {
                customerNameErrorLabel.Text = "Can't start with a number.";
            }
            else if (s.Length > 50)
            {
                customerNameErrorLabel.Text = "Name is too long.";
            }
            else
            {
                customerNameErrorLabel.Text = "";
            }
            createButtonVisibilityStatus();
        }

        private void numberTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string s = numberTextBox.Text;
            if (s.Length != 11 || !s.All(char.IsDigit))
            {
                numberErrorLabel.Text = "Invalid phone number.";
            }
            else
            {
                numberErrorLabel.Text = "";
            }
            createButtonVisibilityStatus();

        }

        private void ageTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string s = ageTextBox.Text;
            if (int.TryParse(s, out int age))
            {
                if (age < 0 || age > 120)
                {
                    ageErrorLabel.Text = "Age must be between 0 and 120.";
                }
                else
                {
                    ageErrorLabel.Text = "";
                }
            }
            else
            {
                ageErrorLabel.Text = "Invalid age format.";
            }
        }

        private void addressTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string s = addressTextBox.Text;
            if (s.Length > 100)
            {
                addressErrorLabel.Text = "Address is too long.";
            }
            else
            {
                addressErrorLabel.Text = "";
            }
            createButtonVisibilityStatus();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (service.Create(new CustomerModel(customerNameTextBox.Text, numberTextBox.Text, int.Parse(ageTextBox.Text), addressTextBox.Text)))
            {
                if (Parent is Panel panel)
                {
                    panel.ShowView<CustomerUI>();
                }
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Database Error.";
            }
        }
    }
}
