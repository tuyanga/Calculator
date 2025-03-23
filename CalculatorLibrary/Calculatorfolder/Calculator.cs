using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary.Memoryfolder;

namespace CalculatorLibrary.Calculatorfoler
{
    public class Calculator :CalculatorAbs, IManagable
    {   
        /// <summary>
        /// нэмэх үйлдэл
        /// </summary>
        /// <param name="num"></param>
        public void Add(int num) 
        { 
            Result += num;
        }
        /// <summary>
        /// хасах үйлдэл
        /// </summary>
        /// <param name="num"></param>
        public void Sub(int num) 
        { 
            Result -= num;
        }
        public Memory memory { get; private set; }=new Memory();
        /// <summary>
        /// санах ой руу хадгалах
        /// </summary>
        public MemoryItem MSave()
        {
            return memory.MSave(Result);
        }

    }
}
