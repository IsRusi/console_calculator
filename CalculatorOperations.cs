

namespace Calculator
{
    internal class CalculatorOperations
    {
       
        public double Add(double x, double y)=>x+y;
        public double Multiplication(double x, double y)=>x*y;
        public double Divide(double x, double y) => y == 0 ? throw new DivideByZeroException("Ошибка! Деление на 0 в данном случае не возможно"):x/y;
        public double Subtraction(double x, double y)=>x-y;
       
    }
        

    
}
