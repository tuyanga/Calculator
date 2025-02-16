using CalculatorApp.Calculatorfoler;
using CalculatorApp.Memoryfolder;
namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Add(10);
            Console.WriteLine("Result: "+ calc.Result);
            calc.Sub(5);
            Console.WriteLine("Result: " + calc.Result);
            calc.MSave();
            calc.Display();
            calc.MAdd(2);
            Console.WriteLine("Memory Recall: " + calc.MRecall());

            calc.MSub(3);
            Console.WriteLine("Memory Recall after MSub: " + calc.MRecall());

            calc.MClear();
            Console.WriteLine("Memory Cleared, Recall: " + calc.MRecall());
        }
    }
}
