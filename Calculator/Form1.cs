namespace Calculator
{
    public partial class Form1 : Form
    {
        private double storedOperand;
        private string storedOperation;
        private string currentInput;
        private string _warningLabelText;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            ResetCalculator();
            KeyPress += Form1_KeyPress;
        }

        private void ResetCalculator()
        {
            storedOperand = 0;
            storedOperation = null;
            currentInput = "";
            UpdateDisplay();
            ClearInputPanels();
            WarningLabelText.Text = string.Empty;
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
            string buttonText = button.Text;

            if (char.IsDigit(buttonText[0]) || buttonText == ".")
            {
                currentInput += buttonText;
                WarningLabelText.Text = string.Empty;
            }
            else
            {
                HandleOperation(buttonText);
            }

            UpdateDisplay();
        }

        private void HandleOperation(string operation)
        {
            if (!string.IsNullOrEmpty(storedOperation))
            {
                PerformCalculation();
            }

            if (!string.IsNullOrEmpty(currentInput))
            {
                storedOperand = double.Parse(currentInput);
                storedOperation = operation;
                currentInput = "";
            }
            else
            {
                storedOperation = operation;
            }
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

            if (!currentInput.Contains("."))
            {
                currentInput += ".";
            }

            UpdateDisplay();
        }


        private void PerformCalculation()
        {
            if (!string.IsNullOrEmpty(storedOperation) && !string.IsNullOrEmpty(currentInput))
            {
                double currentInputValue = double.Parse(currentInput);

                switch (storedOperation)
                {
                    case "+":
                        storedOperand += currentInputValue;
                        break;
                    case "-":
                        storedOperand -= currentInputValue;
                        break;
                    case "*":
                        storedOperand *= currentInputValue;
                        break;
                    case "/":
                        if (currentInputValue != 0)
                        {
                            storedOperand /= currentInputValue;
                        }
                        else
                        {
                            _warningLabelText = "Error: Division by zero";
                            WarningLabelText.Text = _warningLabelText;
                        }
                        break;
                }
                storedOperand = Math.Round(storedOperand, 8);

                storedOperation = null;
                currentInput = storedOperand.ToString();
            }

        }

        private void UpdateDisplay()
        {

            if (displayPanel != null)
            {
                if (!string.IsNullOrEmpty(storedOperation))
                {
                    displayPanel.Text = $"{storedOperand} {storedOperation}";
                }
                else
                {
                    displayPanel.Text = "";
                }
            }

            if (binaryDisplay != null)
            {
                binaryDisplay.Text = ConvertToBinary(currentInput);
            }

            if (hexDisplay != null)
            {
                hexDisplay.Text = ConvertToHexadecimal(currentInput);
            }

            if (inputPanel != null)
            {
                inputPanel.Text = currentInput;
            }

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
            string key = keyPressed.ToString();

            if (char.IsDigit(key[0]) || key == ".")
            {
                WarningLabelText.Text = string.Empty;
                currentInput += key;
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
                _warningLabelText = "Invalid input: Letters are not allowed.";
                WarningLabelText.Text = _warningLabelText;
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