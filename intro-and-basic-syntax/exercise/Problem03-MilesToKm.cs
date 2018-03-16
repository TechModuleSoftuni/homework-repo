using System;

namespace Problem_3.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 mile == 1.60934 kilometers
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;
            
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}