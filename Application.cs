using Calculator.Validation;

namespace Calculator
{
    internal class Application
    {
        public void Run()
        {
            CalculatorOperations calculator = new();
            bool isExitApp = true;
            while (isExitApp)
            {
            Console.WriteLine("Калькулятор 3000");
                try
                {
                    Console.WriteLine("");
                    Console.Write("введите первый операнд:");
                    double inputFirstOperand = InputValueValidator.ReadValidNumber();

                    Console.WriteLine("");
                    Console.WriteLine("выберите операцию из перечисленных");
                    calculator.PrintOperations();
                    Console.Write(":");
                    string operation = InputValueValidator.ReadValidOperation(calculator.GetAllOperations());
                    Console.WriteLine("");
                    Console.Write("введите второй операнд:");
                    double inputSecondOperand = InputValueValidator.ReadValidNumber();
                    double resultCalculating = calculator.Calculate(operation, inputFirstOperand, inputSecondOperand); 
                    Console.WriteLine("");
                    Console.WriteLine($"Результат: {inputFirstOperand} {operation} {inputSecondOperand} = {resultCalculating}");

                }
                catch (DivideByZeroException divideException)
                {
                    Console.WriteLine(divideException.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                    Console.WriteLine("");
                Console.WriteLine("хотите продолжить вычисления? \n(да/нет)");
                    Console.Write(":");
                string userAnswer = Console.ReadLine();
                isExitApp=userAnswer.ToLower() == "да"?true:false;
                Console.Clear();
                Console.WriteLine("для продолжения нажмите на любую клавишу");
                Console.ReadKey();

            }
        }
    }
}
