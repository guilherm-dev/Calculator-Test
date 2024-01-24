using System;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first value:");
            int value1 = int.Parse(Console.ReadLine().ToString());
            Console.WriteLine("Enter the second value:");
            int value2 = int.Parse(Console.ReadLine().ToString());

            Console.WriteLine("Inform the operation to be performed.");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            int operation = int.Parse(Console.ReadLine().ToString());
            double resultOperation = 0;
            switch (operation)
            {
                case 1:
                    resultOperation = Sum(value1, value2);
                    break;
                case 2:
                    resultOperation = Sub(value1, value2);
                    break;
                case 3:
                    resultOperation = Mult(value1, value2);
                    break;
                case 4:
                    resultOperation = Div(value1, value2);
                    break;
                default:
                    break;


            }

            Console.WriteLine($"The result of the operation was: {resultOperation}");
        }

        private static double Div(int value1, int value2) => value1 / value2;

        private static double Mult(int value1, int value2) => value1 * value2;

        private static double Sum(int value1, int value2) => value1 + value2;

        private static double Sub(int value1, int value2) => value1 - value2;

    }
}