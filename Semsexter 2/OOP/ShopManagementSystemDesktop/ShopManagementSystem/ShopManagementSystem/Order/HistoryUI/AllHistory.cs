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

namespace ShopManagementSystem.Order.HistoryUI
{
    public partial class AllHistory : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalControlHeight;

        private OrderService service;
        public AllHistory()
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

        private void AllHistory_Resize(object sender, EventArgs e)
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

        private void loadButton_Click(object sender, EventArgs e)
        {
            statusLabel.ForeColor = Color.Black;
            statusLabel.Text = "Loading...";
            statusLabel.Update();
            List<OrderModel> orders = new List<OrderModel>();
            orders = service.GetAll();
            foreach(var order in orders)
            {
                order.CalculateTotal();
            }
            historyGrid.DataSource = orders;
            historyGrid.Columns["id"].HeaderText = "Order ID";
            historyGrid.Columns["dateTime"].HeaderText = "Time Stamp";
            historyGrid.Columns["customerId"].HeaderText = "Customer ID";
            historyGrid.Columns["customerName"].HeaderText = "Customer Name";
            historyGrid.Columns["totalPrice"].HeaderText = "Total Price($)";
            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = $"Loaded {orders.Count} orders.";
        }
    }
}
