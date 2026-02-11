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
    public partial class ViewAllCustomers : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;
        private CustomerService service;
        public ViewAllCustomers()
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

        private void ViewAllCustomers_Resize(object sender, EventArgs e)
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
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<CustomerUI>();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            statusLabel.ForeColor = Color.Black;
            statusLabel.Text = "Loading customers...";
            statusLabel.Update();
            customersGrid.DataSource = service.GetAll();
            customersGrid.Columns["name"].HeaderText = "Customer Name";
            customersGrid.Columns["phoneNumber"].HeaderText = "Number";
            customersGrid.Columns["age"].HeaderText = "Age";
            customersGrid.Columns["address"].HeaderText = "Address";
            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = "Customers loaded successfully.";
        }
    }
}
