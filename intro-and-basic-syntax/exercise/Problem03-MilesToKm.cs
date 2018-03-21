//CONFIRMED from <petryk>
using System;

namespace Problem_3.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //We get miles from Console and convert it to kilometers using the formula 1 mile == 1.60934 kilometers.
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;
            //TODO print the result.
            Console.WriteLine($"{kilometers:F2}"); 
        }
    }
}
