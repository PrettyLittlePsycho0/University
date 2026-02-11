using ShopManagementSystem.Common;
using ShopManagementSystem.Customer;
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

namespace ShopManagementSystem.Order.OrderUI
{
    public partial class OrderUI : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalControlHeight;
        private CustomerService customerService;
        private ProductService productService;
        private OrderService service;

        private List<OrderItem> orderItems;
        public OrderUI()
        {
            InitializeComponent();
            customerService = new CustomerService(new CustomerRepositoryDB());
            productService = new ProductService(new ProductRepositoryDB());
            service = new OrderService(new OrderRepositoryDB());
            orderItems = new List<OrderItem>();
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
            placeButton.Visible = false;
        }

        private void OrderUI_Resize(object sender, EventArgs e)
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (customerIdTextBox.Text != string.Empty && productIdTextBox.Text != string.Empty && quantityTextBox.Text != string.Empty)
            {
                int customerId = int.Parse(customerIdTextBox.Text);
                int productId = int.Parse(productIdTextBox.Text);
                int quantity = int.Parse(quantityTextBox.Text);
                statusLabel.ForeColor = Color.Black;
                statusLabel.Text = "Searching...";
                statusLabel.Update();
                if (customerService.Exists(customerId))
                {
                    customerIdTextBox.ReadOnly = true;
                    if (productService.Exists(productId))
                    {
                        ProductModel product = productService.GetProductById(productId);
                        orderItems.Add(new OrderItem(product, quantity));
                        itemsTextBox.AppendText($"Added: {product.name} x {quantity}\r\n");
                        statusLabel.ForeColor = Color.Green;
                        statusLabel.Text = "Item added to order.";
                        placeButton.Visible = true;
                    }
                    else
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "Product does not exist.";
                    }
                }
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Customer does not exist.";
                }
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Please fill in all fields.";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (Parent is Panel panel)
            {
                panel.ShowView<mainMenuUI>();
            }
        }

        private void placeButton_Click(object sender, EventArgs e)
        {
            if (service.Create(new OrderModel(customerService.GetCustomerById(int.Parse(customerIdTextBox.Text)), orderItems)))
            {
                if (Parent is Panel panel)
                {
                    panel.ShowView<mainMenuUI>();
                }
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Failed to place order.";
            }
        }
    }
}
