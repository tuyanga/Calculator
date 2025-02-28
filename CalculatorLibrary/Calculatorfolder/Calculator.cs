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
        public void Add(double num) 
        { 
            Result += num;
        }
        /// <summary>
        /// хасах үйлдэл
        /// </summary>
        /// <param name="num"></param>
        public void Sub(double num) 
        { 
            Result -= num;
        }
        Memory memory=new Memory();
        /// <summary>
        /// санах ой руу хадгалах
        /// </summary>
        public void MSave()
        {
            memory.MSave(Result);
        }
        /// <summary>
        /// санах ойн элемзнтэд утга нэмэх
        /// </summary>
        /// <param name="number"></param>
        public void MAdd(double number)
        {
            memory.MAdd(number);
        }
        /// <summary>
        /// санах ойн элемзнтээс утга хасах
        /// </summary>
        /// <param name="number"></param>
        public void MSub(double number)
        {
            memory.MSub(number);
        }

        /// <summary>
        /// санах ойн бүх элементийг устгах
        /// </summary>
        public void MClear()
        {
            memory.MClear();
        }

        /// <summary>
        /// Сүүлийн санах ойд оруулсан элементийн утгыг авах
        /// </summary>
        /// <returns></returns>
        public double MRecall()
        {
            return memory.MRecall();
        }
        /// <summary>
        /// Санах ой дээрх элементүүдийг хэвлэн харуулах
        /// </summary>
        public void Display()
        {
            memory.Display();
        }
    }
}
