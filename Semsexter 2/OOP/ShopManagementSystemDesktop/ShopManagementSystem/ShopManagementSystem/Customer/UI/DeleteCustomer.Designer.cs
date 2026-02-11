namespace ShopManagementSystem.Customer.UI
{
    partial class DeleteCustomer
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
            deleteCustomerTitleLabel = new Label();
            ageLabel = new Label();
            ageTextBox = new Label();
            discountLayout = new TableLayoutPanel();
            addressTextBox = new Label();
            addressLabel = new Label();
            numberLabel = new Label();
            nameTextBox = new Label();
            numberTextBox = new Label();
            idTextBox = new TextBox();
            findButton = new Button();
            nameLabel = new Label();
            idErrorLabel = new Label();
            statusLabel = new Label();
            idLabel = new Label();
            idLayout = new TableLayoutPanel();
            deleteButton = new Button();
            exitButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonsPanel = new TableLayoutPanel();
            namePriceLayout = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            discountLayout.SuspendLayout();
            idLayout.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            buttonsPanel.SuspendLayout();
            namePriceLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // deleteCustomerTitleLabel
            // 
            deleteCustomerTitleLabel.AutoSize = true;
            deleteCustomerTitleLabel.BackColor = Color.SaddleBrown;
            deleteCustomerTitleLabel.Dock = DockStyle.Fill;
            deleteCustomerTitleLabel.ForeColor = Color.White;
            deleteCustomerTitleLabel.Location = new Point(0, 0);
            deleteCustomerTitleLabel.Margin = new Padding(0);
            deleteCustomerTitleLabel.Name = "deleteCustomerTitleLabel";
            deleteCustomerTitleLabel.Size = new Size(600, 60);
            deleteCustomerTitleLabel.TabIndex = 1;
            deleteCustomerTitleLabel.Text = "Delete Customer";
            deleteCustomerTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Dock = DockStyle.Fill;
            ageLabel.ForeColor = Color.SaddleBrown;
            ageLabel.ImageAlign = ContentAlignment.MiddleLeft;
            ageLabel.Location = new Point(3, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(162, 35);
            ageLabel.TabIndex = 3;
            ageLabel.Text = "Age:";
            ageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ageTextBox
            // 
            ageTextBox.AutoSize = true;
            ageTextBox.BackColor = Color.FromArgb(255, 192, 128);
            ageTextBox.Dock = DockStyle.Fill;
            ageTextBox.Location = new Point(171, 3);
            ageTextBox.Margin = new Padding(3);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(246, 29);
            ageTextBox.TabIndex = 4;
            ageTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // discountLayout
            // 
            discountLayout.ColumnCount = 2;
            discountLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            discountLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            discountLayout.Controls.Add(addressTextBox, 1, 1);
            discountLayout.Controls.Add(addressLabel, 0, 1);
            discountLayout.Controls.Add(ageLabel, 0, 0);
            discountLayout.Controls.Add(ageTextBox, 1, 0);
            discountLayout.Dock = DockStyle.Fill;
            discountLayout.Location = new Point(90, 204);
            discountLayout.Margin = new Padding(0);
            discountLayout.Name = "discountLayout";
            discountLayout.RowCount = 3;
            discountLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            discountLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            discountLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            discountLayout.Size = new Size(420, 102);
            discountLayout.TabIndex = 39;
            // 
            // addressTextBox
            // 
            addressTextBox.AutoSize = true;
            addressTextBox.BackColor = Color.FromArgb(255, 192, 128);
            addressTextBox.Dock = DockStyle.Fill;
            addressTextBox.Location = new Point(171, 38);
            addressTextBox.Margin = new Padding(3);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(246, 29);
            addressTextBox.TabIndex = 6;
            addressTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Dock = DockStyle.Fill;
            addressLabel.ForeColor = Color.SaddleBrown;
            addressLabel.ImageAlign = ContentAlignment.MiddleLeft;
            addressLabel.Location = new Point(3, 35);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(162, 35);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            addressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Dock = DockStyle.Fill;
            numberLabel.ForeColor = Color.SaddleBrown;
            numberLabel.ImageAlign = ContentAlignment.MiddleLeft;
            numberLabel.Location = new Point(3, 65);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(162, 37);
            numberLabel.TabIndex = 2;
            numberLabel.Text = "Number:";
            numberLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // numberTextBox
            // 
            numberTextBox.AutoSize = true;
            numberTextBox.BackColor = Color.FromArgb(255, 192, 128);
            numberTextBox.Dock = DockStyle.Fill;
            numberTextBox.Location = new Point(171, 68);
            numberTextBox.Margin = new Padding(3);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(246, 31);
            numberTextBox.TabIndex = 4;
            numberTextBox.TextAlign = ContentAlignment.MiddleCenter;
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
            idLabel.Text = "Enter Customer ID:";
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
            // namePriceLayout
            // 
            namePriceLayout.ColumnCount = 2;
            namePriceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            namePriceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            namePriceLayout.Controls.Add(nameLabel, 0, 1);
            namePriceLayout.Controls.Add(numberLabel, 0, 2);
            namePriceLayout.Controls.Add(nameTextBox, 1, 1);
            namePriceLayout.Controls.Add(numberTextBox, 1, 2);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonsPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(deleteCustomerTitleLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(600, 400);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // DeleteCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DeleteCustomer";
            Size = new Size(600, 400);
            Resize += DeleteCustomer_Resize;
            discountLayout.ResumeLayout(false);
            discountLayout.PerformLayout();
            idLayout.ResumeLayout(false);
            idLayout.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            namePriceLayout.ResumeLayout(false);
            namePriceLayout.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label deleteCustomerTitleLabel;
        private Label ageLabel;
        private Label ageTextBox;
        private TableLayoutPanel discountLayout;
        private Label numberLabel;
        private Label nameTextBox;
        private Label numberTextBox;
        private TextBox idTextBox;
        private Button findButton;
        private Label nameLabel;
        private Label idErrorLabel;
        private Label statusLabel;
        private Label idLabel;
        private TableLayoutPanel idLayout;
        private Button deleteButton;
        private Button exitButton;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel buttonsPanel;
        private TableLayoutPanel namePriceLayout;
        private TableLayoutPanel tableLayoutPanel1;
        private Label addressTextBox;
        private Label addressLabel;
    }
}
