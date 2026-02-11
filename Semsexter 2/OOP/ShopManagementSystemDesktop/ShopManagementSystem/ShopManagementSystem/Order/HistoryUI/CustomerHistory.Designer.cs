namespace ShopManagementSystem.Order.HistoryUI
{
    partial class CustomerHistory
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
            buttonsPanel = new TableLayoutPanel();
            statusLabel = new Label();
            resultsDataGrid = new DataGridView();
            exitButton = new Button();
            searchButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            idLabel = new Label();
            idTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            titleLabel = new Label();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGrid).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 3;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            buttonsPanel.Controls.Add(statusLabel, 1, 2);
            buttonsPanel.Controls.Add(resultsDataGrid, 1, 1);
            buttonsPanel.Controls.Add(exitButton, 0, 2);
            buttonsPanel.Controls.Add(searchButton, 2, 2);
            buttonsPanel.Controls.Add(tableLayoutPanel2, 1, 0);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonsPanel.Location = new Point(0, 60);
            buttonsPanel.Margin = new Padding(0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 3;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonsPanel.Size = new Size(600, 340);
            buttonsPanel.TabIndex = 0;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.ForeColor = Color.Black;
            statusLabel.Location = new Point(93, 306);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(414, 34);
            statusLabel.TabIndex = 45;
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultsDataGrid
            // 
            resultsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultsDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            resultsDataGrid.BackgroundColor = Color.LightGreen;
            resultsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGrid.Dock = DockStyle.Fill;
            resultsDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            resultsDataGrid.GridColor = Color.FromArgb(255, 192, 128);
            resultsDataGrid.Location = new Point(90, 68);
            resultsDataGrid.Margin = new Padding(0);
            resultsDataGrid.Name = "resultsDataGrid";
            resultsDataGrid.ReadOnly = true;
            resultsDataGrid.Size = new Size(420, 238);
            resultsDataGrid.TabIndex = 0;
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
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(255, 192, 128);
            searchButton.Dock = DockStyle.Fill;
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(513, 309);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(84, 28);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(idLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(idTextBox, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(90, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(420, 68);
            tableLayoutPanel2.TabIndex = 46;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Dock = DockStyle.Fill;
            idLabel.Location = new Point(3, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(414, 34);
            idLabel.TabIndex = 0;
            idLabel.Text = "Enter Customer ID:";
            idLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idTextBox
            // 
            idTextBox.BackColor = Color.FromArgb(255, 192, 128);
            idTextBox.Dock = DockStyle.Fill;
            idTextBox.Location = new Point(3, 37);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(414, 24);
            idTextBox.TabIndex = 1;
            idTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonsPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(titleLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(600, 400);
            tableLayoutPanel1.TabIndex = 2;
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
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Customer History";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CustomerHistory";
            Size = new Size(600, 400);
            Resize += CustomerHistory_Resize;
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGrid).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel buttonsPanel;
        private Label statusLabel;
        private DataGridView resultsDataGrid;
        private Button exitButton;
        private Button searchButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label titleLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label idLabel;
        private TextBox idTextBox;
    }
}
