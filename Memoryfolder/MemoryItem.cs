using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Memoryfolder
{
    internal class MemoryItem
    {   
        public double Value { get; private set; }

        public MemoryItem(double value) 
        { 
            Value = value; 
        }
        public void MAdd(double number)
        {
            Value += number;
        }

        public void MSub(double number)
        {
            Value -= number;
        }
    }
}
