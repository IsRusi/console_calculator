namespace Calculator
{
    internal class Calculator
    {
        private readonly Dictionary<string, Func<double, double, double>> _operations;
        public Calculator()
        {
            _operations=new()
                {
                {"+",Add },
                {"-",Subtraction},
                {"*",Multiplication },
                {"/",Divide }

            };
        }
        public Calculator(Dictionary<string, Func<double, double, double>> operations)
        {
            _operations = operations;
        }

        public double Calculate(string UsersInputOperationType, double x, double y)
        =>_operations[UsersInputOperationType].Invoke(x,y);
            
       public  IEnumerable<string> GetAllOperations => _operations.Keys;
        public double Add(double x, double y) => x + y;
        public double Multiplication(double x, double y) => x * y;
        public double Divide(double x, double y) => y == 0 ? throw new DivideByZeroException("Ошибка! Деление на 0 в данном случае не возможно") : x / y;
        public double Subtraction(double x, double y) => x - y;
    }
}
