namespace Calculator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            equalButton = new Button();
            pointButton = new Button();
            zeroButton = new Button();
            negateButton = new Button();
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(equalButton, 3, 4);
            tableLayoutPanel3.Controls.Add(pointButton, 2, 4);
            tableLayoutPanel3.Controls.Add(zeroButton, 1, 4);
            tableLayoutPanel3.Controls.Add(negateButton, 0, 4);
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
            tableLayoutPanel3.Location = new Point(3, 156);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(354, 378);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // equalButton
            // 
            equalButton.Dock = DockStyle.Fill;
            equalButton.Location = new Point(267, 303);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(84, 72);
            equalButton.TabIndex = 19;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = true;
            // 
            // pointButton
            // 
            pointButton.Dock = DockStyle.Fill;
            pointButton.Location = new Point(179, 303);
            pointButton.Name = "pointButton";
            pointButton.Size = new Size(82, 72);
            pointButton.TabIndex = 18;
            pointButton.Text = ".";
            pointButton.UseVisualStyleBackColor = true;
            // 
            // zeroButton
            // 
            zeroButton.Dock = DockStyle.Fill;
            zeroButton.Location = new Point(91, 303);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(82, 72);
            zeroButton.TabIndex = 17;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            // 
            // negateButton
            // 
            negateButton.Dock = DockStyle.Fill;
            negateButton.Location = new Point(3, 303);
            negateButton.Name = "negateButton";
            negateButton.Size = new Size(82, 72);
            negateButton.TabIndex = 16;
            negateButton.Text = "+/-";
            negateButton.UseVisualStyleBackColor = true;
            // 
            // plusButton
            // 
            plusButton.Dock = DockStyle.Fill;
            plusButton.Location = new Point(267, 228);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(84, 69);
            plusButton.TabIndex = 15;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            // 
            // threeButton
            // 
            threeButton.Dock = DockStyle.Fill;
            threeButton.Location = new Point(179, 228);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(82, 69);
            threeButton.TabIndex = 14;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            // 
            // twoButton
            // 
            twoButton.Dock = DockStyle.Fill;
            twoButton.Location = new Point(91, 228);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(82, 69);
            twoButton.TabIndex = 13;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            // 
            // oneButton
            // 
            oneButton.Dock = DockStyle.Fill;
            oneButton.Location = new Point(3, 228);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(82, 69);
            oneButton.TabIndex = 12;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            // 
            // minusButton
            // 
            minusButton.Dock = DockStyle.Fill;
            minusButton.Location = new Point(267, 153);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(84, 69);
            minusButton.TabIndex = 11;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            // 
            // sixButton
            // 
            sixButton.Dock = DockStyle.Fill;
            sixButton.Location = new Point(179, 153);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(82, 69);
            sixButton.TabIndex = 10;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            // 
            // fiveButton
            // 
            fiveButton.Dock = DockStyle.Fill;
            fiveButton.Location = new Point(91, 153);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(82, 69);
            fiveButton.TabIndex = 9;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            // 
            // fourButton
            // 
            fourButton.Dock = DockStyle.Fill;
            fourButton.Location = new Point(3, 153);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(82, 69);
            fourButton.TabIndex = 8;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            multiplyButton.Dock = DockStyle.Fill;
            multiplyButton.Location = new Point(267, 78);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(84, 69);
            multiplyButton.TabIndex = 7;
            multiplyButton.Text = "×";
            multiplyButton.UseVisualStyleBackColor = true;
            // 
            // nineButton
            // 
            nineButton.Dock = DockStyle.Fill;
            nineButton.Location = new Point(179, 78);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(82, 69);
            nineButton.TabIndex = 6;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            // 
            // eightButton
            // 
            eightButton.Dock = DockStyle.Fill;
            eightButton.Location = new Point(91, 78);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(82, 69);
            eightButton.TabIndex = 5;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            // 
            // sevenButton
            // 
            sevenButton.Dock = DockStyle.Fill;
            sevenButton.Location = new Point(3, 78);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(82, 69);
            sevenButton.TabIndex = 4;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            divideButton.Dock = DockStyle.Fill;
            divideButton.Location = new Point(267, 3);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(84, 69);
            divideButton.TabIndex = 3;
            divideButton.Text = "÷";
            divideButton.UseVisualStyleBackColor = true;
            // 
            // backSpaceButton
            // 
            backSpaceButton.Dock = DockStyle.Fill;
            backSpaceButton.Location = new Point(179, 3);
            backSpaceButton.Name = "backSpaceButton";
            backSpaceButton.Size = new Size(82, 69);
            backSpaceButton.TabIndex = 2;
            backSpaceButton.Text = "⌫";
            backSpaceButton.UseVisualStyleBackColor = true;
            // 
            // closeBracketButton
            // 
            closeBracketButton.Dock = DockStyle.Fill;
            closeBracketButton.Location = new Point(91, 3);
            closeBracketButton.Name = "closeBracketButton";
            closeBracketButton.Size = new Size(82, 69);
            closeBracketButton.TabIndex = 1;
            closeBracketButton.Text = ")";
            closeBracketButton.UseVisualStyleBackColor = true;
            // 
            // openBracketButton
            // 
            openBracketButton.Dock = DockStyle.Fill;
            openBracketButton.Location = new Point(3, 3);
            openBracketButton.Name = "openBracketButton";
            openBracketButton.Size = new Size(82, 69);
            openBracketButton.TabIndex = 0;
            openBracketButton.Text = "(";
            openBracketButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(360, 153);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(0, 76);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 71);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 71);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(400, 600);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button equalButton;
        private Button pointButton;
        private Button zeroButton;
        private Button negateButton;
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
    }
}