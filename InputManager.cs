namespace Calculator
{
    internal class InputManager
    {

        public double ReadValidNumber(string message)
        {
            Console.Write(message);
            while (true)
            {
                string value = Console.ReadLine();
                if (double.TryParse(value, out double convertedNumber))
                {
                    return convertedNumber;
                }
                Console.Write("введите корректное число :");
            }
        }
        public string ReadValidOperation(string[] allowedOperations, string message)
        {

            Console.Write(message);
            while (true)
            {
                string inputValue = Console.ReadLine();
                if (allowedOperations.Contains(inputValue))
                {
                    return inputValue;
                }
                Console.Write("данной операции не существует. Введите корректную операцию! :");

            }
        }
        public bool ReadUsersAnswer(string message)
        {
            Console.Write(message);
            string userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "да") return true;
            return false;
        }
        public void PrintOperations(string[] inputOperations)
        {
            Console.WriteLine();
            foreach (var i in inputOperations)
            {
                Console.WriteLine(i);
            }
        }
        public void DisplayTitle() => Console.WriteLine("Калькулятор 3000");
        public void DisplayResult(double firstOperand, string operation, double secondOperand, double result)
        => Console.WriteLine($"\nРезультат вычисления: {firstOperand} {operation} {secondOperand} = {result}");

        public void DisplayError(string message)
        => Console.WriteLine(message);

        public void PromptToContinue()
        {
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }

        public void ClearConsole()
        => Console.Clear();
    }
}
