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
        public void MSave(double value) 
        {  
            memoryList.Add(new MemoryItem(value));
        }
        //mc
        public void MClear()
        {
            memoryList.Clear();
        }
        //madd
        public void MAdd(double value)
        {
            if (memoryList.Count > 0)
                memoryList[^1].MAdd(value);
            else
                MSave(value);
        }

        public void MSub(double value)
        {
            if (memoryList.Count > 0)
                memoryList[^1].MSub(value);
            else
                MSave(-value);
        }
        public double MRecall()
        {
            return memoryList.Count > 0 ? memoryList[^1].Value : 0;
        }
        public void Display()
        {
            Console.WriteLine("Memory list below");
            foreach(var item in memoryList)
            {
                Console.WriteLine($"Memory Item: {item.Value}");
            }
        }
        
    }
}
