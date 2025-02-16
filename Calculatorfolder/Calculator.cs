using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.Memoryfolder;

namespace CalculatorApp.Calculatorfoler
{
    internal class Calculator :CalculatorAbs, IManagable
    {
        public void Add(double num) 
        { 
            Result += num;
        } 
        public void Sub(double num) 
        { 
            Result -= num;
        }
        Memory memory=new Memory();
        public void MSave()
        {
            memory.MSave(Result);
        }

        public void MAdd(double number)
        {
            memory.MAdd(number);
        }

        public void MSub(double number)
        {
            memory.MSub(number);
        }

        public void MClear()
        {
            memory.MClear();
        }

        public double MRecall()
        {
            return memory.MRecall();
        }
        public void Display()
        {
            memory.Display();
        }
    }
}
