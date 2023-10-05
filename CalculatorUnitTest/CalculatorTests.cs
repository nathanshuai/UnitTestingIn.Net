using Calculator;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddingNumbers()
        {
            CalculatorUnit calculator = new CalculatorUnit();
            calculator.EnterNumber('5');
            calculator.EnterOperation("+");
            calculator.EnterNumber('3');
            calculator.PerformCalculation();
            Assert.AreEqual("8", calculator.GetDisplayText());
        }

        [TestMethod]
        public void TestSubtractingNumbers()
        {
            CalculatorUnit calculator = new CalculatorUnit();
            calculator.EnterNumber('8');
            calculator.EnterOperation("-");
            calculator.EnterNumber('3');
            calculator.PerformCalculation();
            Assert.AreEqual("5", calculator.GetDisplayText());
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            CalculatorUnit calculator = new CalculatorUnit();
            calculator.EnterNumber('5');
            calculator.EnterOperation("/");
            calculator.EnterNumber('0');
            calculator.PerformCalculation();
            Assert.AreEqual("Error: Division by zero", calculator.GetWarningLabelText());
        }

        [TestMethod]
        public void TestInvalidInput()
        {
            CalculatorUnit calculator = new CalculatorUnit();
            calculator.EnterNumber('A'); // Trying to enter a non-digit
            Assert.AreEqual("Invalid input: Letters are not allowed.", calculator.GetWarningLabelText());
        }
    }
}
