using System;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            string healthAstext = new string('|', currentHealth);
            string healthMissing = new string('.', maxHealth - currentHealth);


            string energyAsText = new string('|', currentEnergy);
            string energyMissing = new string('.', maxEnergy - currentEnergy);



            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{healthAstext}{healthMissing}|");
            Console.WriteLine($"Energy: |{energyAsText}{energyMissing}|");

        }
    }
}