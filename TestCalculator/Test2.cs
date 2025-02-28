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
    public void Add_IncreaseResult()
    {
        calculator.Add(5);
        Assert.AreEqual(5, calculator.Result);
    }

    [TestMethod]
    public void Sub_DecreaseResult()
    {
        calculator.Sub(3);
        Assert.AreEqual(-3, calculator.Result);
    }

    [TestMethod]
    public void MultipleOp_CorrectResult()
    {
        calculator.Add(6);
        calculator.Sub(2);
        calculator.Add(4);
        Assert.AreEqual(8, calculator.Result);
    }

    [TestMethod]
    public void MemoryOp_CorrectResult()
    {
        calculator.Add(10);
        calculator.MSave();
        calculator.MAdd(5);
        calculator.MSub(3);
        Assert.AreEqual(12, calculator.MRecall());
    }
    [TestMethod]
    public void MSave_StoreZero()
    {
        calculator.MSave();
        Assert.AreEqual(0, calculator.MRecall());
    }

    [TestMethod]
    public void MClear_ClearMemory()
    {
        calculator.Add(10);
        calculator.MSave();
        calculator.MClear();
        Assert.AreEqual(0, calculator.MRecall());
    }

}
