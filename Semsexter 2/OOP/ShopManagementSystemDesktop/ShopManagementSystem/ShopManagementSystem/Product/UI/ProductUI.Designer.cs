namespace ShopManagementSystem.Product
{
    partial class ProductUI
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
            exitButton = new Button();
            advanceSearchButton = new Button();
            viewAllProductsButton = new Button();
            deleteProductButton = new Button();
            updateProductButton = new Button();
            createProductButton = new Button();
            productTitleLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonsPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(productTitleLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(600, 400);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 3;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.Controls.Add(exitButton, 0, 5);
            buttonsPanel.Controls.Add(advanceSearchButton, 1, 4);
            buttonsPanel.Controls.Add(viewAllProductsButton, 1, 3);
            buttonsPanel.Controls.Add(deleteProductButton, 1, 2);
            buttonsPanel.Controls.Add(updateProductButton, 1, 1);
            buttonsPanel.Controls.Add(createProductButton, 1, 0);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonsPanel.Location = new Point(0, 60);
            buttonsPanel.Margin = new Padding(0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 6;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            buttonsPanel.Size = new Size(600, 340);
            buttonsPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 128);
            exitButton.Dock = DockStyle.Fill;
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(3, 308);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(144, 29);
            exitButton.TabIndex = 15;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // advanceSearchButton
            // 
            advanceSearchButton.BackColor = Color.FromArgb(255, 192, 128);
            advanceSearchButton.Dock = DockStyle.Fill;
            advanceSearchButton.ForeColor = Color.White;
            advanceSearchButton.Location = new Point(153, 247);
            advanceSearchButton.Name = "advanceSearchButton";
            advanceSearchButton.Size = new Size(294, 55);
            advanceSearchButton.TabIndex = 13;
            advanceSearchButton.Text = "Advance Search";
            advanceSearchButton.UseVisualStyleBackColor = false;
            advanceSearchButton.Click += advanceSearchButton_Click;
            // 
            // viewAllProductsButton
            // 
            viewAllProductsButton.BackColor = Color.FromArgb(255, 192, 128);
            viewAllProductsButton.Dock = DockStyle.Fill;
            viewAllProductsButton.ForeColor = Color.White;
            viewAllProductsButton.Location = new Point(153, 186);
            viewAllProductsButton.Name = "viewAllProductsButton";
            viewAllProductsButton.Size = new Size(294, 55);
            viewAllProductsButton.TabIndex = 10;
            viewAllProductsButton.Text = "View All Products";
            viewAllProductsButton.UseVisualStyleBackColor = false;
            viewAllProductsButton.Click += viewAllProductsButton_Click;
            // 
            // deleteProductButton
            // 
            deleteProductButton.BackColor = Color.FromArgb(255, 192, 128);
            deleteProductButton.Dock = DockStyle.Fill;
            deleteProductButton.ForeColor = Color.White;
            deleteProductButton.Location = new Point(153, 125);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(294, 55);
            deleteProductButton.TabIndex = 7;
            deleteProductButton.Text = "Delete Product";
            deleteProductButton.UseVisualStyleBackColor = false;
            deleteProductButton.Click += deleteProductButton_Click;
            // 
            // updateProductButton
            // 
            updateProductButton.BackColor = Color.FromArgb(255, 192, 128);
            updateProductButton.Dock = DockStyle.Fill;
            updateProductButton.ForeColor = Color.White;
            updateProductButton.Location = new Point(153, 64);
            updateProductButton.Name = "updateProductButton";
            updateProductButton.Size = new Size(294, 55);
            updateProductButton.TabIndex = 4;
            updateProductButton.Text = "Update Product";
            updateProductButton.UseVisualStyleBackColor = false;
            updateProductButton.Click += updateProductButton_Click;
            // 
            // createProductButton
            // 
            createProductButton.BackColor = Color.FromArgb(255, 192, 128);
            createProductButton.Dock = DockStyle.Fill;
            createProductButton.ForeColor = Color.White;
            createProductButton.Location = new Point(153, 3);
            createProductButton.Name = "createProductButton";
            createProductButton.Size = new Size(294, 55);
            createProductButton.TabIndex = 0;
            createProductButton.Text = "New Product";
            createProductButton.UseVisualStyleBackColor = false;
            createProductButton.Click += createProductButton_Click;
            // 
            // productTitleLabel
            // 
            productTitleLabel.AutoSize = true;
            productTitleLabel.BackColor = Color.SaddleBrown;
            productTitleLabel.Dock = DockStyle.Fill;
            productTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productTitleLabel.ForeColor = Color.White;
            productTitleLabel.Location = new Point(0, 0);
            productTitleLabel.Margin = new Padding(0);
            productTitleLabel.Name = "productTitleLabel";
            productTitleLabel.Size = new Size(600, 60);
            productTitleLabel.TabIndex = 1;
            productTitleLabel.Text = "Product Management";
            productTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ProductUI";
            Size = new Size(600, 400);
            Resize += ProductUI_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel buttonsPanel;
        private Button exitButton;
        private Button advanceSearchButton;
        private Button viewAllProductsButton;
        private Button deleteProductButton;
        private Button updateProductButton;
        private Button createProductButton;
        private Label productTitleLabel;
    }
}
