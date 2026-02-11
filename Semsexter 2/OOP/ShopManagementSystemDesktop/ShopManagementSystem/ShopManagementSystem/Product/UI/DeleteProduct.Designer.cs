namespace ShopManagementSystem.Product.UI
{
    partial class DeleteProduct
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
            deleteButton = new Button();
            exitButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            idLabel = new Label();
            idLayout = new TableLayoutPanel();
            idTextBox = new TextBox();
            findButton = new Button();
            idErrorLabel = new Label();
            namePriceLayout = new TableLayoutPanel();
            nameLabel = new Label();
            priceLabel = new Label();
            nameTextBox = new Label();
            priceTextBox = new Label();
            discountLayout = new TableLayoutPanel();
            discountLabel = new Label();
            discountTextBox = new Label();
            statusLabel = new Label();
            deleteProductTitleLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            buttonsPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            idLayout.SuspendLayout();
            namePriceLayout.SuspendLayout();
            discountLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonsPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(deleteProductTitleLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(600, 400);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 3;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            buttonsPanel.Controls.Add(deleteButton, 2, 3);
            buttonsPanel.Controls.Add(exitButton, 0, 3);
            buttonsPanel.Controls.Add(tableLayoutPanel2, 1, 0);
            buttonsPanel.Controls.Add(namePriceLayout, 1, 1);
            buttonsPanel.Controls.Add(discountLayout, 1, 2);
            buttonsPanel.Controls.Add(statusLabel, 1, 3);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonsPanel.ForeColor = Color.White;
            buttonsPanel.Location = new Point(0, 60);
            buttonsPanel.Margin = new Padding(0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 4;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            buttonsPanel.Size = new Size(600, 340);
            buttonsPanel.TabIndex = 3;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(255, 192, 128);
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(513, 309);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(84, 28);
            deleteButton.TabIndex = 36;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 128);
            exitButton.Dock = DockStyle.Fill;
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(3, 309);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(84, 28);
            exitButton.TabIndex = 25;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(idLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(idLayout, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(90, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(420, 102);
            tableLayoutPanel2.TabIndex = 37;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Dock = DockStyle.Fill;
            idLabel.ForeColor = Color.SaddleBrown;
            idLabel.Location = new Point(0, 0);
            idLabel.Margin = new Padding(0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(420, 51);
            idLabel.TabIndex = 0;
            idLabel.Text = "Enter Product ID:";
            idLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // idLayout
            // 
            idLayout.ColumnCount = 2;
            idLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            idLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            idLayout.Controls.Add(idTextBox, 0, 0);
            idLayout.Controls.Add(findButton, 1, 0);
            idLayout.Controls.Add(idErrorLabel, 0, 1);
            idLayout.Dock = DockStyle.Fill;
            idLayout.Location = new Point(0, 51);
            idLayout.Margin = new Padding(0);
            idLayout.Name = "idLayout";
            idLayout.RowCount = 2;
            idLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            idLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            idLayout.Size = new Size(420, 51);
            idLayout.TabIndex = 1;
            // 
            // idTextBox
            // 
            idTextBox.BackColor = Color.FromArgb(255, 192, 128);
            idTextBox.Dock = DockStyle.Fill;
            idTextBox.Location = new Point(0, 0);
            idTextBox.Margin = new Padding(0);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(336, 24);
            idTextBox.TabIndex = 0;
            idTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // findButton
            // 
            findButton.BackColor = Color.FromArgb(255, 192, 128);
            findButton.Dock = DockStyle.Fill;
            findButton.Location = new Point(336, 0);
            findButton.Margin = new Padding(0);
            findButton.Name = "findButton";
            findButton.Size = new Size(84, 30);
            findButton.TabIndex = 1;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = false;
            findButton.Click += findButton_Click;
            // 
            // idErrorLabel
            // 
            idErrorLabel.AutoSize = true;
            idErrorLabel.Dock = DockStyle.Fill;
            idErrorLabel.ForeColor = Color.Red;
            idErrorLabel.Location = new Point(3, 30);
            idErrorLabel.Name = "idErrorLabel";
            idErrorLabel.Size = new Size(330, 21);
            idErrorLabel.TabIndex = 2;
            idErrorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // namePriceLayout
            // 
            namePriceLayout.ColumnCount = 2;
            namePriceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            namePriceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            namePriceLayout.Controls.Add(nameLabel, 0, 1);
            namePriceLayout.Controls.Add(priceLabel, 0, 2);
            namePriceLayout.Controls.Add(nameTextBox, 1, 1);
            namePriceLayout.Controls.Add(priceTextBox, 1, 2);
            namePriceLayout.Dock = DockStyle.Fill;
            namePriceLayout.Location = new Point(90, 102);
            namePriceLayout.Margin = new Padding(0);
            namePriceLayout.Name = "namePriceLayout";
            namePriceLayout.RowCount = 3;
            namePriceLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            namePriceLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            namePriceLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            namePriceLayout.Size = new Size(420, 102);
            namePriceLayout.TabIndex = 38;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.ForeColor = Color.SaddleBrown;
            nameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            nameLabel.Location = new Point(3, 30);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(162, 35);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name: ";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Dock = DockStyle.Fill;
            priceLabel.ForeColor = Color.SaddleBrown;
            priceLabel.ImageAlign = ContentAlignment.MiddleLeft;
            priceLabel.Location = new Point(3, 65);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(162, 37);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Purchase Price: ";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            nameTextBox.AutoSize = true;
            nameTextBox.BackColor = Color.FromArgb(255, 192, 128);
            nameTextBox.Dock = DockStyle.Fill;
            nameTextBox.Location = new Point(171, 33);
            nameTextBox.Margin = new Padding(3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(246, 29);
            nameTextBox.TabIndex = 3;
            nameTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priceTextBox
            // 
            priceTextBox.AutoSize = true;
            priceTextBox.BackColor = Color.FromArgb(255, 192, 128);
            priceTextBox.Dock = DockStyle.Fill;
            priceTextBox.Location = new Point(171, 68);
            priceTextBox.Margin = new Padding(3);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(246, 31);
            priceTextBox.TabIndex = 4;
            priceTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // discountLayout
            // 
            discountLayout.ColumnCount = 2;
            discountLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            discountLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            discountLayout.Controls.Add(discountLabel, 0, 0);
            discountLayout.Controls.Add(discountTextBox, 1, 0);
            discountLayout.Dock = DockStyle.Fill;
            discountLayout.Location = new Point(90, 204);
            discountLayout.Margin = new Padding(0);
            discountLayout.Name = "discountLayout";
            discountLayout.RowCount = 2;
            discountLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 41.17647F));
            discountLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 58.82353F));
            discountLayout.Size = new Size(420, 102);
            discountLayout.TabIndex = 39;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Dock = DockStyle.Fill;
            discountLabel.ForeColor = Color.SaddleBrown;
            discountLabel.ImageAlign = ContentAlignment.MiddleLeft;
            discountLabel.Location = new Point(3, 0);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(162, 42);
            discountLabel.TabIndex = 3;
            discountLabel.Text = "Discount: ";
            discountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // discountTextBox
            // 
            discountTextBox.AutoSize = true;
            discountTextBox.BackColor = Color.FromArgb(255, 192, 128);
            discountTextBox.Dock = DockStyle.Fill;
            discountTextBox.Location = new Point(171, 3);
            discountTextBox.Margin = new Padding(3);
            discountTextBox.Name = "discountTextBox";
            discountTextBox.Size = new Size(246, 36);
            discountTextBox.TabIndex = 4;
            discountTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.ForeColor = Color.Black;
            statusLabel.Location = new Point(93, 306);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(414, 34);
            statusLabel.TabIndex = 40;
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteProductTitleLabel
            // 
            deleteProductTitleLabel.AutoSize = true;
            deleteProductTitleLabel.BackColor = Color.SaddleBrown;
            deleteProductTitleLabel.Dock = DockStyle.Fill;
            deleteProductTitleLabel.ForeColor = Color.White;
            deleteProductTitleLabel.Location = new Point(0, 0);
            deleteProductTitleLabel.Margin = new Padding(0);
            deleteProductTitleLabel.Name = "deleteProductTitleLabel";
            deleteProductTitleLabel.Size = new Size(600, 60);
            deleteProductTitleLabel.TabIndex = 1;
            deleteProductTitleLabel.Text = "Delete Product";
            deleteProductTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DeleteProduct";
            Size = new Size(600, 400);
            Resize += DeleteProduct_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            idLayout.ResumeLayout(false);
            idLayout.PerformLayout();
            namePriceLayout.ResumeLayout(false);
            namePriceLayout.PerformLayout();
            discountLayout.ResumeLayout(false);
            discountLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label deleteProductTitleLabel;
        private TableLayoutPanel buttonsPanel;
        private Button deleteButton;
        private Button exitButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label idLabel;
        private TableLayoutPanel idLayout;
        private TextBox idTextBox;
        private Button findButton;
        private Label idErrorLabel;
        private TableLayoutPanel namePriceLayout;
        private Label nameLabel;
        private Label priceLabel;
        private TableLayoutPanel discountLayout;
        private Label discountLabel;
        private Label statusLabel;
        private Label nameTextBox;
        private Label priceTextBox;
        private Label discountTextBox;
    }
}
