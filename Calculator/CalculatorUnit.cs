using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorUnit
    {
        public double storedOperand;
        public string storedOperation;
        private double storedValue;

        public double _storedValue
        {
            get
            {
                return storedValue;
            }
            set
            {
                storedValue = value;
            }
        }
        public string currentInput;
        private string _warningLabelText;

        public void Reset()
        {
            storedOperand = 0;
            storedOperation = null;
            currentInput = "";
            storedValue = 0;
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
        public string GetCurrentInput()
        {
            return currentInput;
        }

        public string GetWarningLabelText()
        {
            return _warningLabelText;
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

        public double PerformCalculation()
        {
            if (!string.IsNullOrEmpty(storedOperation) && !string.IsNullOrEmpty(currentInput))
            {
                double currentInputValue = double.Parse(currentInput);

                switch (storedOperation)
                {
                    case "+":
                        storedValue = storedOperand + currentInputValue;
                        break;
                    case "-":
                        storedValue = storedOperand - currentInputValue;
                        break;
                    case "*":
                        storedValue = storedOperand * currentInputValue;
                        break;
                    case "/":
                        if (currentInputValue != 0)
                        {
                            storedValue = storedOperand / currentInputValue;
                        }
                        else
                        {
                            _warningLabelText = "Error: Division by zero";
                        }
                        break;
                }

                storedOperand = 0;
                storedOperation = null;
                currentInput = null;

                // Return the rounded result
                return Math.Round(storedValue, 8);
            }

            // If the calculation doesn't happen, return a default value
            return 0.0;
        }

        public string GetDisplayText()
        {
            if (storedValue != 0)
            {
                return $"{storedValue}";
            }
            else if (storedOperand == 0)
            {
                return $"{currentInput}";
            }
            else
            {
                return $"{storedOperand} {storedOperation} {currentInput}";
            }
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



    }
}
