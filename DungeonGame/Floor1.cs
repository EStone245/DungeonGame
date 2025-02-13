// Made by Ethan Stone
// 11/12/2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGame
{
    public class Floor1
    {
        static void Main(string[] args)
        {
            // Set variables
            int eventNumber = 0;
            int eventCount = 0;
            var rand = new Random();

            // This is where the title screen will be as well as a way to upload a previous save

            // Available weapons
            Weapon WoodSword = new Weapon("Wooden Sword", 2);
            Weapon StoneSword = new Weapon("Stone Sword", 4);
            Weapon Club = new Weapon("Club", 1);

            // Set Player
            Player Player = new Player("Player1", 10, 10, "n/a");
            Console.WriteLine("Enter your name: ");
            Player.PlayerName = Console.ReadLine();
            Console.WriteLine("Welcome " + Player.PlayerName + " to the dungeon. Take this wooden sword and head forth.");
            Player.AddWeapon(WoodSword);
            Console.WriteLine("Would you like to equip the sword? y/n");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                Player.EquipWeapon(1);
            }

            // Floor functions
            void SpawnEvent()
            {
                // generate a random event based on the table
                int eventType = rand.Next(1, 101);

                if (eventType <= 80) 
                {
                    Console.WriteLine("A skeleton has spawned!");
                    eventNumber = 0;
                }

                else if (eventType <= 90)
                {
                    Console.WriteLine("A skeleton Bruiser has spawned!");
                    eventNumber = 1;
                }

                else
                {
                    int chestGold = rand.Next(5, 8);
                    Console.WriteLine("You found a treasure chest and got " + chestGold + " gold");
                    Player.Gold += chestGold;
                    eventNumber = 2;
                }

            }

            while (Player.Health > 0 && eventCount < 10) // This is the main area where gameplay takes place until the player character dies
            {
                SpawnEvent();
                if (eventNumber == 0)
                {
                    Enemy Skeleton = new Enemy("Skeleton", 1, 5, 5, Club);
                    Skeleton.AttackDamage = Skeleton.Weapon.WeaponDamage;

                    while (Skeleton.Health > 0)
                    {
                        Console.WriteLine("Current Health: " + Player.Health + "/" + Player.MaxHealth);
                        Console.WriteLine("Press q to attack or e to try to run");
                        string action = Console.ReadLine();
                        if (action == "q")
                        {
                            // The player takes a swipe at the Skeleton
                            Player.Attack(Player, Skeleton);

                            if (Skeleton.Health <= 0)
                            {
                                break;
                            }

                            // The Skeleton takes a swipe at the player
                            Skeleton.Attack(Skeleton, Player);

                            if (Player.Health > 0)
                            {
                                break;
                            }
                        }

                        // TODO Code for if the player tries to run
                    }

                    int spoils = rand.Next(1, 5);
                    Console.WriteLine("You beat the Skeleton and gained " + spoils + " gold");
                    Player.Gold += spoils;
                }

                else if (eventNumber == 1)
                {
                    Enemy SkeletonBruiser = new Enemy("Skeleton Bruiser", 2, 10, 10, Club);
                    SkeletonBruiser.AttackDamage = SkeletonBruiser.Weapon.WeaponDamage;

                    while (SkeletonBruiser.Health > 0)
                    {
                        Console.WriteLine("Current Health: " + Player.Health + "/" + Player.MaxHealth);
                        Console.WriteLine("Press q to attack or e to try to run");
                        string action = Console.ReadLine();
                        if (action == "q")
                        {
                            // The player takes a swipe at the Skeleton
                            Player.Attack(Player, SkeletonBruiser);

                            if (SkeletonBruiser.Health <= 0)
                            {
                                break;
                            }

                            // The Skeleton takes a swipe at the player
                            SkeletonBruiser.Attack(SkeletonBruiser, Player);

                            if (Player.Health > 0)
                            {
                                break;
                            }
                        }

                        // TODO Code for if the player tries to run
                    }

                    int spoils = rand.Next(8, 11);
                    Console.WriteLine("You beat the Skeleton Bruiser and gained " + spoils + " gold");
                    Player.Gold += spoils;
                }

                eventCount++;
                // TODO After any event happens give the player the opportunity to heal by buying a potion, upgrade their weapon, or simply move on
            }

            if (eventCount == 10)
            {
                Console.WriteLine("You have beaten this level. Would you like to move on to the next level or save your progress?");
            }

            else
            {
                Console.WriteLine("You have lost. Return to the title screen to retry the dungeon.");
            }

            Console.ReadLine();
        }
    }
}
