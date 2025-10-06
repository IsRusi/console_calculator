namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        static void Run()
        {
            CalculatorOperations calculatorOperations = new();
            Calculator calculator = new(calculatorOperations);
            InputManager inputManager = new();
            string[] operationsList = { "+", "-", "/", "*" };
            bool isExitApp = true;
            while (isExitApp)
            {
                inputManager.DisplayTitle();
                try
                {
                    double inputFirstOperand = inputManager.ReadValidNumber("\nвведите первый операнд:");

                    inputManager.PrintOperations(operationsList);

                    string operation = inputManager.ReadValidOperation(operationsList, "\nвыберите операцию из перечисленных выше:");

                    double inputSecondOperand = inputManager.ReadValidNumber("\nвведите второй операнд:");

                    double resultCalculating = calculator.Calculate(operation, inputFirstOperand, inputSecondOperand);

                    inputManager.DisplayResult(inputFirstOperand, operation, inputSecondOperand, resultCalculating);
                }
                catch (DivideByZeroException divideException)
                {
                    inputManager.DisplayError(divideException.Message);
                }
                catch (Exception ex)
                {
                    inputManager.DisplayError(ex.Message);
                }

                isExitApp = inputManager.ReadUsersAnswer("\nхотите продолжить вычисления? \n(да/нет) :");

                inputManager.PromptToContinue();
                inputManager.ClearConsole();

            }
        }
    }
}
