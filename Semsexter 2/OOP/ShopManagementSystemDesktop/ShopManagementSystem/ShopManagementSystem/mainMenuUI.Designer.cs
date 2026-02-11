namespace ShopManagementSystem
{
    partial class mainMenuUI
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
            viewHistoryButton = new Button();
            createOrderButton = new Button();
            customerMenuButton = new Button();
            productMenuButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(titleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonsPanel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(600, 400);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.SaddleBrown;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Margin = new Padding(0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(600, 60);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Shop Management System";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 3;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.Controls.Add(viewHistoryButton, 1, 3);
            buttonsPanel.Controls.Add(createOrderButton, 1, 2);
            buttonsPanel.Controls.Add(customerMenuButton, 1, 1);
            buttonsPanel.Controls.Add(productMenuButton, 1, 0);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
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
            // viewHistoryButton
            // 
            viewHistoryButton.BackColor = Color.FromArgb(255, 192, 128);
            viewHistoryButton.Cursor = Cursors.Hand;
            viewHistoryButton.Dock = DockStyle.Fill;
            viewHistoryButton.Location = new Point(153, 231);
            viewHistoryButton.Name = "viewHistoryButton";
            viewHistoryButton.Size = new Size(294, 70);
            viewHistoryButton.TabIndex = 16;
            viewHistoryButton.Text = "View Order History";
            viewHistoryButton.UseVisualStyleBackColor = false;
            viewHistoryButton.Click += viewHistoryButton_Click;
            // 
            // createOrderButton
            // 
            createOrderButton.BackColor = Color.FromArgb(255, 192, 128);
            createOrderButton.Cursor = Cursors.Hand;
            createOrderButton.Dock = DockStyle.Fill;
            createOrderButton.Location = new Point(153, 155);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(294, 70);
            createOrderButton.TabIndex = 8;
            createOrderButton.Text = "Create New Order";
            createOrderButton.UseVisualStyleBackColor = false;
            createOrderButton.Click += createOrderButton_Click;
            // 
            // customerMenuButton
            // 
            customerMenuButton.BackColor = Color.FromArgb(255, 192, 128);
            customerMenuButton.Cursor = Cursors.Hand;
            customerMenuButton.Dock = DockStyle.Fill;
            customerMenuButton.Location = new Point(153, 79);
            customerMenuButton.Name = "customerMenuButton";
            customerMenuButton.Size = new Size(294, 70);
            customerMenuButton.TabIndex = 5;
            customerMenuButton.Text = "Customer Management";
            customerMenuButton.UseVisualStyleBackColor = false;
            customerMenuButton.Click += customerMenuButton_Click;
            // 
            // productMenuButton
            // 
            productMenuButton.BackColor = Color.FromArgb(255, 192, 128);
            productMenuButton.Cursor = Cursors.Hand;
            productMenuButton.Dock = DockStyle.Fill;
            productMenuButton.Location = new Point(153, 6);
            productMenuButton.Margin = new Padding(3, 6, 3, 3);
            productMenuButton.Name = "productMenuButton";
            productMenuButton.Size = new Size(294, 67);
            productMenuButton.TabIndex = 2;
            productMenuButton.Text = "Product Management";
            productMenuButton.UseVisualStyleBackColor = false;
            productMenuButton.Click += productMenuButton_Click;
            // 
            // mainMenuUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "mainMenuUI";
            Size = new Size(600, 400);
            Resize += mainMenuUI_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label titleLabel;
        private TableLayoutPanel buttonsPanel;
        private Button viewHistoryButton;
        private Button createOrderButton;
        private Button customerMenuButton;
        private Button productMenuButton;
    }
}
