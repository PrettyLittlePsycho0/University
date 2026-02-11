namespace ShopManagementSystem.Product.UI
{
    partial class CreateProduct
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
            buttonsPanel = new TableLayoutPanel();
            createButton = new Button();
            exitButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            productNameLabel = new Label();
            productNameTextBox = new TextBox();
            productNameErrorLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            purchasePriceErrorLabel = new Label();
            purchasePriceLabel = new Label();
            purchasePriceTextBox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            discountErrorLabel = new Label();
            discountLabel = new Label();
            discountTextBox = new TextBox();
            statusLabel = new Label();
            createProductTitleLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            buttonsPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonsPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(createProductTitleLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(623, 383);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 3;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.Controls.Add(createButton, 2, 3);
            buttonsPanel.Controls.Add(exitButton, 0, 3);
            buttonsPanel.Controls.Add(tableLayoutPanel2, 1, 0);
            buttonsPanel.Controls.Add(tableLayoutPanel3, 1, 1);
            buttonsPanel.Controls.Add(tableLayoutPanel4, 1, 2);
            buttonsPanel.Controls.Add(statusLabel, 1, 3);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonsPanel.ForeColor = Color.White;
            buttonsPanel.Location = new Point(0, 57);
            buttonsPanel.Margin = new Padding(0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 4;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            buttonsPanel.Size = new Size(623, 326);
            buttonsPanel.TabIndex = 1;
            // 
            // createButton
            // 
            createButton.BackColor = Color.FromArgb(255, 192, 128);
            createButton.Dock = DockStyle.Fill;
            createButton.ForeColor = Color.White;
            createButton.Location = new Point(469, 294);
            createButton.Name = "createButton";
            createButton.Size = new Size(151, 29);
            createButton.TabIndex = 36;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 128);
            exitButton.Dock = DockStyle.Fill;
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(3, 294);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(149, 29);
            exitButton.TabIndex = 25;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(productNameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(productNameTextBox, 0, 1);
            tableLayoutPanel2.Controls.Add(productNameErrorLabel, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(155, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(311, 97);
            tableLayoutPanel2.TabIndex = 37;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Dock = DockStyle.Fill;
            productNameLabel.ForeColor = Color.SaddleBrown;
            productNameLabel.Location = new Point(3, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(305, 48);
            productNameLabel.TabIndex = 0;
            productNameLabel.Text = "Enter Product's Name:";
            productNameLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // productNameTextBox
            // 
            productNameTextBox.BackColor = Color.FromArgb(255, 192, 128);
            productNameTextBox.Dock = DockStyle.Bottom;
            productNameTextBox.Location = new Point(3, 51);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(305, 24);
            productNameTextBox.TabIndex = 1;
            productNameTextBox.TextAlign = HorizontalAlignment.Center;
            productNameTextBox.KeyUp += productNameTextBox_KeyUp;
            // 
            // productNameErrorLabel
            // 
            productNameErrorLabel.AutoSize = true;
            productNameErrorLabel.Dock = DockStyle.Fill;
            productNameErrorLabel.ForeColor = Color.Red;
            productNameErrorLabel.Location = new Point(0, 77);
            productNameErrorLabel.Margin = new Padding(0);
            productNameErrorLabel.Name = "productNameErrorLabel";
            productNameErrorLabel.Size = new Size(311, 20);
            productNameErrorLabel.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(purchasePriceErrorLabel, 0, 2);
            tableLayoutPanel3.Controls.Add(purchasePriceLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(purchasePriceTextBox, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(155, 97);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(311, 97);
            tableLayoutPanel3.TabIndex = 38;
            // 
            // purchasePriceErrorLabel
            // 
            purchasePriceErrorLabel.AutoSize = true;
            purchasePriceErrorLabel.Dock = DockStyle.Fill;
            purchasePriceErrorLabel.ForeColor = Color.Red;
            purchasePriceErrorLabel.Location = new Point(0, 77);
            purchasePriceErrorLabel.Margin = new Padding(0);
            purchasePriceErrorLabel.Name = "purchasePriceErrorLabel";
            purchasePriceErrorLabel.Size = new Size(311, 20);
            purchasePriceErrorLabel.TabIndex = 3;
            // 
            // purchasePriceLabel
            // 
            purchasePriceLabel.AutoSize = true;
            purchasePriceLabel.Dock = DockStyle.Fill;
            purchasePriceLabel.ForeColor = Color.SaddleBrown;
            purchasePriceLabel.Location = new Point(3, 0);
            purchasePriceLabel.Name = "purchasePriceLabel";
            purchasePriceLabel.Size = new Size(305, 48);
            purchasePriceLabel.TabIndex = 0;
            purchasePriceLabel.Text = "Enter Product's Purchase Price:";
            purchasePriceLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // purchasePriceTextBox
            // 
            purchasePriceTextBox.BackColor = Color.FromArgb(255, 192, 128);
            purchasePriceTextBox.Dock = DockStyle.Fill;
            purchasePriceTextBox.Location = new Point(3, 51);
            purchasePriceTextBox.Name = "purchasePriceTextBox";
            purchasePriceTextBox.Size = new Size(305, 24);
            purchasePriceTextBox.TabIndex = 1;
            purchasePriceTextBox.TextAlign = HorizontalAlignment.Center;
            purchasePriceTextBox.KeyUp += purchasePriceTextBox_KeyUp;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(discountErrorLabel, 0, 2);
            tableLayoutPanel4.Controls.Add(discountLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(discountTextBox, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(155, 194);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(311, 97);
            tableLayoutPanel4.TabIndex = 39;
            // 
            // discountErrorLabel
            // 
            discountErrorLabel.AutoSize = true;
            discountErrorLabel.Dock = DockStyle.Fill;
            discountErrorLabel.ForeColor = Color.Red;
            discountErrorLabel.Location = new Point(0, 77);
            discountErrorLabel.Margin = new Padding(0);
            discountErrorLabel.Name = "discountErrorLabel";
            discountErrorLabel.Size = new Size(311, 20);
            discountErrorLabel.TabIndex = 3;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Dock = DockStyle.Fill;
            discountLabel.ForeColor = Color.SaddleBrown;
            discountLabel.Location = new Point(3, 0);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(305, 48);
            discountLabel.TabIndex = 0;
            discountLabel.Text = "Enter discount percentage:";
            discountLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // discountTextBox
            // 
            discountTextBox.BackColor = Color.FromArgb(255, 192, 128);
            discountTextBox.Dock = DockStyle.Fill;
            discountTextBox.Location = new Point(3, 51);
            discountTextBox.Name = "discountTextBox";
            discountTextBox.Size = new Size(305, 24);
            discountTextBox.TabIndex = 1;
            discountTextBox.TextAlign = HorizontalAlignment.Center;
            discountTextBox.KeyUp += discountTextBox_KeyUp;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Location = new Point(158, 291);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(305, 35);
            statusLabel.TabIndex = 40;
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createProductTitleLabel
            // 
            createProductTitleLabel.AutoSize = true;
            createProductTitleLabel.BackColor = Color.SaddleBrown;
            createProductTitleLabel.Dock = DockStyle.Fill;
            createProductTitleLabel.ForeColor = Color.White;
            createProductTitleLabel.Location = new Point(0, 0);
            createProductTitleLabel.Margin = new Padding(0);
            createProductTitleLabel.Name = "createProductTitleLabel";
            createProductTitleLabel.Size = new Size(623, 57);
            createProductTitleLabel.TabIndex = 2;
            createProductTitleLabel.Text = "Create New Product";
            createProductTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CreateProduct";
            Size = new Size(623, 383);
            Resize += CreateProduct_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel buttonsPanel;
        private Button createButton;
        private Button exitButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label productNameLabel;
        private TextBox productNameTextBox;
        private Label productNameErrorLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label purchasePriceErrorLabel;
        private Label purchasePriceLabel;
        private TextBox purchasePriceTextBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label discountErrorLabel;
        private Label discountLabel;
        private TextBox discountTextBox;
        private Label createProductTitleLabel;
        private Label statusLabel;
    }
}
