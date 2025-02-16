using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Memoryfolder
{
    internal class MemoryItem
    {   
        public double Value { get; }

        public MemoryItem(double value) 
        { 
            Value = value; 
        }
    }
}
