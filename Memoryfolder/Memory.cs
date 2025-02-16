using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Memoryfolder
{
    internal class Memory
    {
        private List<MemoryItem> memoryList = new List<MemoryItem>();

        //ms
        public void Save(MemoryItem item) 
        {  
            memoryList.Add(item);
        }
        //mc
        public void ClearMemory()
        {
            memoryList.Clear();
        }
        public void Display()
        {
            Console.WriteLine("Memory:");
            foreach(var item in memoryList)
            {
                Console.WriteLine(item.Value);
            }
        }
        
    }
}
