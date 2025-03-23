using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Memoryfolder
{
    public class MemoryItem
    {   
        public double Value { get; private set; }

        public MemoryItem(double value) 
        { 
            Value = value; 
        }
        /// <summary>
        /// санах ойн элемзнтэд item-d утга нэмэх
        /// </summary>
        /// <param name="number"></param>
        public void MAdd(double number)
        {
            Value += number;
        }
        /// <summary>
        /// санах ойн элемзнтээс item-aas утга хасах
        /// </summary>
        /// <param name="number"></param>
        public void MSub(double number)
        {
            Value -= number;
        }
    }
}
