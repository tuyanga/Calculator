using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Memoryfolder
{
    public class MemoryItem
    {   
        public int Value { get; private set; }

        public MemoryItem(int value) 
        { 
            Value = value; 
        }
        /// <summary>
        /// санах ойн элемзнтэд item-d утга нэмэх
        /// </summary>
        /// <param name="number"></param>
        public void MAdd(int number)
        {
            Value += number;
        }
        /// <summary>
        /// санах ойн элемзнтээс item-aas утга хасах
        /// </summary>
        /// <param name="number"></param>
        public void MSub(int number)
        {
            Value -= number;
        }
        /// <summary>
        /// memitem- delete хийх
        /// </summary>
        /// <param name="memory"></param>
        public void MC(List<MemoryItem> memoryList)
        {
            memoryList.Remove(this);
        }
    }
}
