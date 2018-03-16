using System;
using System.Threading;

namespace Problem01
{
    class Problem01
    {
        static void Main(string[] args)
        {
            //We recieve from the Consol 4 itegers
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());
            var n4 = int.Parse(Console.ReadLine());

            /*We have to print the input integers
              in 4-digit format as debit card
              (example: input->12 output->0012)
              the result must be in one line
              split by space*/
            Console.Write($"{n1:d4} ");
            Console.Write($"{n2:d4} ");
            Console.Write($"{n3:d4} ");
            Console.Write($"{n4:d4} ");

        }
    }
}