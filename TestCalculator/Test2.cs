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
    // 1. Calculator Operations
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
    // 2. Memory Operations
    [TestMethod]
    public void Memory_CheckOrder()
    {
        calculator.Result = 5;
        calculator.MSave();
        calculator.Result = 15;
        calculator.MSave();
        calculator.Result = 25;
        calculator.MSave();
    
        List<int> memoryValues = calculator.Memory.Select(m => m.Value).ToList();
        
        CollectionAssert.AreEqual(new List<int> { 5, 15, 25 }, memoryValues);
    }
    [TestMethod]
    public void Memory_Add_Subtract_SpecificItems()
    {
        calculator.Result = 5;
        calculator.MSave();
        calculator.Result = 15;
        calculator.MSave();
        calculator.Result = 25;
        calculator.MSave();
    
        calculator.Memory[0].MAdd(10);
        calculator.Memory[0].MSub(2);
        Assert.AreEqual(13, calculator.Memory[0].Value);

        calculator.Memory[1].MAdd(5);
        calculator.Memory[1].MSub(3);
        Assert.AreEqual(17, calculator.Memory[1].Value);
        

        calculator.Memory[2].MAdd(20);
        calculator.Memory[2].MSub(5);
        Assert.AreEqual(40, calculator.Memory[2].Value);

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
        calculator.Result=0;
        calculator.MSave();
        calculator.MClear();
        Assert.AreEqual(0, calculator.MRecall());
    }
    [TestMethod]
    public void ComplexOp_CorrectResult()
    {
        calculator.Add(10);
        calculator.Sub(5);
        calculator.Add(20);
        calculator.Sub(10);
        Assert.AreEqual(15, calculator.Result);
    }


}
