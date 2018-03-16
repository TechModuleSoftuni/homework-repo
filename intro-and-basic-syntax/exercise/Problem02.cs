using System;
using System.Threading;

namespace Softuni
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve 2 floating point numbers-double
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            /*We have to calculate the rectangle’s area,
             * based on its width and height*/
            var area = width*height;

            /*We print the result formatted to 
             * the 2nd character after the decimal point*/
            Console.WriteLine($"{area:f2}");
        }
    }
}