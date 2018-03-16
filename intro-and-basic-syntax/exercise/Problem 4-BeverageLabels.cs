using System;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string bevarageName = Console.ReadLine();
            int inputVolume = int.Parse(Console.ReadLine());
            double inputEnergiContent = double.Parse(Console.ReadLine());
            double inputSugarContent = double.Parse(Console.ReadLine());
                        
            double energi = inputEnergiContent/100;
            double sugar = inputSugarContent/100;
            double energiContentFin = energi * inputVolume;
            double sugarContentFin = sugar * inputVolume;

            /*220ml Nuka-Cola:
              660kcal, 154g sugars*/
            
            Console.WriteLine($"{inputVolume}ml {bevarageName}:");
            Console.WriteLine($"{energiContentFin}kcal, {sugarContentFin}g sugars");

        }
    }
}
