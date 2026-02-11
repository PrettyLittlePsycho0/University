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
using ShopManagementSystem.Order;

namespace ShopManagementSystem.Order.HistoryUI
{
    public partial class CustomerHistory : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalControlHeight;
        private OrderService service;
        public CustomerHistory()
        {
            InitializeComponent();
            service = new OrderService(new OrderRepositoryDB());
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

        private void CustomerHistory_Resize(object sender, EventArgs e)
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


        private void exitButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<HistoryUI>();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string s = idTextBox.Text;
            if (s != string.Empty && s.All(char.IsDigit))
            {
                statusLabel.ForeColor = Color.Black;
                statusLabel.Text = "Loading...";
                statusLabel.Update();
                List<OrderModel> orders = new List<OrderModel>();
                orders = service.GetOrdersByCustomerId(int.Parse(s));
                foreach(OrderModel order in orders)
                {
                    order.CalculateTotal();
                }
                resultsDataGrid.DataSource = orders;
                resultsDataGrid.Columns["id"].HeaderText = "Order ID";
                resultsDataGrid.Columns["dateTime"].HeaderText = "Time Stamp";
                resultsDataGrid.Columns["customerId"].HeaderText = "Customer ID";
                resultsDataGrid.Columns["customerName"].HeaderText = "Customer Name";
                resultsDataGrid.Columns["totalPrice"].HeaderText = "Total Price($)";
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = $"Found {orders.Count} orders.";
            }
        }
    }
}
