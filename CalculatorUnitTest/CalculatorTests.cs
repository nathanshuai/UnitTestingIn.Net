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

            // Assert
            Assert.AreEqual("Error: Division by zero", calculator.GetWarningLabelText());
        }

    }
}