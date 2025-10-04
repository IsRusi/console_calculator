using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class Subtraction:ICalculatorOperation
    {
        public double Calculate(double x, double y) => x - y;
    }
}
