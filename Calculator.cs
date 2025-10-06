namespace Calculator
{
    internal class Calculator
    {
        public readonly CalculatorOperations _operations;
        public Calculator(CalculatorOperations operations)
        {
            _operations = operations;
        }
        public double Calculate(string UsersInputOperationType, double x, double y)
=> UsersInputOperationType switch
{
    "+" => _operations.Add(x, y),
    "-" => _operations.Subtraction(x, y),
    "/" => _operations.Divide(x, y),
    "*" => _operations.Multiplication(x, y)
};

    }
}
