using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGame
{
    public class Enemy
    {
        // private variables

        private String type = "n/a";
        private int id = 0;
        private int health = 0;
        private int maxHealth = 0;
        private int attackDamage = 0;
        private String weapon = "n/a";

        // public variables

        public String Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
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

        // constructors

        public Enemy()
        {
            // empty constructor
        }

        public Enemy(String aType, int anId, int aHealth, int aMaxHealth)
        {
            this.type = aType;
            this.id = anId;
            this.health = aHealth;
            this.MaxHealth = aMaxHealth;
        }

        // methods

        public void Attack(Enemy attacker, Player target)
        {
            target.Health -= attacker.AttackDamage;
            Console.WriteLine(target.Name + " has taken " + attacker.AttackDamage + " damage.\n");
        }

        public override string ToString()
        {
            string message = "";
            message = message + "Enemy: " + this.Type + " " + this.Id + "\n";
            message = message + "Current Health: " + this.Health + "/" + this.MaxHealth + "\n";
            message = message + "Current Weapon: " + this.Weapon + "\n";
            return message;
        }
    }
}
