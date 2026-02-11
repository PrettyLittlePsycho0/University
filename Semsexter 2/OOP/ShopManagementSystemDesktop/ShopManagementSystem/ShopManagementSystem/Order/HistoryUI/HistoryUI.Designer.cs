namespace ShopManagementSystem.Order.HistoryUI
{
    partial class HistoryUI
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
            allHistoryButton = new Button();
            customerHistoryButton = new Button();
            exitButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            buttonsPanel.SuspendLayout();
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
            tableLayoutPanel1.TabIndex = 1;
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
            titleLabel.Text = "Order History";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 3;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.Controls.Add(allHistoryButton, 1, 0);
            buttonsPanel.Controls.Add(customerHistoryButton, 1, 1);
            buttonsPanel.Controls.Add(exitButton, 0, 3);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonsPanel.Location = new Point(0, 60);
            buttonsPanel.Margin = new Padding(0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 4;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            buttonsPanel.Size = new Size(600, 340);
            buttonsPanel.TabIndex = 1;
            // 
            // allHistoryButton
            // 
            allHistoryButton.BackColor = Color.FromArgb(255, 192, 128);
            allHistoryButton.Dock = DockStyle.Fill;
            allHistoryButton.ForeColor = Color.White;
            allHistoryButton.Location = new Point(153, 3);
            allHistoryButton.Name = "allHistoryButton";
            allHistoryButton.Size = new Size(294, 96);
            allHistoryButton.TabIndex = 0;
            allHistoryButton.Text = "All History";
            allHistoryButton.UseVisualStyleBackColor = false;
            allHistoryButton.Click += allHistoryButton_Click;
            // 
            // customerHistoryButton
            // 
            customerHistoryButton.BackColor = Color.FromArgb(255, 192, 128);
            customerHistoryButton.Dock = DockStyle.Fill;
            customerHistoryButton.ForeColor = Color.White;
            customerHistoryButton.Location = new Point(153, 105);
            customerHistoryButton.Name = "customerHistoryButton";
            customerHistoryButton.Size = new Size(294, 96);
            customerHistoryButton.TabIndex = 1;
            customerHistoryButton.Text = "Customer History";
            customerHistoryButton.UseVisualStyleBackColor = false;
            customerHistoryButton.Click += customerHistoryButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 128);
            exitButton.Dock = DockStyle.Fill;
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(3, 309);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(144, 28);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // HistoryUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "HistoryUI";
            Size = new Size(600, 400);
            Resize += HistoryUI_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label titleLabel;
        private TableLayoutPanel buttonsPanel;
        private Button allHistoryButton;
        private Button customerHistoryButton;
        private Button exitButton;
    }
}
