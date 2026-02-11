namespace ShopManagementSystem.Product.UI
{
    partial class ViewAllProducts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            viewTitleLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            productsGrid = new DataGridView();
            buttonsPanel = new TableLayoutPanel();
            exitButton = new Button();
            loadButton = new Button();
            statusLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(viewTitleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(600, 400);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Click += exitButton_Click;
            // 
            // viewTitleLabel
            // 
            viewTitleLabel.AutoSize = true;
            viewTitleLabel.BackColor = Color.SaddleBrown;
            viewTitleLabel.Dock = DockStyle.Fill;
            viewTitleLabel.ForeColor = Color.White;
            viewTitleLabel.Location = new Point(0, 0);
            viewTitleLabel.Margin = new Padding(0);
            viewTitleLabel.Name = "viewTitleLabel";
            viewTitleLabel.Size = new Size(600, 60);
            viewTitleLabel.TabIndex = 0;
            viewTitleLabel.Text = "View All Products";
            viewTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            viewTitleLabel.Click += exitButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(productsGrid, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonsPanel, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 60);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(600, 340);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Click += exitButton_Click;
            // 
            // productsGrid
            // 
            productsGrid.AllowUserToAddRows = false;
            productsGrid.AllowUserToDeleteRows = false;
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            productsGrid.BackgroundColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Dock = DockStyle.Fill;
            productsGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            productsGrid.Location = new Point(0, 0);
            productsGrid.Margin = new Padding(0);
            productsGrid.Name = "productsGrid";
            productsGrid.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle2.ForeColor = Color.White;
            productsGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            productsGrid.Size = new Size(600, 306);
            productsGrid.TabIndex = 2;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 3;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsPanel.Controls.Add(exitButton, 0, 0);
            buttonsPanel.Controls.Add(loadButton, 2, 0);
            buttonsPanel.Controls.Add(statusLabel, 1, 0);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonsPanel.Location = new Point(0, 306);
            buttonsPanel.Margin = new Padding(0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonsPanel.Size = new Size(600, 34);
            buttonsPanel.TabIndex = 3;
            buttonsPanel.Click += exitButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 128);
            exitButton.Dock = DockStyle.Fill;
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(3, 3);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(144, 28);
            exitButton.TabIndex = 0;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.FromArgb(255, 192, 128);
            loadButton.Dock = DockStyle.Fill;
            loadButton.ForeColor = Color.White;
            loadButton.Location = new Point(453, 3);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(144, 28);
            loadButton.TabIndex = 1;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Location = new Point(153, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(294, 34);
            statusLabel.TabIndex = 2;
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewAllProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ViewAllProducts";
            Size = new Size(600, 400);
            Resize += ViewAllProducts_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label viewTitleLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView productsGrid;
        private TableLayoutPanel buttonsPanel;
        private Button exitButton;
        private Button loadButton;
        private Label statusLabel;
    }
}
