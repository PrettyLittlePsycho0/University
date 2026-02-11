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
    public partial class UpdateCustomer : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;

        private CustomerService service;
        public UpdateCustomer()
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
            updateButton.Visible = false;
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

        private void UpdateCustomer_Resize(object sender, EventArgs e)
        {
            if (Parent?.TopLevelControl is Form mainForm)
            {
                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    return;
                }
                float scaleFactor = (float)Height * 1.5f / _originalHeight;
                float newSize = _originalFontSize * scaleFactor;
                updateCustomerTitleLabel.Font = new Font(updateCustomerTitleLabel.Font.FontFamily, newSize, updateCustomerTitleLabel.Font.Style);
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
                    updateButton.Visible = true;
                }
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Customer not found.";
                    updateButton.Visible = false;
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string number = numberTextBox.Text;
            string age = ageTextBox.Text;
            bool nameValid = !char.IsDigit(name[0]) && name.Length < 50 && name != String.Empty;
            bool addressValid = address.Length < 100 && address != String.Empty;
            bool numberValid = OtherUtils.IsAllDigits(number) && number.Length == 11;
            bool ageValid = int.TryParse(age, out int ageValue) && ageValue > 0;
            if (nameValid && addressValid && numberValid && ageValid)
            {
                if (service.Update(new CustomerModel(int.Parse(idTextBox.Text), name, number, ageValue, address)))
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
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Invalid Input.";
            }
        }
    }
}
