using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public abstract class CalculatorAbs
    {
        public double Result { get; protected set; } = 0;
    }
}
