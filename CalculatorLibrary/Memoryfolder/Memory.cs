using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Memoryfolder
{
    public class Memory
    {
        public List<MemoryItem> memoryList { get; private set; } = new List<MemoryItem>();

        //ms
        /// <summary>
        /// санах ойд хадгалах
        /// </summary>
        /// <param name="value"></param>
        public MemoryItem MSave(int value) 
        {
            MemoryItem newItem = new MemoryItem(value);
            memoryList.Add(newItem);
            return newItem;
        }

        //mc
        /// <summary>
        /// санах ойн бүх элементийг устгах
        /// </summary>
        /// 
        public void MClear()
        {
            memoryList.Clear();
        }        
    }
}
