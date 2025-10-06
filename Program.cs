namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        static public void Run()
        {
            string[] operationsList = {"+","-","/","*" };
            CalculatorOperations calculatorOperations = new();
            Calculator calculator = new(calculatorOperations);

            bool isExitApp = true;
            while (isExitApp)
            {
                Console.WriteLine("Калькулятор 3000");
                try
                {
                    Console.Write("\nвведите первый операнд:");
                    
                    double inputFirstOperand = InputManager.ReadValidNumber();

                    Console.WriteLine("\nвыберите операцию из перечисленных");
                    
                    InputManager.PrintOperations(operationsList);

                    Console.Write(":");
                    string operation = InputManager.ReadValidOperation(operationsList);

                    Console.Write("\nвведите второй операнд:");
                    
                    double inputSecondOperand = InputManager.ReadValidNumber();
                    
                    double resultCalculating = calculator.Calculate(operation, inputFirstOperand, inputSecondOperand);
                    
                    Console.WriteLine($"\nРезультат вычисления: {inputFirstOperand} {operation} {inputSecondOperand} = {resultCalculating}");

                }
                catch (DivideByZeroException divideException)
                {
                    Console.WriteLine(divideException.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("\nхотите продолжить вычисления? \n(да/нет) :");

                isExitApp = InputManager.ReadUsersAnswer();

                Console.WriteLine("для продолжения нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
