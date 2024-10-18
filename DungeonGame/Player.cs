// Made by Ethan Stone
// 10/8/2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGame
{
    public class Player
    {
        // private variables

        private String name = "n/a";
        private int health = 0;
        private int maxHealth = 0;
        private int attackDamage = 0;
        private String weapon = "n/a";
        private List<String> weapons = new List<String>();

        // getters and setters

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public int MaxHealth
        {
            get { return this.maxHealth; }
            set { this.maxHealth = value; }
        }

        public int AttackDamage
        {
            get { return this.attackDamage; }
            set { this.attackDamage = value; }
        }

        public String Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public List<String> Weapons
        {
            get { return this.weapons; }
            set { this.weapons = value; }
        }

        // constructors

        public Player()
        {
            // empty constructor
        }

        public Player(String aName, int aHealth, int aMaxHealth)
        {
            this.name = aName;
            this.health = aHealth;
            this.MaxHealth = aMaxHealth;
        }

        // methods

        public void Attack(Player attacker, Enemy target)
        {
            if (attacker.AttackDamage >= target.Health)
            {
                target.Health = 0;
                Console.WriteLine(target.Type + " " + target.Id + " has taken " + attacker.AttackDamage + " damage and has been defeated.\n");
            }

            else
            {
                target.Health -= attacker.AttackDamage;
                Console.WriteLine(target.Type + " " + target.Id + " has taken " + attacker.AttackDamage + " damage.\n");
            }
        }

        public override string ToString()
        {
            string message = "";
            message = message + "Player name: " + this.Name + "\n";
            message = message + "Current Health: " + this.Health + "/" + this.MaxHealth + "\n";
            message = message + "Current Weapon: " + this.Weapon + "\n";
            message = message + "Attack Damage: " + this.AttackDamage + "\n";
            return message;
        }
    }
}
