using System;
using System.Threading;

namespace Softuni
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve 2 floating point numbers-double
            var widthRectangle = double.Parse(Console.ReadLine());
            var heightRectangle = double.Parse(Console.ReadLine());

            /*We have to calculate the rectangle’s area,
             * based on its width and height*/
            var areaRectangle = widthRectangle*heightRectangle;

            /*We print the result formatted to 
             * the 2nd character after the decimal point*/
            Console.WriteLine($"{areaRectangle:f2}");
        }
    }
}