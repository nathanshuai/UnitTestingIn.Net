namespace Calculator
{
    public partial class Form1 : Form
    {
        private CalculatorUnit calculator;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            calculator = new CalculatorUnit();
            ResetCalculator();
            KeyPress += Form1_KeyPress;
        }

        private void ResetCalculator()
        {
            calculator.Reset();
            UpdateDisplay();
            ClearInputPanels();
        }

        private void ClearInputPanels()
        {
            if (displayPanel != null)
            {
                displayPanel.Text = "";
            }

            if (inputPanel != null)
            {
                inputPanel.Text = "";
            }
        }

        private void OnNumberButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char digit = button.Text[0];
            calculator.EnterNumber(digit);
            UpdateDisplay();
        }

        private void HandleOperation(string operation)
        {
            calculator.EnterOperation(operation);
            UpdateDisplay();
        }

        private void OperationButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string operation = button.Text;

            HandleOperation(operation);
            UpdateDisplay();
        }

        private void DecimalButtonClick(object sender, EventArgs e)
        {

            calculator.EnterDecimal();
            UpdateDisplay();
        }


        private void PerformCalculation()
        {
            calculator.PerformCalculation();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            if (displayPanel != null)
            {
                displayPanel.Text = calculator.GetDisplayText();
            }

            if (binaryDisplay != null)
            {
                binaryDisplay.Text = calculator.GetBinaryDisplay();
            }

            if (hexDisplay != null)
            {
                hexDisplay.Text = calculator.GetHexadecimalDisplay();
            }

            if (inputPanel != null)
            {
                inputPanel.Text = calculator.GetDisplayText();
            }

            WarningLabelText.Text = calculator.GetWarningLabelText();
        }

        private string ConvertToBinary(string value)
        {
            try
            {
                if (int.TryParse(value, out int decimalNumber))
                {
                    string binaryRepresentation = Convert.ToString(decimalNumber, 2);

                    if (binaryRepresentation.Length > 8)
                    {
                        return "OUT OF RNG";
                    }

                    return binaryRepresentation.PadLeft(8, '0');
                }
                else
                {

                    throw new ArgumentException("Invalid input. Not a valid integer.", nameof(value));
                }
            }
            catch (Exception)
            {
                return "OUT OF RNG";
            }
        }



        private string ConvertToHexadecimal(string value)
        {
            try
            {
                if (int.TryParse(value, out int decimalNumber))
                {
                    string hexadecimalRepresentation = Convert.ToString(decimalNumber, 16).ToUpper();


                    if (hexadecimalRepresentation.Length > 8)
                    {
                        return "OUT OF RNG";
                    }

                    return hexadecimalRepresentation.PadLeft(8, '0');
                }
                else
                {

                    throw new ArgumentException("Invalid input. Not a valid integer.", nameof(value));
                };
            }
            catch (Exception)
            {
                return "OUT OF RNG";
            }
        }


        private void OnEqualsButtonClick(object sender, EventArgs e)
        {
            PerformCalculation();
            UpdateDisplay();
        }

        private void OnClearButtonClick(object sender, EventArgs e)
        {

            ResetCalculator();
            this.Focus();

        }


        private void HandleKeyPress(char keyPressed)
        {
            if (keyPressed == '.')
            {
                calculator.EnterDecimal();
            }
            else
            {
                string key = keyPressed.ToString();

                if (char.IsDigit(key[0]))
                {
                    WarningLabelText.Text = string.Empty;
                    calculator.EnterNumber(key[0]);
                }
                else if (key == "+" || key == "-" || key == "*" || key == "/")
                {
                    HandleOperation(key);
                }
                else if (key == "=" || key == "\r")
                {
                    PerformCalculation();
                }
                else
                {
                    WarningLabelText.Text = calculator.GetWarningLabelText();
                }
            }

            UpdateDisplay();
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle keypress event for the entire form
            HandleKeyPress(e.KeyChar);

        }

    }
}