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
    public partial class AdvanceSearch : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;
        private CustomerService service;
        public AdvanceSearch()
        {
            InitializeComponent();
            service = new CustomerService(new CustomerRepositoryDB());
            searchButton.Visible = false;
            modesComboBox.Items.Add("By Name");
            modesComboBox.Items.Add("By First Char");
            modesComboBox.Items.Add("By Phone Number");
            modesComboBox.Items.Add("By Address");
            modesComboBox.Items.Add("By Age");
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

        private void AdvanceSearch_Resize(object sender, EventArgs e)
        {
            if (Parent?.TopLevelControl is Form mainForm)
            {
                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    return;
                }
                float scaleFactor = (float)Height * 1.5f / _originalHeight;
                float newSize = _originalFontSize * scaleFactor;
                advanceSearchTitleLabel.Font = new Font(advanceSearchTitleLabel.Font.FontFamily, newSize, advanceSearchTitleLabel.Font.Style);
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

        private void modesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox.Text = String.Empty;
            resultsDataGrid.DataSource = null;
            statusLabel.Text = String.Empty;
            if (modesComboBox.SelectedItem?.ToString() == "By Name")
            {
                Label.Text = "Name:";
                searchButton.Visible = true;
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By First Char")
            {
                Label.Text = "First Char:";
                searchButton.Visible = true;
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By Phone Number")
            {
                Label.Text = "Number:";
                searchButton.Visible = true;
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By Address")
            {
                Label.Text = "Address:";
                searchButton.Visible = true;
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By Age")
            {
                Label.Text = "Age:";
                searchButton.Visible = true;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (modesComboBox.SelectedItem?.ToString() == "By Name")
            {
                if (textBox.Text != String.Empty)
                {
                    statusLabel.ForeColor = Color.Black;
                    statusLabel.Text = "Searching...";
                    statusLabel.Update();
                    List<CustomerModel> results = service.GetCustomerByName(textBox.Text);
                    resultsDataGrid.DataSource = results;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = $"{results.Count} customers found.";
                    if (results.Count == 0)
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "No customers found.";
                    }
                }
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By First Char")
            {
                if (textBox.Text != String.Empty)
                {
                    statusLabel.ForeColor = Color.Black;
                    statusLabel.Text = "Searching...";
                    statusLabel.Update();
                    List<CustomerModel> results = service.GetCustomerByFirstChar(textBox.Text[0].ToString());
                    resultsDataGrid.DataSource = results;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = $"{results.Count} customers found.";
                    if (results.Count == 0)
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "No customers found.";
                    }
                }
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By Phone Number")
            {
                if (textBox.Text != String.Empty)
                {
                    statusLabel.ForeColor = Color.Black;
                    statusLabel.Text = "Searching...";
                    statusLabel.Update();
                    CustomerModel result = service.GetCustomerByPhoneNumber(textBox.Text);
                    List<CustomerModel> results = new List<CustomerModel>();
                    results.Add(result);
                    resultsDataGrid.DataSource = results;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = $"{1} customers found.";
                    if (results == null)
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "No customers found.";
                    }
                }
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By Address")
            {
                if (textBox.Text != String.Empty)
                {
                    statusLabel.ForeColor = Color.Black;
                    statusLabel.Text = "Searching...";
                    statusLabel.Update();
                    List<CustomerModel> results = service.GetCustomerByAddress(textBox.Text);
                    resultsDataGrid.DataSource = results;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = $"{results.Count} customers found.";
                    if (results.Count == 0)
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "No customers found.";
                    }
                }
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By Age")
            {
                if (int.TryParse(textBox.Text, out int age))
                {
                    statusLabel.ForeColor = Color.Black;
                    statusLabel.Text = "Searching...";
                    statusLabel.Update();
                    List<CustomerModel> results = service.GetCustomerByAge(age);
                    resultsDataGrid.DataSource = results;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = $"{results.Count} customers found.";
                    if (results.Count == 0)
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "No customers found.";
                    }
                }
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Please enter a valid age.";
                }
            }
        }
    }
}
