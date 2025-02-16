using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Calculatorfoler
{
    internal class Calculator :CalculatorAbs, IManagable
    {
        public void Add(int num) { Result += num; }
        public void Sub(int num) { Result -= num; }
    }
}
