using System;
using System.Threading;

namespace Problem01
{
    class Problem01
    {
        static void Main(string[] args)
        {
            //We recieve from the Consol 4 itegers
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());
            var number4 = int.Parse(Console.ReadLine());

            /*We have to print the input integers
              in 4-digit format as debit card
              (example: input->12 output->0012)
              the result must be in one line
              split by space*/
            Console.Write($"{number1:d4} ");
            Console.Write($"{number2:d4} ");
            Console.Write($"{number3:d4} ");
            Console.Write($"{number4:d4} ");

        }
    }
}
