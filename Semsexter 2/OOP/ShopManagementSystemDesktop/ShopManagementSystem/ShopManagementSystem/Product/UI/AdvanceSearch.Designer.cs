namespace ShopManagementSystem.Product.UI
{
    partial class AdvanceSearch
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
            statusLabel = new Label();
            resultsDataGrid = new DataGridView();
            exitButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            modeLabel = new Label();
            Label = new Label();
            modesComboBox = new ComboBox();
            textBox = new TextBox();
            searchButton = new Button();
            advanceSearchTitleLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGrid).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonsPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(advanceSearchTitleLabel, 0, 0);
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
            buttonsPanel.Controls.Add(statusLabel, 1, 2);
            buttonsPanel.Controls.Add(resultsDataGrid, 1, 1);
            buttonsPanel.Controls.Add(exitButton, 0, 2);
            buttonsPanel.Controls.Add(tableLayoutPanel3, 1, 0);
            buttonsPanel.Controls.Add(searchButton, 2, 2);
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(modeLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(Label, 1, 0);
            tableLayoutPanel3.Controls.Add(modesComboBox, 0, 1);
            tableLayoutPanel3.Controls.Add(textBox, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(90, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(420, 68);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // modeLabel
            // 
            modeLabel.AutoSize = true;
            modeLabel.BackColor = Color.Transparent;
            modeLabel.Dock = DockStyle.Fill;
            modeLabel.ForeColor = Color.SaddleBrown;
            modeLabel.Location = new Point(0, 0);
            modeLabel.Margin = new Padding(0);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new Size(210, 34);
            modeLabel.TabIndex = 0;
            modeLabel.Text = "Mode";
            modeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Dock = DockStyle.Fill;
            Label.ForeColor = Color.SaddleBrown;
            Label.Location = new Point(210, 0);
            Label.Margin = new Padding(0);
            Label.Name = "Label";
            Label.Size = new Size(210, 34);
            Label.TabIndex = 1;
            Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modesComboBox
            // 
            modesComboBox.BackColor = Color.FromArgb(255, 192, 128);
            modesComboBox.Dock = DockStyle.Fill;
            modesComboBox.FormattingEnabled = true;
            modesComboBox.Location = new Point(0, 34);
            modesComboBox.Margin = new Padding(0);
            modesComboBox.Name = "modesComboBox";
            modesComboBox.Size = new Size(210, 23);
            modesComboBox.TabIndex = 2;
            modesComboBox.SelectedIndexChanged += modesComboBox_SelectedIndexChanged;
            // 
            // textBox
            // 
            textBox.BackColor = Color.FromArgb(255, 192, 128);
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(210, 34);
            textBox.Margin = new Padding(0);
            textBox.Name = "textBox";
            textBox.Size = new Size(210, 24);
            textBox.TabIndex = 3;
            textBox.TextAlign = HorizontalAlignment.Center;
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
            // advanceSearchTitleLabel
            // 
            advanceSearchTitleLabel.AutoSize = true;
            advanceSearchTitleLabel.BackColor = Color.SaddleBrown;
            advanceSearchTitleLabel.Dock = DockStyle.Fill;
            advanceSearchTitleLabel.ForeColor = Color.White;
            advanceSearchTitleLabel.Location = new Point(0, 0);
            advanceSearchTitleLabel.Margin = new Padding(0);
            advanceSearchTitleLabel.Name = "advanceSearchTitleLabel";
            advanceSearchTitleLabel.Size = new Size(600, 60);
            advanceSearchTitleLabel.TabIndex = 1;
            advanceSearchTitleLabel.Text = "Advance Search";
            advanceSearchTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdvanceSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AdvanceSearch";
            Size = new Size(600, 400);
            Resize += AdvanceSearch_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGrid).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel buttonsPanel;
        private Label advanceSearchTitleLabel;
        private DataGridView resultsDataGrid;
        private Button exitButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Label modeLabel;
        private Label Label;
        private ComboBox modesComboBox;
        private TextBox textBox;
        private Button searchButton;
        private Label statusLabel;
    }
}
