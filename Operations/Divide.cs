namespace Calculator.Operations
{
    internal class Divide:ICalculatorOperation
    {
        public double Calculate(double x, double y)
            =>y != 0 ?x/y: throw new DivideByZeroException("Ошибка! Деление на 0 в данном случае невозможно");
        
    }
}
