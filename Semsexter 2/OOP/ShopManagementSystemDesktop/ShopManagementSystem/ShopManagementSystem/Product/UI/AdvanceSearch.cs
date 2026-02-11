using System;
using ShopManagementSystem.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem.Product.UI
{
    public partial class AdvanceSearch : UserControl
    {
        private readonly float _originalFontSize;
        private readonly int _originalHeight;
        private ProductService service;
        public AdvanceSearch()
        {
            InitializeComponent();
            service = new ProductService(new ProductRepositoryDB());
            searchButton.Visible = false;
            modesComboBox.Items.Add("By Name");
            modesComboBox.Items.Add("By Price");
            modesComboBox.Items.Add("By Price Difference");
            modesComboBox.Items.Add("By Substring");
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
                panel.ShowView<ProductUI>();
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
            else if (modesComboBox.SelectedItem?.ToString() == "By Price")
            {
                Label.Text = "Price:";
                searchButton.Visible = true;
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By Price Difference")
            {
                Label.Text = "Price Difference:";
                searchButton.Visible = true;
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By Substring")
            {
                Label.Text = "Substring:";
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
                    List<ProductModel> results = service.GetProductByName(textBox.Text);
                    resultsDataGrid.DataSource = results;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = $"{results.Count} products found.";
                    if (results.Count == 0)
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "No products found.";
                    }
                }
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By Price")
            {
                if (double.TryParse(textBox.Text, out double price))
                {
                    statusLabel.ForeColor = Color.Black;
                    statusLabel.Text = "Searching...";
                    statusLabel.Update();
                    List<ProductModel> results = service.GetProductsByPrice(price);
                    resultsDataGrid.DataSource = results;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = $"{results.Count} products found.";
                    if (results.Count == 0)
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "No products found.";
                    }
                }
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By Price Difference")
            {
                if (double.TryParse(textBox.Text, out double priceDiff))
                {
                    statusLabel.ForeColor = Color.Black;
                    statusLabel.Text = "Searching...";
                    statusLabel.Update();
                    List<ProductModel> results = service.GetProductsByPriceDifference(priceDiff);
                    resultsDataGrid.DataSource = results;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = $"{results.Count} products found.";
                    if (results.Count == 0)
                    {
                        statusLabel.ForeColor = Color.Black;
                        statusLabel.Text = "No products found.";
                    }
                }
            }
            else if (modesComboBox.SelectedItem?.ToString() == "By Substring")
            {
                if (textBox.Text != String.Empty)
                {
                    statusLabel.ForeColor = Color.Black;
                    statusLabel.Text = "Searching...";
                    statusLabel.Update();
                    List<ProductModel> results = service.GetProductsBySubString(textBox.Text);
                    resultsDataGrid.DataSource = results;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = $"{results.Count} products found.";
                    if (results.Count == 0)
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "No products found.";
                    }
                }
            }
        }
    }
}
