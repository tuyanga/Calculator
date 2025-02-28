using CalculatorLibrary.Calculatorfoler;

namespace TestCalculator;

[TestClass]
public class CalculatorTests
{
    private Calculator? calculator;

    [TestInitialize]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [TestMethod]
    public void Add_ShouldIncreaseResult()
    {
        calculator.Add(5);
        Assert.AreEqual(5, calculator.Result);
    }

    [TestMethod]
    public void Sub_ShouldDecreaseResult()
    {
        calculator.Sub(3);
        Assert.AreEqual(-3, calculator.Result);
    }

    [TestMethod]
    public void MultipleOperations_ShouldProduceCorrectResult()
    {
        calculator.Add(6);
        calculator.Sub(2);
        calculator.Add(4);
        Assert.AreEqual(8, calculator.Result);
    }

    [TestMethod]
    public void MemoryOperations_ShouldWorkCorrectly()
    {
        calculator.Add(10);
        calculator.MSave();
        calculator.MAdd(5);
        calculator.MSub(3);
        Assert.AreEqual(12, calculator.MRecall());
    }
}
