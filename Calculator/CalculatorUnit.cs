using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorUnit
    {
        private double storedOperand;
        private string storedOperation;
        private string currentInput;
        private string _warningLabelText;

        public void Reset()
        {
            storedOperand = 0;
            storedOperation = null;
            currentInput = "";
            _warningLabelText = string.Empty;
        }

        public void EnterNumber(char digit)
        {
            if (char.IsDigit(digit) || digit == '.')
            {
                currentInput += digit;
                _warningLabelText = string.Empty;
            }
        }

        public void EnterDecimal()
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
            }
        }
        public void EnterOperation(string operation)
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

        public void PerformCalculation()
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
                        }
                        break;
                }
                storedOperand = Math.Round(storedOperand, 8);

                storedOperation = null;
                currentInput = storedOperand.ToString();
            }
        }

        public string GetDisplayText()
        {
            return $"{storedOperand} {storedOperation}";
        }

        public string GetBinaryDisplay()
        {
            if (double.TryParse(currentInput, out double decimalNumber))
            {
                string binaryRepresentation = Convert.ToString((long)decimalNumber, 2);

                if (binaryRepresentation.Length > 8)
                {
                    return "OUT OF RNG";
                }

                return binaryRepresentation.PadLeft(8, '0');
            }
            else
            {
                return "OUT OF RNG";
            }
        }

        public string GetHexadecimalDisplay()
        {
            if (double.TryParse(currentInput, out double decimalNumber))
            {
                string hexadecimalRepresentation = Convert.ToString((long)decimalNumber, 16).ToUpper();

                if (hexadecimalRepresentation.Length > 8)
                {
                    return "OUT OF RNG";
                }

                return hexadecimalRepresentation.PadLeft(8, '0');
            }
            else
            {
                return "OUT OF RNG";
            }
        }

        public string GetWarningLabelText()
        {
            return _warningLabelText;
        }

    }
}
