using System;
using System.Threading;

namespace Softuni
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve 2 floating point numbers-double
            var n1 =double.Parse(Console.ReadLine());
            var n2= double.Parse(Console.ReadLine());

            /*We have to calculate the rectangle’s area,
             * based on its width and height*/
            var result = n1 *n2;

            /*We print the result formatted to 
             * the 2nd character after the decimal point*/
            Console.WriteLine($"{result:f2}");
        }
    }
}