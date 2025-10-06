namespace Calculator
{
    internal class InputManager
    {
        private readonly Calculator calculator;
        public InputManager(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public static double ReadValidNumber()
        {

            while (true)
            {
                string value= Console.ReadLine();
                if (double.TryParse(value, out double convertedNumber))
                {
                    return convertedNumber;
                }
                    Console.Write("введите корректное число :");
                }
        }
        public static string ReadValidOperation(string[] allowedOperations)
        {
            while(true)
            {
                string inputValue = Console.ReadLine();
                if (allowedOperations.Contains(inputValue))
                {
                    return inputValue;
                }
                Console.Write("данной операции не существует. Введите корректную операцию! :");
                
            }
        }
        public static bool ReadUsersAnswer()
        {
            string userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "да") return true;
            return false;
        }
        public static void PrintOperations(string[] inputOperations)
        {
            foreach(var i in inputOperations)
            {
                Console.WriteLine(i);
            }
        }
        public void Run()
        {
            string[] operationsList = { "+", "-", "/", "*" };
            bool isExitApp = true;
            while (isExitApp)
            {
                Console.WriteLine("Калькулятор 3000");
                try
                {
                    Console.Write("\nвведите первый операнд:");

                    double inputFirstOperand = ReadValidNumber();

                    Console.WriteLine("\nвыберите операцию из перечисленных");

                    PrintOperations(operationsList);

                    Console.Write(":");
                    string operation = ReadValidOperation(operationsList);

                    Console.Write("\nвведите второй операнд:");

                    double inputSecondOperand = ReadValidNumber();

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

                isExitApp = ReadUsersAnswer();

                Console.WriteLine("для продолжения нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
