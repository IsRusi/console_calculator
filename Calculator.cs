namespace Calculator
{
    internal class Application
    {
        public readonly CalculatorOperations _operations;
        public Application(CalculatorOperations operations)
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
