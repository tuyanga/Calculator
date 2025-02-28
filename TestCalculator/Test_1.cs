using CalculatorLibrary.Calculatorfoler;

namespace TestCalculator
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test_Add_Valid()
        {
            Calculator calc = new();
            calc.Add(10);
            Assert.AreEqual(10, calc.Result);
            Console.WriteLine(calc.Result);
        }
    }
}
