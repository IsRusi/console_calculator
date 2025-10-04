using Calculator.Operations;

namespace Calculator
{
    internal class CalculatorOperations
    {
        private Dictionary<string, ICalculatorOperation> _operations;
        
        public double Calculate(string UsersInputOperationType, double x,double y)
=>_operations[UsersInputOperationType].Calculate(x, y);
        
        public IEnumerable<string> GetAllOperations() => _operations.Keys;
        public CalculatorOperations()
        {
            _operations = new()
            {
                { "+" , new Add() },
                {"-" , new Subtraction()},
                {"/",new Divide()},
                {"*",new Multiplication()}
            };
    }

    }
}
