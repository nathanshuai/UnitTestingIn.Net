using Calculator;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void PerformCalculation_Addition_ValidOperands_ShouldReturnCorrectValue()
        {
            // Arrange
            CalculatorUnit calculator = new CalculatorUnit();
            calculator.EnterNumber('5');
            calculator.EnterOperation("+");
            calculator.EnterNumber('3');         

            // Act
            calculator.PerformCalculation();

            // Assert
            Assert.AreEqual("8", calculator.GetDisplayText());
        }

        [TestMethod]
        public void PerformCalculation_Subtraction_ValidOperands_ShouldReturnCorrectValue()
        {
            // Arrange
            CalculatorUnit calculator = new CalculatorUnit();
            calculator.EnterNumber('8');
            calculator.EnterOperation("-");
            calculator.EnterNumber('3');

            // Act
            calculator.PerformCalculation();

            // Assert
            Assert.AreEqual("5", calculator.GetDisplayText());
        }

        [TestMethod]
        public void PerformCalculation_DivisionByZero_ShouldSetWarningLabelText()
        {
            // Arrange
            CalculatorUnit calculator = new CalculatorUnit();
            calculator.EnterNumber('5');
            calculator.EnterOperation("/");
            calculator.EnterNumber('0');

            // Act
            calculator.PerformCalculation();
            const string Result_Message = "Error: Division by zero";
            // Assert
            Assert.AreEqual(Result_Message, calculator.GetWarningLabelText());
        }

        [TestMethod]

        public void GetBinaryDisplay_ConvertTheNumberToBinary_ReturnBinaryRepresentation()
        {
            //Arrange 

            CalculatorUnit calculator = new CalculatorUnit();

            calculator.EnterNumber('7');

            //Act
            string binaryRepresentation = "00000111";
           calculator.GetBinaryDisplay();

            //Assert
            Assert.AreEqual(binaryRepresentation, calculator.GetBinaryDisplay());

        }
        [TestMethod]
        public void GetHexadecimalDisplay_ConvertTheNumberToHexadecimal_ReturnHexadecimalRepresentation()
        {
            //Arrange 

            CalculatorUnit calculator = new CalculatorUnit();

            calculator.EnterNumber('7');

            //Act
            string hexadecimalRepresentation = "00000007";
            calculator.GetHexadecimalDisplay();

            //Assert
            Assert.AreEqual(hexadecimalRepresentation, calculator.GetHexadecimalDisplay());

        }

    }
}