namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorOperations calculatorOperations=new();
            Calculator calculator = new(calculatorOperations);
            InputManager inputManager = new(calculator);
            inputManager.Run();
        }
       
    }
}
