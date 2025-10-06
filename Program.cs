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
            Calculator calculator = new();
            InputManager inputManager = new();
            bool isExitApp = true;
            while (isExitApp)
            {
                inputManager.DisplayTitle();
                try
                {
                    double inputFirstOperand = inputManager.ReadValidNumber("\nвведите первый операнд:");

                    inputManager.PrintOperations(calculator.GetAllOperations);

                    string operation = inputManager.ReadValidOperation(calculator.GetAllOperations, "\nвыберите операцию из перечисленных выше:");

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
