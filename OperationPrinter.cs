namespace Calculator
{
    internal static class OperationPrinter
    {
        public static void PrintOperations(this CalculatorOperations op)
        {
            foreach(var i in op.GetAllOperations())
            {
                Console.WriteLine(i);
            }
        }
    }
}
