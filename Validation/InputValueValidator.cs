namespace Calculator.Validation
{
    internal class InputValueValidator
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
                    Console.WriteLine("введите корректное число");
                    Console.Write(":");
            }
        }
        public static string ReadValidOperation(IEnumerable<string> allowedOperations)
        {
            while(true)
            {
                string inputValue = Console.ReadLine();
                if (allowedOperations.Contains(inputValue))
                {
                    return inputValue;
                }
                Console.WriteLine("данной операции не существует. Введите корректную операцию!");
                Console.Write(":");
            }
        }
    }
}
