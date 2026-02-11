using System.Data;
using System.Text.RegularExpressions;
namespace Calculator
{
    public partial class MainForm : Form
    {
        private readonly float _originalFontSize;
        private readonly int _originalFormHeight;
        public MainForm()
        {
            InitializeComponent();
            _originalFontSize = resultTextBox.Font.Size;
            _originalFormHeight = this.Height;
        }

        private string eval(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
            {
                return "";
            }
            string cleanedExpression = expression.Replace('×', '*').Replace('÷', '/').Trim();

            if (!Regex.IsMatch(cleanedExpression, @"^[0-9+\-*/().\s]+$"))
            {
                return "Invalid Characters.";
            }

            try
            {
                using (DataTable dataTable = new DataTable())
                {
                    var result = dataTable.Compute(cleanedExpression, null);

                    if (result == null || result is DBNull)
                    {
                        return "";
                    }
                    double value = Convert.ToDouble(result);
                    if (double.IsNaN(value))
                    {
                        return "Math Error.";
                    }
                    return value.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                return "Syntax Error.";
            }
            catch (EvaluateException)
            {
                return "Math Error.";
            }
            catch (Exception)
            {
                return "Error.";
            }
        }

        private void insertChar(char ch)
        {
            inputTextBox.Text += ch;
        }

        private void openBracketButton_Click(object sender, EventArgs e)
        {
            insertChar('(');
        }

        private void closeBracketButton_Click(object sender, EventArgs e)
        {
            insertChar(')');
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0)
            {
                inputTextBox.Text = inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1);
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            insertChar('÷');
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            insertChar('7');
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            insertChar('8');
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            insertChar('9');
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            insertChar('×');
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            insertChar('4');
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            insertChar('5');
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            insertChar('6');
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            insertChar('-');
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            insertChar('1');
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            insertChar('2');
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            insertChar('3');
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            insertChar('+');
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            insertChar('0');
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            insertChar('.');
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = eval(inputTextBox.Text);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                return;
            }
            float scaleFactor = (float)this.Height / _originalFormHeight;
            float newSize = (_originalFontSize * scaleFactor) + (_originalFontSize * scaleFactor * 0.1f);
            inputTextBox.Font = new Font(inputTextBox.Font.FontFamily, newSize, inputTextBox.Font.Style);
            resultTextBox.Font = new Font(resultTextBox.Font.FontFamily, newSize, resultTextBox.Font.Style);
            tableLayoutPanel3.Font = new Font(tableLayoutPanel3.Font.FontFamily, newSize * 0.50f, tableLayoutPanel3.Font.Style);
        }

        private void allClearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = string.Empty;
            resultTextBox.Text = string.Empty;
        }
    }
}
