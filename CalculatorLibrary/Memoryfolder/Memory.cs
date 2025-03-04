﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Memoryfolder
{
    public class Memory
    {
        private List<MemoryItem> memoryList = new List<MemoryItem>();

        //ms
        /// <summary>
        /// санах ой руу хадгалах
        /// </summary>
        /// <param name="value"></param>
        public void MSave(double value) 
        {  
            memoryList.Add(new MemoryItem(value));
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

        //madd
        /// <summary>
        /// санах ойн элемзнтэд утга нэмэх
        /// </summary>
        /// <param name="value"></param>
        public void MAdd(double value)
        {
            if (memoryList.Count > 0)
                memoryList[^1].MAdd(value);
            else
                MSave(value);
        }

        /// <summary>
        /// санах ойн элемзнтээс утга хасах
        /// </summary>
        /// <param name="value"></param>
        public void MSub(double value)
        {
            if (memoryList.Count > 0)
                memoryList[^1].MSub(value);
            else
                MSave(-value);
        }

        /// <summary>
        /// санах ойн бүх элементийг устгах
        /// </summary>
        /// <returns></returns>
        public double MRecall()
        {
            return memoryList.Count > 0 ? memoryList[^1].Value : 0;
        }

        /// <summary>
        ///  Санах ой дээрх элементүүдийг хэвлэн харуулах
        /// </summary>
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
