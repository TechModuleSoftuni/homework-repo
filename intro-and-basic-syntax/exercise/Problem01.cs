using System;
using System.Threading;

namespace Problem01
{
    class Problem01
    {
        static void Main(string[] args)
        {
            //We recieve from the Consol 4 itegers
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var fourthNumber = int.Parse(Console.ReadLine());

            /*We have to print the input integers
              in 4-digit format as debit card
              (example: input->12 output->0012)
              the result must be in one line
              split by space*/
            Console.Write($"{firstNumber:d4} ");
            Console.Write($"{secondNumber:d4} ");
            Console.Write($"{thirdNumber:d4} ");
            Console.Write($"{fourthNumber:d4} ");

        }
    }
}
