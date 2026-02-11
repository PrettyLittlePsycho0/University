namespace ShopManagementSystem.Customer
{
    partial class CustomerUI
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
            customerTitleLabel = new Label();
            buttonsPanel = new TableLayoutPanel();
            exitButton = new Button();
            advanceSearchButton = new Button();
            viewAllCustomersButton = new Button();
            deleteCustomerButton = new Button();
            updateCustomerButton = new Button();
            newCustomerButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(customerTitleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonsPanel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(600, 407);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // customerTitleLabel
            // 
            customerTitleLabel.AutoSize = true;
            customerTitleLabel.BackColor = Color.SaddleBrown;
            customerTitleLabel.Dock = DockStyle.Fill;
            customerTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerTitleLabel.ForeColor = Color.White;
            customerTitleLabel.Location = new Point(0, 0);
            customerTitleLabel.Margin = new Padding(0);
            customerTitleLabel.Name = "customerTitleLabel";
            customerTitleLabel.Size = new Size(600, 61);
            customerTitleLabel.TabIndex = 0;
            customerTitleLabel.Text = "Customer Management";
            customerTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonsPanel
            // 
            buttonsPanel.BackColor = Color.PaleGreen;
            buttonsPanel.ColumnCount = 3;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.Controls.Add(exitButton, 0, 5);
            buttonsPanel.Controls.Add(advanceSearchButton, 1, 4);
            buttonsPanel.Controls.Add(viewAllCustomersButton, 1, 3);
            buttonsPanel.Controls.Add(deleteCustomerButton, 1, 2);
            buttonsPanel.Controls.Add(updateCustomerButton, 1, 1);
            buttonsPanel.Controls.Add(newCustomerButton, 1, 0);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonsPanel.Location = new Point(0, 61);
            buttonsPanel.Margin = new Padding(0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 6;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            buttonsPanel.Size = new Size(600, 346);
            buttonsPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 128);
            exitButton.Dock = DockStyle.Fill;
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(3, 313);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(144, 30);
            exitButton.TabIndex = 26;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // advanceSearchButton
            // 
            advanceSearchButton.BackColor = Color.FromArgb(255, 192, 128);
            advanceSearchButton.Cursor = Cursors.Hand;
            advanceSearchButton.Dock = DockStyle.Fill;
            advanceSearchButton.ForeColor = Color.White;
            advanceSearchButton.Location = new Point(153, 251);
            advanceSearchButton.Name = "advanceSearchButton";
            advanceSearchButton.Size = new Size(294, 56);
            advanceSearchButton.TabIndex = 24;
            advanceSearchButton.Text = "Advance Search";
            advanceSearchButton.UseVisualStyleBackColor = false;
            advanceSearchButton.Click += advanceSearchButton_Click;
            // 
            // viewAllCustomersButton
            // 
            viewAllCustomersButton.BackColor = Color.FromArgb(255, 192, 128);
            viewAllCustomersButton.Cursor = Cursors.Hand;
            viewAllCustomersButton.Dock = DockStyle.Fill;
            viewAllCustomersButton.ForeColor = Color.White;
            viewAllCustomersButton.Location = new Point(153, 192);
            viewAllCustomersButton.Margin = new Padding(3, 6, 3, 3);
            viewAllCustomersButton.Name = "viewAllCustomersButton";
            viewAllCustomersButton.Size = new Size(294, 53);
            viewAllCustomersButton.TabIndex = 13;
            viewAllCustomersButton.Text = "View All Customers";
            viewAllCustomersButton.UseVisualStyleBackColor = false;
            viewAllCustomersButton.Click += viewAllCustomersButton_Click;
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.BackColor = Color.FromArgb(255, 192, 128);
            deleteCustomerButton.Cursor = Cursors.Hand;
            deleteCustomerButton.Dock = DockStyle.Fill;
            deleteCustomerButton.ForeColor = Color.White;
            deleteCustomerButton.Location = new Point(153, 130);
            deleteCustomerButton.Margin = new Padding(3, 6, 3, 3);
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.Size = new Size(294, 53);
            deleteCustomerButton.TabIndex = 10;
            deleteCustomerButton.Text = "Delete Customer";
            deleteCustomerButton.UseVisualStyleBackColor = false;
            deleteCustomerButton.Click += deleteCustomerButton_Click;
            // 
            // updateCustomerButton
            // 
            updateCustomerButton.BackColor = Color.FromArgb(255, 192, 128);
            updateCustomerButton.Cursor = Cursors.Hand;
            updateCustomerButton.Dock = DockStyle.Fill;
            updateCustomerButton.ForeColor = Color.White;
            updateCustomerButton.Location = new Point(153, 68);
            updateCustomerButton.Margin = new Padding(3, 6, 3, 3);
            updateCustomerButton.Name = "updateCustomerButton";
            updateCustomerButton.Size = new Size(294, 53);
            updateCustomerButton.TabIndex = 7;
            updateCustomerButton.Text = "Update Customer";
            updateCustomerButton.UseVisualStyleBackColor = false;
            updateCustomerButton.Click += updateCustomerButton_Click;
            // 
            // newCustomerButton
            // 
            newCustomerButton.BackColor = Color.FromArgb(255, 192, 128);
            newCustomerButton.Cursor = Cursors.Hand;
            newCustomerButton.Dock = DockStyle.Fill;
            newCustomerButton.ForeColor = Color.White;
            newCustomerButton.Location = new Point(153, 6);
            newCustomerButton.Margin = new Padding(3, 6, 3, 3);
            newCustomerButton.Name = "newCustomerButton";
            newCustomerButton.Size = new Size(294, 53);
            newCustomerButton.TabIndex = 4;
            newCustomerButton.Text = "Add New Customer";
            newCustomerButton.UseVisualStyleBackColor = false;
            newCustomerButton.Click += newCustomerButton_Click;
            // 
            // CustomerUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CustomerUI";
            Size = new Size(600, 407);
            Resize += CustomerUI_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label customerTitleLabel;
        private TableLayoutPanel buttonsPanel;
        private Button viewAllCustomersButton;
        private Button deleteCustomerButton;
        private Button updateCustomerButton;
        private Button newCustomerButton;
        private Button exitButton;
        private Button advanceSearchButton;
    }
}
