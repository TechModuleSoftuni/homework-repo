using System;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energyContentPer100ml = double.Parse(Console.ReadLine());
            double sugarContentPer100ml = double.Parse(Console.ReadLine());

            double energy = energyContentPer100ml / 100;
            double sugar = sugarContentPer100ml / 100;
            double totalEnergy = energy * volume;
            double totalSugar = sugar * volume;

            /*220ml Nuka-Cola:
              660kcal, 154g sugars*/

            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");

        }
    }
}
