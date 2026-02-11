namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            equalButton = new Button();
            pointButton = new Button();
            zeroButton = new Button();
            allClearButton = new Button();
            plusButton = new Button();
            threeButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            minusButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            multiplyButton = new Button();
            nineButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            divideButton = new Button();
            backSpaceButton = new Button();
            closeBracketButton = new Button();
            openBracketButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            resultTextBox = new TextBox();
            inputTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.Fuchsia;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel1.Size = new Size(360, 537);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.BackColor = Color.FromArgb(255, 147, 126);
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(equalButton, 3, 4);
            tableLayoutPanel3.Controls.Add(pointButton, 2, 4);
            tableLayoutPanel3.Controls.Add(zeroButton, 1, 4);
            tableLayoutPanel3.Controls.Add(allClearButton, 0, 4);
            tableLayoutPanel3.Controls.Add(plusButton, 3, 3);
            tableLayoutPanel3.Controls.Add(threeButton, 2, 3);
            tableLayoutPanel3.Controls.Add(twoButton, 1, 3);
            tableLayoutPanel3.Controls.Add(oneButton, 0, 3);
            tableLayoutPanel3.Controls.Add(minusButton, 3, 2);
            tableLayoutPanel3.Controls.Add(sixButton, 2, 2);
            tableLayoutPanel3.Controls.Add(fiveButton, 1, 2);
            tableLayoutPanel3.Controls.Add(fourButton, 0, 2);
            tableLayoutPanel3.Controls.Add(multiplyButton, 3, 1);
            tableLayoutPanel3.Controls.Add(nineButton, 2, 1);
            tableLayoutPanel3.Controls.Add(eightButton, 1, 1);
            tableLayoutPanel3.Controls.Add(sevenButton, 0, 1);
            tableLayoutPanel3.Controls.Add(divideButton, 3, 0);
            tableLayoutPanel3.Controls.Add(backSpaceButton, 2, 0);
            tableLayoutPanel3.Controls.Add(closeBracketButton, 1, 0);
            tableLayoutPanel3.Controls.Add(openBracketButton, 0, 0);
            tableLayoutPanel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel3.Location = new Point(0, 153);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(360, 384);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // equalButton
            // 
            equalButton.BackColor = Color.FromArgb(163, 215, 138);
            equalButton.Dock = DockStyle.Fill;
            equalButton.ForeColor = Color.White;
            equalButton.Location = new Point(273, 307);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(84, 74);
            equalButton.TabIndex = 19;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = false;
            equalButton.Click += equalButton_Click;
            // 
            // pointButton
            // 
            pointButton.BackColor = Color.FromArgb(163, 215, 138);
            pointButton.Dock = DockStyle.Fill;
            pointButton.ForeColor = Color.White;
            pointButton.Location = new Point(183, 307);
            pointButton.Name = "pointButton";
            pointButton.Size = new Size(84, 74);
            pointButton.TabIndex = 18;
            pointButton.Text = ".";
            pointButton.UseVisualStyleBackColor = false;
            pointButton.Click += pointButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.BackColor = Color.FromArgb(163, 215, 138);
            zeroButton.Dock = DockStyle.Fill;
            zeroButton.ForeColor = Color.White;
            zeroButton.Location = new Point(93, 307);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(84, 74);
            zeroButton.TabIndex = 17;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += zeroButton_Click;
            // 
            // allClearButton
            // 
            allClearButton.BackColor = Color.FromArgb(163, 215, 138);
            allClearButton.Dock = DockStyle.Fill;
            allClearButton.ForeColor = Color.White;
            allClearButton.Location = new Point(3, 307);
            allClearButton.Name = "allClearButton";
            allClearButton.Size = new Size(84, 74);
            allClearButton.TabIndex = 16;
            allClearButton.Text = "AC";
            allClearButton.UseVisualStyleBackColor = false;
            allClearButton.Click += allClearButton_Click;
            // 
            // plusButton
            // 
            plusButton.BackColor = Color.FromArgb(163, 215, 138);
            plusButton.Dock = DockStyle.Fill;
            plusButton.ForeColor = Color.White;
            plusButton.Location = new Point(273, 231);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(84, 70);
            plusButton.TabIndex = 15;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = false;
            plusButton.Click += plusButton_Click;
            // 
            // threeButton
            // 
            threeButton.BackColor = Color.FromArgb(163, 215, 138);
            threeButton.Dock = DockStyle.Fill;
            threeButton.ForeColor = Color.White;
            threeButton.Location = new Point(183, 231);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(84, 70);
            threeButton.TabIndex = 14;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += threeButton_Click;
            // 
            // twoButton
            // 
            twoButton.BackColor = Color.FromArgb(163, 215, 138);
            twoButton.Dock = DockStyle.Fill;
            twoButton.ForeColor = Color.White;
            twoButton.Location = new Point(93, 231);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(84, 70);
            twoButton.TabIndex = 13;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += twoButton_Click;
            // 
            // oneButton
            // 
            oneButton.BackColor = Color.FromArgb(163, 215, 138);
            oneButton.Dock = DockStyle.Fill;
            oneButton.ForeColor = Color.White;
            oneButton.Location = new Point(3, 231);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(84, 70);
            oneButton.TabIndex = 12;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += oneButton_Click;
            // 
            // minusButton
            // 
            minusButton.BackColor = Color.FromArgb(163, 215, 138);
            minusButton.Dock = DockStyle.Fill;
            minusButton.ForeColor = Color.White;
            minusButton.Location = new Point(273, 155);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(84, 70);
            minusButton.TabIndex = 11;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = false;
            minusButton.Click += minusButton_Click;
            // 
            // sixButton
            // 
            sixButton.BackColor = Color.FromArgb(163, 215, 138);
            sixButton.Dock = DockStyle.Fill;
            sixButton.ForeColor = Color.White;
            sixButton.Location = new Point(183, 155);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(84, 70);
            sixButton.TabIndex = 10;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += sixButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.BackColor = Color.FromArgb(163, 215, 138);
            fiveButton.Dock = DockStyle.Fill;
            fiveButton.ForeColor = Color.White;
            fiveButton.Location = new Point(93, 155);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(84, 70);
            fiveButton.TabIndex = 9;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += fiveButton_Click;
            // 
            // fourButton
            // 
            fourButton.BackColor = Color.FromArgb(163, 215, 138);
            fourButton.Dock = DockStyle.Fill;
            fourButton.ForeColor = Color.White;
            fourButton.Location = new Point(3, 155);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(84, 70);
            fourButton.TabIndex = 8;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += fourButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.BackColor = Color.FromArgb(163, 215, 138);
            multiplyButton.Dock = DockStyle.Fill;
            multiplyButton.ForeColor = Color.White;
            multiplyButton.Location = new Point(273, 79);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(84, 70);
            multiplyButton.TabIndex = 7;
            multiplyButton.Text = "×";
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // nineButton
            // 
            nineButton.BackColor = Color.FromArgb(163, 215, 138);
            nineButton.Dock = DockStyle.Fill;
            nineButton.ForeColor = Color.White;
            nineButton.Location = new Point(183, 79);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(84, 70);
            nineButton.TabIndex = 6;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += nineButton_Click;
            // 
            // eightButton
            // 
            eightButton.BackColor = Color.FromArgb(163, 215, 138);
            eightButton.Dock = DockStyle.Fill;
            eightButton.ForeColor = Color.White;
            eightButton.Location = new Point(93, 79);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(84, 70);
            eightButton.TabIndex = 5;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += eightButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.BackColor = Color.FromArgb(163, 215, 138);
            sevenButton.Dock = DockStyle.Fill;
            sevenButton.ForeColor = Color.White;
            sevenButton.Location = new Point(3, 79);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(84, 70);
            sevenButton.TabIndex = 4;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += sevenButton_Click;
            // 
            // divideButton
            // 
            divideButton.BackColor = Color.FromArgb(163, 215, 138);
            divideButton.Dock = DockStyle.Fill;
            divideButton.ForeColor = Color.White;
            divideButton.Location = new Point(273, 3);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(84, 70);
            divideButton.TabIndex = 3;
            divideButton.Text = "÷";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += divideButton_Click;
            // 
            // backSpaceButton
            // 
            backSpaceButton.BackColor = Color.FromArgb(163, 215, 138);
            backSpaceButton.Dock = DockStyle.Fill;
            backSpaceButton.ForeColor = Color.White;
            backSpaceButton.Location = new Point(183, 3);
            backSpaceButton.Name = "backSpaceButton";
            backSpaceButton.Size = new Size(84, 70);
            backSpaceButton.TabIndex = 2;
            backSpaceButton.Text = "⌫";
            backSpaceButton.UseVisualStyleBackColor = false;
            backSpaceButton.Click += backSpaceButton_Click;
            // 
            // closeBracketButton
            // 
            closeBracketButton.BackColor = Color.FromArgb(163, 215, 138);
            closeBracketButton.Dock = DockStyle.Fill;
            closeBracketButton.ForeColor = Color.White;
            closeBracketButton.Location = new Point(93, 3);
            closeBracketButton.Name = "closeBracketButton";
            closeBracketButton.Size = new Size(84, 70);
            closeBracketButton.TabIndex = 1;
            closeBracketButton.Text = ")";
            closeBracketButton.UseVisualStyleBackColor = false;
            closeBracketButton.Click += closeBracketButton_Click;
            // 
            // openBracketButton
            // 
            openBracketButton.BackColor = Color.FromArgb(163, 215, 138);
            openBracketButton.Dock = DockStyle.Fill;
            openBracketButton.ForeColor = Color.White;
            openBracketButton.Location = new Point(3, 3);
            openBracketButton.Name = "openBracketButton";
            openBracketButton.Size = new Size(84, 70);
            openBracketButton.TabIndex = 0;
            openBracketButton.Text = "(";
            openBracketButton.UseVisualStyleBackColor = false;
            openBracketButton.Click += openBracketButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.LavenderBlush;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(resultTextBox, 0, 1);
            tableLayoutPanel2.Controls.Add(inputTextBox, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(360, 153);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // resultTextBox
            // 
            resultTextBox.BackColor = Color.LavenderBlush;
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Dock = DockStyle.Fill;
            resultTextBox.Font = new Font("Segoe UI", 42F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(0, 76);
            resultTextBox.Margin = new Padding(0);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.ScrollBars = ScrollBars.Horizontal;
            resultTextBox.Size = new Size(360, 75);
            resultTextBox.TabIndex = 1;
            resultTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // inputTextBox
            // 
            inputTextBox.BackColor = Color.LavenderBlush;
            inputTextBox.Dock = DockStyle.Fill;
            inputTextBox.Font = new Font("Segoe UI", 42F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputTextBox.Location = new Point(0, 0);
            inputTextBox.Margin = new Padding(0);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(360, 82);
            inputTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 147, 126);
            ClientSize = new Size(384, 561);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MinimumSize = new Size(400, 600);
            Name = "MainForm";
            Text = "Pretty Little Calculator";
            Resize += MainForm_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button equalButton;
        private Button pointButton;
        private Button zeroButton;
        private Button allClearButton;
        private Button plusButton;
        private Button threeButton;
        private Button twoButton;
        private Button oneButton;
        private Button minusButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button multiplyButton;
        private Button nineButton;
        private Button eightButton;
        private Button sevenButton;
        private Button divideButton;
        private Button backSpaceButton;
        private Button closeBracketButton;
        private Button openBracketButton;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox inputTextBox;
        private TextBox resultTextBox;
    }
}
