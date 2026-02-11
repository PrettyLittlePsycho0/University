namespace ShopManagementSystem.Order.OrderUI
{
    partial class OrderUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            titleLabel = new Label();
            buttonsPanel = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            customerIdLabel = new Label();
            productIdLabel = new Label();
            quantityLabel = new Label();
            customerIdTextBox = new TextBox();
            productIdTextBox = new TextBox();
            quantityTextBox = new TextBox();
            addButton = new Button();
            exitButton = new Button();
            placeButton = new Button();
            itemsTextBox = new RichTextBox();
            statusLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            buttonsPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(titleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonsPanel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(600, 400);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.SaddleBrown;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Margin = new Padding(0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(600, 60);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Place Order";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 3;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            buttonsPanel.Controls.Add(tableLayoutPanel3, 1, 0);
            buttonsPanel.Controls.Add(exitButton, 0, 2);
            buttonsPanel.Controls.Add(placeButton, 2, 2);
            buttonsPanel.Controls.Add(itemsTextBox, 1, 1);
            buttonsPanel.Controls.Add(statusLabel, 1, 2);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonsPanel.Location = new Point(0, 60);
            buttonsPanel.Margin = new Padding(0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 3;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            buttonsPanel.Size = new Size(600, 340);
            buttonsPanel.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(customerIdLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(productIdLabel, 1, 0);
            tableLayoutPanel3.Controls.Add(quantityLabel, 2, 0);
            tableLayoutPanel3.Controls.Add(customerIdTextBox, 0, 1);
            tableLayoutPanel3.Controls.Add(productIdTextBox, 1, 1);
            tableLayoutPanel3.Controls.Add(quantityTextBox, 2, 1);
            tableLayoutPanel3.Controls.Add(addButton, 3, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(90, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(420, 68);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.BackColor = Color.Transparent;
            customerIdLabel.Dock = DockStyle.Fill;
            customerIdLabel.ForeColor = Color.SaddleBrown;
            customerIdLabel.Location = new Point(0, 0);
            customerIdLabel.Margin = new Padding(0);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(126, 34);
            customerIdLabel.TabIndex = 0;
            customerIdLabel.Text = "Customer ID";
            customerIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.BackColor = Color.Transparent;
            productIdLabel.Dock = DockStyle.Fill;
            productIdLabel.ForeColor = Color.SaddleBrown;
            productIdLabel.Location = new Point(126, 0);
            productIdLabel.Margin = new Padding(0);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(126, 34);
            productIdLabel.TabIndex = 1;
            productIdLabel.Text = "ProductID";
            productIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.Dock = DockStyle.Fill;
            quantityLabel.ForeColor = Color.SaddleBrown;
            quantityLabel.Location = new Point(252, 0);
            quantityLabel.Margin = new Padding(0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(126, 34);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Quantity";
            quantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.BackColor = Color.FromArgb(255, 192, 128);
            customerIdTextBox.Dock = DockStyle.Fill;
            customerIdTextBox.Location = new Point(3, 37);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new Size(120, 24);
            customerIdTextBox.TabIndex = 3;
            customerIdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // productIdTextBox
            // 
            productIdTextBox.BackColor = Color.FromArgb(255, 192, 128);
            productIdTextBox.Dock = DockStyle.Fill;
            productIdTextBox.Location = new Point(129, 37);
            productIdTextBox.Name = "productIdTextBox";
            productIdTextBox.Size = new Size(120, 24);
            productIdTextBox.TabIndex = 4;
            productIdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // quantityTextBox
            // 
            quantityTextBox.BackColor = Color.FromArgb(255, 192, 128);
            quantityTextBox.Dock = DockStyle.Fill;
            quantityTextBox.Location = new Point(255, 37);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(120, 24);
            quantityTextBox.TabIndex = 5;
            quantityTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(255, 192, 128);
            addButton.Dock = DockStyle.Fill;
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(379, 35);
            addButton.Margin = new Padding(1);
            addButton.Name = "addButton";
            addButton.Size = new Size(40, 32);
            addButton.TabIndex = 6;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 128);
            exitButton.Dock = DockStyle.Fill;
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(3, 309);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(84, 28);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // placeButton
            // 
            placeButton.BackColor = Color.FromArgb(255, 192, 128);
            placeButton.Dock = DockStyle.Fill;
            placeButton.ForeColor = Color.White;
            placeButton.Location = new Point(513, 309);
            placeButton.Name = "placeButton";
            placeButton.Size = new Size(84, 28);
            placeButton.TabIndex = 2;
            placeButton.Text = "Place";
            placeButton.UseVisualStyleBackColor = false;
            placeButton.Click += placeButton_Click;
            // 
            // itemsTextBox
            // 
            itemsTextBox.BackColor = Color.FromArgb(128, 255, 128);
            itemsTextBox.Dock = DockStyle.Fill;
            itemsTextBox.ForeColor = Color.Black;
            itemsTextBox.Location = new Point(93, 71);
            itemsTextBox.Name = "itemsTextBox";
            itemsTextBox.ReadOnly = true;
            itemsTextBox.Size = new Size(414, 232);
            itemsTextBox.TabIndex = 3;
            itemsTextBox.Text = "";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Location = new Point(93, 306);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(414, 34);
            statusLabel.TabIndex = 4;
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OrderUI";
            Size = new Size(600, 400);
            Resize += OrderUI_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label titleLabel;
        private TableLayoutPanel buttonsPanel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label customerIdLabel;
        private Label productIdLabel;
        private Label quantityLabel;
        private TextBox customerIdTextBox;
        private TextBox productIdTextBox;
        private TextBox quantityTextBox;
        private Button addButton;
        private Button exitButton;
        private Button placeButton;
        private RichTextBox itemsTextBox;
        private Label statusLabel;
    }
}
