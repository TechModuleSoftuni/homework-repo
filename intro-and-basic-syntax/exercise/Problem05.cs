//CONFIRMED from <RosenDev>
using System;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* We will receive information about video game character 
             * as name, current health, maximum health,
             * current energy, maximum energy
             * each on a separate lines*/
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            /* We calculate how much health and energi the character has
             * and drow it with |
             * second variable is todisplay how much health and energy is missing
             * drow with . */
            string healthAstext = new string('|', currentHealth);
            string healthMissing = new string('.', maxHealth - currentHealth);

            string energyAsText = new string('|', currentEnergy);
            string energyMissing = new string('.', maxEnergy - currentEnergy);

            /*The output should be in 3 lines
             1-st the name of the character
             2-nd helth the character  
             3-rd energy
             example: currentHelth-5 ; maxHelth-10 -> Health: ||||||.....| */
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{healthAstext}{healthMissing}|");
            Console.WriteLine($"Energy: |{energyAsText}{energyMissing}|");

        }
    }
}
