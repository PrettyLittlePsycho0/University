namespace ShopManagementSystem.Customer.UI
{
    partial class CreateCustomer
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
            tableLayoutPanel12 = new TableLayoutPanel();
            addressErrorLabel = new Label();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            customerNameLabel = new Label();
            customerNameTextBox = new TextBox();
            customerNameErrorLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            numberErrorLabel = new Label();
            numberLabel = new Label();
            numberTextBox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            ageErrorLabel = new Label();
            ageLabel = new Label();
            ageTextBox = new TextBox();
            exitButton = new Button();
            createButton = new Button();
            statusLabel = new Label();
            createCustomerTitleLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            buttonsPanel.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(createCustomerTitleLabel, 0, 0);
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
            buttonsPanel.Controls.Add(tableLayoutPanel12, 1, 3);
            buttonsPanel.Controls.Add(tableLayoutPanel2, 1, 0);
            buttonsPanel.Controls.Add(tableLayoutPanel3, 1, 1);
            buttonsPanel.Controls.Add(tableLayoutPanel4, 1, 2);
            buttonsPanel.Controls.Add(exitButton, 0, 4);
            buttonsPanel.Controls.Add(createButton, 2, 4);
            buttonsPanel.Controls.Add(statusLabel, 1, 4);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonsPanel.ForeColor = Color.White;
            buttonsPanel.Location = new Point(0, 60);
            buttonsPanel.Margin = new Padding(0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 5;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            buttonsPanel.Size = new Size(600, 340);
            buttonsPanel.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(addressErrorLabel, 0, 2);
            tableLayoutPanel12.Controls.Add(addressLabel, 0, 0);
            tableLayoutPanel12.Controls.Add(addressTextBox, 0, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(150, 228);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 3;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel12.Size = new Size(300, 76);
            tableLayoutPanel12.TabIndex = 47;
            // 
            // addressErrorLabel
            // 
            addressErrorLabel.AutoSize = true;
            addressErrorLabel.Dock = DockStyle.Fill;
            addressErrorLabel.ForeColor = Color.Red;
            addressErrorLabel.Location = new Point(0, 57);
            addressErrorLabel.Margin = new Padding(0, 5, 0, 0);
            addressErrorLabel.Name = "addressErrorLabel";
            addressErrorLabel.Size = new Size(300, 19);
            addressErrorLabel.TabIndex = 3;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Dock = DockStyle.Fill;
            addressLabel.ForeColor = Color.SaddleBrown;
            addressLabel.Location = new Point(3, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(294, 30);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Enter Address:";
            addressLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // addressTextBox
            // 
            addressTextBox.BackColor = Color.FromArgb(255, 192, 128);
            addressTextBox.Dock = DockStyle.Fill;
            addressTextBox.Location = new Point(3, 33);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(294, 24);
            addressTextBox.TabIndex = 1;
            addressTextBox.TextAlign = HorizontalAlignment.Center;
            addressTextBox.KeyUp += addressTextBox_KeyUp;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(customerNameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(customerNameTextBox, 0, 1);
            tableLayoutPanel2.Controls.Add(customerNameErrorLabel, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(150, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Size = new Size(300, 76);
            tableLayoutPanel2.TabIndex = 37;
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Dock = DockStyle.Fill;
            customerNameLabel.ForeColor = Color.SaddleBrown;
            customerNameLabel.Location = new Point(3, 0);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(294, 30);
            customerNameLabel.TabIndex = 0;
            customerNameLabel.Text = "Enter Name:";
            customerNameLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.BackColor = Color.FromArgb(255, 192, 128);
            customerNameTextBox.Dock = DockStyle.Bottom;
            customerNameTextBox.Location = new Point(3, 33);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(294, 24);
            customerNameTextBox.TabIndex = 1;
            customerNameTextBox.TextAlign = HorizontalAlignment.Center;
            customerNameTextBox.KeyUp += customerNameTextBox_KeyUp;
            // 
            // customerNameErrorLabel
            // 
            customerNameErrorLabel.AutoSize = true;
            customerNameErrorLabel.Dock = DockStyle.Fill;
            customerNameErrorLabel.ForeColor = Color.Red;
            customerNameErrorLabel.Location = new Point(0, 52);
            customerNameErrorLabel.Margin = new Padding(0);
            customerNameErrorLabel.Name = "customerNameErrorLabel";
            customerNameErrorLabel.Size = new Size(300, 24);
            customerNameErrorLabel.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(numberErrorLabel, 0, 2);
            tableLayoutPanel3.Controls.Add(numberLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(numberTextBox, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(150, 76);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Size = new Size(300, 76);
            tableLayoutPanel3.TabIndex = 38;
            // 
            // numberErrorLabel
            // 
            numberErrorLabel.AutoSize = true;
            numberErrorLabel.Dock = DockStyle.Fill;
            numberErrorLabel.ForeColor = Color.Red;
            numberErrorLabel.Location = new Point(0, 57);
            numberErrorLabel.Margin = new Padding(0, 5, 0, 0);
            numberErrorLabel.Name = "numberErrorLabel";
            numberErrorLabel.Size = new Size(300, 19);
            numberErrorLabel.TabIndex = 3;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Dock = DockStyle.Fill;
            numberLabel.ForeColor = Color.SaddleBrown;
            numberLabel.Location = new Point(3, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(294, 30);
            numberLabel.TabIndex = 0;
            numberLabel.Text = "Enter Number:";
            numberLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // numberTextBox
            // 
            numberTextBox.BackColor = Color.FromArgb(255, 192, 128);
            numberTextBox.Dock = DockStyle.Fill;
            numberTextBox.Location = new Point(3, 33);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(294, 24);
            numberTextBox.TabIndex = 1;
            numberTextBox.TextAlign = HorizontalAlignment.Center;
            numberTextBox.KeyUp += numberTextBox_KeyUp;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(ageErrorLabel, 0, 2);
            tableLayoutPanel4.Controls.Add(ageLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(ageTextBox, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(150, 152);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.Size = new Size(300, 76);
            tableLayoutPanel4.TabIndex = 39;
            // 
            // ageErrorLabel
            // 
            ageErrorLabel.AutoSize = true;
            ageErrorLabel.Dock = DockStyle.Fill;
            ageErrorLabel.ForeColor = Color.Red;
            ageErrorLabel.Location = new Point(0, 57);
            ageErrorLabel.Margin = new Padding(0, 5, 0, 0);
            ageErrorLabel.Name = "ageErrorLabel";
            ageErrorLabel.Size = new Size(300, 19);
            ageErrorLabel.TabIndex = 3;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Dock = DockStyle.Fill;
            ageLabel.ForeColor = Color.SaddleBrown;
            ageLabel.Location = new Point(3, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(294, 30);
            ageLabel.TabIndex = 0;
            ageLabel.Text = "Enter Age:";
            ageLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // ageTextBox
            // 
            ageTextBox.BackColor = Color.FromArgb(255, 192, 128);
            ageTextBox.Dock = DockStyle.Fill;
            ageTextBox.Location = new Point(3, 33);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(294, 24);
            ageTextBox.TabIndex = 1;
            ageTextBox.TextAlign = HorizontalAlignment.Center;
            ageTextBox.KeyUp += ageTextBox_KeyUp;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 128);
            exitButton.Dock = DockStyle.Fill;
            exitButton.Location = new Point(3, 307);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(144, 30);
            exitButton.TabIndex = 48;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // createButton
            // 
            createButton.BackColor = Color.FromArgb(255, 192, 128);
            createButton.Dock = DockStyle.Fill;
            createButton.Location = new Point(453, 307);
            createButton.Name = "createButton";
            createButton.Size = new Size(144, 30);
            createButton.TabIndex = 49;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Location = new Point(153, 304);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(294, 36);
            statusLabel.TabIndex = 50;
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createCustomerTitleLabel
            // 
            createCustomerTitleLabel.AutoSize = true;
            createCustomerTitleLabel.BackColor = Color.SaddleBrown;
            createCustomerTitleLabel.Dock = DockStyle.Fill;
            createCustomerTitleLabel.ForeColor = Color.White;
            createCustomerTitleLabel.Location = new Point(0, 0);
            createCustomerTitleLabel.Margin = new Padding(0);
            createCustomerTitleLabel.Name = "createCustomerTitleLabel";
            createCustomerTitleLabel.Size = new Size(600, 60);
            createCustomerTitleLabel.TabIndex = 2;
            createCustomerTitleLabel.Text = "Create New Customer";
            createCustomerTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CreateCustomer";
            Size = new Size(600, 400);
            Resize += CreateCustomer_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox customerNameTextBox;
        private Label customerNameErrorLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label numberErrorLabel;
        private Label numberLabel;
        private TextBox numberTextBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label ageErrorLabel;
        private Label ageLabel;
        private TextBox ageTextBox;
        private Label createCustomerTitleLabel;
        private TableLayoutPanel tableLayoutPanel12;
        private Label addressErrorLabel;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label customerNameLabel;
        private Button exitButton;
        private Button createButton;
        private Label statusLabel;
    }
}
