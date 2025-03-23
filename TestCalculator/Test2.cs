using CalculatorLibrary.Calculatorfoler;
using CalculatorLibrary.Memoryfolder;

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

    [TestCleanup]
    public void Cleanup()
    {
        calculator = null;
    }

    // 1. Calculator Operations
    [TestMethod]
    public void Add_IncreaseResult()
    {
        calculator.Add(5);
        Assert.AreEqual(5, calculator.Result);
    }

    [TestMethod]
    public void Add_NegativeResult()
    {
        calculator.Add(-5);
        Assert.AreEqual(-5, calculator.Result);
    }

    [TestMethod]
    public void Sub_DecreaseResult()
    {
        calculator.Sub(3);
        Assert.AreEqual(-3, calculator.Result);
    }

    [TestMethod]
    public void Sub_NegativeResult()
    {
        calculator.Sub(-3);
        Assert.AreEqual(3, calculator.Result);
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
    
        List<int> memoryValues = calculator.memory.memoryList.Select(m => m.Value).ToList();
        
        CollectionAssert.AreEqual(new List<int> { 5, 15, 25 }, memoryValues);
    }

    [TestMethod]
    public void Memory_Add_Sub_OnItems()
    {
        calculator.Result = 5;
        calculator.MSave();
        calculator.Result = 15;
        calculator.MSave();
        calculator.Result = 25;
        calculator.MSave();
    
        calculator.memory.memoryList[0].MAdd(10);
        calculator.memory.memoryList[0].MSub(2);
        Assert.AreEqual(13, calculator.memory.memoryList[0].Value);

        calculator.memory.memoryList[1].MAdd(5);
        calculator.memory.memoryList[1].MSub(3);
        Assert.AreEqual(17, calculator.memory.memoryList[1].Value);

        calculator.memory.memoryList[2].MAdd(20);
        calculator.memory.memoryList[2].MSub(5);
        Assert.AreEqual(40, calculator.memory.memoryList[2].Value);

    }

    [TestMethod]
    public void Memory_Delete_Item()
    {

        calculator.Result = 5;
        calculator.MSave();
        calculator.Result = 15;
        calculator.MSave();
        calculator.Result = 25;
        calculator.MSave();

        Assert.AreEqual(3, calculator.memory.memoryList.Count);

        calculator.memory.memoryList[1].MC(calculator.memory.memoryList);

        List<int> remainingValues = calculator.memory.memoryList.Select(m => m.Value).ToList();
        CollectionAssert.AreEqual(new List<int> { 5, 25 }, remainingValues);
    }

    [TestMethod]
    public void MSave_StoreZero()
    {
        calculator.Result = 0;
        calculator.MSave();
        Assert.AreEqual(0, calculator.memory.memoryList[0].Value);
    }
    [TestMethod]
    public void MSave_StoreNegative()
    {
        calculator.Result = -5;
        calculator.MSave();
        Assert.AreEqual(-5, calculator.memory.memoryList[0].Value);
    }
    [TestMethod]
    public void MClear_ClearMemory()
    {
        calculator.Result=0;
        calculator.MSave();
        calculator.Result = 1;
        calculator.MSave();
        calculator.Result = 2;
        calculator.MSave();

        calculator.memory.MClear();
        List<int> remainingValues = calculator.memory.memoryList.Select(m => m.Value).ToList();
        CollectionAssert.AreEqual(new List<int> {}, remainingValues);
    }
}
