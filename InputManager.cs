namespace Calculator
{
    internal class InputManager
    {

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
    }
}
