// Made by Ethan Stone
// 10/17/2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGame
{
    public class DungeonGame
    {
        static void Main(string[] args)
        {
            // Set Player
            Player Player1 = new Player("Player1", 10, 10);
            Console.WriteLine("Enter your name: ");
            Player1.Name = Console.ReadLine();
            Console.WriteLine(Player1.ToString());

            // Set Enemy
            Enemy Goblin1 = new Enemy("Goblin", 1, 5, 5);
            Console.WriteLine(Goblin1.ToString());

            // Basic attacking testing
            Player1.AttackDamage = 2;
            Player1.Attack(Player1, Goblin1);
            Console.WriteLine(Goblin1.ToString());

            Goblin1.AttackDamage = 2;
            Goblin1.Attack(Goblin1, Player1);
            Console.WriteLine(Player1.ToString());

            // Defeating Goblin 1
            Player1.AttackDamage = 5;
            Player1.Attack(Player1, Goblin1);
            Console.WriteLine(Goblin1.ToString());

            Console.ReadLine();
        }
    }
}
